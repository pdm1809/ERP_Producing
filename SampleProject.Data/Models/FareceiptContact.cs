using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAReceiptContacts")]
public partial class FareceiptContact
{
    [Key]
    [Column("FAReceiptContactID")]
    public int FareceiptContactId { get; set; }

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

    [Column("FAReceiptID")]
    public int FareceiptId { get; set; }

    [Column("FAContactID")]
    public int FacontactId { get; set; }

    [Column("FAContactTypeID")]
    [StringLength(50)]
    public string FacontactTypeId { get; set; }

    [Column("NEWFAReceiptContact")]
    public int? NewfareceiptContact { get; set; }

    [ForeignKey("FacontactId")]
    [InverseProperty("FareceiptContacts")]
    public virtual Facontact Facontact { get; set; }

    [ForeignKey("FareceiptId")]
    [InverseProperty("FareceiptContacts")]
    public virtual Icreceipt Fareceipt { get; set; }
}
