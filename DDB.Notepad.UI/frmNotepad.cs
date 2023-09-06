namespace DDB.Notepad.UI
{
    public partial class frmNotepad : Form
    {
        public frmNotepad()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTimerToggle_Click(object sender, EventArgs e)
        {
            // Toggle the button - LONG WAY

            if (btnTimerToggle.Text == "ON")
            {
                //Enable Timer and change text to OFF
                btnTimerToggle.Text = "OFF";
                timer1.Enabled = true;
            }
            else
            {
                //Disable Timer and change text to ON
                btnTimerToggle.Text = "ON";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // This code will execute every second
            // when timer is enabled.

            lbxInfo.Items.Add(DateTime.Now.ToString());

        }
    }
}