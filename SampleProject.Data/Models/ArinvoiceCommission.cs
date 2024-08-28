using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARInvoiceCommissions")]
public partial class ArinvoiceCommission
{
    [Key]
    [Column("ARInvoiceCommissionID")]
    public int ArinvoiceCommissionId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARInvoiceID")]
    public int? FkArinvoiceId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARCommissionID")]
    public int? FkArcommissionId { get; set; }

    [Column("ACObjectAccessKey")]
    [StringLength(100)]
    public string AcobjectAccessKey { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARInvoiceCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceCommissionPercent { get; set; }

    [Column("ARInvoiceCommissionAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceCommissionAmount { get; set; }

    [Column("ARInvoiceCommissionRate", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceCommissionRate { get; set; }

    [Column("ARInvoiceCommissionPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceCommissionPaidAmount { get; set; }

    [Column("ARInvoiceCommissionRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArinvoiceCommissionRemainAmount { get; set; }

    [Column("ACObjectName")]
    [StringLength(100)]
    public string AcobjectName { get; set; }

    [Column("ACObjectNo")]
    [StringLength(50)]
    public string AcobjectNo { get; set; }

    [ForeignKey("FkArcommissionId")]
    [InverseProperty("ArinvoiceCommissions")]
    public virtual Arcommission FkArcommission { get; set; }

    [ForeignKey("FkArinvoiceId")]
    [InverseProperty("ArinvoiceCommissions")]
    public virtual Arinvoice FkArinvoice { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArinvoiceCommissions")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }
}
