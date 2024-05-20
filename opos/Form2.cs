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

        Form1 parent;
        public Form2(Form1 okno)
        {
            InitializeComponent();
            parent = okno; 
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
           
            int domyslneX = 3;
            int domyslneY = 3;
            int domyslneDydelfy = 1;
            int domyslneKrokodyle = 1;
            int domyslnyCzas = 30;

            
            int wprowadzoneX = string.IsNullOrWhiteSpace(textBox4.Text) ? domyslneX : int.Parse(textBox4.Text);
            int wprowadzoneY = string.IsNullOrWhiteSpace(textBox5.Text) ? domyslneY : int.Parse(textBox5.Text);
            int wprowadzoneDydelfy = string.IsNullOrWhiteSpace(textBox1.Text) ? domyslneDydelfy : int.Parse(textBox1.Text);
            int wprowadzoneKrokodyle = string.IsNullOrWhiteSpace(textBox2.Text) ? domyslneKrokodyle : int.Parse(textBox2.Text);
            int wprowadzonyCzas = string.IsNullOrWhiteSpace(textBox3.Text) ? domyslnyCzas : int.Parse(textBox3.Text);

          
            if (wprowadzoneX <= 10 && wprowadzoneY <= 10 && wprowadzoneDydelfy + wprowadzoneKrokodyle <= wprowadzoneX * wprowadzoneY && wprowadzonyCzas > 0)
            {
               
                parent.x = wprowadzoneX;
                parent.y = wprowadzoneY;
                parent.dydelfy = wprowadzoneDydelfy;
                parent.krokodyle = wprowadzoneKrokodyle;
                parent.czas = wprowadzonyCzas;

                Close();
            }
            else
            {
                label7.Text = "wprowadz poprawne dane";
            }
        }


    }
}
