using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARInvoiceItemShipmentItems")]
public partial class ArinvoiceItemShipmentItem
{
    [Key]
    [Column("ARInvoiceItemShipmentItemID")]
    public int ArinvoiceItemShipmentItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARInvoiceItemID")]
    public int? FkArinvoiceItemId { get; set; }

    [Column("FK_ICShipmentItemID")]
    public int? FkIcshipmentItemId { get; set; }

    [ForeignKey("FkArinvoiceItemId")]
    [InverseProperty("ArinvoiceItemShipmentItems")]
    public virtual ArinvoiceItem FkArinvoiceItem { get; set; }

    [ForeignKey("FkIcshipmentItemId")]
    [InverseProperty("ArinvoiceItemShipmentItems")]
    public virtual IcshipmentItem FkIcshipmentItem { get; set; }
}
