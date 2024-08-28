using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARPriceSheetItemWorks")]
public partial class ArpriceSheetItemWork
{
    [Key]
    [Column("ARPriceSheetItemWorkID")]
    public int ArpriceSheetItemWorkId { get; set; }

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

    [Column("FK_ARPriceSheetItemID")]
    public int? FkArpriceSheetItemId { get; set; }

    [Column("FK_ARPriceSheetID")]
    public int? FkArpriceSheetId { get; set; }

    [Column("ARPriceSheetItemWorkProductNo")]
    [StringLength(50)]
    public string ArpriceSheetItemWorkProductNo { get; set; }

    [Column("ARPriceSheetItemWorkProductName")]
    [StringLength(256)]
    public string ArpriceSheetItemWorkProductName { get; set; }

    [Column("ARPriceSheetItemWorkProductDesc")]
    [StringLength(512)]
    public string ArpriceSheetItemWorkProductDesc { get; set; }

    [Column("ARPriceSheetItemWorkProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArpriceSheetItemWorkProductQty { get; set; }

    [Column("ARPriceSheetItemWorkProductType")]
    [StringLength(50)]
    public string ArpriceSheetItemWorkProductType { get; set; }

    [Column("ARPriceSheetItemWorkProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArpriceSheetItemWorkProductUnitPrice { get; set; }

    [Column("ARPriceSheetItemWorkTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpriceSheetItemWorkTotalAmount { get; set; }

    [Column("ARPriceSheetItemWorkSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpriceSheetItemWorkSubTotalAmount { get; set; }

    [Column("ARPriceSheetItemWorkProductChargeCheck")]
    public bool? ArpriceSheetItemWorkProductChargeCheck { get; set; }

    [Column("ARPriceSheetItemWorkStatus")]
    [StringLength(50)]
    public string ArpriceSheetItemWorkStatus { get; set; }

    [Column("ARPriceSheetItemWorkType")]
    [StringLength(50)]
    public string ArpriceSheetItemWorkType { get; set; }

    [Column("ARPriceSheetItemWorkParentID")]
    public int? ArpriceSheetItemWorkParentId { get; set; }

    [Column("ARPriceSheetItemWorkComment")]
    [StringLength(256)]
    public string ArpriceSheetItemWorkComment { get; set; }

    [Column("ARPriceSheetItemWorkDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArpriceSheetItemWorkDiscountAmount { get; set; }

    [Column("ARPriceSheetItemWorkDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? ArpriceSheetItemWorkDiscountPerCent { get; set; }

    [ForeignKey("FkArpriceSheetId")]
    [InverseProperty("ArpriceSheetItemWorks")]
    public virtual ArpriceSheet FkArpriceSheet { get; set; }

    [ForeignKey("FkArpriceSheetItemId")]
    [InverseProperty("ArpriceSheetItemWorks")]
    public virtual ArpriceSheetItem FkArpriceSheetItem { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArpriceSheetItemWorks")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArpriceSheetItemWorks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArpriceSheetItemWorks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArpriceSheetItemWorks")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }
}
