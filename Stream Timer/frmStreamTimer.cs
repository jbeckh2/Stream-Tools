using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stream_Timer
{
    public partial class frmStreamTimer : Form
    {
        public frmStreamTimer()
        {
            InitializeComponent();
        }

        private void frmStreamTimer_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today;
            dtpTime.Value = DateTime.Now.AddHours(1).AddMinutes(-1 * DateTime.Now.Minute).AddSeconds(-1 * DateTime.Now.Second);
            lblCurrentCountDown.Text = "";

            Settings defaults = Settings.Load();
            if (defaults != null)
            {
                txtFile.Text = defaults.OutputFile;
                txtMessage.Text = defaults.Message;
                txtFormat.Text = defaults.TimeSpanFormat;
                chkDisplayMessage.Checked = defaults.ShowMessage;
            }
            else
            {   
                txtFile.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "timerOutput.txt");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string oldTime = lblCurrentCountDown.Text;
            string newTime = GetCountDown(dtpDate.Value, dtpTime.Value).ToString(GetTimeFormat());
            if (oldTime != newTime)
            {
                if (TimeIsUp())
                {
                    newTime = txtMessage.Text;
                }
                lblCurrentCountDown.Text = newTime;
                WriteCountDownToFile(lblCurrentCountDown.Text, txtFile.Text);
            }
        }

        private string GetTimeFormat()
        {
            return txtFormat.Text.Replace(":", "\\:");
        }

        private bool TimeIsUp()
        {
            return GetEndTime() <= DateTime.Now;
        }

        private void WriteCountDownToFile(string strOutput, string strFile)
        {
            File.WriteAllText(strFile, strOutput);
        }

        private TimeSpan GetCountDown(DateTime dtDate, DateTime dtTime)
        {
            TimeSpan result;

            DateTime dtEndTime = GetEndTime();
            result = dtEndTime - DateTime.Now;
            return result;
        }

        private DateTime GetEndTime()
        {
            return dtpDate.Value.Add(dtpTime.Value.TimeOfDay); 
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (SettingsAreValid())
            {
                if (timer1.Enabled)
                {
                    btnStartStop.Text = "Start";
                    txtFile.Enabled = true;
                    txtFormat.Enabled = true;
                    timer1.Stop();
                }
                else
                {
                    btnStartStop.Text = "Stop";
                    txtFile.Enabled = false;
                    txtFormat.Enabled = false;
                    timer1.Start();
                }
            }
            else
            {
                MessageBox.Show("Settings are not valid");
            }
        }

        private bool SettingsAreValid()
        {
            try
            {
                (DateTime.Now - DateTime.Now).ToString(GetTimeFormat());
                string fullPath = Path.GetFullPath(txtFile.Text);
                string directory = Path.GetDirectoryName(txtFile.Text);
                if (!Directory.Exists(directory))
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = sfdFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFile.Text = sfdFile.FileName;
            }
        }

        private void chkDisplayMessage_CheckedChanged(object sender, EventArgs e)
        {
            txtMessage.Enabled = chkDisplayMessage.Checked;   
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDefaults();
        }

        private void SaveDefaults()
        {
            Settings settings = new Settings()
            {
                Message = txtMessage.Text,
                ShowMessage = chkDisplayMessage.Checked,
                OutputFile = txtFile.Text,
                TimeSpanFormat = txtFormat.Text
            };

            settings.Save();
        }
    }
}
