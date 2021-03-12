using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6.Views
{
    public partial class AddWord : Form
    {
        public AddWord()
        {
            InitializeComponent();

            KeyInput.Validating += inputValidation;
            ValueInput.Validating += inputValidation;

        }

        private void inputValidation(object sender, CancelEventArgs e)
        {
            //Валидация для ключа
            if (String.IsNullOrEmpty(KeyInput.Text))
                errorValid.SetError(KeyInput, "Ключ не указан!");
            else if (KeyInput.Text.Length < 3)
                errorValid.SetError(KeyInput, "Слишком короткий ключ");
            else errorValid.Clear();

            //Валидация для значения
            if (String.IsNullOrEmpty(ValueInput.Text))
                errorValid.SetError(ValueInput, "Значение не указано!");
            else if (ValueInput.Text.Length < 3)
                errorValid.SetError(ValueInput, "Слишком короткое значение");
            else errorValid.Clear();
        }
    }
}
