using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FASellOrderContacts")]
public partial class FasellOrderContact
{
    [Key]
    [Column("FASellOrderContactID")]
    public int FasellOrderContactId { get; set; }

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

    [Column("FASellOrderID")]
    public int FasellOrderId { get; set; }

    [Column("FAContactID")]
    public int FacontactId { get; set; }

    [Column("FAContactTypeID")]
    [StringLength(50)]
    public string FacontactTypeId { get; set; }

    [Column("NEWFASellOrderContact")]
    public int? NewfasellOrderContact { get; set; }

    [ForeignKey("FasellOrderId")]
    [InverseProperty("FasellOrderContacts")]
    public virtual ArsaleOrder FasellOrder { get; set; }
}
