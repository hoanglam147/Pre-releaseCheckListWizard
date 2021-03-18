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
using System.Collections;
using System.Diagnostics;
using static System.Windows.Forms.ComboBox;

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
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "ConfiugreAllComboBox.ini");
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
        private void InitComboComboBoxItemSelected ()
        {
            ComboBox[] allCbx =  ClearChannelsFieldbusDiagnosticImageSavingComboBox();
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "ConfiugreAllComboBox.ini");
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
                    else if (line.Contains("Begin") && !line.Contains(allCbx[i].Name))
                    {
                        tagToContinue = true;
                        continue;
                    }
                    else if (tagToContinue)
                    {
                        continue;
                    }
                    else if (line.Contains("End") && line.Contains(allCbx[i].Name))
                    {
                        break;
                    }
                    allCbx[i].Items.Add(line);
                }
            }
        }
        private ComboBox[] ClearChannelsFieldbusDiagnosticImageSavingComboBox()
        {
            // here saved the width of all combo box user for laters
            width__ComboBoxAnalysis = comboBoxAnalysis.Width;
            width__ComboBoxFieldbus = comboBoxFieldbus.Width;
            width__ComboBoxImageSaving = comboBoxImageSaving.Width;
            width__ComboBoxDiagnostics = comboBoxDiagnostics.Width;

            // clear  combo box
            comboBoxChannels.Items.Clear();
            comboBoxFieldbus.Items.Clear();
            comboBoxImageSaving.Items.Clear();
            comboBoxDiagnostics.Items.Clear();
            ComboBox[] allCbx =
                {
                 comboBoxChannels, comboBoxImageSaving,
                comboBoxFieldbus, comboBoxDiagnostics
                };
            return allCbx;


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
            comboBoxChannels.Items.Clear();
            comboBoxFieldbus.Items.Clear();
            comboBoxImageSaving.Items.Clear();
            comboBoxDiagnostics.Items.Clear();
            ComboBox[] allCbx =
                {
                comboBoxMatrixType , comboBoxCurrentFW, comboBoxUpgradeFrom,
                comboBoxUpgradeTo , comboBoxCode1 , comboBoxCode2, comboBoxModes,
                comboBoxAnalysis, comboBoxLogicOperator, comboBoxChannels, comboBoxImageSaving,
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
            comboBoxCode2.Location = new System.Drawing.Point(comboBoxCode1.Location.X + comboBoxCode1.Width + 31, 44);

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
        private Hashtable CreateHashTableNameCBX_CBX()
        {
            Hashtable hash = new Hashtable();
            hash.Add("Matrix type", comboBoxMatrixType);
            hash.Add("Current FW", comboBoxCurrentFW);
            hash.Add("From", comboBoxUpgradeFrom);
            hash.Add("To", comboBoxUpgradeTo);
            hash.Add("Code1", comboBoxCode1);
            hash.Add("Code2", comboBoxCode2);
            hash.Add("Modes", comboBoxModes);
            hash.Add("Analysis", comboBoxAnalysis);
            hash.Add("Logic Operator", comboBoxLogicOperator);
            hash.Add("Channels", comboBoxChannels);
            hash.Add("Fieldbus", comboBoxFieldbus);
            hash.Add("Image Saving", comboBoxImageSaving);
            hash.Add("Diagnostics", comboBoxDiagnostics);
            return hash;
        }
        private void defaultSettingText()
        {
            comboBoxCode1.Text = "DMECC200";
            comboBoxCode2.Text = "None";
            comboBoxModes.Text = "Continuous Mode";
            comboBoxAnalysis.Text = "Code Combination";
            comboBoxLogicOperator.Text = "AND";
            comboBoxChannels.Text = "None";
            comboBoxFieldbus.Text = "None";
            comboBoxImageSaving.Text = "None";
            comboBoxDiagnostics.Text = "None";
            
        }
        private void defaultSettingDisable(bool x)
        {
            comboBoxCode1.Enabled = x;
            comboBoxCode2.Enabled = x;
            comboBoxModes.Enabled = x;
            comboBoxAnalysis.Enabled = x;
            comboBoxLogicOperator.Enabled = x;
            comboBoxChannels.Enabled = x;
            comboBoxFieldbus.Enabled = x;
            comboBoxImageSaving.Enabled = x;
            comboBoxDiagnostics.Enabled = x;
            textBoxDeviceIP.Enabled = x;
        }
        private void comboBoxMatrixType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCurrentFW.Enabled = false;
            if(comboBoxMatrixType.Text.Contains("M120") || comboBoxMatrixType.Text.Contains("M210"))
            {
                radioButtonDefault.Checked = true;
                defaultSettingText();
                defaultSettingDisable(false);
                return;
            }
            else
            {
                radioButtonUserDefined.Checked = true;
                defaultSettingDisable(true);
            }
            Class1 class1 = new Class1();
            ClassAllDataCsv AllItem = new ClassAllDataCsv();
            AllItem = class1.ReturnResultComboBoxs(comboBoxMatrixType.Text);
            Hashtable cbxTable = CreateHashTableNameCBX_CBX();
            string cbxDescription = "";
            string[] ItemsCbx ;
            ComboBox cbx = (ComboBox)cbxTable[cbxDescription];
            //cbx.Items.Clear();

            foreach (ComboBox value in cbxTable.Values)
            {
                var nameCBX= value.Name;
                //cbx = (ComboBox)cbxTable[value];
                if (nameCBX != "comboBoxMatrixType")
                {

                    value.Text = string.Empty;
                }

            }


            for (int i = 1; i < AllItem.NonOriginal.Count; i++)
            {
                cbxDescription = AllItem.NonOriginal[i][0];
                cbx = (ComboBox)cbxTable[cbxDescription];
                cbx.Items.Clear();

                for (int k = 1; k < AllItem.NonOriginal[i].Length; k++)
                {
                    cbx.Items.Add(AllItem.NonOriginal[i][k]);
                    //if (cbx.Name != "comboBoxMatrixType")
                    //{

                    //    cbx.Text = string.Empty;
                    //}


                }

            }
            //Duyadd
            string device = comboBoxMatrixType.Text;
            string devicetype = device.Substring(1,3);
            int deviceint = Int16.Parse(devicetype);
            
            if (deviceint < 300)
            {   
                if(comboBoxModes.Items.Contains("PackTrack"))
                {
                    comboBoxModes.Items.Remove("PackTrack");
                }
                else
                {
                    //Do nothing
                }
                
            }
            else
            {
                if (comboBoxModes.Items.Contains("PackTrack"))
                {
                    //comboBoxModes.Items.Insert(4, "PackTrack");
                }
                else
                {
                    comboBoxModes.Items.Insert(4, "PackTrack");

                }
            }



        }

        private void comboBoxMatrixType_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            string fileName = comboBoxMatrixType.Text;
            fileName = fileName.Replace(' ', '_');
            StreamWriter streamWriter = new StreamWriter(fileName + ".testCfg");
            streamWriter.WriteLine("Device Model:" + comboBoxMatrixType.Text);
            streamWriter.WriteLine("Current:" + comboBoxCurrentFW.Text);
            streamWriter.WriteLine("Upgrade from:" + comboBoxUpgradeFrom.Text);
            streamWriter.WriteLine("Upgrade to:" + comboBoxUpgradeTo.Text);
            streamWriter.WriteLine("***************Configuration contains****************");
            if(radioButtonDefault.Checked)
            {
                streamWriter.WriteLine("DefaultConfiguration");
            }
            
            streamWriter.WriteLine("Code 1:" + comboBoxCode1.Text);
            streamWriter.WriteLine("Code 2:" + comboBoxCode2.Text);
            streamWriter.WriteLine("Mode:" + comboBoxModes.Text);
            streamWriter.WriteLine("Analysis:" + comboBoxAnalysis.Text);
            streamWriter.WriteLine("Logic Operator:" + comboBoxLogicOperator.Text);
            streamWriter.WriteLine("Reader Channel:" + comboBoxChannels.Text);
            streamWriter.WriteLine("Fieldbus Type:" + comboBoxFieldbus.Text);
            streamWriter.WriteLine("Image Saving:" + comboBoxImageSaving.Text);
            streamWriter.WriteLine("Remote IP:" + textBoxDeviceIP.Text);
            streamWriter.WriteLine("Diagnostics:" + comboBoxDiagnostics.Text);
            streamWriter.Close();
        }
        public static string  argv = "";
        private void buttonGo_Click(object sender, EventArgs e)
        {
            if(buttonGo.Text == "Done")
            {
                buttonGo.Text = "GO!";                
            }
            else if(buttonGo.Text == "GO!")
            {
                var formRun = new PopUpInfoForm();
                formRun.Show();
            }            
        }

        private void comboBoxModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void comboBoxChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBoxCurrentFW_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxUpgradeFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioButtonDefault.Checked)
            {
                defaultSettingText();
                defaultSettingDisable(false);
                return;
            }
            Hashtable cbxTable = CreateHashTableNameCBX_CBX();

            //ComboBox value;
            foreach (ComboBox value in cbxTable.Values)
            {
                //var nameCBX = value.Name;
                //cbx = (ComboBox)cbxTable[value];
                if (value.Name != "comboBoxMatrixType"&&
                    value.Name != "comboBoxUpgradeTo" &&
                    value.Name != "comboBoxCurrentFW"&&
                    value.Name != "comboBoxUpgradeFrom")
                {

                    //value.Text = string.Empty;
                    value.ResetText();
                }
            }
            //// Condition For Combobox Mode BEGING
            string fromValue = comboBoxUpgradeFrom.Text;
            //var jhggk = fromValue.Substring(2, 1);
            int numberValueFrom = Int16.Parse(fromValue.Substring(2, 1));
            if(numberValueFrom< 5)
            {
                if (comboBoxModes.Items.Contains("Presentation Mode"))
                {
                    comboBoxModes.Items.Remove("Presentation Mode");
                }
                else
                {
                    //Do nothing
                }

            }
            else
            {
                if (comboBoxModes.Items.Contains("Presentation Mode"))
                {
                    //comboBoxModes.Items.Insert(4, "PackTrack");
                }
                else
                {
                    comboBoxModes.Items.Insert(5, "Presentation Mode");

                }
            }


            ///Condition For Combobox Mode  END
            Class1 class1 = new Class1();
            ClassAllDataCsv AllItem = class1.ReturnResultComboBoxs(comboBoxMatrixType.Text);
            string cbxDescription = "";
            ComboBox cbx = (ComboBox)cbxTable[cbxDescription];
            //cbx.Items.Clear();


            for (int i = 1; i < AllItem.Original.Count; i++)
            {
                cbxDescription = AllItem.Original[i][0];
                cbx = (ComboBox)cbxTable[cbxDescription];
                if (cbx.Name != "comboBoxUpgradeFrom")
                {
                    //cbx.ResetText();
                    cbx.Items.Clear();
                }
                for (int k = 1; k < AllItem.Original[i].Length; k++)
                {
                    if (cbx.Name != "comboBoxUpgradeFrom")
                    {
                        cbx.Items.Add(AllItem.Original[i][k]);
                    }

                }

            }



            //////////////////////////////////////
            string ValueChannels = "";
            string VersionFWChannels = "";
            ArrayList FW = new ArrayList();
            char expecialWordsOpen = '[';
            char expecialWordsClose = ']';
            string FWString;
            string ComboboxItemsAll;
            int countFW=0;
            Boolean CheckAllFW = false;
            ComboBox[] ForCBXchange = new ComboBox[4] ;
            ForCBXchange[0]= comboBoxChannels;
            ForCBXchange[1]= comboBoxFieldbus;
            ForCBXchange[2]= comboBoxImageSaving;
            ForCBXchange[3]= comboBoxDiagnostics;
            string FromToFW = comboBoxUpgradeFrom.Text;
            int q = 0;
            for (q = 0; q < ForCBXchange.Length; q++)
            {

                FromToFW = comboBoxUpgradeFrom.Text;
                string[] comboBoxChannelsItems = new string[ForCBXchange[q].Items.Count];
                for (int k = 0; k < ForCBXchange[q].Items.Count; k++)
                {
                    comboBoxChannelsItems[k] = ForCBXchange[q].Items[k].ToString();
                }
                ForCBXchange[q].Items.Clear();
                for (int k = 0; k < comboBoxChannelsItems.Length; k++)
                {
                    ValueChannels = "";
                    ComboboxItemsAll = comboBoxChannelsItems[k].ToString();
                    for (int i = 0; i < ComboboxItemsAll.Length; i++)
                    {
                        if (ComboboxItemsAll.Contains(expecialWordsOpen))
                        {
                            CheckAllFW = false;
                        }
                        else
                        {
                            CheckAllFW = true;
                        }
                        if (ComboboxItemsAll[i] == expecialWordsOpen)
                        {
                            i++;
                            while (ComboboxItemsAll[i] != expecialWordsClose)
                            {
                                if (ComboboxItemsAll[i] == '/')
                                {
                                    FW.Add(VersionFWChannels);
                                    VersionFWChannels = "";
                                    i++;
                                }
                                else
                                {
                                    VersionFWChannels = VersionFWChannels + ComboboxItemsAll[i];
                                    i++;
                                }
                            }
                            FW.Add(VersionFWChannels);
                            VersionFWChannels = "";
                            break;
                        }
                        ValueChannels = ValueChannels + ComboboxItemsAll[i];
                    }
                    if (CheckAllFW == true)
                    {

                        if (ForCBXchange[q].Name == "comboBoxChannels")
                        {
                            comboBoxChannels.Items.Add(ValueChannels);
                        }
                        else if (ForCBXchange[q].Name == "comboBoxFieldbus")
                        {
                            comboBoxFieldbus.Items.Add(ValueChannels);
                        }
                        else if (ForCBXchange[q].Name == "comboBoxImageSaving")
                        {
                            comboBoxImageSaving.Items.Add(ValueChannels);
                        }
                        else
                        {
                            comboBoxDiagnostics.Items.Add(ValueChannels);
                        }

                    }
                    else
                    {
                        while (countFW < FW.Count)
                        {
                            FWString = FW[countFW].ToString();
                            if (FWString == FromToFW)
                            {
                                if (ForCBXchange[q].Name == "comboBoxChannels")
                                {
                                    comboBoxChannels.Items.Add(ValueChannels);
                                }
                                else if (ForCBXchange[q].Name == "comboBoxFieldbus")
                                {
                                    comboBoxFieldbus.Items.Add(ValueChannels);
                                }
                                else if (ForCBXchange[q].Name == "comboBoxImageSaving")
                                {
                                    comboBoxImageSaving.Items.Add(ValueChannels);
                                }
                                else
                                {
                                    comboBoxDiagnostics.Items.Add(ValueChannels);
                                }
                            }
                            countFW++;
                        }
                    }
                }
            }

        }

        private void comboBoxAnalysis_SelectedIndexChanged(object sender, EventArgs e)
        {
           string valueAnalysis =  comboBoxAnalysis.Text;
            if(valueAnalysis== "Code Collection" || valueAnalysis == "Code Presentation")
            {
                comboBoxLogicOperator.Enabled = false;
            }
            else
            {
                comboBoxLogicOperator.Enabled = true;
            }
            
            
        }

        private void comboBoxAnalysis_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string valueAnalysis = comboBoxAnalysis.Text;
            if (valueAnalysis == "Code Collection" ||
                valueAnalysis == "Code Presentation"||
                valueAnalysis == "None")
            {
                comboBoxLogicOperator.Text = string.Empty;
                comboBoxLogicOperator.Enabled = false;
            }
            else
            {
                comboBoxLogicOperator.Text = string.Empty;
                comboBoxLogicOperator.Enabled = true;
            }
        }

        private void comboBoxImageSaving_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormBaseApp_Load(object sender, EventArgs e)
        {

        }



        private void radioButtonDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDefault.Checked)
            {
                defaultSettingText();
            }
            defaultSettingDisable(!radioButtonDefault.Checked);
        }

        private void radioButtonUserDefined_CheckedChanged(object sender, EventArgs e)
        {
            defaultSettingDisable(!radioButtonDefault.Checked);
        }
    }
}
