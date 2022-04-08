using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combining_translations
{
    public partial class Form1 : Form
    {
        private string ruFileName;
        private string enFileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файл перевода 'lang_ru.js' | lang_ru.js";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ruFileName = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = ruFileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Файл перевода 'lang_en.js' | lang_en.js";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                enFileName = openFileDialog2.FileName;
                textBox2.Clear();
                textBox2.Text = enFileName;
            }
        }
    }
}
