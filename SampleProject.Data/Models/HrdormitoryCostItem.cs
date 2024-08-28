using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDormitoryCostItems")]
public partial class HrdormitoryCostItem
{
    [Key]
    [Column("HRDormitoryCostItemID")]
    public int HrdormitoryCostItemId { get; set; }

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

    [Column("FK_HRDormitoryCostID")]
    public int FkHrdormitoryCostId { get; set; }

    [Column("FK_HRDormitoryID")]
    public int FkHrdormitoryId { get; set; }

    [Column("HRDormitoryCostItemDormitoryName")]
    [StringLength(50)]
    public string HrdormitoryCostItemDormitoryName { get; set; }

    [Column("HRDormitoryCostItemStartNumber", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemStartNumber { get; set; }

    [Column("HRDormitoryCostItemEndNumber", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemEndNumber { get; set; }

    [Column("HRDormitoryCostItemNumberElectricity", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemNumberElectricity { get; set; }

    [Column("HRDormitoryCostItemGarbageCost", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemGarbageCost { get; set; }

    [Column("HRDormitoryCostItemOrtherCost", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemOrtherCost { get; set; }

    [Column("HRDormitoryCostItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemTotalAmount { get; set; }

    [Column("HRDormitoryCostItemDormitoryCost", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemDormitoryCost { get; set; }

    [Column("HRDormitoryCostItemInternetCost", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemInternetCost { get; set; }

    [Column("HRDormitoryCostItemWaterStartNumber", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemWaterStartNumber { get; set; }

    [Column("HRDormitoryCostItemWaterEndNumber", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemWaterEndNumber { get; set; }

    [Column("HRDormitoryCostItemNumberWater", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemNumberWater { get; set; }

    [Column("HRDormitoryCostItemWaterCost", TypeName = "decimal(18, 5)")]
    public decimal? HrdormitoryCostItemWaterCost { get; set; }

    [ForeignKey("FkHrdormitoryId")]
    [InverseProperty("HrdormitoryCostItems")]
    public virtual Hrdormitory FkHrdormitory { get; set; }

    [ForeignKey("FkHrdormitoryCostId")]
    [InverseProperty("HrdormitoryCostItems")]
    public virtual HrdormitoryCost FkHrdormitoryCost { get; set; }
}
