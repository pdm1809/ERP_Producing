using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARInvoiceShipments")]
public partial class ArinvoiceShipment
{
    [Key]
    [Column("ARInvoiceShipmentID")]
    public int ArinvoiceShipmentId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("FK_ICShipmentID")]
    public int? FkIcshipmentId { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArinvoiceShipments")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkIcshipmentId")]
    [InverseProperty("ArinvoiceShipments")]
    public virtual Icshipment FkIcshipment { get; set; }
}
