namespace Task6
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.DictionaryList = new System.Windows.Forms.CheckedListBox();
            this.ValueText = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createDic = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDic = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsDic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DicMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddWord = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteWord = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchByKey = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchByValue = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearDic = new System.Windows.Forms.ToolStripMenuItem();
            this.SortMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByKey = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByValue = new System.Windows.Forms.ToolStripMenuItem();
            this.StyleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DarkTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.WhiteTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchGoogle = new System.Windows.Forms.Button();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DictionaryList
            // 
            this.DictionaryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictionaryList.FormattingEnabled = true;
            this.DictionaryList.Location = new System.Drawing.Point(12, 40);
            this.DictionaryList.Name = "DictionaryList";
            this.DictionaryList.Size = new System.Drawing.Size(219, 403);
            this.DictionaryList.TabIndex = 0;
            this.DictionaryList.SelectedIndexChanged += new System.EventHandler(this.DictionaryList_SelectedIndexChanged);
            // 
            // ValueText
            // 
            this.ValueText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ValueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueText.Location = new System.Drawing.Point(237, 40);
            this.ValueText.Name = "ValueText";
            this.ValueText.Size = new System.Drawing.Size(551, 103);
            this.ValueText.TabIndex = 1;
            this.ValueText.Text = "Значения слова";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.DicMenu,
            this.StyleMenu,
            this.AboutMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDic,
            this.SaveDic,
            this.SaveAsDic,
            this.toolStripSeparator1,
            this.ExitButton});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 20);
            this.fileMenu.Text = "Файл";
            // 
            // createDic
            // 
            this.createDic.Name = "createDic";
            this.createDic.Size = new System.Drawing.Size(165, 22);
            this.createDic.Text = "Создать словарь";
            this.createDic.Click += new System.EventHandler(this.createDic_Click);
            // 
            // SaveDic
            // 
            this.SaveDic.Name = "SaveDic";
            this.SaveDic.Size = new System.Drawing.Size(165, 22);
            this.SaveDic.Text = "Сохранить";
            this.SaveDic.Click += new System.EventHandler(this.SaveDic_Click);
            // 
            // SaveAsDic
            // 
            this.SaveAsDic.Name = "SaveAsDic";
            this.SaveAsDic.Size = new System.Drawing.Size(165, 22);
            this.SaveAsDic.Text = "Сохранить как";
            this.SaveAsDic.Click += new System.EventHandler(this.SaveAsDic_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(165, 22);
            this.ExitButton.Text = "Выйти";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DicMenu
            // 
            this.DicMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddWord,
            this.DeleteWord,
            this.SearchMenu,
            this.ClearDic,
            this.SortMenu});
            this.DicMenu.Name = "DicMenu";
            this.DicMenu.Size = new System.Drawing.Size(66, 20);
            this.DicMenu.Text = "Словарь";
            // 
            // AddWord
            // 
            this.AddWord.Name = "AddWord";
            this.AddWord.Size = new System.Drawing.Size(180, 22);
            this.AddWord.Text = "Добавить слово";
            this.AddWord.Click += new System.EventHandler(this.AddWord_Click);
            // 
            // DeleteWord
            // 
            this.DeleteWord.Name = "DeleteWord";
            this.DeleteWord.Size = new System.Drawing.Size(180, 22);
            this.DeleteWord.Text = "Удалить слово";
            this.DeleteWord.Click += new System.EventHandler(this.DeleteWord_Click);
            // 
            // SearchMenu
            // 
            this.SearchMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchByKey,
            this.SearchByValue});
            this.SearchMenu.Name = "SearchMenu";
            this.SearchMenu.Size = new System.Drawing.Size(180, 22);
            this.SearchMenu.Text = "Найти";
            // 
            // SearchByKey
            // 
            this.SearchByKey.Name = "SearchByKey";
            this.SearchByKey.Size = new System.Drawing.Size(148, 22);
            this.SearchByKey.Text = "По ключу";
            this.SearchByKey.Click += new System.EventHandler(this.SearchByKey_Click);
            // 
            // SearchByValue
            // 
            this.SearchByValue.Name = "SearchByValue";
            this.SearchByValue.Size = new System.Drawing.Size(148, 22);
            this.SearchByValue.Text = "По значению";
            this.SearchByValue.Click += new System.EventHandler(this.SearchByValue_Click);
            // 
            // ClearDic
            // 
            this.ClearDic.Name = "ClearDic";
            this.ClearDic.Size = new System.Drawing.Size(180, 22);
            this.ClearDic.Text = "Очистить словарь";
            this.ClearDic.Click += new System.EventHandler(this.ClearDic_Click);
            // 
            // SortMenu
            // 
            this.SortMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortByKey,
            this.SortByValue});
            this.SortMenu.Name = "SortMenu";
            this.SortMenu.Size = new System.Drawing.Size(180, 22);
            this.SortMenu.Text = "Сортировать";
            // 
            // SortByKey
            // 
            this.SortByKey.Name = "SortByKey";
            this.SortByKey.Size = new System.Drawing.Size(148, 22);
            this.SortByKey.Text = "По ключу";
            this.SortByKey.Click += new System.EventHandler(this.SortByKey_Click);
            // 
            // SortByValue
            // 
            this.SortByValue.Name = "SortByValue";
            this.SortByValue.Size = new System.Drawing.Size(148, 22);
            this.SortByValue.Text = "По значению";
            this.SortByValue.Click += new System.EventHandler(this.SortByValue_Click);
            // 
            // StyleMenu
            // 
            this.StyleMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WhiteTheme,
            this.DarkTheme,
            this.toolStripSeparator2,
            this.CreateTheme,
            this.LoadTheme});
            this.StyleMenu.Name = "StyleMenu";
            this.StyleMenu.Size = new System.Drawing.Size(53, 20);
            this.StyleMenu.Text = "Стили";
            // 
            // DarkTheme
            // 
            this.DarkTheme.Name = "DarkTheme";
            this.DarkTheme.Size = new System.Drawing.Size(180, 22);
            this.DarkTheme.Text = "Темная тема";
            this.DarkTheme.Click += new System.EventHandler(this.DarkTheme_Click);
            // 
            // WhiteTheme
            // 
            this.WhiteTheme.Name = "WhiteTheme";
            this.WhiteTheme.Size = new System.Drawing.Size(180, 22);
            this.WhiteTheme.Text = "Белая тема";
            this.WhiteTheme.Click += new System.EventHandler(this.WhiteTheme_Click);
            // 
            // LoadTheme
            // 
            this.LoadTheme.Name = "LoadTheme";
            this.LoadTheme.Size = new System.Drawing.Size(180, 22);
            this.LoadTheme.Text = "Загрузить тему";
            this.LoadTheme.Click += new System.EventHandler(this.LoadTheme_Click);
            // 
            // CreateTheme
            // 
            this.CreateTheme.Name = "CreateTheme";
            this.CreateTheme.Size = new System.Drawing.Size(180, 22);
            this.CreateTheme.Text = "Создать тему";
            this.CreateTheme.Click += new System.EventHandler(this.CreateTheme_Click);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(94, 20);
            this.AboutMenu.Text = "О программе";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // searchGoogle
            // 
            this.searchGoogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchGoogle.Location = new System.Drawing.Point(237, 420);
            this.searchGoogle.Name = "searchGoogle";
            this.searchGoogle.Size = new System.Drawing.Size(124, 23);
            this.searchGoogle.TabIndex = 3;
            this.searchGoogle.Text = "Найти в Google";
            this.searchGoogle.UseVisualStyleBackColor = true;
            this.searchGoogle.Click += new System.EventHandler(this.searchGoogle_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchGoogle);
            this.Controls.Add(this.ValueText);
            this.Controls.Add(this.DictionaryList);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Main";
            this.Text = "DictionaryFury";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox DictionaryList;
        private System.Windows.Forms.Label ValueText;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DicMenu;
        private System.Windows.Forms.ToolStripMenuItem AddWord;
        private System.Windows.Forms.ToolStripMenuItem DeleteWord;
        private System.Windows.Forms.ToolStripMenuItem SearchMenu;
        private System.Windows.Forms.ToolStripMenuItem ClearDic;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem createDic;
        private System.Windows.Forms.ToolStripMenuItem SaveDic;
        private System.Windows.Forms.ToolStripMenuItem SaveAsDic;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem SortMenu;
        private System.Windows.Forms.ToolStripMenuItem SortByKey;
        private System.Windows.Forms.ToolStripMenuItem SortByValue;
        private System.Windows.Forms.ToolStripMenuItem StyleMenu;
        private System.Windows.Forms.ToolStripMenuItem DarkTheme;
        private System.Windows.Forms.ToolStripMenuItem WhiteTheme;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.ToolStripMenuItem SearchByKey;
        private System.Windows.Forms.ToolStripMenuItem SearchByValue;
        private System.Windows.Forms.Button searchGoogle;
        private System.Windows.Forms.ToolStripMenuItem LoadTheme;
        private System.Windows.Forms.ToolStripMenuItem CreateTheme;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

