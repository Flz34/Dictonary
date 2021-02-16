using System;
using System.Collections.Generic;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictonary<int, string> plakalarveSehirler = new Dictonary<int, string>();

            plakalarveSehirler.Add(25, "Erzurum");
            plakalarveSehirler.Add(34, "İstanbul");
            plakalarveSehirler.Add(06, "Ankara");
            plakalarveSehirler.Add(02, "Adıyaman");
            plakalarveSehirler.Add(01, "Adana");
            plakalarveSehirler.Add(23, "Elazığ");
           
            Console.WriteLine(plakalarveSehirler.Count);
        }
    }
}
