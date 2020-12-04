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

            //string BusinessFilePath = @"C:\Users\Prime Laptop\Desktop\Business_UPDATE_20201117.xml";
            string IndividualFilePath = @"C:\Users\Prime Laptop\Desktop\PEPsDailyFeeds\Individual_UPDATE_20201117.xml";


            BusinessParser businessParser = new BusinessParser();
            // businessParser.BusinessFileParser(BusinessFilePath);
            IndividualParser individualParser = new IndividualParser();
            individualParser.IndividualFileParser(IndividualFilePath);
        }
   
    
    
    }
}