namespace Task6.Views
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.Location = new System.Drawing.Point(12, 9);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(320, 23);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Введите ключ";
            this.SearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(79, 50);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(185, 20);
            this.SearchText.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SearchButton.Location = new System.Drawing.Point(79, 106);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(185, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 141);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.SearchLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск по словарю";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button SearchButton;
        public System.Windows.Forms.TextBox SearchText;
    }
}