using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Task6.Views
{
    public partial class Theme : Form
    {
        public Theme()
        {
            InitializeComponent();
        }

        //объект, который хранит конфигурацию темы
        public Classes.ColorConfig config = new Classes.ColorConfig();

        private void TextColor_Click(object sender, EventArgs e)
        {
            //Элементу на который нажали устанавливаем цвет из ColorDialog
            Button button = (Button)sender;

            Color color = ChooseColor();
            //Присваиваем цвет нашему свойству класса
            config.TextForeground = color;
            button.BackColor = color;
        }

        private void AppBackColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Color color = ChooseColor();
            config.ApplicationBackground = color;
            button.BackColor = color;
        }

        private void ListBackColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Color color = ChooseColor();
            config.ListBackground = color;
            button.BackColor = color;
        }

        private void ListColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Color color = ChooseColor();
            config.ListForeground = color;
            button.BackColor = color;
        }

        private void ButtonBackColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Color color = ChooseColor();
            config.ButtonBackground = color;
            button.BackColor = color;
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Color color = ChooseColor();
            config.ButtonForeground = color;
            button.BackColor = color;
        }

        private void MenuBackColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Color color = ChooseColor();
            config.MenuBackground = color;
            button.BackColor = color;
        }

        private void MenuColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Color color = ChooseColor();
            config.MenuForeground = color;
            button.BackColor = color;
        }



        private Color ChooseColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();

            return colorDialog.Color;
        }

        //При нажатии на кнопку сохранить
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Если поле имя темы не пустое
            if (String.IsNullOrEmpty(NameTheme.Text))
            {
                MessageBox.Show("Название темы пусто","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


    }
}
