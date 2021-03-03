using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace BaseCode
{
    public class ClassAllDataCsv
    {
        public List<string[]> Original = new List<string[]>();
        public List<string[]> NonOriginal = new List<string[]>();

    }

    public class Class1
    {
        public ClassAllDataCsv ReturnResultComboBoxs(string model)
        {
            int i = 0;
            var From = new List<string>();
            string[] CountRow = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "ComboBoxDescription.csv");

            ClassAllDataCsv AllDataCsv = new ClassAllDataCsv();
            

            int temp = 0;
            //ArrayList a = new ArrayList();
            string tempvalue = "";
            for (i = 0; i < CountRow.Length; i++)
            {
                if (CountRow[i].Contains(model))
                {
                    temp = i;
                    while (true)
                    {
                        if (CountRow[temp].Contains("END"))
                        {
                            break;
                        }
                        string[] b = CountRow[temp].Split(',');
                        string[] b1 = b.Where(w => w != "").ToArray();
                        string[] b2 = b.Where(w => w != "").ToArray();
                        
                        for (int m = 0; m < b2.Length; m++)
                        {
                            if (b2[m].Contains("["))
                            {
                                string s = b2[m].ToString();
                                for (int n = 0; n < s.Length; n++)
                                {
                                    if (s[n] == '[')
                                    {
                                        break;
                                    }
                                    tempvalue = tempvalue + s[n];
                                }
                                b2[m] = tempvalue;
                                tempvalue = "";
                            }

                        }
                        AllDataCsv.Original.Add(b1);
                        AllDataCsv.NonOriginal .Add(b2);

                        temp = temp + 1;
                    }
                    break;
                }
            }

            return AllDataCsv;

        }
    }
    //public class Class2
    //{
    //    public List<string[]> ReturnValue(string comboBoxMatrixType, string cbxDescription)
    //    {
    //        Class1 class1 = new Class1();
    //        List<string[]> AllItem = class1.ReturnResultComboBoxs(comboBoxMatrixType);
    //        string cbxDescription = "";
    //        Hashtable cbxTable = Hashtable.CreateHashTableNameCBX_CBX();
    //        for (int i = 1; i < AllItem.Count; i++)
    //        {
    //            if (cbxDescription == "Channels")
    //            {
    //                for (int k = 1; k < AllItem[i].Length; k++)
    //                {
    //                    cbx.Items.Add(AllItem[i][k]);
    //                }
    //                for (int k = 0; k < cbx.Items.Count; k++)
    //                {
    //                    var valueX = cbx.Items[k];
    //                    //valueX = valueX.Value;
    //                }
    //                var channelValueObj = cbx.Items[1];
    //                string channelValue = channelValueObj.ToString();
    //                var value = "";
    //                for (i = 0; i < channelValue.Length; i++)
    //                {
    //                    varvalue = channelValue[i];
    //                    if (value != "[")
    //                    {

    //                    }
    //                }

    //                cbx.Items.GetHashCode();

    //            }
    //        }







    //        if (cbxDescription == "Channels")
    //        {
    //            for (int k = 1; k < AllItem[i].Length; k++)
    //            {
    //                cbx.Items.Add(AllItem[i][k]);
    //            }
    //            for (int k = 0; k < cbx.Items.Count; k++)
    //            {
    //                var valueX = cbx.Items[k];
    //                //valueX = valueX.Value;
    //            }
    //            var channelValueObj = cbx.Items[1];
    //            string channelValue = channelValueObj.ToString();
    //            string value = "";
    //            for (i = 0; i < channelValue.Length; i++)
    //            {
    //                value = channelValue[i];
    //                if (value != "[")
    //                {

    //                }
    //            }

    //            cbx.Items.GetHashCode();

    //        }
    //    }
    //}


}
