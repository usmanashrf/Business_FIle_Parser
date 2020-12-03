using System;
using System.Collections.Generic;
using System.Xml;
using static XmlParserApp.CompanyClasses;

namespace XmlParserApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string filepath = @"C:\Users\Prime Laptop\Desktop\Business_UPDATE_20201117.xml";

            Parser parser = new Parser();
            parser.ParserFile(filepath);

        }
   
    
    
    }
}