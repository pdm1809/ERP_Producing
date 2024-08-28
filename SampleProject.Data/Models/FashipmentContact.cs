using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAShipmentContacts")]
public partial class FashipmentContact
{
    [Key]
    [Column("FAShipmentContactID")]
    public int FashipmentContactId { get; set; }

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

    [Column("FAShipmentID")]
    public int FashipmentId { get; set; }

    [Column("FAContactID")]
    public int FacontactId { get; set; }

    [Column("FAContactTypeID")]
    [StringLength(50)]
    public string FacontactTypeId { get; set; }

    [Column("NEWFAShipmentContact")]
    [StringLength(10)]
    public string NewfashipmentContact { get; set; }

    [ForeignKey("FacontactId")]
    [InverseProperty("FashipmentContacts")]
    public virtual Facontact Facontact { get; set; }

    [ForeignKey("FashipmentId")]
    [InverseProperty("FashipmentContacts")]
    public virtual Icshipment Fashipment { get; set; }
}
