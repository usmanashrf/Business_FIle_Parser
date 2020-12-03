using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using static XmlParserApp.CompanyClasses;

namespace XmlParserApp
{
   public class Parser
    {
        public void ParserFile(string FilePath)
        {
            Companies companies = new Companies();
            CompaniesCompany company = new CompaniesCompany();
            CompaniesCompanyAddress address = new CompaniesCompanyAddress();
            CompaniesCompanyAlias alias = new CompaniesCompanyAlias();
            CompaniesCompanyArticle article = new CompaniesCompanyArticle();
            CompaniesCompanyBusiness_Association business_Association = new CompaniesCompanyBusiness_Association();
            CompaniesCompanyIndividual_Association individual_Association = new CompaniesCompanyIndividual_Association();
            CompaniesCompanyNote note = new CompaniesCompanyNote();
            CompaniesCompanySanction sanction_Datas = new CompaniesCompanySanction();
            CompaniesCompanyArticleSnippetsSnippet snippets = new CompaniesCompanyArticleSnippetsSnippet();



            using (XmlReader reader = XmlReader.Create(FilePath))
            {
                
                int count = 0;
                while (!reader.EOF)
                {
                    if (reader.ReadToFollowing("Company"))
                    {
                        if (reader.ReadToFollowing("UniqueID"))
                        {
                            reader.Read();
                            company.UniqueID = reader.Value;
                            Console.WriteLine(company.UniqueID);
                        }
                        if (reader.ReadToFollowing("Business_Name"))
                        {
                            reader.Read();
                            company.Business_Name = reader.Value;
                            Console.WriteLine(company.Business_Name);
                        }
                        if (reader.ReadToFollowing("Description"))
                        {
                            reader.Read();
                            company.Description = reader.Value;
                            Console.WriteLine(company.Description);
                        }
                        if (reader.ReadToFollowing("Telephone"))
                        {
                            reader.Read();
                            company.Telephone = reader.Value;
                            Console.WriteLine(company.Telephone);
                        }
                        if (reader.ReadToFollowing("Fax"))
                        {
                            reader.Read();
                            company.Fax = reader.Value;
                            Console.WriteLine(company.Fax);
                        }
                        if (reader.ReadToFollowing("Website"))
                        {
                            reader.Read();
                            company.Website = reader.Value;
                            Console.WriteLine(company.Website);
                        }
                        if (reader.ReadToFollowing("Source"))
                        {
                            reader.Read();
                            company.Source = reader.Value;
                            Console.WriteLine(company.Source);
                        }
                        if (reader.ReadToFollowing("Date_of_Capture"))
                        {
                            reader.Read();
                            company.Date_of_Capture = reader.Value;
                            Console.WriteLine(company.Date_of_Capture);
                        }
                        if (reader.ReadToFollowing("Soft_Delete"))
                        {
                            reader.Read();
                            company.Soft_Delete = reader.Value;
                            Console.WriteLine(company.Soft_Delete);
                        }
                        if (reader.ReadToFollowing("Date_of_Soft_Delete"))
                        {
                            reader.Read();
                            company.Date_of_Soft_Delete = reader.Value;
                            Console.WriteLine(company.Date_of_Soft_Delete);
                        }
                        if (reader.ReadToFollowing("Category"))
                        {
                            reader.Read();
                            company.Category = reader.Value;
                            Console.WriteLine(company.Category);
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
                                    // Console.WriteLine(address.Address_Line_3);
                                }
                                if (reader.ReadToFollowing("Address_Line_4"))
                                {
                                    reader.Read();
                                    address.Address_Line_4 = reader.Value;
                                    //Console.WriteLine(address.Address_Line_4);
                                }
                                if (reader.ReadToFollowing("Town_City"))
                                {
                                    reader.Read();
                                    address.Town_City = reader.Value;
                                    // Console.WriteLine(address.Town_City);
                                }
                                if (reader.ReadToFollowing("County_State"))
                                {
                                    reader.Read();
                                    address.County_State = reader.Value;
                                    //Console.WriteLine(address.County_State);
                                }
                                if (reader.ReadToFollowing("Post_Zip_Code"))
                                {
                                    reader.Read();
                                    address.Post_Zip_Code = reader.Value;
                                    // Console.WriteLine(address.Post_Zip_Code);
                                }
                                if (reader.ReadToFollowing("Post_Zip_Code"))
                                {
                                    reader.Read();
                                    address.Post_Zip_Code = reader.Value;
                                    // Console.WriteLine(address.Post_Zip_Code);
                                }
                                if (reader.ReadToFollowing("Country"))
                                {
                                    reader.Read();
                                    address.Country = reader.Value;
                                    //Console.WriteLine(address.Country);
                                }
                                if (reader.ReadToFollowing("Soft_Delete"))
                                {
                                    reader.Read();
                                    address.Soft_Delete = reader.Value;
                                    //Console.WriteLine(address.Soft_Delete);
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
                                    // Console.WriteLine(alias.AliasID);
                                }
                                if (reader.ReadToFollowing("Business_Name"))
                                {
                                    reader.Read();
                                    alias.Business_Name = reader.Value;
                                    // Console.WriteLine(alias.Business_Name);
                                }
                                if (reader.ReadToFollowing("Soft_Delete"))
                                {
                                    reader.Read();
                                    alias.Soft_Delete = reader.Value;
                                    // Console.WriteLine(alias.Soft_Delete);
                                }
                            }
                        }

                        if (reader.ReadToFollowing("Individual_Association"))
                        {
                            if (reader.ReadToFollowing("Individual_Association"))
                            {
                                if (reader.ReadToFollowing("Individual_ID"))
                                {
                                    reader.Read();
                                    individual_Association.Individual_ID = reader.Value;
                                    // Console.WriteLine(individual_Association.Individual_ID);
                                }
                                if (reader.ReadToFollowing("Position"))
                                {
                                    reader.Read();
                                    individual_Association.Position = reader.Value;
                                    // Console.WriteLine(individual_Association.Position);
                                }
                                if (reader.ReadToFollowing("Soft_Delete"))
                                {
                                    reader.Read();
                                    individual_Association.Soft_Delete = reader.Value;
                                    // Console.WriteLine(individual_Association.Soft_Delete);
                                }


                            }
                        }

                        if (reader.ReadToFollowing("Business_Associations"))
                        {
                            if (reader.ReadToFollowing("Business_Association"))
                            {
                                if (reader.ReadToFollowing("Business_ID_2"))
                                {
                                    reader.Read();
                                    business_Association.Business_ID_2 = reader.Value;
                                    //Console.WriteLine(business_Association.Business_ID_2);
                                }
                                if (reader.ReadToFollowing("Link_Description"))
                                {
                                    reader.Read();
                                    business_Association.Link_Description = reader.Value;
                                    // Console.WriteLine(business_Association.Link_Description);
                                }
                                if (reader.ReadToFollowing("Soft_Delete"))
                                {
                                    reader.Read();
                                    business_Association.Soft_Delete = reader.Value;
                                    // Console.WriteLine(business_Association.Soft_Delete);
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
                                    //Console.WriteLine(article.Original_URL);
                                }
                                if (reader.ReadToFollowing("C6_URL"))
                                {
                                    reader.Read();
                                    article.C6_URL = reader.Value;
                                    //Console.WriteLine(article.C6_URL);
                                }
                                if (reader.ReadToFollowing("File_Name"))
                                {
                                    reader.Read();
                                    article.File_Name = reader.Value;
                                    // Console.WriteLine(article.File_Name);
                                }
                                if (reader.ReadToFollowing("Source"))
                                {
                                    reader.Read();
                                    article.Source = reader.Value;
                                    // Console.WriteLine(article.Source);
                                }
                                if (reader.ReadToFollowing("Snippets"))
                                {
                                    if (reader.ReadToFollowing("Snippet"))
                                    {
                                        if (reader.ReadToFollowing("Title"))
                                        {
                                            reader.Read();
                                            snippets.Title = reader.Value;
                                            //Console.WriteLine(snippets.Title);
                                        }
                                        if (reader.ReadToFollowing("SnippetText"))
                                        {
                                            reader.Read();
                                            snippets.SnippetText = reader.Value;
                                            //Console.WriteLine(snippets.SnippetText);
                                        }
                                        if (reader.ReadToFollowing("Adverse_Terms"))
                                        {
                                            reader.Read();
                                            snippets.Adverse_Terms = reader.Value;
                                            //Console.WriteLine(snippets.Adverse_Terms);
                                        }
                                    }
                                }

                                if (reader.ReadToFollowing("Date_of_Capture"))
                                {
                                    reader.Read();
                                    article.Date_of_Capture = reader.Value;
                                    // Console.WriteLine(article.Date_of_Capture);
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
                                    // Console.WriteLine(note.Source_of_Notes);
                                }
                                if (reader.ReadToFollowing("Notes"))
                                {
                                    reader.Read();
                                    note.Notes = reader.Value;
                                    //  Console.WriteLine(note.Notes);
                                }
                                if (reader.ReadToFollowing("Soft_Delete"))
                                {
                                    reader.Read();
                                    note.Soft_Delete = reader.Value;
                                    //  Console.WriteLine(note.Soft_Delete);
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
                                    sanction_Datas.Sanction_Body = reader.Value;
                                    //  Console.WriteLine(sanction_Datas.Sanction_Body);
                                }
                                if (reader.ReadToFollowing("Sanction_Is_Current"))
                                {
                                    reader.Read();
                                    sanction_Datas.Sanction_Is_Current = reader.Value;
                                    //Console.WriteLine(sanction_Datas.Sanction_Is_Current);
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
