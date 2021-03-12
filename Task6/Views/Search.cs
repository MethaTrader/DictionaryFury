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
    public partial class Search : Form
    {
        public Search(string v)
        {
            InitializeComponent();

            SearchLabel.Text = "Введите " + v;
            this.Text = $"Поиск слова ({v})";
        }
    }
}
