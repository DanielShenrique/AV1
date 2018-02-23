using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage mago = new Mage("Utvior");
            Mage maga = new Mage("Uyyna");

            Monk monk = new Monk("Opaug");
            Monk monka = new Monk("Afuiogood");

            Console.WriteLine(mago.Name);
            Console.WriteLine(maga.Name);
            Console.WriteLine(monk.Name);
            Console.WriteLine(monka.Name);

            mago.Name = "OMagoéImplacavel";
            maga.Name = "Pyuzyn";

            monk.Name = "Cravenia";
            monka.Name = "Ziubykanoitmaretyuzigapoqwexadebiuxazesasada";


            Console.WriteLine(mago.Name);
            Console.WriteLine(maga.Name);

            Console.WriteLine(monk.Name);
            Console.WriteLine(monka.Name);

        }
    }
}
