using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductItemGeneralPlans")]
public partial class MmbatchProductItemGeneralPlan
{
    [Key]
    [Column("MMBatchProductItemGeneralPlanID")]
    public int MmbatchProductItemGeneralPlanId { get; set; }

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
    public string Aastatus { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMBatchProductItemGeneralPlanDate", TypeName = "datetime")]
    public DateTime? MmbatchProductItemGeneralPlanDate { get; set; }

    [Column("MMBatchProductItemGeneralPlanExcuteTime", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemGeneralPlanExcuteTime { get; set; }

    [Column("MMBatchProductItemGeneralPlanQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemGeneralPlanQty { get; set; }

    [Column("MMProductGroupTypeSwitching")]
    [StringLength(50)]
    public string MmproductGroupTypeSwitching { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("MMProductGroupType")]
    [StringLength(50)]
    public string MmproductGroupType { get; set; }

    [Column("MMBatchProductItemGeneralPlanSwitchingQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemGeneralPlanSwitchingQty { get; set; }

    [Column("MMProductGroupTypeSwitchingPercent", TypeName = "decimal(18, 5)")]
    public decimal? MmproductGroupTypeSwitchingPercent { get; set; }

    [Column("MMBatchProductItemGeneralPlanSwitchingRate", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductItemGeneralPlanSwitchingRate { get; set; }

    [Column("MMBatchProductItemGeneralPlanIndex")]
    [StringLength(50)]
    public string MmbatchProductItemGeneralPlanIndex { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbatchProductItemGeneralPlans")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmbatchProductItemGeneralPlans")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmbatchProductItemGeneralPlans")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
