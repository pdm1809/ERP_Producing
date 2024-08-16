using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMSemiProductIngredients")]
public partial class MmsemiProductIngredient
{
    [Key]
    [Column("MMSemiProductIngredientID")]
    public int MmsemiProductIngredientId { get; set; }

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

    [Column("FK_MMBatchProductID")]
    public int FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Required]
    [Column("MMSemiProductIngredientNo")]
    [StringLength(50)]
    public string MmsemiProductIngredientNo { get; set; }

    [Column("MMSemiProductIngredientName")]
    [StringLength(100)]
    public string MmsemiProductIngredientName { get; set; }

    [Column("MMSemiProductIngredientDesc")]
    [StringLength(512)]
    public string MmsemiProductIngredientDesc { get; set; }

    [Column("MMSemiProductIngredientComment")]
    [StringLength(512)]
    public string MmsemiProductIngredientComment { get; set; }

    [Column("MMSemiProductIngredientDate", TypeName = "datetime")]
    public DateTime MmsemiProductIngredientDate { get; set; }

    [Column("MMSemiProductIngredientType")]
    [StringLength(100)]
    [Unicode(false)]
    public string MmsemiProductIngredientType { get; set; }

    [Column("MMSemiProductIngredientStatus")]
    [StringLength(50)]
    public string MmsemiProductIngredientStatus { get; set; }

    [Column("MMSemiProductIngredientTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? MmsemiProductIngredientTotalAmount { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmsemiProductIngredients")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmsemiProductIngredients")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmsemiProductIngredients")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }

    [InverseProperty("FkMmsemiProductIngredient")]
    public virtual ICollection<MmsemiProductIngredientItem> MmsemiProductIngredientItems { get; set; } = new List<MmsemiProductIngredientItem>();
}
