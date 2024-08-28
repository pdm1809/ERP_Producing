using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReturnSupplierContacts")]
public partial class FareturnSupplierContact
{
    [Key]
    [Column("FAReturnSupplierContactID")]
    public int FareturnSupplierContactId { get; set; }

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

    [Column("FAReturnSupplierID")]
    public int FareturnSupplierId { get; set; }

    [Column("FAContactID")]
    public int FacontactId { get; set; }

    [Column("FAContactTypeID")]
    [StringLength(50)]
    public string FacontactTypeId { get; set; }

    [Column("NEWFAReturnSupplierContact")]
    [StringLength(10)]
    public string NewfareturnSupplierContact { get; set; }

    [ForeignKey("FacontactId")]
    [InverseProperty("FareturnSupplierContacts")]
    public virtual Facontact Facontact { get; set; }

    [ForeignKey("FareturnSupplierId")]
    [InverseProperty("FareturnSupplierContacts")]
    public virtual FareturnSupplier FareturnSupplier { get; set; }
}
