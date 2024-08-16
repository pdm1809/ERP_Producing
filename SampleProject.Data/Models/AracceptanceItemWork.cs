using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARAcceptanceItemWorks")]
public partial class AracceptanceItemWork
{
    [Key]
    [Column("ARAcceptanceItemWorkID")]
    public int AracceptanceItemWorkId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARSaleOrderItemWorkID")]
    public int? FkArsaleOrderItemWorkId { get; set; }

    [Column("FK_ARAcceptanceID")]
    public int? FkAracceptanceId { get; set; }

    [Column("ARAcceptanceItemWorkProductNo")]
    [StringLength(50)]
    public string AracceptanceItemWorkProductNo { get; set; }

    [Column("ARAcceptanceItemWorkProductName")]
    [StringLength(256)]
    public string AracceptanceItemWorkProductName { get; set; }

    [Column("ARAcceptanceItemWorkProductDesc")]
    [StringLength(512)]
    public string AracceptanceItemWorkProductDesc { get; set; }

    [Column("ARAcceptanceItemWorkProductQty", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemWorkProductQty { get; set; }

    [Column("ARAcceptanceItemWorkProductType")]
    [StringLength(50)]
    public string AracceptanceItemWorkProductType { get; set; }

    [Column("ARAcceptanceItemWorkProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemWorkProductUnitPrice { get; set; }

    [Column("ARAcceptanceItemWorkTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemWorkTotalAmount { get; set; }

    [Column("ARAcceptanceItemWorkSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemWorkSubTotalAmount { get; set; }

    [Column("ARAcceptanceItemWorkProductChargeCheck")]
    public bool? AracceptanceItemWorkProductChargeCheck { get; set; }

    [Column("ARAcceptanceItemWorkStatus")]
    [StringLength(50)]
    public string AracceptanceItemWorkStatus { get; set; }

    [Column("ARAcceptanceItemWorkIsCost")]
    public bool? AracceptanceItemWorkIsCost { get; set; }

    [Column("ARAcceptanceItemWorkParentID")]
    public int? AracceptanceItemWorkParentId { get; set; }

    [Column("ARAcceptanceItemWorkComment")]
    [StringLength(256)]
    public string AracceptanceItemWorkComment { get; set; }

    [Column("ARAcceptanceItemWorkDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemWorkDiscountAmount { get; set; }

    [Column("ARAcceptanceItemWorkDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemWorkDiscountPercent { get; set; }

    [Column("ARAcceptanceItemWorkTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemWorkTaxAmount { get; set; }

    [Column("ARAcceptanceItemWorkTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceItemWorkTaxPercent { get; set; }

    [InverseProperty("FkAracceptanceItemWork")]
    public virtual ICollection<ArinvoiceItemWork> ArinvoiceItemWorks { get; set; } = new List<ArinvoiceItemWork>();

    [ForeignKey("FkAracceptanceId")]
    [InverseProperty("AracceptanceItemWorks")]
    public virtual Aracceptance FkAracceptance { get; set; }

    [ForeignKey("FkArsaleOrderItemWorkId")]
    [InverseProperty("AracceptanceItemWorks")]
    public virtual ArsaleOrderItemWork FkArsaleOrderItemWork { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("AracceptanceItemWorks")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("AracceptanceItemWorks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AracceptanceItemWorks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("AracceptanceItemWorks")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
