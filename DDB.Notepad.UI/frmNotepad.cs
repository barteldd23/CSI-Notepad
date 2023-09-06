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

            //if (btnTimerToggle.Text == "ON")
            //{
            //    //Enable Timer and change text to OFF
            //    btnTimerToggle.Text = "OFF";
            //    timer1.Enabled = true;
            //}
            //else
            //{
            //    //Disable Timer and change text to ON
            //    btnTimerToggle.Text = "ON";
            //    timer1.Enabled = false;
            //}

            //turnary operator
            btnTimerToggle.Text = btnTimerToggle.Text == "ON" ? btnTimerToggle.Text = "OFF" : btnTimerToggle.Text = "ON";
            timer1.Enabled = !timer1.Enabled;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // This code will execute every second
            // when timer is enabled.
            this.Opacity -= .01;

            lbxInfo.Items.Add(DateTime.Now.ToString());

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;


                //designate the file path and escape the slashes
                string strFileName = "c:\\Users\\public\\data.txt";

                //Or use relative pathing
                //string strFileName = 

                StreamWriter streamWriter;

                // use the streamwriter to create a file;
                streamWriter = File.CreateText(strFileName);

                // put the data in the file;
                string strContents = txtInfo.Text;
                streamWriter.WriteLine(strContents);

                // clean up;
                streamWriter.Close();
                streamWriter = null;

                lblStatus.Text = "File written (" + strFileName + ")";
            }
            catch (Exception ex)
            {
                statusStrip.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
                throw;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;

                string strFileName = @"c:\Users\public\data1.txt";

                StreamReader streamReader;
                lblInfo.Text = string.Empty;

                if (File.Exists(strFileName))
                {
                    streamReader = File.OpenText(strFileName);
                    string contents = streamReader.ReadToEnd();

                    streamReader.Close();
                    streamReader = null;

                    lblInfo.Text = contents;
                    lblStatus.Text = "Successfully read " + strFileName;
                }
                else
                {
                    throw new Exception(strFileName + " does not exist.");










                }


                
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
                throw;
            }
        }
    }
}