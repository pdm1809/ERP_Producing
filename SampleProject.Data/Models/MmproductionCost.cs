using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCosts")]
public partial class MmproductionCost
{
    [Key]
    [Column("MMProductionCostID")]
    public int MmproductionCostId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("MMProductionCostNo")]
    [StringLength(50)]
    public string MmproductionCostNo { get; set; }

    [Column("MMProductionCostName")]
    [StringLength(100)]
    public string MmproductionCostName { get; set; }

    [Column("MMProductionCostDesc")]
    [StringLength(512)]
    public string MmproductionCostDesc { get; set; }

    [Column("MMProductionCostFromDate", TypeName = "datetime")]
    public DateTime? MmproductionCostFromDate { get; set; }

    [Column("MMProductionCostToDate", TypeName = "datetime")]
    public DateTime? MmproductionCostToDate { get; set; }

    [Column("MMProductionCostStatus")]
    [StringLength(50)]
    public string MmproductionCostStatus { get; set; }

    [Column("MMProductionCostType")]
    [StringLength(50)]
    public string MmproductionCostType { get; set; }

    [Column("MMProductionCostWoodQtyPhoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodQtyPhoi { get; set; }

    [Column("MMProductionCostWoodQtySoChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodQtySoChe { get; set; }

    [Column("MMProductionCostWoodQtyTinhChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodQtyTinhChe { get; set; }

    [Column("MMProductionCostWoodQtyLapRap", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodQtyLapRap { get; set; }

    [Column("MMProductionCostWoodQtySon", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodQtySon { get; set; }

    [Column("MMProductionCostWoodQtyDongGoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodQtyDongGoi { get; set; }

    [Column("MMProductionCostWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodQty { get; set; }

    [Column("MMProductionCostWoodFeePhoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodFeePhoi { get; set; }

    [Column("MMProductionCostHardwareFeePhoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostHardwareFeePhoi { get; set; }

    [Column("MMProductionCostPaintFeePhoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPaintFeePhoi { get; set; }

    [Column("MMProductionCostPackagingFeePhoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPackagingFeePhoi { get; set; }

    [Column("MMProductionCostElecFeePhoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostElecFeePhoi { get; set; }

    [Column("MMProductionCostDepreciationFeePhoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostDepreciationFeePhoi { get; set; }

    [Column("MMProductionCostOtherFeePhoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOtherFeePhoi { get; set; }

    [Column("MMProductionCostWoodFeeSoChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodFeeSoChe { get; set; }

    [Column("MMProductionCostHardwareFeeSoChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostHardwareFeeSoChe { get; set; }

    [Column("MMProductionCostPaintFeeSoChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPaintFeeSoChe { get; set; }

    [Column("MMProductionCostPackagingFeeSoChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPackagingFeeSoChe { get; set; }

    [Column("MMProductionCostElecFeeSoChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostElecFeeSoChe { get; set; }

    [Column("MMProductionCostDepreciationFeeSoChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostDepreciationFeeSoChe { get; set; }

    [Column("MMProductionCostOtherFeeSoChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOtherFeeSoChe { get; set; }

    [Column("MMProductionCostWoodFeeTinhChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodFeeTinhChe { get; set; }

    [Column("MMProductionCostHardwareFeeTinhChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostHardwareFeeTinhChe { get; set; }

    [Column("MMProductionCostPaintFeeTinhChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPaintFeeTinhChe { get; set; }

    [Column("MMProductionCostPackagingFeeTinhChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPackagingFeeTinhChe { get; set; }

    [Column("MMProductionCostElecFeeTinhChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostElecFeeTinhChe { get; set; }

    [Column("MMProductionCostDepreciationFeeTinhChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostDepreciationFeeTinhChe { get; set; }

    [Column("MMProductionCostOtherFeeTinhChe", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOtherFeeTinhChe { get; set; }

    [Column("MMProductionCostWoodFeeLapRap", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodFeeLapRap { get; set; }

    [Column("MMProductionCostHardwareFeeLapRap", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostHardwareFeeLapRap { get; set; }

    [Column("MMProductionCostPaintFeeLapRap", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPaintFeeLapRap { get; set; }

    [Column("MMProductionCostPackagingFeeLapRap", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPackagingFeeLapRap { get; set; }

    [Column("MMProductionCostElecFeeLapRap", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostElecFeeLapRap { get; set; }

    [Column("MMProductionCostDepreciationFeeLapRap", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostDepreciationFeeLapRap { get; set; }

    [Column("MMProductionCostOtherFeeLapRap", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOtherFeeLapRap { get; set; }

    [Column("MMProductionCostWoodFeeSon", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodFeeSon { get; set; }

    [Column("MMProductionCostHardwareFeeSon", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostHardwareFeeSon { get; set; }

    [Column("MMProductionCostPaintFeeSon", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPaintFeeSon { get; set; }

    [Column("MMProductionCostPackagingFeeSon", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPackagingFeeSon { get; set; }

    [Column("MMProductionCostElecFeeSon", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostElecFeeSon { get; set; }

    [Column("MMProductionCostDepreciationFeeSon", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostDepreciationFeeSon { get; set; }

    [Column("MMProductionCostOtherFeeSon", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOtherFeeSon { get; set; }

    [Column("MMProductionCostWoodFeeDongGoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostWoodFeeDongGoi { get; set; }

    [Column("MMProductionCostHardwareFeeDongGoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostHardwareFeeDongGoi { get; set; }

    [Column("MMProductionCostPaintFeeDongGoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPaintFeeDongGoi { get; set; }

    [Column("MMProductionCostPackagingFeeDongGoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostPackagingFeeDongGoi { get; set; }

    [Column("MMProductionCostElecFeeDongGoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostElecFeeDongGoi { get; set; }

    [Column("MMProductionCostDepreciationFeeDongGoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostDepreciationFeeDongGoi { get; set; }

    [Column("MMProductionCostOtherFeeDongGoi", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOtherFeeDongGoi { get; set; }

    [Column("MMProductionCost6279FeeP", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCost6279FeeP { get; set; }

    [Column("MMProductionCost6279FeeSC", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCost6279FeeSc { get; set; }

    [Column("MMProductionCost6279FeeTC", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCost6279FeeTc { get; set; }

    [Column("MMProductionCost6279FeeS", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCost6279FeeS { get; set; }

    [Column("MMProductionCost6279FeeLR", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCost6279FeeLr { get; set; }

    [Column("MMProductionCost6279FeeDG", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCost6279FeeDg { get; set; }

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductPriceIncomplete> MmproductPriceIncompletes { get; set; } = new List<MmproductPriceIncomplete>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductPrice> MmproductPrices { get; set; } = new List<MmproductPrice>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCostDddg> MmproductionCostIngredientCostDddgs { get; set; } = new List<MmproductionCostIngredientCostDddg>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCostDdlr> MmproductionCostIngredientCostDdlrs { get; set; } = new List<MmproductionCostIngredientCostDdlr>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCostDd> MmproductionCostIngredientCostDds { get; set; } = new List<MmproductionCostIngredientCostDd>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCostDdsc> MmproductionCostIngredientCostDdscs { get; set; } = new List<MmproductionCostIngredientCostDdsc>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCostDdson> MmproductionCostIngredientCostDdsons { get; set; } = new List<MmproductionCostIngredientCostDdson>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCostDdtc> MmproductionCostIngredientCostDdtcs { get; set; } = new List<MmproductionCostIngredientCostDdtc>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCostDg> MmproductionCostIngredientCostDgs { get; set; } = new List<MmproductionCostIngredientCostDg>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCostLr> MmproductionCostIngredientCostLrs { get; set; } = new List<MmproductionCostIngredientCostLr>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCostSc> MmproductionCostIngredientCostScs { get; set; } = new List<MmproductionCostIngredientCostSc>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCostSon> MmproductionCostIngredientCostSons { get; set; } = new List<MmproductionCostIngredientCostSon>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCostTc> MmproductionCostIngredientCostTcs { get; set; } = new List<MmproductionCostIngredientCostTc>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostIngredientCost> MmproductionCostIngredientCosts { get; set; } = new List<MmproductionCostIngredientCost>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostItem> MmproductionCostItems { get; set; } = new List<MmproductionCostItem>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostOtherFee> MmproductionCostOtherFees { get; set; } = new List<MmproductionCostOtherFee>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmproductionCostOverall> MmproductionCostOveralls { get; set; } = new List<MmproductionCostOverall>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmsemiProductIngredientItem> MmsemiProductIngredientItems { get; set; } = new List<MmsemiProductIngredientItem>();

    [InverseProperty("FkMmproductionCost")]
    public virtual ICollection<MmsemiProductIngredient> MmsemiProductIngredients { get; set; } = new List<MmsemiProductIngredient>();
}
