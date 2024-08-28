using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMMergeBOMChangeItemMaterialBOMLogs")]
public partial class MmmergeBomchangeItemMaterialBomlog
{
    [Key]
    [Column("MMMergeBOMChangeItemMaterialBOMLogID")]
    public int MmmergeBomchangeItemMaterialBomlogId { get; set; }

    [Column("FK_MMMergeBOMChangeID")]
    public int? FkMmmergeBomchangeId { get; set; }

    [Column("ICProductItemMaterialLogID")]
    public int? IcproductItemMaterialLogId { get; set; }

    [Column("FK_MMProductionNormApproveLogID")]
    public int? FkMmproductionNormApproveLogId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("ICProductItemMaterialID")]
    public int? IcproductItemMaterialId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductCarcassID")]
    public int? FkIcproductCarcassId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductMaterialID")]
    public int? FkIcproductMaterialId { get; set; }

    [Column("ICProductItemMaterialLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemMaterialLength { get; set; }

    [Column("ICProductItemMaterialWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemMaterialWidth { get; set; }

    [Column("ICProductItemMaterialHeigth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemMaterialHeigth { get; set; }

    [Column("ICProductItemMaterialQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemMaterialQty { get; set; }

    [Column("ICProductItemMaterialWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemMaterialWoodQty { get; set; }

    [Column("ICProductItemMaterialDepreciationRate", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemMaterialDepreciationRate { get; set; }

    [Column("ICProductItemMaterialDepreciationQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductItemMaterialDepreciationQty { get; set; }

    [Column("MMMergeBOMChangeActionType")]
    [StringLength(50)]
    public string MmmergeBomchangeActionType { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmmergeBomchangeItemMaterialBomlogs")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmmergeBomchangeItemMaterialBomlogs")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmmergeBomchangeId")]
    [InverseProperty("MmmergeBomchangeItemMaterialBomlogs")]
    public virtual MmmergeBomchange FkMmmergeBomchange { get; set; }
}
