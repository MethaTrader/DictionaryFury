namespace Task6.Views
{
    partial class AddWord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWord));
            this.KeyInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValueInput = new System.Windows.Forms.TextBox();
            this.AddWordButton = new System.Windows.Forms.Button();
            this.errorValid = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorValid)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyInput
            // 
            this.KeyInput.Location = new System.Drawing.Point(89, 25);
            this.KeyInput.Name = "KeyInput";
            this.KeyInput.Size = new System.Drawing.Size(160, 20);
            this.KeyInput.TabIndex = 0;
            this.KeyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Значение";
            // 
            // ValueInput
            // 
            this.ValueInput.Location = new System.Drawing.Point(89, 64);
            this.ValueInput.Name = "ValueInput";
            this.ValueInput.Size = new System.Drawing.Size(160, 20);
            this.ValueInput.TabIndex = 3;
            this.ValueInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddWordButton
            // 
            this.AddWordButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddWordButton.Location = new System.Drawing.Point(89, 106);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(160, 23);
            this.AddWordButton.TabIndex = 4;
            this.AddWordButton.Text = "Добавить";
            this.AddWordButton.UseVisualStyleBackColor = true;
            // 
            // errorValid
            // 
            this.errorValid.ContainerControl = this;
            // 
            // AddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 141);
            this.Controls.Add(this.AddWordButton);
            this.Controls.Add(this.ValueInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить слово";
            ((System.ComponentModel.ISupportInitialize)(this.errorValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddWordButton;
        public System.Windows.Forms.TextBox ValueInput;
        public System.Windows.Forms.TextBox KeyInput;
        private System.Windows.Forms.ErrorProvider errorValid;
    }
}