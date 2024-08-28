using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAPurchaseOrderContacts")]
public partial class FapurchaseOrderContact
{
    [Key]
    [Column("FAPurchaseOrderContactID")]
    public int FapurchaseOrderContactId { get; set; }

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

    [Column("FAPurchaseOrderID")]
    public int FapurchaseOrderId { get; set; }

    [Column("FAContactID")]
    public int FacontactId { get; set; }

    [Column("FAContactTypeID")]
    [StringLength(50)]
    public string FacontactTypeId { get; set; }

    [Column("NEWFAPurchaseOrderContact")]
    public int? NewfapurchaseOrderContact { get; set; }

    [ForeignKey("FacontactId")]
    [InverseProperty("FapurchaseOrderContacts")]
    public virtual Facontact Facontact { get; set; }

    [ForeignKey("FapurchaseOrderId")]
    [InverseProperty("FapurchaseOrderContacts")]
    public virtual FapurchaseOrder FapurchaseOrder { get; set; }
}
