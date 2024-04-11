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
    public partial class Form3 : Form
    {
        Random random = new Random();
        public Form3()
        {
            InitializeComponent();
            
        }
        int rows, columns, dydelfRows, dydelfColumns;
        
        public Form3(int rows, int columns)
        {
            InitializeComponent();
            this.rows = rows;
            this.columns = columns;
            createButtons(rows, columns);
            PlaceDydelf(rows, columns);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void createButtons(int rows, int columns)
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Button button = new Button();
                    //button.Text = "Button " + i + " " + j;
                    button.Location = new Point(10 + i * 100, 10 + j * 100);
                    button.Size = new Size(80, 80);
                    this.Controls.Add(button);
                }
            }
        }



        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Location.X == 10 + dydelfColumns * 100 && button.Location.Y == 10 + dydelfRows * 100)
            {
                MessageBox.Show("Dydelf znaleziony");
            }
            else
            {
                MessageBox.Show("Puste pole");
            }
        }

        private void PlaceDydelf(int rows, int columns)
        {
            dydelfRows = random.Next(0, rows);
            dydelfColumns = random.Next(0, columns);
            Button button = new Button();
            button.Text = "Dydelf";
            button.Location = new Point(10 + dydelfColumns * 100, 10 + dydelfRows * 100);
            button.Size = new Size(80, 80);
            this.Controls.Add(button);
        }
    }
}
