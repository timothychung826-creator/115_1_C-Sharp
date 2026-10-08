namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Closable = true;
        }

        private void showFacebutton(object sender, EventArgs e)
        {
            cardFacePictureBox.Visible= true
        }   cardBackPictureBox.Visible= false
        
        
      

        private void showBackbutton_Click(object sender, EventArgs e)
        { cardBackPictureBox.Visible= true
          cardFacePictureBox.Visible= false

        }
    }
}
