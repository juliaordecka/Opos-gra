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
        int rows, columns, dydelfRows, dydelfColumns, numberOfDydelfs;
        
        public Form3(int rows, int columns, int numberOfDydelfs)
        {
            InitializeComponent();
            this.rows = rows;
            this.columns = columns;
            this.numberOfDydelfs=numberOfDydelfs;
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
                    button.Name = $"button_{i}_{j}";
                    button.Location = new Point(10 + i * 100, 10 + j * 100);
                    button.Size = new Size(80, 80);
                    button.BackColor = Color.Gray;
                    button.Click += button_Click;
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
        //set random dydelf placement
        //ZLEEEEEEEEEEEEEEEEEEEEEEE 
        private void PlaceDydelf(int rows, int columns)
        {
            for (int k = 0; k < numberOfDydelfs; k++)
            {
                int dydelfRow = random.Next(0, rows);
                int dydelfColumn = random.Next(0, columns);
                Button button = (Button)this.Controls.Find($"button_{dydelfColumn}_{dydelfRow}", true).FirstOrDefault();
                if (button != null && button.Text != "Dydelf")
                {
                    button.Text = "Dydelf";
                }
                else
                {
                    k--; // If the position already has a Dydelf, repeat the loop
                }
            }
        }
        //to zmodyfikowac zeby dzialalo dla ilosci dydelfow wprowadzonych przez uzytkownika
        //after clicking the generated buttons check if dydelf is found - applies to all generated buttons
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Location.X == 10 + dydelfColumns * 100 && button.Location.Y == 10 + dydelfRows * 100)
            {
                button.Text="Dydelf znaleziony";
                button.Enabled = false;
            }
            else
            {
                button.Text="Puste pole";
                button.Enabled = false;
            }
        }


    }
}
