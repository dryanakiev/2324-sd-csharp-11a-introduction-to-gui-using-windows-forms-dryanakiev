namespace SimpleButtonClicker
{
    public partial class ButtonSmasher : Form
    {
        public int Clicks { get; set; }
        public ButtonSmasher()
        {
            InitializeComponent();

            labelCounter.Text = "Cut off one of my heads and \ntwo new ones will grow back!";
            buttonClicker.Text = "Cut off";
        }

        private void buttonClicker_Click(object sender, EventArgs e)
        {
            //Clicks++;

            //labelCounter.Text = $"Clicks: {Clicks}";
            this.Hide();

            ButtonSmasher buttonSmasher1 = new ButtonSmasher();
            ButtonSmasher buttonSmasher2 = new ButtonSmasher();
            Random random = new Random();

            buttonSmasher1.Show();
            buttonSmasher1.Location = new Point(random.Next(0, 1800), random.Next(0, 1000));
            buttonSmasher2.Show();
            buttonSmasher2.Location = new Point(random.Next(0, 1800), random.Next(0, 1800));
        }
    }
}