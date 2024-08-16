using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FASellReturnContacts")]
public partial class FasellReturnContact
{
    [Key]
    [Column("FASellReturnContactID")]
    public int FasellReturnContactId { get; set; }

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

    [Column("FASellReturnID")]
    public int FasellReturnId { get; set; }

    [Column("FAContactID")]
    public int FacontactId { get; set; }

    [Column("FAContactTypeID")]
    [StringLength(50)]
    public string FacontactTypeId { get; set; }

    [Column("NEWFASellReturnContact")]
    public int? NewfasellReturnContact { get; set; }

    [ForeignKey("FacontactId")]
    [InverseProperty("FasellReturnContacts")]
    public virtual Facontact Facontact { get; set; }

    [ForeignKey("FasellReturnId")]
    [InverseProperty("FasellReturnContacts")]
    public virtual FasellReturn FasellReturn { get; set; }
}
