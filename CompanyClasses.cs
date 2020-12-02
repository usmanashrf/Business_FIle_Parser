using System;
using System.Collections.Generic;
using System.Text;

namespace XmlParserApp
{
    class CompanyClasses
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Companies
        {

            private CompaniesCompany[] companyField;

            private decimal schemaVersionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Company")]
            public CompaniesCompany[] Company
            {
                get
                {
                    return this.companyField;
                }
                set
                {
                    this.companyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal schemaVersion
            {
                get
                {
                    return this.schemaVersionField;
                }
                set
                {
                    this.schemaVersionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CompaniesCompany
        {

            private string uniqueIDField;

            private string business_NameField;

            private string descriptionField;

            private string telephoneField;

            private string faxField;

            private string websiteField;

            private string sourceField;

            private string date_of_CaptureField;

            private string soft_DeleteField;

            private string date_of_Soft_DeleteField;

            private object categoryField;

            private CompaniesCompanyAddress[] addressesField;

            private CompaniesCompanyAlias[] aliasesField;

            private CompaniesCompanyIndividual_Association[] individual_AssociationsField;

            private CompaniesCompanyBusiness_Association[] business_AssociationsField;

            private CompaniesCompanyArticle[] articlesField;

            private CompaniesCompanyNote[] notesField;

            private CompaniesCompanySanction[] sanctions_DataField;

            /// <remarks/>
            public string UniqueID
            {
                get
                {
                    return this.uniqueIDField;
                }
                set
                {
                    this.uniqueIDField = value;
                }
            }

            /// <remarks/>
            public string Business_Name
            {
                get
                {
                    return this.business_NameField;
                }
                set
                {
                    this.business_NameField = value;
                }
            }

            /// <remarks/>
            public string Description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public string Telephone
            {
                get
                {
                    return this.telephoneField;
                }
                set
                {
                    this.telephoneField = value;
                }
            }

            /// <remarks/>
            public string Fax
            {
                get
                {
                    return this.faxField;
                }
                set
                {
                    this.faxField = value;
                }
            }

            /// <remarks/>
            public string Website
            {
                get
                {
                    return this.websiteField;
                }
                set
                {
                    this.websiteField = value;
                }
            }

            /// <remarks/>
            public string Source
            {
                get
                {
                    return this.sourceField;
                }
                set
                {
                    this.sourceField = value;
                }
            }

            /// <remarks/>
            public string Date_of_Capture
            {
                get
                {
                    return this.date_of_CaptureField;
                }
                set
                {
                    this.date_of_CaptureField = value;
                }
            }

            /// <remarks/>
            public string Soft_Delete
            {
                get
                {
                    return this.soft_DeleteField;
                }
                set
                {
                    this.soft_DeleteField = value;
                }
            }

            /// <remarks/>
            public string Date_of_Soft_Delete
            {
                get
                {
                    return this.date_of_Soft_DeleteField;
                }
                set
                {
                    this.date_of_Soft_DeleteField = value;
                }
            }

            /// <remarks/>
            public object Category
            {
                get
                {
                    return this.categoryField;
                }
                set
                {
                    this.categoryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Address", IsNullable = false)]
            public CompaniesCompanyAddress[] Addresses
            {
                get
                {
                    return this.addressesField;
                }
                set
                {
                    this.addressesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Alias", IsNullable = false)]
            public CompaniesCompanyAlias[] Aliases
            {
                get
                {
                    return this.aliasesField;
                }
                set
                {
                    this.aliasesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Individual_Association", IsNullable = false)]
            public CompaniesCompanyIndividual_Association[] Individual_Associations
            {
                get
                {
                    return this.individual_AssociationsField;
                }
                set
                {
                    this.individual_AssociationsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Business_Association", IsNullable = false)]
            public CompaniesCompanyBusiness_Association[] Business_Associations
            {
                get
                {
                    return this.business_AssociationsField;
                }
                set
                {
                    this.business_AssociationsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Article", IsNullable = false)]
            public CompaniesCompanyArticle[] Articles
            {
                get
                {
                    return this.articlesField;
                }
                set
                {
                    this.articlesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Note", IsNullable = false)]
            public CompaniesCompanyNote[] Notes
            {
                get
                {
                    return this.notesField;
                }
                set
                {
                    this.notesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Sanction", IsNullable = false)]
            public CompaniesCompanySanction[] Sanctions_Data
            {
                get
                {
                    return this.sanctions_DataField;
                }
                set
                {
                    this.sanctions_DataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CompaniesCompanyAddress
        {

            private string address_Line_1Field;

            private string address_Line_2Field;

            private string address_Line_3Field;

            private string address_Line_4Field;

            private string town_CityField;

            private string county_StateField;

            private string post_Zip_CodeField;

            private string countryField;

            private string soft_DeleteField;

            /// <remarks/>
            public string Address_Line_1
            {
                get
                {
                    return this.address_Line_1Field;
                }
                set
                {
                    this.address_Line_1Field = value;
                }
            }

            /// <remarks/>
            public string Address_Line_2
            {
                get
                {
                    return this.address_Line_2Field;
                }
                set
                {
                    this.address_Line_2Field = value;
                }
            }

            /// <remarks/>
            public string Address_Line_3
            {
                get
                {
                    return this.address_Line_3Field;
                }
                set
                {
                    this.address_Line_3Field = value;
                }
            }

            /// <remarks/>
            public string Address_Line_4
            {
                get
                {
                    return this.address_Line_4Field;
                }
                set
                {
                    this.address_Line_4Field = value;
                }
            }

            /// <remarks/>
            public string Town_City
            {
                get
                {
                    return this.town_CityField;
                }
                set
                {
                    this.town_CityField = value;
                }
            }

            /// <remarks/>
            public string County_State
            {
                get
                {
                    return this.county_StateField;
                }
                set
                {
                    this.county_StateField = value;
                }
            }

            /// <remarks/>
            public string Post_Zip_Code
            {
                get
                {
                    return this.post_Zip_CodeField;
                }
                set
                {
                    this.post_Zip_CodeField = value;
                }
            }

            /// <remarks/>
            public string Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            public string Soft_Delete
            {
                get
                {
                    return this.soft_DeleteField;
                }
                set
                {
                    this.soft_DeleteField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CompaniesCompanyAlias
        {

            private string aliasIDField;

            private string business_NameField;

            private string soft_DeleteField;

            /// <remarks/>
            public string AliasID
            {
                get
                {
                    return this.aliasIDField;
                }
                set
                {
                    this.aliasIDField = value;
                }
            }

            /// <remarks/>
            public string Business_Name
            {
                get
                {
                    return this.business_NameField;
                }
                set
                {
                    this.business_NameField = value;
                }
            }

            /// <remarks/>
            public string Soft_Delete
            {
                get
                {
                    return this.soft_DeleteField;
                }
                set
                {
                    this.soft_DeleteField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CompaniesCompanyIndividual_Association
        {

            private string individual_IDField;

            private string positionField;

            private string soft_DeleteField;

            /// <remarks/>
            public string Individual_ID
            {
                get
                {
                    return this.individual_IDField;
                }
                set
                {
                    this.individual_IDField = value;
                }
            }

            /// <remarks/>
            public string Position
            {
                get
                {
                    return this.positionField;
                }
                set
                {
                    this.positionField = value;
                }
            }

            /// <remarks/>
            public string Soft_Delete
            {
                get
                {
                    return this.soft_DeleteField;
                }
                set
                {
                    this.soft_DeleteField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CompaniesCompanyBusiness_Association
        {

            private string business_ID_2Field;

            private string link_DescriptionField;

            private string soft_DeleteField;

            /// <remarks/>
            public string Business_ID_2
            {
                get
                {
                    return this.business_ID_2Field;
                }
                set
                {
                    this.business_ID_2Field = value;
                }
            }

            /// <remarks/>
            public string Link_Description
            {
                get
                {
                    return this.link_DescriptionField;
                }
                set
                {
                    this.link_DescriptionField = value;
                }
            }

            /// <remarks/>
            public string Soft_Delete
            {
                get
                {
                    return this.soft_DeleteField;
                }
                set
                {
                    this.soft_DeleteField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CompaniesCompanyArticle
        {

            private string original_URLField;

            private string c6_URLField;

            private string file_NameField;

            private string sourceField;

            private CompaniesCompanyArticleSnippets snippetsField;

            private string date_of_CaptureField;

            /// <remarks/>
            public string Original_URL
            {
                get
                {
                    return this.original_URLField;
                }
                set
                {
                    this.original_URLField = value;
                }
            }

            /// <remarks/>
            public string C6_URL
            {
                get
                {
                    return this.c6_URLField;
                }
                set
                {
                    this.c6_URLField = value;
                }
            }

            /// <remarks/>
            public string File_Name
            {
                get
                {
                    return this.file_NameField;
                }
                set
                {
                    this.file_NameField = value;
                }
            }

            /// <remarks/>
            public string Source
            {
                get
                {
                    return this.sourceField;
                }
                set
                {
                    this.sourceField = value;
                }
            }

            /// <remarks/>
            public CompaniesCompanyArticleSnippets Snippets
            {
                get
                {
                    return this.snippetsField;
                }
                set
                {
                    this.snippetsField = value;
                }
            }

            /// <remarks/>
            public string Date_of_Capture
            {
                get
                {
                    return this.date_of_CaptureField;
                }
                set
                {
                    this.date_of_CaptureField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CompaniesCompanyArticleSnippets
        {

            private CompaniesCompanyArticleSnippetsSnippet snippetField;

            /// <remarks/>
            public CompaniesCompanyArticleSnippetsSnippet Snippet
            {
                get
                {
                    return this.snippetField;
                }
                set
                {
                    this.snippetField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CompaniesCompanyArticleSnippetsSnippet
        {

            private string titleField;

            private string snippetTextField;

            private string adverse_TermsField;

            /// <remarks/>
            public string Title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            public string SnippetText
            {
                get
                {
                    return this.snippetTextField;
                }
                set
                {
                    this.snippetTextField = value;
                }
            }

            /// <remarks/>
            public string Adverse_Terms
            {
                get
                {
                    return this.adverse_TermsField;
                }
                set
                {
                    this.adverse_TermsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CompaniesCompanyNote
        {

            private string source_of_NotesField;

            private string notesField;

            private string soft_DeleteField;

            /// <remarks/>
            public string Source_of_Notes
            {
                get
                {
                    return this.source_of_NotesField;
                }
                set
                {
                    this.source_of_NotesField = value;
                }
            }

            /// <remarks/>
            public string Notes
            {
                get
                {
                    return this.notesField;
                }
                set
                {
                    this.notesField = value;
                }
            }

            /// <remarks/>
            public string Soft_Delete
            {
                get
                {
                    return this.soft_DeleteField;
                }
                set
                {
                    this.soft_DeleteField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class CompaniesCompanySanction
        {

            private string sanction_BodyField;

            private string sanction_Is_CurrentField;

            /// <remarks/>
            public string Sanction_Body
            {
                get
                {
                    return this.sanction_BodyField;
                }
                set
                {
                    this.sanction_BodyField = value;
                }
            }

            /// <remarks/>
            public string Sanction_Is_Current
            {
                get
                {
                    return this.sanction_Is_CurrentField;
                }
                set
                {
                    this.sanction_Is_CurrentField = value;
                }
            }
        }


    }
}
