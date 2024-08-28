using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAAddress")]
public partial class Faaddress
{
    [Key]
    [Column("FAAddressID")]
    public int FaaddressId { get; set; }

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

    [Required]
    [Column("FAAddressName")]
    [StringLength(100)]
    public string FaaddressName { get; set; }

    [Column("FAAddressDesc1")]
    [StringLength(250)]
    public string FaaddressDesc1 { get; set; }

    [Column("FAAddressDesc2")]
    [StringLength(250)]
    public string FaaddressDesc2 { get; set; }

    [Column("FAAddressDesc3")]
    [StringLength(250)]
    public string FaaddressDesc3 { get; set; }

    [Required]
    [Column("FAAddressStreet")]
    [StringLength(200)]
    public string FaaddressStreet { get; set; }

    [Required]
    [Column("FAAddressHouseNumber")]
    [StringLength(50)]
    public string FaaddressHouseNumber { get; set; }

    [Required]
    [Column("FAAddressCity")]
    [StringLength(50)]
    public string FaaddressCity { get; set; }

    [Required]
    [Column("FAAddressPostalCode")]
    [StringLength(50)]
    public string FaaddressPostalCode { get; set; }

    [Required]
    [Column("FAAddressStateProvince")]
    [StringLength(50)]
    public string FaaddressStateProvince { get; set; }

    [Required]
    [Column("FAAddressZipCode")]
    [StringLength(50)]
    public string FaaddressZipCode { get; set; }

    [Required]
    [Column("FAAddressCountry")]
    [StringLength(50)]
    public string FaaddressCountry { get; set; }

    [Column("FAAddressEmail")]
    [StringLength(100)]
    public string FaaddressEmail { get; set; }

    [Column("FAAddressWebsite")]
    [StringLength(50)]
    public string FaaddressWebsite { get; set; }

    [Column("FAAddressCellPhone")]
    [StringLength(50)]
    public string FaaddressCellPhone { get; set; }

    [Column("FAAddressPhone")]
    [StringLength(50)]
    public string FaaddressPhone { get; set; }

    [Column("FAAddresssFax")]
    [StringLength(50)]
    public string FaaddresssFax { get; set; }

    [Column("FAAddresssInfo")]
    [StringLength(255)]
    public string FaaddresssInfo { get; set; }

    [Column("FAAddresssCarZip")]
    [StringLength(50)]
    public string FaaddresssCarZip { get; set; }

    [InverseProperty("Faaddress")]
    public virtual ICollection<Facontact> Facontacts { get; set; } = new List<Facontact>();
}
