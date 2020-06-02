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
    public partial class MainForm : Form
    {
        int[] array;
        public MainForm()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void Random_Click(object sender, EventArgs e)
        {
            using (RandomForm form = new RandomForm())
            {
                if (form.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                array = new int[form.count];
                for (int i = 0; i < form.count; i++)
                {
                    array[i] = rnd.Next(form.min, form.max + 1);
                }
                Print(array);
            }
        }

        private void Print(int[] array)
        {
            tbArray.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                tbArray.Text += array[i].ToString() + ", ";
            }
            tbArray.Text = tbArray.Text.Substring(0, tbArray.Text.Length - 2);
        }

        private void HibbardSort(int[] array)
        {
            List<int> list = new List<int>();
            int elem = 1;
            int elemPower = 1;
            do
            {
                list.Add(elem);
                elemPower++;
                elem = (elem ^ elemPower) - 1;
            } while (elem < array.Length);
            int[] d = list.ToArray();
            int i, j, inc, temp;
            int count = 0;
            int dIndex = d.Length - 1;
            inc = d[dIndex];
            while (inc > 0)
            {
                for (i = 0; i < array.Length; i++)
                {
                    j = i;
                    temp = array[i];
                    while ((j >= inc) && (array[j - inc] > temp))
                    {
                        array[j] = array[j - inc];
                        j -= inc;
                        count++;
                    }
                    array[j] = temp;
                }
                if (dIndex == 0)
                {
                    inc = 0;
                }
                else
                {
                    inc = d[--dIndex];
                }
            }
            dgv.Rows.Add("Последовательность Хиббарда", count.ToString());
        }

        private void MarcinSort(int[] array)
        {
            int[] d = new int[] { 1, 4, 10, 23, 57, 132, 301, 701 };
            int dIndex = d.Length;
            int i, j, inc, temp;
            int count = 0;
            inc = 57;
            while (inc > 0)
            {
                for (i = 0; i < array.Length; i++)
                {
                    j = i;
                    temp = array[i];
                    while ((j >= inc) && (array[j - inc] > temp))
                    {
                        array[j] = array[j - inc];
                        j -= inc;
                        count++;
                    }
                    array[j] = temp;
                }
                if (dIndex == 0)
                {
                    inc = 0;
                }
                else
                {
                    inc = d[--dIndex];
                }
            }
            dgv.Rows.Add("Последовательность Марцина Цируна", count.ToString());
        }
        private void RegularSort(int[] array)
        {
            int i, j, inc, temp;
            int count = 0;
            inc = array.Length / 2;
            while (inc > 0)
            {
                for (i = 0; i < array.Length; i++)
                {
                    j = i;
                    temp = array[i];
                    while ((j >= inc) && (array[j - inc] > temp))
                    {
                        array[j] = array[j - inc];
                        j -= inc;
                        count++;
                    }
                    array[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
            dgv.Rows.Add("Обычный выбор шага", count.ToString());
        }
        private void Sort_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            RegularSort((int[])array.Clone());
            MarcinSort((int[])array.Clone());
            HibbardSort((int[])array.Clone());
        }
    }
}
