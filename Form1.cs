using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> list = new List< int>();
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random random = new Random();
            for(int i = 0;i<n;i++)
            {
                list.Add(random.Next(-1000,999));
            }
            foreach(int i in list)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int max = -1001;
            int druheMax = -1001;
            int poradiMax = 0;
            int poradiDruhehoMax = 0;
            for(int i =0;i<list.Count;i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                    poradiMax = i;
                }
                if (list[i] > druheMax && list[i] < max)
                {
                    druheMax = list[i];
                    poradiDruhehoMax=i;
                }
            }
            MessageBox.Show("Max: " + max + " Poradi max: " + poradiMax + "\nDruhe max: " + druheMax + " Poradi druheho max: " + poradiDruhehoMax);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int max = list.Max();
            int min = list.Min();
            list[list.IndexOf(max)] = min;
            list[list.IndexOf(min)] = max;
            foreach(int x in list)
            {
                listBox2.Items.Add(x);
            }
        }
    }
}
