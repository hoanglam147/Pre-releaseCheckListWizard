using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BaseCode
{
    public class Class1
    {
        public List<string[]> ReturnResultComboBoxs(string model)
        {
            int i = 0;
            var From = new List<string>();
            string[] CountRow = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "ComboBoxDescription.csv");
            List<string[]> a = new List<string[]>();
            int temp = 0;
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
                        b = b.Where(w => w != "").ToArray();
                        a.Add(b);
                        temp = temp + 1;
                    }
                    break;
                }
            }
            return a;

        }
    }

}
