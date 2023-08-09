using System.CodeDom;

namespace WordsPerMinute
{
    public partial class Form1 : Form
    {
        private bool testStarted = false;
        private DateTime timeStarted = DateTime.MinValue;
        private DateTime timeEnded = DateTime.MinValue;
        //private DateTime timeElapsed = DateTime.MinValue;
        private TimeSpan timeInterval = TimeSpan.Zero;
        char passwordDotSmall = '\u2022';// or "\u25cf"
        char passwordDotLarge = '\u25cf';

        public Form1()
        {
            InitializeComponent();
            textBox1.PasswordChar = passwordDotLarge;
            textBox1.UseSystemPasswordChar = false;
        }

        private void updateResultTimer(object sender, EventArgs e)
        {
            UpdateResult();
            if (!checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = true;

            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void updateResultKeyPress(object sender, KeyEventArgs e)
        {
            UpdateResult();
        }

        private void UpdateResult()
        {
            if (testStarted)
            {
                float wpm = 0;
                float cpm = 0;
                if (timeStarted != DateTime.MinValue)
                {
                    timeInterval = timeEnded - timeStarted;
                    cpm = 60 * (textBox1.Text.Length / (float)timeInterval.TotalSeconds);
                    wpm = cpm / 5;
                    if (textBox1.Text.Length > 2)
                    {
                        labelResult.Text = "WPM: " + ((int)wpm).ToString().PadLeft(3);
                        labelTime.Text = "Time: " + TimeSpanHMS(timeInterval).ToString().Substring(3, 5);
                        //this.Text = "Words Per Minute   debug: " + textBox1.Text.Length;
                    }
                    else
                    {                        
                        labelResult.Text = "WPM: ..."; // hide negative numbers and other errors at the start of typing
                    }
                }

            }
            else
            {
                if (textBox1.Text.Length > 0)
                {
                    StartTest();
                }
            }
        }

        public TimeSpan TimeSpanHMS(TimeSpan time)
        {
            return new TimeSpan(time.Hours, time.Minutes, time.Seconds);
        }

        private void StartTest()
        {
            testStarted = true;
            timeStarted = DateTime.Now;
        }

        private void handleKeys(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                ResetTest();
            }
            else
            {
                timeEnded = DateTime.Now;
            }
        }

        private void ResetTest()
        {
            textBox1.Text = string.Empty;
            labelResult.Text = "WPM: ...";
            labelTime.Text = "Time: 00:00";
            testStarted = false;
            textBox1.Focus();
        }

        private void clickReset(object sender, EventArgs e)
        {
            ResetTest();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = true;
                ResetTest();
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
                ResetTest();
            }
        }
    }
}