
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Individuals
{

    private IndividualsIndividual[] individualField;

    private decimal schemaVersionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Individual")]
    public IndividualsIndividual[] Individual
    {
        get
        {
            return this.individualField;
        }
        set
        {
            this.individualField = value;
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
public partial class IndividualsIndividual
{

    private string uniqueIDField;

    private string titleField;

    private object alternate_TitleField;

    private string forenameField;

    private string middlenameField;

    private string surnameField;

    private string date_of_BirthField;

    private string date_of_DeathField;

    private ushort year_of_BirthField;

    private ushort year_of_DeathField;

    private string genderField;

    private string home_TelephoneField;

    private object business_TelephoneField;

    private string mobile_TelephoneField;

    private string faxField;

    private string emailField;

    private string nationalityField;

    private string pEP_TierField;

    private string sourceField;

    private string date_of_CaptureField;

    private string soft_DeleteField;

    private string date_of_Soft_DeleteField;

    private object categoryField;

    private string pictureField;

    private IndividualsIndividualAddress[] addressesField;

    private IndividualsIndividualAlias[] aliasesField;

    private IndividualsIndividualIndividual_Association[] individual_AssociationsField;

    private IndividualsIndividualBusiness_Association[] business_AssociationsField;

    private IndividualsIndividualArticle[] articlesField;

    private IndividualsIndividualNote[] notesField;

    private IndividualsIndividualPolitical_Position[] political_PositionsField;

    private IndividualsIndividualSanction[] sanctions_DataField;

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
    public object Alternate_Title
    {
        get
        {
            return this.alternate_TitleField;
        }
        set
        {
            this.alternate_TitleField = value;
        }
    }

    /// <remarks/>
    public string Forename
    {
        get
        {
            return this.forenameField;
        }
        set
        {
            this.forenameField = value;
        }
    }

    /// <remarks/>
    public string Middlename
    {
        get
        {
            return this.middlenameField;
        }
        set
        {
            this.middlenameField = value;
        }
    }

    /// <remarks/>
    public string Surname
    {
        get
        {
            return this.surnameField;
        }
        set
        {
            this.surnameField = value;
        }
    }

    /// <remarks/>
    public string Date_of_Birth
    {
        get
        {
            return this.date_of_BirthField;
        }
        set
        {
            this.date_of_BirthField = value;
        }
    }

    /// <remarks/>
    public string Date_of_Death
    {
        get
        {
            return this.date_of_DeathField;
        }
        set
        {
            this.date_of_DeathField = value;
        }
    }

    /// <remarks/>
    public ushort Year_of_Birth
    {
        get
        {
            return this.year_of_BirthField;
        }
        set
        {
            this.year_of_BirthField = value;
        }
    }

    /// <remarks/>
    public ushort Year_of_Death
    {
        get
        {
            return this.year_of_DeathField;
        }
        set
        {
            this.year_of_DeathField = value;
        }
    }

    /// <remarks/>
    public string Gender
    {
        get
        {
            return this.genderField;
        }
        set
        {
            this.genderField = value;
        }
    }

    /// <remarks/>
    public string Home_Telephone
    {
        get
        {
            return this.home_TelephoneField;
        }
        set
        {
            this.home_TelephoneField = value;
        }
    }

    /// <remarks/>
    public object Business_Telephone
    {
        get
        {
            return this.business_TelephoneField;
        }
        set
        {
            this.business_TelephoneField = value;
        }
    }

    /// <remarks/>
    public string Mobile_Telephone
    {
        get
        {
            return this.mobile_TelephoneField;
        }
        set
        {
            this.mobile_TelephoneField = value;
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
    public string Email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }

    /// <remarks/>
    public string Nationality
    {
        get
        {
            return this.nationalityField;
        }
        set
        {
            this.nationalityField = value;
        }
    }

    /// <remarks/>
    public string PEP_Tier
    {
        get
        {
            return this.pEP_TierField;
        }
        set
        {
            this.pEP_TierField = value;
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
    public string Picture
    {
        get
        {
            return this.pictureField;
        }
        set
        {
            this.pictureField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Address", IsNullable = false)]
    public IndividualsIndividualAddress[] Addresses
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
    public IndividualsIndividualAlias[] Aliases
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
    public IndividualsIndividualIndividual_Association[] Individual_Associations
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
    public IndividualsIndividualBusiness_Association[] Business_Associations
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
    public IndividualsIndividualArticle[] Articles
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
    public IndividualsIndividualNote[] Notes
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
    [System.Xml.Serialization.XmlArrayItemAttribute("Political_Position", IsNullable = false)]
    public IndividualsIndividualPolitical_Position[] Political_Positions
    {
        get
        {
            return this.political_PositionsField;
        }
        set
        {
            this.political_PositionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Sanction", IsNullable = false)]
    public IndividualsIndividualSanction[] Sanctions_Data
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
public partial class IndividualsIndividualAddress
{

    private string address_Line_1Field;

    private string address_Line_2Field;

    private string address_Line_3Field;

    private string address_Line_4Field;

    private string town_CityField;

    private string county_StateField;

    private string post_Zip_CodeField;

    private string countryField;

    private string iSO_CountryField;

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
    public string ISO_Country
    {
        get
        {
            return this.iSO_CountryField;
        }
        set
        {
            this.iSO_CountryField = value;
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
public partial class IndividualsIndividualAlias
{

    private string aliasIDField;

    private string titleField;

    private string alternate_TitleField;

    private string forenameField;

    private string middle_NameField;

    private string surnameField;

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
    public string Alternate_Title
    {
        get
        {
            return this.alternate_TitleField;
        }
        set
        {
            this.alternate_TitleField = value;
        }
    }

    /// <remarks/>
    public string Forename
    {
        get
        {
            return this.forenameField;
        }
        set
        {
            this.forenameField = value;
        }
    }

    /// <remarks/>
    public string Middle_Name
    {
        get
        {
            return this.middle_NameField;
        }
        set
        {
            this.middle_NameField = value;
        }
    }

    /// <remarks/>
    public string Surname
    {
        get
        {
            return this.surnameField;
        }
        set
        {
            this.surnameField = value;
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
public partial class IndividualsIndividualIndividual_Association
{

    private string individual_ID_2Field;

    private string link_DescriptionField;

    private string soft_DeleteField;

    /// <remarks/>
    public string Individual_ID_2
    {
        get
        {
            return this.individual_ID_2Field;
        }
        set
        {
            this.individual_ID_2Field = value;
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
public partial class IndividualsIndividualBusiness_Association
{

    private string business_IDField;

    private string descriptionField;

    private string soft_DeleteField;

    /// <remarks/>
    public string Business_ID
    {
        get
        {
            return this.business_IDField;
        }
        set
        {
            this.business_IDField = value;
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
public partial class IndividualsIndividualArticle
{

    private string original_URLField;

    private string c6_URLField;

    private string file_NameField;

    private string sourceField;

    private IndividualsIndividualArticleSnippets snippetsField;

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
    public IndividualsIndividualArticleSnippets Snippets
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
public partial class IndividualsIndividualArticleSnippets
{

    private IndividualsIndividualArticleSnippetsSnippet snippetField;

    /// <remarks/>
    public IndividualsIndividualArticleSnippetsSnippet Snippet
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
public partial class IndividualsIndividualArticleSnippetsSnippet
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
public partial class IndividualsIndividualNote
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
public partial class IndividualsIndividualPolitical_Position
{

    private string descriptionField;

    private string fromField;

    private string toField;

    private string countryField;

    private string soft_DeleteField;

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
    public string From
    {
        get
        {
            return this.fromField;
        }
        set
        {
            this.fromField = value;
        }
    }

    /// <remarks/>
    public string To
    {
        get
        {
            return this.toField;
        }
        set
        {
            this.toField = value;
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
public partial class IndividualsIndividualSanction
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

