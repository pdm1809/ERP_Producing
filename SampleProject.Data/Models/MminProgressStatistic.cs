using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMInProgressStatistics")]
public partial class MminProgressStatistic
{
    [Key]
    [Column("MMInProgressStatisticID")]
    public int MminProgressStatisticId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Required]
    [Column("MMInProgressStatisticNo")]
    [StringLength(50)]
    public string MminProgressStatisticNo { get; set; }

    [Column("MMInProgressStatisticDate", TypeName = "datetime")]
    public DateTime? MminProgressStatisticDate { get; set; }

    [Column("MMInProgressStatisticFromDate", TypeName = "datetime")]
    public DateTime? MminProgressStatisticFromDate { get; set; }

    [Column("MMInProgressStatisticToDate", TypeName = "datetime")]
    public DateTime? MminProgressStatisticToDate { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("MMInProgressStatisticDesc")]
    [StringLength(512)]
    public string MminProgressStatisticDesc { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("MMInProgressStatisticType")]
    [StringLength(50)]
    public string MminProgressStatisticType { get; set; }

    [Column("FK_MMProductionCostFormulaID")]
    public int FkMmproductionCostFormulaId { get; set; }

    [Column("MMProductionCostInProgressClassifyType")]
    [StringLength(100)]
    public string MmproductionCostInProgressClassifyType { get; set; }

    [Column("MMInProgressStatisticStatus")]
    [StringLength(50)]
    public string MminProgressStatisticStatus { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MminProgressStatistics")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("MminProgressStatistics")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MminProgressStatistics")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmproductionCostFormulaId")]
    [InverseProperty("MminProgressStatistics")]
    public virtual MmproductionCostFormula FkMmproductionCostFormula { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MminProgressStatistics")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkMminProgressStatistic")]
    public virtual ICollection<MminProgressStatisticDetail> MminProgressStatisticDetails { get; set; } = new List<MminProgressStatisticDetail>();
}
