using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IPrinter
    {
        void canPrint(string document);
        void canScan(string document);
        void canFax(string document);
    }

    public class MultifunctionPrinter() : IPrinter
    {
        public void canFax(string document)
        {
            Console.WriteLine($"Can Fax{document}");
        }

        public void canPrint(string document)
        {
            Console.WriteLine($"Can Print{document}");
        }

        public void canScan(string document)
        {
            Console.WriteLine($"Can Scan{document}");
        }
    }

    public class SimplePrinter : IPrinter
    {
        public void canFax(string document)
        {
            Console.WriteLine($"Can Fax{document}");
        }

        public void canPrint(string document)
        {
            Console.WriteLine($"Can Print{document}");
        }

        public void canScan(string document)
        {
            Console.WriteLine($"Can Scan{document}");
        }
    }
}
