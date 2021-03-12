namespace Task6.Views
{
    partial class Theme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.AppBackColor = new System.Windows.Forms.Button();
            this.TextColor = new System.Windows.Forms.Button();
            this.ListBackColor = new System.Windows.Forms.Button();
            this.ListColor = new System.Windows.Forms.Button();
            this.ButtonBackColor = new System.Windows.Forms.Button();
            this.ButtonColor = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NameTheme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MenuBackColor = new System.Windows.Forms.Button();
            this.MenuColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройка темы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фон";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Цвет текста";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Цвет фона списка";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Цвет текста списка";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(14, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Цвет фона кнопок";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Цвет текста кнопок";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AppBackColor
            // 
            this.AppBackColor.Location = new System.Drawing.Point(161, 63);
            this.AppBackColor.Name = "AppBackColor";
            this.AppBackColor.Size = new System.Drawing.Size(103, 23);
            this.AppBackColor.TabIndex = 2;
            this.AppBackColor.Text = "Выбрать цвет";
            this.AppBackColor.UseVisualStyleBackColor = true;
            this.AppBackColor.Click += new System.EventHandler(this.AppBackColor_Click);
            // 
            // TextColor
            // 
            this.TextColor.Location = new System.Drawing.Point(161, 96);
            this.TextColor.Name = "TextColor";
            this.TextColor.Size = new System.Drawing.Size(103, 23);
            this.TextColor.TabIndex = 2;
            this.TextColor.Text = "Выбрать цвет";
            this.TextColor.UseVisualStyleBackColor = true;
            this.TextColor.Click += new System.EventHandler(this.TextColor_Click);
            // 
            // ListBackColor
            // 
            this.ListBackColor.Location = new System.Drawing.Point(161, 132);
            this.ListBackColor.Name = "ListBackColor";
            this.ListBackColor.Size = new System.Drawing.Size(103, 23);
            this.ListBackColor.TabIndex = 2;
            this.ListBackColor.Text = "Выбрать цвет";
            this.ListBackColor.UseVisualStyleBackColor = true;
            this.ListBackColor.Click += new System.EventHandler(this.ListBackColor_Click);
            // 
            // ListColor
            // 
            this.ListColor.Location = new System.Drawing.Point(161, 168);
            this.ListColor.Name = "ListColor";
            this.ListColor.Size = new System.Drawing.Size(103, 23);
            this.ListColor.TabIndex = 2;
            this.ListColor.Text = "Выбрать цвет";
            this.ListColor.UseVisualStyleBackColor = true;
            this.ListColor.Click += new System.EventHandler(this.ListColor_Click);
            // 
            // ButtonBackColor
            // 
            this.ButtonBackColor.Location = new System.Drawing.Point(161, 206);
            this.ButtonBackColor.Name = "ButtonBackColor";
            this.ButtonBackColor.Size = new System.Drawing.Size(103, 23);
            this.ButtonBackColor.TabIndex = 2;
            this.ButtonBackColor.Text = "Выбрать цвет";
            this.ButtonBackColor.UseVisualStyleBackColor = true;
            this.ButtonBackColor.Click += new System.EventHandler(this.ButtonBackColor_Click);
            // 
            // ButtonColor
            // 
            this.ButtonColor.Location = new System.Drawing.Point(161, 243);
            this.ButtonColor.Name = "ButtonColor";
            this.ButtonColor.Size = new System.Drawing.Size(103, 23);
            this.ButtonColor.TabIndex = 2;
            this.ButtonColor.Text = "Выбрать цвет";
            this.ButtonColor.UseVisualStyleBackColor = true;
            this.ButtonColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(537, 284);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NameTheme
            // 
            this.NameTheme.Location = new System.Drawing.Point(416, 286);
            this.NameTheme.Name = "NameTheme";
            this.NameTheme.Size = new System.Drawing.Size(115, 20);
            this.NameTheme.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(286, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Название темы";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(303, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Цвет фона меню";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(303, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Цвет меню";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MenuBackColor
            // 
            this.MenuBackColor.Location = new System.Drawing.Point(444, 63);
            this.MenuBackColor.Name = "MenuBackColor";
            this.MenuBackColor.Size = new System.Drawing.Size(103, 23);
            this.MenuBackColor.TabIndex = 8;
            this.MenuBackColor.Text = "Выбрать цвет";
            this.MenuBackColor.UseVisualStyleBackColor = true;
            this.MenuBackColor.Click += new System.EventHandler(this.MenuBackColor_Click);
            // 
            // MenuColor
            // 
            this.MenuColor.Location = new System.Drawing.Point(444, 98);
            this.MenuColor.Name = "MenuColor";
            this.MenuColor.Size = new System.Drawing.Size(103, 23);
            this.MenuColor.TabIndex = 9;
            this.MenuColor.Text = "Выбрать цвет";
            this.MenuColor.UseVisualStyleBackColor = true;
            this.MenuColor.Click += new System.EventHandler(this.MenuColor_Click);
            // 
            // Theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.MenuColor);
            this.Controls.Add(this.MenuBackColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NameTheme);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ButtonColor);
            this.Controls.Add(this.ButtonBackColor);
            this.Controls.Add(this.ListColor);
            this.Controls.Add(this.ListBackColor);
            this.Controls.Add(this.TextColor);
            this.Controls.Add(this.AppBackColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Theme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка темы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button AppBackColor;
        private System.Windows.Forms.Button TextColor;
        private System.Windows.Forms.Button ListBackColor;
        private System.Windows.Forms.Button ListColor;
        private System.Windows.Forms.Button ButtonBackColor;
        private System.Windows.Forms.Button ButtonColor;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox NameTheme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button MenuBackColor;
        private System.Windows.Forms.Button MenuColor;
    }
}