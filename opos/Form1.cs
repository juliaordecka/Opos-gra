namespace opos
{
    public partial class Form1 : Form
    {
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
            Form F3 = new Form3();
            F3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form F2 = new Form2();
            F2.Show();
   
            
        }
    }
}
