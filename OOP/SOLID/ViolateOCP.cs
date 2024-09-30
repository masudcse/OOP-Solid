using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class ViolateOCP
    {
        public string GetPrinterName(string printerName)
        {
            if (printerName == "HP")
            {
                return $"{printerName} Printer Origin from America";
            }
            else if(printerName == "Dell")
            {
                return $"{printerName} Printer Origin from America";
            }
            else
                return $"{printerName} Printer Origin Others";
        }
    }
}
