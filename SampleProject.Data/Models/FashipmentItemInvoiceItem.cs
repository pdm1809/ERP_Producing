using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAShipmentItemInvoiceItems")]
public partial class FashipmentItemInvoiceItem
{
    [Key]
    [Column("FAShipmentItemInvoiceItemID")]
    public int FashipmentItemInvoiceItemId { get; set; }

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

    [Column("FAInvoiceItemID")]
    public int? FainvoiceItemId { get; set; }

    [Column("FAShipmentItemID")]
    public int? FashipmentItemId { get; set; }

    [ForeignKey("FashipmentItemId")]
    [InverseProperty("FashipmentItemInvoiceItems")]
    public virtual IcshipmentItem FashipmentItem { get; set; }
}
