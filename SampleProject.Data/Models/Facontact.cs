using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAContacts")]
public partial class Facontact
{
    [Key]
    [Column("FAContactID")]
    public int FacontactId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("FAAddressID")]
    public int? FaaddressId { get; set; }

    [Column("FALanguageIDCombo")]
    public int? FalanguageIdcombo { get; set; }

    [Required]
    [Column("FAContactName")]
    [StringLength(50)]
    public string FacontactName { get; set; }

    [Column("FAContactBirthday", TypeName = "datetime")]
    public DateTime? FacontactBirthday { get; set; }

    [Column("FAContactFirstName")]
    [StringLength(50)]
    public string FacontactFirstName { get; set; }

    [Column("FAContactLastName")]
    [StringLength(50)]
    public string FacontactLastName { get; set; }

    [Column("FAContactTitle")]
    [StringLength(50)]
    public string FacontactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("FAContactHeaderLetter")]
    [StringLength(100)]
    public string FacontactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("FAContactHeaderMessage")]
    [StringLength(255)]
    public string FacontactHeaderMessage { get; set; }

    [Column("FAContactEmail1")]
    [StringLength(100)]
    public string FacontactEmail1 { get; set; }

    [Column("FAContactEmail2")]
    [StringLength(100)]
    public string FacontactEmail2 { get; set; }

    [Column("FAContactWebsite")]
    [StringLength(100)]
    public string FacontactWebsite { get; set; }

    [Column("FAContactPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacontactPhonePrivat { get; set; }

    [Column("FAContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacontactPhone { get; set; }

    [Column("FAContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacontactPhone1 { get; set; }

    [Column("FAContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacontactCellPhone1 { get; set; }

    [Column("FAContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacontactCellPhone { get; set; }

    [Column("FAContactCellPhonePrivat")]
    [StringLength(50)]
    [Unicode(false)]
    public string FacontactCellPhonePrivat { get; set; }

    [Column("FAContactFax")]
    [StringLength(50)]
    public string FacontactFax { get; set; }

    [Column("FAContactType")]
    [StringLength(50)]
    public string FacontactType { get; set; }

    [Column("MAContactTypeDisplay")]
    [StringLength(100)]
    public string MacontactTypeDisplay { get; set; }

    [Column("FAContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string FacontactInformation { get; set; }

    [Column("FAContactDepartment")]
    [StringLength(50)]
    public string FacontactDepartment { get; set; }

    [Column("FAContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string FacontactRoom { get; set; }

    [Column("FAContactImage")]
    public byte[] FacontactImage { get; set; }

    [ForeignKey("FaaddressId")]
    [InverseProperty("Facontacts")]
    public virtual Faaddress Faaddress { get; set; }

    [InverseProperty("Facontact")]
    public virtual ICollection<FacreditNoteContact> FacreditNoteContacts { get; set; } = new List<FacreditNoteContact>();

    [InverseProperty("Facontact")]
    public virtual ICollection<FainvoiceContact> FainvoiceContacts { get; set; } = new List<FainvoiceContact>();

    [ForeignKey("FalanguageIdcombo")]
    [InverseProperty("Facontacts")]
    public virtual Gelanguage FalanguageIdcomboNavigation { get; set; }

    [InverseProperty("Facontact")]
    public virtual ICollection<FaproposalContact> FaproposalContacts { get; set; } = new List<FaproposalContact>();

    [InverseProperty("Facontact")]
    public virtual ICollection<FapurchaseOrderContact> FapurchaseOrderContacts { get; set; } = new List<FapurchaseOrderContact>();

    [InverseProperty("Facontact")]
    public virtual ICollection<FareceiptContact> FareceiptContacts { get; set; } = new List<FareceiptContact>();

    [InverseProperty("Facontact")]
    public virtual ICollection<FareturnSupplierContact> FareturnSupplierContacts { get; set; } = new List<FareturnSupplierContact>();

    [InverseProperty("Facontact")]
    public virtual ICollection<FasellReturnContact> FasellReturnContacts { get; set; } = new List<FasellReturnContact>();

    [InverseProperty("Facontact")]
    public virtual ICollection<FashipmentContact> FashipmentContacts { get; set; } = new List<FashipmentContact>();
}
