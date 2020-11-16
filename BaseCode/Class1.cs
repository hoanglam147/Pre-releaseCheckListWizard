using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCode
{
    public class Class1
    {
    }
    public class CODE1DString
    {
        public string[] ar_1D_Codes =
        {    "PDF417", "MICROPDF","CODE128","GS1-128","CODE39",
            "INT2OF5","PHARMA","MSI","PLESSEY","STD2OF5","MTX2OF5","CODABAR",
            "GS1 DATABAR EXPANDED","GS1 DATABAR EXPANDED STACKED","GS1 DATABAR LIMITED",
            "GS1 DATABAR","GS1 DATABAR STACKED","CODE93","EAN13","EAN8","UPCA","UPCE"
        };
        public uint length = 22;
    }
    public class CODE2DString
    {
        public string[] ar_2D_Codes =
        {
            "DMECC200", "QR", "MICROQR", "AZTEC", "MAXICODE", "DOTCODE"
        };
        public uint length = 6;
    }
    public class CODEPostalString
    {
        public string[] ar_Postal_Codes =
        {
            "Australia Post", "Royal Mail 45 State",
            "KIX Code", "Japan Post", "PLANET", "POSTNET", "Intelligent Mail", "Swedish Postal", "Finnish Post",
        };        
        public uint length = 9;
    }
    public class DeviceType
    {
    }
}
