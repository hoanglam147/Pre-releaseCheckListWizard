using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseApplication
{
    public partial class PopUpInfoForm : Form
    {
        public PopUpInfoForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string folder = AppDomain.CurrentDomain.BaseDirectory;
            string pythonExeFile = folder + "Python37\\python.exe";
            string pythonScript = folder + "Script_Tool-_JAZZ\\testSElenium\\Add_lib.py";
            string buildRecord = textBoxbuildRecord.Text;
            buildRecord = buildRecord.Replace(' ', '_');
            string argv = textBoxUsername.Text + " " + textBoxPassword.Text + " " + textBoxtestPlan.Text + " " + buildRecord;
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = pythonExeFile;
            //start.Arguments = string.Format("{0} {1}", @"E:\WORK\IVS.Matrix.300\project\study\Training\JazzTool2\Script_Tool-_JAZZ\testSElenium\Add_lib.py", argv);
            start.Arguments = pythonScript + " " + argv;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            Process.Start(start);
            
            this.Close();
        }

        private void PopUpInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
