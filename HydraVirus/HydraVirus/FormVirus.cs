namespace HydraVirus
{
    public partial class FormVirus : Form
    {
        public FormVirus()
        {
            InitializeComponent();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            this.Hide();

            FormVirus lefHead = new FormVirus();
            lefHead.Location = new Point(random.Next(0, 300), random.Next(0, 300));
            lefHead.Show();

            FormVirus rightHead = new FormVirus();
            rightHead.Location = new Point(random.Next(0, 300), random.Next(0, 300));
            rightHead.Show();
        }
    }
}