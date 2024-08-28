using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARCommissions")]
public partial class Arcommission
{
    [Key]
    [Column("ARCommissionID")]
    public int ArcommissionId { get; set; }

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

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("ACObjectAccessKey")]
    [StringLength(100)]
    public string AcobjectAccessKey { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    public string ArobjectType { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArcommissionPercent { get; set; }

    [Column("ARCommissionAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcommissionAmount { get; set; }

    [Column("ARCommissionRate", TypeName = "decimal(18, 5)")]
    public decimal? ArcommissionRate { get; set; }

    [Column("ARCommissionPaidAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcommissionPaidAmount { get; set; }

    [Column("ARCommissionRemainAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArcommissionRemainAmount { get; set; }

    [Column("ACObjectNo")]
    [StringLength(50)]
    public string AcobjectNo { get; set; }

    [Column("ACObjectName")]
    [StringLength(100)]
    public string AcobjectName { get; set; }

    [Column("ARCommissionType")]
    [StringLength(100)]
    public string ArcommissionType { get; set; }

    [Column("ARCommissionDesc")]
    [StringLength(512)]
    public string ArcommissionDesc { get; set; }

    [InverseProperty("FkArcommission")]
    public virtual ICollection<ArinvoiceCommission> ArinvoiceCommissions { get; set; } = new List<ArinvoiceCommission>();

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("Arcommissions")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }
}
