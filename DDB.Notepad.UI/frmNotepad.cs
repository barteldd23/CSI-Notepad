using System.Drawing.Printing;
using System.Web;

namespace DDB.Notepad.UI
{//test push. test
    public partial class frmNotepad : Form
    {
        string fileName = @"c:\users\public\data.txt";
        string folder = string.Empty;
        List<string> lines;
        PrintPreviewDialog printPreviewDialog;

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
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;

                //string strFileName = @"c:\Users\public\data.txt";

                StreamReader streamReader;
                lblInfo.Text = string.Empty;

                if (File.Exists(fileName))
                {
                    streamReader = File.OpenText(fileName);
                    string contents = streamReader.ReadToEnd();

                    streamReader.Close();
                    streamReader = null;

                    lblInfo.Text = contents;
                    lblStatus.Text = "Successfully read " + fileName;
                }
                else
                {
                    throw new Exception(fileName + " does not exist.");

                }

            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
                {
                    File.Delete(fileName);
                    lblStatus.Text = $"{fileName} was deleted.";
                }
                else
                {
                    throw new FileNotFoundException($"{fileName} not set or does not exist.");
                }
            }
            catch (FileNotFoundException ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Purple;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Opacity = trackBar1.Value / 100.0;
        }

        private void btnWriteAppend_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;


                //Or use relative pathing
                //string strFileName = 

                StreamWriter streamWriter;

                // use the streamwriter to create a file;
                streamWriter = File.AppendText(fileName);

                // put the data in the file;
                string strContents = txtInfo.Text;
                streamWriter.WriteLine(strContents);

                // clean up;
                streamWriter.Close();
                streamWriter = null;

                lblStatus.Text = $"File written ({fileName})";
            }
            catch (Exception ex)
            {
                statusStrip.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                string targetFile = Path.GetDirectoryName(fileName) + "\\data_copy.txt";

                if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
                {
                    File.Copy(fileName, targetFile);
                    lblStatus.Text = $"{fileName} was copied.";
                }
                else
                {
                    throw new FileNotFoundException($"{fileName} not set or does not exist.");
                }
            }
            catch (FileNotFoundException ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Purple;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnReadByLine_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;

                StreamReader streamReader;
                lblInfo.Text = string.Empty;

                if (File.Exists(fileName))
                {
                    streamReader = File.OpenText(fileName);

                    lbxInfo.Items.Clear();


                    lines = new List<string>();
                    // loop while I am not at the end of the file;
                    while (!streamReader.EndOfStream)
                    {
                        //lbxInfo.Items.Add(streamReader.ReadLine());
                        lines.Add(streamReader.ReadLine());
                    }

                    //Bind the lines to the list box
                    lbxInfo.DataSource = lines;

                    streamReader.Close();
                    streamReader = null;

                    lblStatus.Text = $"Successfully read {lines.Count} records.";
                }
                else
                {
                    throw new Exception(fileName + " does not exist.");

                }

            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnPickAFile_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = string.Empty;

                OpenFileDialog openFileDialog;

                openFileDialog = new OpenFileDialog();

                openFileDialog.Title = "Pick a file";
                openFileDialog.InitialDirectory = @"c:\Users\public";

                // Show the dialog to the user
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lblStatus.Text = openFileDialog.FileName;
                    fileName = openFileDialog.FileName;
                }
                else
                {
                    throw new Exception("No file selected. No soup for you!");
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = string.Empty;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                StreamWriter streamWriter;

                saveFileDialog.Title = "Please pick a file";
                saveFileDialog.InitialDirectory = @"c:\Users\public";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileDialog.FileName;
                    streamWriter = File.CreateText(fileName);

                    streamWriter.WriteLine(txtInfo.Text);
                    streamWriter.Close();
                    streamWriter = null;
                    lblStatus.Text = $"{fileName} written. . .";
                }
                else
                {
                    throw new Exception("No file selected ... ");
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSelectOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = string.Empty;

                OpenFileDialog openFileDialog;

                openFileDialog = new OpenFileDialog();

                openFileDialog.Title = "Pick a file";
                openFileDialog.InitialDirectory = @"c:\Users\public";
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                // Show the dialog to the user
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                    StreamReader streamReader = File.OpenText(fileName);
                    lblInfo.Text = streamReader.ReadToEnd();

                    lblStatus.Text = openFileDialog.FileName;

                    streamReader.Close();
                    streamReader = null;
                }
                else
                {
                    throw new Exception("No file selected. No soup for you!");
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDialog.Color;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnChangeButtonsColor_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Loop through all the controls on the form.
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        // Ask if this controls[i] is a button
                        if (this.Controls[i].GetType() == typeof(Button))
                        {
                            this.Controls[i].BackColor = colorDialog.Color;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folder = folderBrowserDialog.SelectedPath;
                lblStatus.Text = $"Selected Folder : {folder}";
            }
        }

        private void btnSetFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in this.Controls)
                {
                    control.Font = fontDialog.Font;
                }
            }
        }

        private void btnChangeStyle_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in this.Controls)
                {
                    control.Font = new Font(control.Font.FontFamily,
                                            control.Font.Size,
                                            fontDialog.Font.Style);
                }
            }
        }

        private PrintDocument docToPrint = new PrintDocument();
        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog = new PrintPreviewDialog();

            printPreviewDialog.Document = docToPrint;

            printPreviewDialog.Document.PrintPage += new PrintPageEventHandler(document_PrintPage);

            DialogResult result = printPreviewDialog.ShowDialog();

            if (result == DialogResult.OK) 
            {
                docToPrint.Print();
            }

        }

        private void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = "Hello C# Intermediate";
            Font printFont = new Font("Arial", 35, System.Drawing.FontStyle.Regular);

            //draw the content
            e.Graphics.DrawString(text, printFont, Brushes.Black, 10, 10);
        }
    }
}