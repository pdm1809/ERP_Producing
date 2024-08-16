using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRBonusSaleItems")]
public partial class HrbonusSaleItem
{
    [Key]
    [Column("HRBonusSaleItemID")]
    public int HrbonusSaleItemId { get; set; }

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

    [Column("FK_HRBonusSaleID")]
    public int FkHrbonusSaleId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HREmployeeID2")]
    public int? FkHremployeeId2 { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("HRBonusSaleItemCardNumber")]
    [StringLength(200)]
    public string HrbonusSaleItemCardNumber { get; set; }

    [Column("HRBonusSaleItemDesc")]
    [StringLength(500)]
    public string HrbonusSaleItemDesc { get; set; }

    [Column("HRBonusSaleItemAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemAmount { get; set; }

    [Column("HRBonusSaleItemWorkingQty", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemWorkingQty { get; set; }

    [Column("HRBonusSaleItemDSBHNoVAT", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemDsbhnoVat { get; set; }

    [Column("HRBonusSaleItemVAT", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemVat { get; set; }

    [Column("HRBonusSaleItemAllowanceTT", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemAllowanceTt { get; set; }

    [Column("HRBonusSaleItemAllowanceCN", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemAllowanceCn { get; set; }

    [Column("HRBonusSaleItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemTotalAmount { get; set; }

    [Column("HRBonusSaleItemLevelAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemLevelAllowance { get; set; }

    [Column("HRBonusSaleItemAmountBonusSale", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemAmountBonusSale { get; set; }

    [Column("HRBonusSaleItemAmountBonusSaleTT", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemAmountBonusSaleTt { get; set; }

    [Column("HRBonusSaleItemAmountBonusSaleCN", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemAmountBonusSaleCn { get; set; }

    [Column("HRBonusSaleItemPercentageRetained", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemPercentageRetained { get; set; }

    [Column("HRBonusSaleItemPercentageRetainedType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrbonusSaleItemPercentageRetainedType { get; set; }

    [Column("HRBonusSaleItemBonusReachTarget", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemBonusReachTarget { get; set; }

    [Column("HRBonusSaleItemBonusBeyondTarget", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemBonusBeyondTarget { get; set; }

    [Column("HRBonusSaleItemMonthlyBonus", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemMonthlyBonus { get; set; }

    [Column("HRBonusSaleItemTarget", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemTarget { get; set; }

    [Column("HRBonusSaleItemManagementSalesAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemManagementSalesAmount { get; set; }

    [Column("HRBonusSaleItemRetainedAmount", TypeName = "decimal(18, 5)")]
    public decimal? HrbonusSaleItemRetainedAmount { get; set; }

    [ForeignKey("FkHrbonusSaleId")]
    [InverseProperty("HrbonusSaleItems")]
    public virtual HrbonusSale FkHrbonusSale { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrbonusSaleItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HrbonusSaleItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrbonusSaleItemFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeId2")]
    [InverseProperty("HrbonusSaleItemFkHremployeeId2Navigations")]
    public virtual Hremployee FkHremployeeId2Navigation { get; set; }
}
