using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace SemWebDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the OWL file

            XDocument doc = XDocument.Load("D:\\college work\\SEM-IV\\VBNETProject\\SemWebDemo\\SemWebDemo\\myonto.owl");

            // Display all the children and descendants element of the XML root

            foreach (var element in doc.Root.Descendants())
            {

                Console.WriteLine("{0}:     {1}", element.Name, element.Value);

            }
            Console.ReadLine();
        }
    }
}
