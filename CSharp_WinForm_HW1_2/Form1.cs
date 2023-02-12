namespace CSharp_WinForm_HW1_2
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation  = "CodMw4.wav";
            player.Play();
        }
        Random ran = new Random();
        static byte size = 180;
        private void button1_Click(object sender, EventArgs e)
        {
            size = 100;
            button1.Top = ran.Next(50, Height - 350);
            button1.Left = ran.Next(0, Width - 350);
            
        }
    }
}