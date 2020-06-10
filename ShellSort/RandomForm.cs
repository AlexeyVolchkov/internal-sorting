using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShellSort
{
    public partial class RandomForm : Form
    {
        public int min;
        public int max;
        public int count;
        public RandomForm()
        {
            InitializeComponent();
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            if ((int) nudMin.Value > (int) nudMax.Value)
            {
                MessageBox.Show("Минимум больше максимума!");
                return;
            }
            min = (int) nudMin.Value;
            max = (int) nudMax.Value;
            count = (int) nudCount.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
