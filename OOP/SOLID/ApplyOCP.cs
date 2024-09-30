using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IPrinterOrigin
    {
        string GetPrinterName(string printerName);
    }

    public class GetPrinterHP : IPrinterOrigin
    {
        public string GetPrinterName(string printerName)
        {
            return $"{printerName} Printer Origin from America";
        }
    }

    public class GetPrinterDell : IPrinterOrigin
    {
        public string GetPrinterName(string printerName)
        {
            return $"{printerName} Printer Origin from America";
        }
    }

    public class GetPrinterAcer : IPrinterOrigin
    {
        public string GetPrinterName(string printerName)
        {
            return $"{printerName} Printer Origin from Taiwan";
        }
    }
    public class GetPrinterLenovo : IPrinterOrigin
    {
        public string GetPrinterName(string printerName)
        {
            return $"{printerName} Printer Origin from China";
        }
    }


}
