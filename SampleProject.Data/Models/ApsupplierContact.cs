using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APSupplierContacts")]
[Microsoft.EntityFrameworkCore.Index("FkApsupplierId", Name = "Idx_APSupplierContacts")]
public partial class ApsupplierContact
{
    [Key]
    [Column("APSupplierContactID")]
    public int ApsupplierContactId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("APSupplierContactName")]
    [StringLength(100)]
    public string ApsupplierContactName { get; set; }

    [Column("FK_APSupplierID")]
    public int FkApsupplierId { get; set; }

    [Column("APSupplierContactBirthday", TypeName = "datetime")]
    public DateTime? ApsupplierContactBirthday { get; set; }

    [Column("APSupplierContactFirstName")]
    [StringLength(50)]
    public string ApsupplierContactFirstName { get; set; }

    [Column("APSupplierContactLastName")]
    [StringLength(50)]
    public string ApsupplierContactLastName { get; set; }

    [Column("APSupplierContactTitle")]
    [StringLength(50)]
    public string ApsupplierContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("APSupplierContactHeaderLetter")]
    [StringLength(100)]
    public string ApsupplierContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("APSupplierContactHeaderMessage")]
    [StringLength(255)]
    public string ApsupplierContactHeaderMessage { get; set; }

    [Column("APSupplierContactEmail1")]
    [StringLength(100)]
    public string ApsupplierContactEmail1 { get; set; }

    [Column("APSupplierContactEmail2")]
    [StringLength(100)]
    public string ApsupplierContactEmail2 { get; set; }

    [Column("APSupplierContactWebsite")]
    [StringLength(100)]
    public string ApsupplierContactWebsite { get; set; }

    [Column("APSupplierContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierContactPhone { get; set; }

    [Column("APSupplierContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierContactPhone1 { get; set; }

    [Column("APSupplierContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierContactCellPhone1 { get; set; }

    [Column("APSupplierContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ApsupplierContactCellPhone { get; set; }

    [Column("APSupplierContactFax")]
    [StringLength(50)]
    public string ApsupplierContactFax { get; set; }

    [Column("APSupplierContactDepartment")]
    [StringLength(50)]
    public string ApsupplierContactDepartment { get; set; }

    [Column("APSupplierContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ApsupplierContactRoom { get; set; }

    [Column("APSupplierContactAddressLine1")]
    [StringLength(200)]
    public string ApsupplierContactAddressLine1 { get; set; }

    [Column("APSupplierContactAddressLine2")]
    [StringLength(200)]
    public string ApsupplierContactAddressLine2 { get; set; }

    [Column("APSupplierContactAddressLine3")]
    [StringLength(200)]
    public string ApsupplierContactAddressLine3 { get; set; }

    [Column("APSupplierContactAddressStreet")]
    [StringLength(200)]
    public string ApsupplierContactAddressStreet { get; set; }

    [Column("APSupplierContactAddressCity")]
    [StringLength(50)]
    public string ApsupplierContactAddressCity { get; set; }

    [Column("APSupplierContactAddressPostalCode")]
    [StringLength(50)]
    public string ApsupplierContactAddressPostalCode { get; set; }

    [Column("APSupplierContactAddressStateProvince")]
    [StringLength(50)]
    public string ApsupplierContactAddressStateProvince { get; set; }

    [Column("APSupplierContactAddressZipCode")]
    [StringLength(50)]
    public string ApsupplierContactAddressZipCode { get; set; }

    [Column("APSupplierContactAddressCountry")]
    [StringLength(50)]
    public string ApsupplierContactAddressCountry { get; set; }

    [Column("APSupplierContactDealCheck")]
    public bool? ApsupplierContactDealCheck { get; set; }

    [Column("APSupplierContactPODefaultCheck")]
    public bool? ApsupplierContactPodefaultCheck { get; set; }

    [Column("APSupplierContactLevel")]
    [StringLength(256)]
    public string ApsupplierContactLevel { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("ApsupplierContacts")]
    public virtual Apsupplier FkApsupplier { get; set; }
}
