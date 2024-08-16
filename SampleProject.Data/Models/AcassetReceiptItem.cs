using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAssetReceiptItems")]
[Microsoft.EntityFrameworkCore.Index("FkAcassetReceiptId", Name = "Idx_ACAssetReceiptItems")]
public partial class AcassetReceiptItem
{
    [Key]
    [Column("ACAssetReceiptItemID")]
    public int AcassetReceiptItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACAssetReceiptID")]
    public int FkAcassetReceiptId { get; set; }

    [Column("FK_ACAssetID")]
    public int FkAcassetId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int FkHrdepartmentRoomId { get; set; }

    [Column("ACAssetReceiptItemUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptItemUnitCost { get; set; }

    [Column("ACAssetReceiptItemQty", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptItemQty { get; set; }

    [Column("ACAssetReceiptItemExtCost", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptItemExtCost { get; set; }

    [Column("ACAssetReceiptItemDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptItemDiscountPercent { get; set; }

    [Column("ACAssetReceiptItemDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptItemDiscountAmount { get; set; }

    [Column("ACAssetReceiptItemTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptItemTaxPercent { get; set; }

    [Column("ACAssetReceiptItemTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptItemTaxAmount { get; set; }

    [Column("ACAssetReceiptItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptItemTotalCost { get; set; }

    [Column("ACAssetReceiptItemOriginalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptItemOriginalAmount { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_HRDepartmentRoomGroupID")]
    public int? FkHrdepartmentRoomGroupId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_HREmployeeUserID")]
    public int? FkHremployeeUserId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ACAssetReceiptItemProductDesc")]
    [StringLength(512)]
    public string AcassetReceiptItemProductDesc { get; set; }

    [Column("ACAssetReceiptItemProductName")]
    [StringLength(256)]
    public string AcassetReceiptItemProductName { get; set; }

    [Column("FK_ACUnfinishedConstructionCostID")]
    public int? FkAcunfinishedConstructionCostId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ICProductName")]
    [StringLength(500)]
    public string IcproductName { get; set; }

    [Column("ACAssetReceiptItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? AcassetReceiptItemProductUnitCost { get; set; }

    [Column("ACAssetReceiptItemProductSerialNo")]
    [StringLength(50)]
    public string AcassetReceiptItemProductSerialNo { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkAcassetReceiptId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual AcassetReceipt FkAcassetReceipt { get; set; }

    [ForeignKey("FkAcunfinishedConstructionCostId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual AcunfinishedConstructionCost FkAcunfinishedConstructionCost { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual HrdepartmentRoomGroup FkHrdepartmentRoomGroup { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeUserId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual Hremployee FkHremployeeUser { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("AcassetReceiptItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
