using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opos
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows, columns;
            if (!int.TryParse(textBox4.Text, out rows) || !int.TryParse(textBox5.Text, out columns))
            {
                MessageBox.Show("Podaj liczby całkowite");
                return;
            }
            Form3 form3 = new Form3(rows, columns);
            form3.Show();
        }
    }
}
