using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;

namespace Task6
{
    public partial class Main : Form
    {
        //Наш словарь
        Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "delegate", "делегат" },
                { "string","строковый тип данных"},
                { "int", "числовой тип данных"},
                { "array", "массив"},
                { "class", "класс"},
                { "new", "создания объекта"},
                { "csv", "тексовый формат данных"}
            };

        public Main()
        {
            InitializeComponent();

            //Выводим словарь в список
            UpdateDictionary();
        }

        //Открытие окна "О Программе"
        private void AboutMenu_Click(object sender, EventArgs e)
        {
            Views.About newForm = new Views.About();
            newForm.Show();
        }

        //Создание нового словаря (вкладка)
        private void createDic_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
        }

        //Выход из программы
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result =   MessageBox.Show("Вы уверены что хотите выйти?","Подстверждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Функция "сохранить как"
        private void SaveAsDic_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog
            {
                Filter = "Текстовый формат(*.txt)|*.txt|Формат CSV(*.csv)|*.csv|Формат JSON(*.json)|*.json",
                Title = "Сохранить словарь как",
                FileName = "Dictionary",
                RestoreDirectory = true
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (fileDialog.FilterIndex)
                {
                    case 1:
                        SaveAs(filename: fileDialog.FileName, type: "txt");
                        break;
                    case 2:
                        SaveAs(filename: fileDialog.FileName, type: "csv");
                        break;
                    case 3:
                        SaveAs(filename: fileDialog.FileName, type: "json");
                        break;
                    default:
                        MessageBox.Show("Произошла ошибка при выборе формата");
                        break;
                }
            }
        }

        //Сохраняем файл в соответствующий формат
        public void SaveAs(string filename, string type)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filename))
                {
                    switch (type)
                    {
                        //Сохранение в формате TxT
                        case "txt":
                            foreach (var item in dictionary)
                            {
                                streamWriter.WriteLine($"{item.Key}|{item.Value}");
                            }
                            break;
                        //Сохранение в формате CsV
                        case "csv":
                            foreach (var item in dictionary)
                            {
                                streamWriter.WriteLine($"{item.Key},{item.Value}");
                            }
                            break;
                        //Сохранение в формате JSON
                        case "json":
                            string json = JsonConvert.SerializeObject(dictionary, Formatting.Indented);
                            streamWriter.Write(json);
                            break;
                        default:
                            break;
                    }

                    streamWriter.Close();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //Функция "сохранить"
        private void SaveDic_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem button = (ToolStripMenuItem)sender;

            string fileName = Path.Combine(Directory.GetCurrentDirectory(), "dictionary.dicf");

            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                foreach (var item in dictionary)
                {
                    streamWriter.WriteLine($"{item.Key} {item.Value}");
                }
                streamWriter.Close();
            }
            button.Enabled = false;
        }

        //Функция добавления слова в словарь
        private void AddWord_Click(object sender, EventArgs e)
        {
            //переход к Add Form
            Views.AddWord addWord = new Views.AddWord();
            DialogResult result = addWord.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            if (addWord.KeyInput.Text.Length > 2 && addWord.ValueInput.Text.Length > 2)
            {
                if (!dictionary.ContainsKey(addWord.KeyInput.Text))
                {
                    dictionary.Add(addWord.KeyInput.Text, addWord.ValueInput.Text);
                    UpdateDictionary();
                } else
                {
                    MessageBox.Show("Ключ уже существует в словаре","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        //Обновления словаря (вывод на экран)
        private void UpdateDictionary()
        {
            DictionaryList.Items.Clear();
            ValueText.Text = "";
            SaveDic.Enabled = true;
            foreach (var item in dictionary)
            {
                DictionaryList.Items.Add(item.Key);
            }
        }

        //Функция удаления слова/слов из словаря
        private void DeleteWord_Click(object sender, EventArgs e)
        {
            //массив ключей, которые надо удалить
            string[] keys = new string[DictionaryList.CheckedItems.Count];
            //добавляем в массив ключей только выбранные слова
            for (int i = 0; i < DictionaryList.CheckedItems.Count; i++)
            {
                keys[i] = DictionaryList.CheckedItems[i].ToString();
            }

            var result = MessageBox.Show($"Вы уверены что хотите удалить {keys.Length} элементов словаря","Подтверждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Удаляем данные из Dictionary<string,string>
                for (int i = 0; i < keys.Length; i++)
                {
                    dictionary.Remove(keys[i]);
                }
                Thread.Sleep(1000);
                UpdateDictionary();
                MessageBox.Show("Элементы успешно удалены","Успех",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        //Если мы выбираем элемент из списка
        private void DictionaryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DictionaryList.SelectedIndex != -1)
            {
                ValueText.Text = DictionaryList.SelectedItem.ToString() + " - " + dictionary[DictionaryList.SelectedItem.ToString()];
            }
        }

        //Функция для поиска слова из словаря в Google
        private void searchGoogle_Click(object sender, EventArgs e)
        {
            //поисковый запрос
            string url = $"https://www.google.com/search?q={dictionary[DictionaryList.SelectedItem.ToString()]}&ie=UTF-8";
            System.Diagnostics.Process.Start(url);
        }

        //Функция для очистки словаря
        private void ClearDic_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены что хотите очистить словарь?","Подтверждение",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dictionary.Clear();
                UpdateDictionary();
            }
        }

        //Поиск по ключу
        private void SearchByKey_Click(object sender, EventArgs e)
        {
            //переход к Search
            Views.Search search = new Views.Search("ключ");
            DialogResult result = search.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            string key = search.SearchText.Text;

            if (dictionary.ContainsKey(key))
            {
                DictionaryList.SelectedIndex = DictionaryList.Items.IndexOf(key);
            }
            else MessageBox.Show("Слово не найдено","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        //Поиск по значению
        private void SearchByValue_Click(object sender, EventArgs e)
        {
            //переход к Search
            Views.Search search = new Views.Search("значение");
            DialogResult result = search.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            string value = search.SearchText.Text;
            string key = dictionary.FirstOrDefault(x => x.Value.Contains(value)).Key;
            if (!String.IsNullOrEmpty(key))
            {
                //в списке выбираем индекс первого вхождения элемента по вказанному предикату (ищем содержит ли значение данное слово в себе)
                DictionaryList.SelectedIndex = DictionaryList.Items.IndexOf(key);
            }
            else MessageBox.Show("Слово не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Сортировка словаря по ключу
        private void SortByKey_Click(object sender, EventArgs e)
        {
            dictionary = dictionary.OrderBy(obj => obj.Key).ToDictionary(obj => obj.Key, obj => obj.Value);
            UpdateDictionary();
        }

        //Сортировка по значению
        private void SortByValue_Click(object sender, EventArgs e)
        {
            dictionary = dictionary.OrderBy(obj => obj.Value).ToDictionary(obj => obj.Key, obj => obj.Value);
            UpdateDictionary();
        }

        //Белая тема приложения
        private void WhiteTheme_Click(object sender, EventArgs e)
        {
            #region Цвет формы
            this.BackColor = Color.FromName("Control");
            this.ForeColor = Color.FromName("ControlText");
            #endregion

            #region Цвет списка
            DictionaryList.BackColor = Color.FromName("Control");
            DictionaryList.ForeColor = Color.FromName("ControlText");
            #endregion

            #region Цвет текста
            ValueText.ForeColor = Color.FromName("ControlText");
            #endregion

            #region Цвет кнопки
            searchGoogle.BackColor = Color.FromName("Control");
            searchGoogle.ForeColor = Color.FromName("ControlText");
            searchGoogle.FlatAppearance.BorderColor = Color.FromName("Control");
            #endregion

            #region Цвет меню
            MenuStrip.BackColor = Color.FromName("Control");
            MenuStrip.ForeColor = Color.FromName("ControlText");
            #endregion
        }

        //Темная тема приложения
        private void DarkTheme_Click(object sender, EventArgs e)
        {
            #region Цвет формы
            this.BackColor = Color.FromArgb(54, 59, 78);
            this.ForeColor = Color.FromArgb(196, 187, 240);
            #endregion

            #region Цвет списка
            DictionaryList.BackColor = Color.FromArgb(54, 59, 78);
            DictionaryList.ForeColor = Color.FromArgb(196, 187, 240);
            #endregion

            #region Цвет текста
            ValueText.ForeColor = Color.FromArgb(196, 187, 240);
            #endregion

            #region Цвет кнопки
            searchGoogle.BackColor = Color.FromArgb(79, 59, 120);
            searchGoogle.ForeColor = Color.FromArgb(196, 187, 240);
            searchGoogle.FlatAppearance.BorderColor = Color.FromArgb(146, 127, 191);
            #endregion

            #region Цвет меню
            MenuStrip.BackColor = Color.FromArgb(79, 59, 120);
            MenuStrip.ForeColor = Color.FromArgb(196, 187, 240);
            #endregion
        }

        //Применения пользовательской темы приложения
        public void ApplyTheme(Classes.ColorConfig config)
        {
            #region Цвет формы
            this.BackColor = config.ApplicationBackground;
            this.ForeColor = config.ApplicationForeground;
            #endregion

            #region Цвет списка
            DictionaryList.BackColor = config.ListBackground;
            DictionaryList.ForeColor = config.ListForeground;
            #endregion

            #region Цвет текста
            ValueText.ForeColor = config.TextForeground;
            #endregion

            #region Цвет кнопки
            searchGoogle.BackColor = config.ButtonBackground;
            searchGoogle.ForeColor = config.ButtonForeground;
            //searchGoogle.FlatAppearance.BorderColor = Color.FromArgb(146, 127, 191);
            #endregion

            #region Цвет меню
            MenuStrip.BackColor = config.MenuBackground;
            MenuStrip.ForeColor = config.MenuForeground;
            #endregion
        }

        //Окно с настройкой темы приложения
        private void CreateTheme_Click(object sender, EventArgs e)
        {
            //переход к Theme Form
            Views.Theme theme = new Views.Theme();
            DialogResult result = theme.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            if (!String.IsNullOrEmpty(theme.NameTheme.Text))
            {
                string fileName = theme.NameTheme.Text + ".json";
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "JSON формат(*.json)|*.json",
                    FileName = fileName
                };
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                File.WriteAllText(saveFileDialog.FileName, theme.config.Configurate());
                MessageBox.Show("Файл темы успешно сохранен");
            }
            
        }

        //Окно с загрузкой темы. Формат .json
        private void LoadTheme_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "JSON формат(*.json)|*.json"
            };
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = fileDialog.FileName;
            // читаем файл в строку
            string json = File.ReadAllText(filename);

            //десериализируем JSON в объект класса и вызываем метод применения темы
            Classes.ColorConfig config = JsonConvert.DeserializeObject<Classes.ColorConfig>(json);

            ApplyTheme(config); //применяем тему
        }
    }
}
