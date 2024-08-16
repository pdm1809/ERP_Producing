using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICPromotions")]
[Microsoft.EntityFrameworkCore.Index("IcpromotionNo", "IcpromotionTypeCombo", Name = "Idx_ICPromotions")]
public partial class Icpromotion
{
    [Key]
    [Column("ICPromotionID")]
    public int IcpromotionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Required]
    [Column("ICPromotionNo")]
    [StringLength(50)]
    public string IcpromotionNo { get; set; }

    [Required]
    [Column("ICPromotionName")]
    [StringLength(100)]
    public string IcpromotionName { get; set; }

    [Column("ICPromotionDesc")]
    [StringLength(512)]
    public string IcpromotionDesc { get; set; }

    [Column("ICPromotionStartDate", TypeName = "datetime")]
    public DateTime? IcpromotionStartDate { get; set; }

    [Column("ICPromotionEndDate", TypeName = "datetime")]
    public DateTime? IcpromotionEndDate { get; set; }

    [Required]
    [Column("ICPromotionTypeCombo")]
    [StringLength(50)]
    public string IcpromotionTypeCombo { get; set; }

    [Column("ICPromotionDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? IcpromotionDiscountPercent { get; set; }

    [Column("ICPromotionDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? IcpromotionDiscountAmount { get; set; }

    [Column("ICPromotionDiscountQty", TypeName = "decimal(18, 5)")]
    public decimal? IcpromotionDiscountQty { get; set; }

    [Column("ICPromotionBuyX", TypeName = "decimal(18, 5)")]
    public decimal? IcpromotionBuyX { get; set; }

    [Column("ICPromotionTogetPctOff", TypeName = "decimal(18, 5)")]
    public decimal? IcpromotionTogetPctOff { get; set; }

    [Column("ICPromotionTogetAmtOff", TypeName = "decimal(18, 5)")]
    public decimal? IcpromotionTogetAmtOff { get; set; }

    [Column("ICPromotionMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcpromotionMatchCode01Combo { get; set; }

    [Column("ICPromotionMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcpromotionMatchCode02Combo { get; set; }

    [Column("ICPromotionMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcpromotionMatchCode03Combo { get; set; }

    [Column("ICPromotionMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcpromotionMatchCode04Combo { get; set; }

    [Column("ICPromotionMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcpromotionMatchCode05Combo { get; set; }

    [Column("ICPromotionMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcpromotionMatchCode06Combo { get; set; }

    [Column("ICPromotionMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcpromotionMatchCode07Combo { get; set; }

    [Column("ICPromotionMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcpromotionMatchCode08Combo { get; set; }

    [Column("ICPromotionMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcpromotionMatchCode09Combo { get; set; }

    [Column("ICPromotionMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcpromotionMatchCode10Combo { get; set; }

    [Required]
    [Column("ICPromotionActiveCheck")]
    public bool? IcpromotionActiveCheck { get; set; }

    [InverseProperty("FkIcpromotion")]
    public virtual ICollection<IcpromotionItem> IcpromotionItems { get; set; } = new List<IcpromotionItem>();
}
