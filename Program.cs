using System;
using System.Collections.Generic;
using System.Xml;


namespace XmlParserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Address address = new Address();
            Alias alias = new Alias();
            Article article = new Article();
            Business_Association business_Association = new Business_Association();
            Individual_Association individual_Association = new Individual_Association();
            Note note = new Note();
            Sanction_Data sanction_Datas = new Sanction_Data();
            Snippet snippets = new Snippet();


            using (XmlReader reader = XmlReader.Create(@"C:\Users\Prime Laptop\Desktop\PEPsDailyFeeds\Business_UPDATE_20201117.xml"))


            while (reader.Read())
                {
                   
                        reader.ReadToFollowing("Company");
                        do
                        {
                            reader.MoveToFirstAttribute();
                            //Console.WriteLine($"genre: {reader.Value}");

                            reader.ReadToFollowing("UniqueID");
                            //Console.WriteLine($"UniqueID: {reader.ReadElementContentAsString()}");
                            company.UniqueID = reader.ReadElementContentAsString();

                            reader.ReadToFollowing("Business_Name");
                            //Console.WriteLine($"Business_Name: {reader.ReadElementContentAsString()}");
                            company.Business_Name = reader.ReadElementContentAsString();

                            reader.ReadToFollowing("Description");
                            // Console.WriteLine($"Description: {reader.ReadElementContentAsString()}");
                            company.Description = reader.ReadElementContentAsString();

                        reader.ReadToFollowing("Addresses");
                        do
                        {
                            reader.ReadToFollowing("Address");
                            do
                            {
                                reader.MoveToFirstAttribute();

                                reader.ReadToFollowing("Address_Line_1");
                                //Console.WriteLine($"Address_Line_1: {reader.ReadElementContentAsString()}");
                                address.Address_Line_1 = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Address_Line_2");
                                //Console.WriteLine($"Address_Line_2: {reader.ReadElementContentAsString()}");
                                address.Address_Line_2 = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Address_Line_3");
                                // Console.WriteLine($"Address_Line_3: {reader.ReadElementContentAsString()}");
                                address.Address_Line_3 = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Address_Line_4");
                                address.Address_Line_4 = reader.ReadElementContentAsString();
                                //Console.WriteLine($"Address_Line_4: {reader.ReadElementContentAsString()}");

                                reader.ReadToFollowing("Town_City");
                                address.Town_City = reader.ReadElementContentAsString();
                                //Console.WriteLine($"Town_City: {reader.ReadElementContentAsString()}");

                                reader.ReadToFollowing("County_State");
                                address.County_State = reader.ReadElementContentAsString();
                                //Console.WriteLine($"County_State: {reader.ReadElementContentAsString()}");

                                reader.ReadToFollowing("Post_Zip_Code");
                                address.Post_Zip_Code = reader.ReadElementContentAsString();
                                //Console.WriteLine($"Post_Zip_Code: {reader.ReadElementContentAsString()}");

                                reader.ReadToFollowing("Country");
                                address.Country = reader.ReadElementContentAsString();
                                //Console.WriteLine($"Country: {reader.ReadElementContentAsString()}");

                                reader.ReadToFollowing("Soft_Delete");
                                address.Soft_Delete = reader.ReadElementContentAsString();
                                //Console.WriteLine($"Soft_Delete: {reader.ReadElementContentAsString()}");

                            }
                            while (reader.ReadToFollowing("Address"));
                        }
                        while (reader.ReadToFollowing("Addresses"));


                        reader.ReadToFollowing("Aliases");
                        do
                        {
                            reader.ReadToFollowing("Alias");
                            do
                            {
                                reader.ReadToFollowing("AliasID");
                                alias.AliasID = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Business_Name");
                                alias.Business_Name = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Soft_Delete");
                                alias.Soft_Delete = reader.ReadElementContentAsString();


                            }
                            while (reader.ReadToFollowing("Alias"));

                        }
                        while (reader.ReadToFollowing("Aliases"));

                        reader.ReadToFollowing("Individual_Associations");
                        do
                        {
                            reader.ReadToFollowing("Individual_Association");
                            do
                            {
                                reader.ReadToFollowing("Individual_ID");
                                individual_Association.Individual_ID = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Position");
                                individual_Association.Position = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Soft_Delete");
                                individual_Association.Soft_Delete = reader.ReadElementContentAsString();

                            }
                            while (reader.ReadToFollowing("Individual_Association"));
                        }
                        while (reader.ReadToFollowing("Individual_Associations"));


                        reader.ReadToFollowing("Busniess_Associations");
                        do
                        {
                            reader.ReadToFollowing("Busniess_Association");
                            do
                            {
                                reader.ReadToFollowing("Business_ID_2");
                                business_Association.Business_ID_2 = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Link_Description");
                                business_Association.Link_Description = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Soft_Delete");
                                business_Association.Soft_Delete = reader.ReadElementContentAsString();

                            }
                            while (reader.ReadToFollowing("Busniess_Association"));
                        }

                        while (reader.ReadToFollowing("Busniess_Associations"));

                        reader.ReadToFollowing("Articles");
                        do
                        {
                            reader.ReadToFollowing("Article");
                            do
                            {
                                reader.ReadToFollowing("Original_URL");
                                article.Original_URL= reader.ReadElementContentAsString();

                                reader.ReadToFollowing("C6_URL");
                                article.C6_URL = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("File_Name");
                                article.File_Name = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Source");
                                article.Source= reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Snippets");
                                do
                                {
                                    reader.ReadToFollowing("Snippet");
                                    do
                                    {
                                        reader.ReadToFollowing("Title");
                                        snippets.Title = reader.ReadElementContentAsString();

                                        reader.ReadToFollowing("SnippetText");
                                        snippets.SnippetText = reader.ReadElementContentAsString();

                                        reader.ReadToFollowing("Adverse_Terms");
                                        snippets.Adverse_Terms = reader.ReadElementContentAsString();
                                    }
                                    while (reader.ReadToFollowing("Snippet"));
                                }
                                while (reader.ReadToFollowing("Snippets"));

                                reader.ReadToFollowing("Date_of_Capture");
                                article.Date_of_Capture = reader.ReadElementContentAsString();

                            }
                            while (reader.ReadToFollowing("Article"));

                        }
                        while (reader.ReadToFollowing("Articles"));


                        reader.ReadToFollowing("Notes");
                        do
                        {
                            reader.ReadToFollowing("Note");
                            do
                            {
                                reader.ReadToFollowing("Source_of_Notes");
                                note.Source_of_Notes = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Notes");
                                note.Notes = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Soft_Delete");
                                note.Soft_Delete = reader.ReadElementContentAsString();

                            }
                            while (reader.ReadToFollowing("Note"));

                        }
                        while (reader.ReadToFollowing("Notes"));

                        reader.ReadToFollowing("Sanctions_Data");
                        do
                        {
                            reader.ReadToFollowing("Sanction");
                            do
                            {
                                reader.ReadToFollowing("Sanction_Body");
                                sanction_Datas.Sanction_Body = reader.ReadElementContentAsString();

                                reader.ReadToFollowing("Sanction_Is_Current");
                                sanction_Datas.Sanction_Is_Current = reader.ReadElementContentAsString();

                            }
                            while (reader.ReadToFollowing("Sanction"));
                        }
                        while (reader.ReadToFollowing("Sanctions_Data"));


                    } while (reader.ReadToFollowing("Company"));
                    
                    

                        
                    
                   
                }
        }
    }
}
