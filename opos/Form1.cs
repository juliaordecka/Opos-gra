namespace opos
{
    public partial class Form1 : Form
    {

        public int x = 3;
        public int y = 3;
        public int dydelfy = 1;
        public int krokodyle = 1;
        public int czas = 30;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //koniec - zamknij okno
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //start
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 nowe_okno = new Form3(this);
            nowe_okno.Show();
            nowe_okno.GameBoard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 nowe_okno = new Form2(this);
            nowe_okno.ShowDialog(); ;
   
            
        }
    }
}
