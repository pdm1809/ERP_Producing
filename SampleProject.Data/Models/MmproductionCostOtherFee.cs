using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostOtherFees")]
public partial class MmproductionCostOtherFee
{
    [Key]
    [Column("MMProductionCostOtherFeeID")]
    public int MmproductionCostOtherFeeId { get; set; }

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
    [Column("MMProductionCostOtherFeeNo")]
    [StringLength(50)]
    public string MmproductionCostOtherFeeNo { get; set; }

    [Column("MMProductionCostOtherFeeName")]
    [StringLength(100)]
    public string MmproductionCostOtherFeeName { get; set; }

    [Column("MMProductionCostOtherFeeDesc")]
    [StringLength(512)]
    public string MmproductionCostOtherFeeDesc { get; set; }

    [Column("MMProductionCostOtherFeeFromDate", TypeName = "datetime")]
    public DateTime? MmproductionCostOtherFeeFromDate { get; set; }

    [Column("MMProductionCostOtherFeeToDate", TypeName = "datetime")]
    public DateTime? MmproductionCostOtherFeeToDate { get; set; }

    [Column("MMProductionCostOtherFeeStatus")]
    [StringLength(50)]
    public string MmproductionCostOtherFeeStatus { get; set; }

    [Column("MMProductionCostOtherFeeTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostOtherFeeTotalAmount { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMProductionCostID")]
    public int? FkMmproductionCostId { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmproductionCostOtherFees")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostOtherFees")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostOtherFees")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }
}
