namespace ClicksPerMinute
{
    public partial class FormCPM : Form
    {
        private int clicks = 0;
        private int highScore = 0;
        private int countdown = 10;

        public FormCPM()
        {
            InitializeComponent();

            timerCountdown.Interval = 1000;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Hide();
            label1.Text = "";
            timerCountdown.Enabled = true;
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (countdown <= 1)
            {
                timerCountdown.Stop();
                buttonStart.Show();

                label1.Text = $"High score: {highScore} \nCurrent score: {clicks*6} per minute";

                if (highScore < clicks*6)
                {
                    highScore = clicks * 6;
                }

                countdown = 10;

                clicks = 0;
            }
            else
            {
                countdown--;

                label1.Text = $"Time left: {countdown}";
            }
        }

        private void FormCPM_Click(object sender, EventArgs e)
        {
            if (timerCountdown.Enabled)
            {
                clicks++;
            }
        }
    }
}