using opos.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//START 

namespace opos
{
    public partial class Form3 : Form
    {
        Form1 parent;
        private int czasOdmierzania;

        public Form3(Form1 okno)
        {
            InitializeComponent();
            parent = okno;
            czasOdmierzania = parent.czas;
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;

            timer.Start();

        }

        private int znalezione_dydelfy;
        private bool koniec_gry;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        int x = 0;
        int y = 100;
        private PictureBox[,] pictureBoxes; 
        List<Tuple<int, int>> listaDydelfow = new List<Tuple<int, int>>();
        List<Tuple<int, int>> listaKrokodylow = new List<Tuple<int, int>>();

        public void GameBoard()
        {
            pictureBoxes = new PictureBox[parent.y, parent.x];
            for (int i = 0; i < parent.y; i++)
            {
                for (int j = 0; j < parent.x; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(x, y);
                    x = x + 170;
               
                    pictureBox.Size = new Size(100, 100);
                    pictureBox.Image = Resources.garbage_can;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    Controls.Add(pictureBox);
                    
                    pictureBoxes[i, j] = pictureBox;
                  
                    pictureBox.Click += PictureBox_Click;
                }
                y = y + 170;
                x = 0;
            }

            int totalFields = parent.y * parent.x;

            for (int i = 0; i < parent.dydelfy; i++)
            {
                Random random = new Random();
                int randomRow = random.Next(1, parent.y);
                int randomColumn = random.Next(1, parent.x);
                listaDydelfow.Add(new Tuple<int, int>(randomRow, randomColumn));
            }

            for (int i = 0; i < parent.krokodyle; i++)
            {
                Tuple<int, int> krokodylTuple;
                do
                {
                    Random random = new Random();
                    int randomRow = random.Next(1, parent.y);
                    int randomColumn = random.Next(1, parent.x);
                    krokodylTuple = new Tuple<int, int>(randomRow, randomColumn);
                } while (listaDydelfow.Contains(krokodylTuple));
                listaKrokodylow.Add(krokodylTuple);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;
            int clickedRowIndex = -1;
            int clickedColumnIndex = -1;
            bool isClickedDydelf = false;
            bool isClickedKrokodyl = false;
            for (int i = 0; i < parent.y; i++)
            {
                for (int j = 0; j < parent.x; j++)
                {
                    if (pictureBoxes[i, j] == clickedPictureBox)
                    {
                        clickedRowIndex = i;
                        clickedColumnIndex = j;
                        var clickedBox = Tuple.Create(j, i);
                        isClickedDydelf = listaDydelfow.Contains(clickedBox);
                        isClickedKrokodyl = listaKrokodylow.Contains(clickedBox);
                        break;
                    }
                }
                if (clickedRowIndex != -1)
                    break;
            }

            if (isClickedDydelf)
            {
                clickedPictureBox.Image = Resources.possum;
                clickedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                znalezione_dydelfy++;
                if (znalezione_dydelfy == parent.dydelfy && !koniec_gry)
                {
                    koniec_gry = true;
                    label3.Text = "gratulacje";
                    timer.Stop();
                }
            }
            else if (isClickedKrokodyl)
            {
                clickedPictureBox.Image = Resources.krokodyl;
                clickedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                if (!koniec_gry)
                {
                    koniec_gry = true;
                    label3.Text = "przegrales";
                    timer.Stop();
                }
            }
            else
            {
                clickedPictureBox.Image = Resources.nic;
                clickedPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            czasOdmierzania--;

            label2.Text = czasOdmierzania.ToString() + " s";

            if (czasOdmierzania <= 0)
            {
                timer.Stop();

                label3.Text = "koniec czasu";
                koniec_gry = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
    
