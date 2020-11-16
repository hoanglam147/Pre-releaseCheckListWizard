using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BaseCode;
namespace BaseApplication
{
    public partial class FormBaseApp : Form
    {
        private int width__ComboBoxMatrixType = 0;
        private int width__ComboBoxCurrentFW = 0;
        private int width__ComboBoxUpgradeFrom = 0;
        private int width__ComboBoxUpgradeTo = 0;
        private int width__ComboBoxCode1 = 0;
        private int width__ComboBoxCode2 = 0;
        private int width__ComboBoxModes = 0;
        private int width__ComboBoxAnalysis = 0;
        private int width__ComboBoxLogicOperator = 0;
        private int width__ComboBoxFieldbus = 0;
        private int width__ComboBoxImageSaving = 0;
        private int width__ComboBoxDiagnostics = 0;
        private int width_groupBoxContains = 0;
        private int width_FormBaseAppActiveForm = 477;
        public FormBaseApp()
        {
            InitializeComponent();
            InitComboAllComboBoxItem();
            
        }
        
        private void groupBoxContains_Enter(object sender, EventArgs e)
        {

        }
        private void InitComboAllComboBoxItem()
        {
            ComboBox[] allCbx = ClearAllComboBox();
            string[] lines = File.ReadAllLines(@"C:\Users\lhoang\source\repos\Pre-releaseCheckListWizard\BaseApplication\ConfiugreAllComboBox.ini");
            bool tagToContinue = false;
            for (int i = 0; i < allCbx.Length; i++)
            {
                tagToContinue = false;
                foreach (string line in lines)
                {
                    if (line.Contains("Begin") && line.Contains(allCbx[i].Name))
                    {
                        tagToContinue = false;
                        continue;                        
                    }
                    else if(line.Contains("Begin") && !line.Contains(allCbx[i].Name))
                    {
                        tagToContinue = true;
                        continue;
                    }
                    else if(tagToContinue)
                    {
                        continue;
                    }
                    else if(line.Contains("End") && line.Contains(allCbx[i].Name))
                    {
                        break;
                    }

                    allCbx[i].Items.Add(line);                    
                }
            }            
        }
        private ComboBox[] ClearAllComboBox()
        {
            // here saved the width of all combo box user for laters
            width__ComboBoxMatrixType = comboBoxMatrixType.Width;
            width__ComboBoxCurrentFW = comboBoxCurrentFW.Width;
            width__ComboBoxUpgradeFrom = comboBoxUpgradeFrom.Width;
            width__ComboBoxUpgradeTo = comboBoxUpgradeTo.Width;
            width__ComboBoxCode1 = comboBoxCode1.Width;
            width__ComboBoxCode2 = comboBoxCode2.Width;
            width__ComboBoxModes = comboBoxModes.Width;
            width__ComboBoxAnalysis = comboBoxAnalysis.Width;
            width__ComboBoxLogicOperator = comboBoxLogicOperator.Width;
            width__ComboBoxFieldbus = comboBoxFieldbus.Width;
            width__ComboBoxImageSaving = comboBoxImageSaving.Width;
            width__ComboBoxDiagnostics = comboBoxDiagnostics.Width;
            width_groupBoxContains = groupBoxContains.Width; // add one line  here save width of group box
            
            // clear all combo box
            comboBoxMatrixType.Items.Clear();
            comboBoxCurrentFW.Items.Clear();
            comboBoxUpgradeFrom.Items.Clear();
            comboBoxUpgradeTo.Items.Clear();
            comboBoxCode1.Items.Clear();
            comboBoxCode2.Items.Clear();
            comboBoxModes.Items.Clear();
            comboBoxAnalysis.Items.Clear();
            comboBoxLogicOperator.Items.Clear();
            comboBoxFieldbus.Items.Clear();
            comboBoxImageSaving.Items.Clear();
            comboBoxDiagnostics.Items.Clear();
            ComboBox[] allCbx =
                {
                comboBoxMatrixType , comboBoxCurrentFW, comboBoxUpgradeFrom,
                comboBoxUpgradeTo , comboBoxCode1 , comboBoxCode2, comboBoxModes,
                comboBoxAnalysis, comboBoxLogicOperator, comboBoxImageSaving,
                comboBoxFieldbus, comboBoxDiagnostics
                };
            return allCbx;
            
            
        }
        private const double gain = 1.2;
        private int t_width__ComboBoxCode1 = 0;
        private int t_width__ComboBoxCode2 = 0;
        private void OnComboBoxSelectedChange(object sender, EventArgs e)
        {
            int a = groupBoxContains.Width;
            int b = FormBaseApp.ActiveForm.Width;
            t_width__ComboBoxCode1 = comboBoxCode1.Width;
            t_width__ComboBoxCode2 = comboBoxCode2.Width;
            

            Size textSize = new Size();
            if(comboBoxCode1.Text != "")
            {
                textSize = TextRenderer.MeasureText(comboBoxCode1.Text, comboBoxCode1.Font);
                if(comboBoxCode1.Text.Length > 10)
                {
                    comboBoxCode1.Width = (int)(textSize.Width * gain);
                }
                else if (comboBoxCode1.Text.Length < 5)
                {
                    comboBoxCode1.Width = width__ComboBoxCode1;
                }
                else
                {
                    //comboBoxCode1.Width = (int)(textSize.Width * (gain + 0.4));
                    comboBoxCode1.Width = width__ComboBoxCode1;
                }
            }
            comboBoxCode2.Location = new System.Drawing.Point(comboBoxCode1.Location.X + comboBoxCode1.Width + 31, 31);
            if(comboBoxCode2.Text != "")
            {
                textSize = TextRenderer.MeasureText(comboBoxCode2.Text, comboBoxCode2.Font);
                if (comboBoxCode2.Text.Length > 10)
                {
                    comboBoxCode2.Width = (int)(textSize.Width * gain);
                }
                else if(comboBoxCode2.Text.Length < 4)
                {
                    //comboBoxCode2.Width = (int)(textSize.Width * (gain + 0.8));
                    comboBoxCode2.Width = width__ComboBoxCode2;
                }
                else
                {
                    //comboBoxCode2.Width = (int)(textSize.Width * (gain + 0.4));
                    comboBoxCode2.Width = width__ComboBoxCode2;
                }
            }
            if(comboBoxCode1.Width != width__ComboBoxCode1 || comboBoxCode2.Width != width__ComboBoxCode2)
            {
                groupBoxContains.Width = a + comboBoxCode1.Width + comboBoxCode2.Width - t_width__ComboBoxCode1 - t_width__ComboBoxCode2;
                groupBoxDeviceInfo.Width = groupBoxContains.Width;
                comboBoxModes.Width = width__ComboBoxModes + comboBoxCode1.Width + comboBoxCode2.Width - t_width__ComboBoxCode1 - t_width__ComboBoxCode2;
                FormBaseApp.ActiveForm.Width = b + groupBoxContains.Width - a;
            }
            else
            {
                comboBoxModes.Width = width__ComboBoxModes;
                groupBoxContains.Width = width_groupBoxContains;
                groupBoxDeviceInfo.Width = width_groupBoxContains;
                FormBaseApp.ActiveForm.Width = width_FormBaseAppActiveForm;
            }
        }
    }
}
