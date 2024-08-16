using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMSemiProductIngredientItems")]
public partial class MmsemiProductIngredientItem
{
    [Key]
    [Column("MMSemiProductIngredientItemID")]
    public int MmsemiProductIngredientItemId { get; set; }

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
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_MMProductionCostID")]
    public int FkMmproductionCostId { get; set; }

    [Column("FK_MMSemiProductIngredientID")]
    public int FkMmsemiProductIngredientId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_MMProductionCostIngredientCostID")]
    public int? FkMmproductionCostIngredientCostId { get; set; }

    [Required]
    [Column("MMSemiProductIngredientItemProductNo")]
    [StringLength(50)]
    public string MmsemiProductIngredientItemProductNo { get; set; }

    [Column("MMSemiProductIngredientItemProductName")]
    [StringLength(100)]
    public string MmsemiProductIngredientItemProductName { get; set; }

    [Column("MMSemiProductIngredientItemProductDesc")]
    [StringLength(512)]
    public string MmsemiProductIngredientItemProductDesc { get; set; }

    [Column("MMSemiProductIngredientItemComment")]
    [StringLength(512)]
    public string MmsemiProductIngredientItemComment { get; set; }

    [Column("MMSemiProductIngredientItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmsemiProductIngredientItemProductQty { get; set; }

    [Column("MMSemiProductIngredientItemProductWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmsemiProductIngredientItemProductWoodQty { get; set; }

    [Column("MMSemiProductIngredientItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmsemiProductIngredientItemProductUnitPrice { get; set; }

    [Column("MMSemiProductIngredientItemProductTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? MmsemiProductIngredientItemProductTotalAmount { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmsemiProductIngredientItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmsemiProductIngredientItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmsemiProductIngredientItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmsemiProductIngredientItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmsemiProductIngredientItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmsemiProductIngredientItems")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }

    [ForeignKey("FkMmsemiProductIngredientId")]
    [InverseProperty("MmsemiProductIngredientItems")]
    public virtual MmsemiProductIngredient FkMmsemiProductIngredient { get; set; }
}
