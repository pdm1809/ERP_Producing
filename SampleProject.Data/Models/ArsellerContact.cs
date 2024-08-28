using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSellerContacts")]
public partial class ArsellerContact
{
    [Key]
    [Column("ARSellerContactID")]
    public int ArsellerContactId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ARSellerContactName")]
    [StringLength(50)]
    public string ArsellerContactName { get; set; }

    [Column("FK_ARSellerID")]
    public int FkArsellerId { get; set; }

    [Column("ARSellerContactBirthday", TypeName = "datetime")]
    public DateTime? ArsellerContactBirthday { get; set; }

    [Column("ARSellerContactFirstName")]
    [StringLength(50)]
    public string ArsellerContactFirstName { get; set; }

    [Column("ARSellerContactLastName")]
    [StringLength(50)]
    public string ArsellerContactLastName { get; set; }

    [Column("ARSellerContactTitle")]
    [StringLength(50)]
    public string ArsellerContactTitle { get; set; }

    /// <summary>
    /// fuer Umschlag: zB. Z.Hand Herrn Meyer
    /// </summary>
    [Column("ARSellerContactHeaderLetter")]
    [StringLength(100)]
    public string ArsellerContactHeaderLetter { get; set; }

    /// <summary>
    /// Anrede fuer Briefe
    /// </summary>
    [Column("ARSellerContactHeaderMessage")]
    [StringLength(255)]
    public string ArsellerContactHeaderMessage { get; set; }

    [Column("ARSellerContactEmail1")]
    [StringLength(100)]
    public string ArsellerContactEmail1 { get; set; }

    [Column("ARSellerContactEmail2")]
    [StringLength(100)]
    public string ArsellerContactEmail2 { get; set; }

    [Column("ARSellerContactWebsite")]
    [StringLength(100)]
    public string ArsellerContactWebsite { get; set; }

    [Column("ARSellerContactPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerContactPhonePrivate { get; set; }

    [Column("ARSellerContactPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerContactPhone { get; set; }

    [Column("ARSellerContactPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerContactPhone1 { get; set; }

    [Column("ARSellerContactCellPhone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerContactCellPhone1 { get; set; }

    [Column("ARSellerContactCellPhone")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerContactCellPhone { get; set; }

    [Column("ARSellerContactCellPhonePrivate")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsellerContactCellPhonePrivate { get; set; }

    [Column("ARSellerContactFax")]
    [StringLength(50)]
    public string ArsellerContactFax { get; set; }

    [Column("ARContactType")]
    [StringLength(100)]
    public string ArcontactType { get; set; }

    [Column("ARSellerContactTypeDisplay")]
    [StringLength(100)]
    public string ArsellerContactTypeDisplay { get; set; }

    [Column("ARSellerContactInformation")]
    [StringLength(510)]
    [Unicode(false)]
    public string ArsellerContactInformation { get; set; }

    [Column("ARSellerContactDepartment")]
    [StringLength(50)]
    public string ArsellerContactDepartment { get; set; }

    [Column("ARSellerContactRoom")]
    [StringLength(30)]
    [Unicode(false)]
    public string ArsellerContactRoom { get; set; }

    [Column("ARSellerContactAddressLine1")]
    [StringLength(200)]
    public string ArsellerContactAddressLine1 { get; set; }

    [Column("ARSellerContactAddressLine2")]
    [StringLength(200)]
    public string ArsellerContactAddressLine2 { get; set; }

    [Column("ARSellerContactAddressLine3")]
    [StringLength(200)]
    public string ArsellerContactAddressLine3 { get; set; }

    [Column("ARSellerContactAddressStreet")]
    [StringLength(200)]
    public string ArsellerContactAddressStreet { get; set; }

    [Column("ARSellerContactAddressCity")]
    [StringLength(50)]
    public string ArsellerContactAddressCity { get; set; }

    [Column("ARSellerContactAddressPostalCode")]
    [StringLength(50)]
    public string ArsellerContactAddressPostalCode { get; set; }

    [Column("ARSellerContactAddressStateProvince")]
    [StringLength(50)]
    public string ArsellerContactAddressStateProvince { get; set; }

    [Column("ARSellerContactAddressZipCode")]
    [StringLength(50)]
    public string ArsellerContactAddressZipCode { get; set; }

    [Column("ARSellerContactAddressCountry")]
    [StringLength(50)]
    public string ArsellerContactAddressCountry { get; set; }

    [ForeignKey("FkArsellerId")]
    [InverseProperty("ArsellerContacts")]
    public virtual Arseller FkArseller { get; set; }
}
