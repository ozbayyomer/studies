namespace ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sonuc = 0;
        double sonuc2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textbox1.Text);
            int s2 = Convert.ToInt32(textbox2.Text);
            int Sonuc = s1 - s2;
            lblSonuc.Text = Sonuc.ToString();

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            sonuc = double.Parse(textbox1.Text) + double.Parse(textbox2.Text);
            lblSonuc.Text = sonuc.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            sonuc = double.Parse(textbox1.Text) / double.Parse(textbox2.Text);
            lblSonuc.Text = sonuc.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            sonuc = double.Parse(textbox1.Text) * double.Parse(textbox2.Text);
            lblSonuc.Text = sonuc.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textbox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int en = pb1.Width;
            int boy = pb1.Height;
            pb1.Size = new Size(en - 3, boy - 3);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int en = pb1.Width;
            int boy = pb1.Height;
            pb1.Size = new Size(en + 3, boy + 3);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pb1.Location = new Point(pb1.Location.X, pb1.Location.Y + 3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pb1.Location = new Point(pb1.Location.X, pb1.Location.Y - 3);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Random hareket = new Random();
            pb1.Top = hareket.Next(300);
            pb1.Left = hareket.Next(800); pb1.Width = hareket.Next(200);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sonuc = double.Parse(textbox3.Text) * (6.28);
            label5.Text = sonuc.ToString();
            sonuc2 = double.Parse(textbox3.Text) * double.Parse(textbox3.Text) * 3.14;
            label6.Text = sonuc2.ToString();
        }
    }
}
