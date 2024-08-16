using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAssetShipmentItems")]
public partial class AcassetShipmentItem
{
    [Key]
    [Column("ACAssetShipmentItemID")]
    public int AcassetShipmentItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_ACAssetID")]
    public int FkAcassetId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int FkHrdepartmentRoomId { get; set; }

    [Column("ACAssetShipmentItemQty", TypeName = "decimal(18, 5)")]
    public decimal? AcassetShipmentItemQty { get; set; }

    [Column("ACAssetShipmentItemDepreciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetShipmentItemDepreciatedAmount { get; set; }

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

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("FK_ACDepreciationAccountID")]
    public int? FkAcdepreciationAccountId { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("AcassetShipmentItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcassetShipmentItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcassetShipmentItems")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcassetShipmentItems")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcassetShipmentItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcassetShipmentItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupId")]
    [InverseProperty("AcassetShipmentItems")]
    public virtual HrdepartmentRoomGroup FkHrdepartmentRoomGroup { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("AcassetShipmentItems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeUserId")]
    [InverseProperty("AcassetShipmentItems")]
    public virtual Hremployee FkHremployeeUser { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("AcassetShipmentItems")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("AcassetShipmentItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
