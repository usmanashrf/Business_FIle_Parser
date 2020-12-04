using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XmlParserApp
{
    class IndividualParser
    {
        public void IndividualFileParser(string FilePath)
        {
            IndividualsIndividual individual = new IndividualsIndividual(); 
            IndividualsIndividual individualsIndividual = new IndividualsIndividual();
            IndividualsIndividualAddress address = new IndividualsIndividualAddress();
            IndividualsIndividualAlias alias = new IndividualsIndividualAlias();
            IndividualsIndividualIndividual_Association individual_Association = new IndividualsIndividualIndividual_Association();
            IndividualsIndividualBusiness_Association business_Association = new IndividualsIndividualBusiness_Association();
            IndividualsIndividualArticle article = new IndividualsIndividualArticle();
            IndividualsIndividualArticleSnippets snippets = new IndividualsIndividualArticleSnippets();
            IndividualsIndividualArticleSnippetsSnippet snippet = new IndividualsIndividualArticleSnippetsSnippet();
            IndividualsIndividualNote note = new IndividualsIndividualNote();
            IndividualsIndividualPolitical_Position political_Position = new IndividualsIndividualPolitical_Position();
            IndividualsIndividualSanction sanction = new IndividualsIndividualSanction();

            using (XmlReader reader = XmlReader.Create(FilePath))
            {

                int count = 0;
                while (!reader.EOF)
                {
                    if (reader.ReadToFollowing("Individuals"))
                    {
                        if (reader.ReadToFollowing("Individual"))
                        {
                            if (reader.ReadToFollowing("UniqueID"))
                            {
                                reader.Read();
                                individual.UniqueID = reader.Value;
                                Console.WriteLine(individual.UniqueID);
                            }
                            if (reader.ReadToFollowing("Title"))
                            {
                                reader.Read();
                                individual.Title = reader.Value;
                                Console.WriteLine(individual.Title);
                            }
                            if (reader.ReadToFollowing("Alternate_Title"))
                            {
                                reader.Read();
                                individual.Alternate_Title = reader.Value;
                                Console.WriteLine(individual.Alternate_Title);
                            }
                            if (reader.ReadToFollowing("Forename"))
                            {
                                reader.Read();
                                individual.Forename = reader.Value;
                                Console.WriteLine(individual.Forename);
                            }
                            if (reader.ReadToFollowing("Middlename"))
                            {
                                reader.Read();
                                individual.Middlename = reader.Value;
                                Console.WriteLine(individual.Middlename);
                            }
                            if (reader.ReadToFollowing("Surname"))
                            {
                                reader.Read();
                                individual.Surname = reader.Value;
                                Console.WriteLine(individual.Surname);
                            }
                            if (reader.ReadToFollowing("Date_of_Birth"))
                            {
                                reader.Read();
                                individual.Date_of_Birth = reader.Value;
                                Console.WriteLine(individual.Date_of_Birth);
                            }
                            if (reader.ReadToFollowing("Date_of_Death"))
                            {
                                reader.Read();
                                individual.Date_of_Death = reader.Value;
                                Console.WriteLine(individual.Date_of_Death);
                            }
                            if (reader.ReadToFollowing("Year_of_Birth"))
                            {
                                reader.Read();
                                individual.Year_of_Birth = Convert.ToUInt16(reader.Value);
                                Console.WriteLine(individual.Year_of_Birth);
                            }
                            if (reader.ReadToFollowing("Year_of_Death"))
                            {
                                reader.Read();
                                individual.Year_of_Death = Convert.ToUInt16(reader.Value);
                                Console.WriteLine(individual.Year_of_Death);
                            }
                            if (reader.ReadToFollowing("Gender"))
                            {
                                reader.Read();
                                individual.Gender = reader.Value;
                                Console.WriteLine(individual.Gender);
                            }
                            if (reader.ReadToFollowing("Home_Telephone"))
                            {
                                reader.Read();
                                individual.Home_Telephone = reader.Value;
                                Console.WriteLine(individual.Home_Telephone);
                            }
                            if (reader.ReadToFollowing("Business_Telephone"))
                            {
                                reader.Read();
                                individual.Business_Telephone = reader.Value;
                                Console.WriteLine(individual.Business_Telephone);
                            }
                            if (reader.ReadToFollowing("Mobile_Telephone"))
                            {
                                reader.Read();
                                individual.Mobile_Telephone = reader.Value;
                                Console.WriteLine(individual.Mobile_Telephone);
                            }
                            if (reader.ReadToFollowing("Fax"))
                            {
                                reader.Read();
                                individual.Fax = reader.Value;
                                Console.WriteLine(individual.Fax);
                            }
                            if (reader.ReadToFollowing("Email"))
                            {
                                reader.Read();
                                individual.Email = reader.Value;
                                Console.WriteLine(individual.Email);
                            }
                            if (reader.ReadToFollowing("Nationality"))
                            {
                                reader.Read();
                                individual.Nationality = reader.Value;
                                Console.WriteLine(individual.Nationality);
                            }
                            if (reader.ReadToFollowing("PEP_Tier"))
                            {
                                reader.Read();
                                individual.PEP_Tier = reader.Value;
                                Console.WriteLine(individual.PEP_Tier);
                            }
                            if (reader.ReadToFollowing("Source"))
                            {
                                reader.Read();
                                individual.Source = reader.Value;
                                Console.WriteLine(individual.Source);
                            }
                            if (reader.ReadToFollowing("Date_of_Capture"))
                            {
                                reader.Read();
                                individual.Date_of_Capture = reader.Value;
                                Console.WriteLine(individual.Date_of_Capture);
                            }

                            if (reader.ReadToFollowing("Soft_Delete"))
                            {
                                reader.Read();
                                individual.Soft_Delete = reader.Value;
                                Console.WriteLine(individual.Soft_Delete);
                            }

                            if (reader.ReadToFollowing("Date_of_Soft_Delete"))
                            {
                                reader.Read();
                                individual.Date_of_Soft_Delete = reader.Value;
                                Console.WriteLine(individual.Date_of_Soft_Delete);
                            }
                            if (reader.ReadToFollowing("Category"))
                            {
                                reader.Read();
                                individual.Category = reader.Value;
                                Console.WriteLine(individual.Category);
                            }
                            if (reader.ReadToFollowing("Picture"))
                            {
                                reader.Read();
                                individual.Picture = reader.Value;
                                Console.WriteLine(individual.Picture);
                            }

                            if (reader.ReadToFollowing("Addresses"))
                            {
                                if (reader.ReadToFollowing("Address"))
                                {
                                    if (reader.ReadToFollowing("Address_Line_1"))
                                    {
                                        reader.Read();
                                        address.Address_Line_1 = reader.Value;
                                        Console.WriteLine(address.Address_Line_1);
                                    }
                                    if (reader.ReadToFollowing("Address_Line_2"))
                                    {
                                        reader.Read();
                                        address.Address_Line_2 = reader.Value;
                                        Console.WriteLine(address.Address_Line_2);
                                    }
                                    if (reader.ReadToFollowing("Address_Line_3"))
                                    {
                                        reader.Read();
                                        address.Address_Line_3 = reader.Value;
                                        Console.WriteLine(address.Address_Line_3);
                                    }
                                    if (reader.ReadToFollowing("Address_Line_4"))
                                    {
                                        reader.Read();
                                        address.Address_Line_4 = reader.Value;
                                        Console.WriteLine(address.Address_Line_4);
                                    }
                                    if (reader.ReadToFollowing("Town_City"))
                                    {
                                        reader.Read();
                                        address.Town_City = reader.Value;
                                        Console.WriteLine(address.Town_City);
                                    }
                                    if (reader.ReadToFollowing("County_State"))
                                    {
                                        reader.Read();
                                        address.County_State = reader.Value;
                                        Console.WriteLine(address.County_State);
                                    }
                                    if (reader.ReadToFollowing("Post_Zip_Code"))
                                    {
                                        reader.Read();
                                        address.Post_Zip_Code = reader.Value;
                                        Console.WriteLine(address.Post_Zip_Code);
                                    }
                                    if (reader.ReadToFollowing("Post_Zip_Code"))
                                    {
                                        reader.Read();
                                        address.Post_Zip_Code = reader.Value;
                                        Console.WriteLine(address.Post_Zip_Code);
                                    }
                                    if (reader.ReadToFollowing("Country"))
                                    {
                                        reader.Read();
                                        address.Country = reader.Value;
                                        Console.WriteLine(address.Country);
                                    }
                                    if (reader.ReadToFollowing("ISO_Country"))
                                    {
                                        reader.Read();
                                        address.ISO_Country = reader.Value;
                                        Console.WriteLine(address.ISO_Country);
                                    }
                                    if (reader.ReadToFollowing("Soft_Delete"))
                                    {
                                        reader.Read();
                                        address.Soft_Delete = reader.Value;
                                        Console.WriteLine(address.Soft_Delete);
                                    }
                                }
                            }

                            if (reader.ReadToFollowing("Aliases"))
                            {
                                if (reader.ReadToFollowing("Alias"))
                                {
                                    if (reader.ReadToFollowing("AliasID"))
                                    {
                                        reader.Read();
                                        alias.AliasID = reader.Value;
                                        Console.WriteLine(alias.AliasID);
                                    }
                                    if (reader.ReadToFollowing("Title"))
                                    {
                                        reader.Read();
                                        alias.Title = reader.Value;
                                        Console.WriteLine(alias.Title);
                                    }
                                    if (reader.ReadToFollowing("Alternate_Title"))
                                    {
                                        reader.Read();
                                        alias.Alternate_Title = reader.Value;
                                        Console.WriteLine(alias.Alternate_Title);
                                    }
                                    if (reader.ReadToFollowing("Forename"))
                                    {
                                        reader.Read();
                                        alias.Forename = reader.Value;
                                        Console.WriteLine(alias.Forename);
                                    }
                                    if (reader.ReadToFollowing("Middle_Name"))
                                    {
                                        reader.Read();
                                        alias.Middle_Name = reader.Value;
                                        Console.WriteLine(alias.Middle_Name);
                                    }
                                    if (reader.ReadToFollowing("Surname"))
                                    {
                                        reader.Read();
                                        alias.Surname = reader.Value;
                                        Console.WriteLine(alias.Surname);
                                    }

                                    if (reader.ReadToFollowing("Soft_Delete"))
                                    {
                                        reader.Read();
                                        alias.Soft_Delete = reader.Value;
                                        Console.WriteLine(alias.Soft_Delete);
                                    }
                                }
                            }

                            if (reader.ReadToFollowing("Individual_Associations"))
                            {
                                if (reader.ReadToFollowing("Individual_Association"))
                                {
                                    if (reader.ReadToFollowing("Individual_ID_2"))
                                    {
                                        reader.Read();
                                        individual_Association.Individual_ID_2 = reader.Value;
                                        Console.WriteLine(individual_Association.Individual_ID_2);
                                    }
                                    if (reader.ReadToFollowing("Link_Description"))
                                    {
                                        reader.Read();
                                        individual_Association.Link_Description = reader.Value;
                                        Console.WriteLine(individual_Association.Link_Description);
                                    }
                                    if (reader.ReadToFollowing("Soft_Delete"))
                                    {
                                        reader.Read();
                                        individual_Association.Soft_Delete = reader.Value;
                                        Console.WriteLine(individual_Association.Soft_Delete);
                                    }


                                }
                            }

                            if (reader.ReadToFollowing("Business_Associations"))
                            {
                                if (reader.ReadToFollowing("Business_Association"))
                                {
                                    if (reader.ReadToFollowing("Business_ID"))
                                    {
                                        reader.Read();
                                        business_Association.Business_ID = reader.Value;
                                        Console.WriteLine(business_Association.Business_ID);
                                    }
                                    if (reader.ReadToFollowing("Description"))
                                    {
                                        reader.Read();
                                        business_Association.Description = reader.Value;
                                        Console.WriteLine(business_Association.Description);
                                    }
                                    if (reader.ReadToFollowing("Soft_Delete"))
                                    {
                                        reader.Read();
                                        business_Association.Soft_Delete = reader.Value;
                                        Console.WriteLine(business_Association.Soft_Delete);
                                    }
                                }
                            }

                            if (reader.ReadToFollowing("Articles"))
                            {
                                if (reader.ReadToFollowing("Article"))
                                {
                                    if (reader.ReadToFollowing("Original_URL"))
                                    {
                                        reader.Read();
                                        article.Original_URL = reader.Value;
                                        Console.WriteLine(article.Original_URL);
                                    }
                                    if (reader.ReadToFollowing("C6_URL"))
                                    {
                                        reader.Read();
                                        article.C6_URL = reader.Value;
                                        Console.WriteLine(article.C6_URL);
                                    }
                                    if (reader.ReadToFollowing("File_Name"))
                                    {
                                        reader.Read();
                                        article.File_Name = reader.Value;
                                        Console.WriteLine(article.File_Name);
                                    }
                                    if (reader.ReadToFollowing("Source"))
                                    {
                                        reader.Read();
                                        article.Source = reader.Value;
                                        Console.WriteLine(article.Source);
                                    }
                                    if (reader.ReadToFollowing("Snippets"))
                                    {
                                        if (reader.ReadToFollowing("Snippet"))
                                        {
                                            if (reader.ReadToFollowing("Title"))
                                            {
                                                reader.Read();
                                                snippet.Title = reader.Value;
                                                Console.WriteLine(snippet.Title);
                                            }
                                            if (reader.ReadToFollowing("SnippetText"))
                                            {
                                                reader.Read();
                                                snippet.SnippetText = reader.Value;
                                                Console.WriteLine(snippet.SnippetText);
                                            }
                                            if (reader.ReadToFollowing("Adverse_Terms"))
                                            {
                                                reader.Read();
                                                snippet.Adverse_Terms = reader.Value;
                                                //Console.WriteLine(snippets.Adverse_Terms);
                                            }
                                        }
                                    }

                                    if (reader.ReadToFollowing("Date_of_Capture"))
                                    {
                                        reader.Read();
                                        article.Date_of_Capture = reader.Value;
                                        Console.WriteLine(article.Date_of_Capture);
                                    }


                                }
                            }

                            if (reader.ReadToFollowing("Notes"))
                            {
                                if (reader.ReadToFollowing("Note"))
                                {
                                    if (reader.ReadToFollowing("Source_of_Notes"))
                                    {
                                        reader.Read();
                                        note.Source_of_Notes = reader.Value;
                                        Console.WriteLine(note.Source_of_Notes);
                                    }
                                    if (reader.ReadToFollowing("Notes"))
                                    {
                                        reader.Read();
                                        note.Notes = reader.Value;
                                        Console.WriteLine(note.Notes);
                                    }
                                    if (reader.ReadToFollowing("Soft_Delete"))
                                    {
                                        reader.Read();
                                        note.Soft_Delete = reader.Value;
                                        Console.WriteLine(note.Soft_Delete);
                                    }
                                }
                            }

                            if (reader.ReadToFollowing("Political_Positions"))
                            {
                                if (reader.ReadToFollowing("Political_Position"))
                                {
                                    if (reader.ReadToFollowing("Description"))
                                    {
                                        reader.Read();
                                        political_Position.Description = reader.Value;
                                        Console.WriteLine(political_Position.Description);
                                    }
                                    if (reader.ReadToFollowing("From"))
                                    {
                                        reader.Read();
                                        political_Position.From = reader.Value;
                                        Console.WriteLine(political_Position.From);
                                    }
                                    if (reader.ReadToFollowing("To"))
                                    {
                                        reader.Read();
                                        political_Position.To = reader.Value;
                                        Console.WriteLine(political_Position.To);
                                    }
                                    if (reader.ReadToFollowing("Country"))
                                    {
                                        reader.Read();
                                        political_Position.Country = reader.Value;
                                        Console.WriteLine(political_Position.Country);
                                    }
                                    if (reader.ReadToFollowing("Soft_Delete"))
                                    {
                                        reader.Read();
                                        political_Position.Soft_Delete = reader.Value;
                                        Console.WriteLine(political_Position.Soft_Delete);
                                    }
                                }
                            }

                            if (reader.ReadToFollowing("Sanctions_Data"))
                            {
                                if (reader.ReadToFollowing("Sanction"))
                                {
                                    if (reader.ReadToFollowing("Sanction_Body"))
                                    {
                                        reader.Read();
                                        sanction.Sanction_Body = reader.Value;
                                        Console.WriteLine(sanction.Sanction_Body);
                                    }
                                    if (reader.ReadToFollowing("Sanction_Is_Current"))
                                    {
                                        reader.Read();
                                        sanction.Sanction_Is_Current = reader.Value;
                                        Console.WriteLine(sanction.Sanction_Is_Current);
                                    }
                                }
                            }

                        }
                        count = count + 1;
                        Console.WriteLine("========================");
                        Console.WriteLine(count);
                        Console.WriteLine("========================");
                    }
                }
            }



        }
    }
}
