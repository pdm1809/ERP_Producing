using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAssetTransferItems")]
public partial class AcassetTransferItem
{
    [Key]
    [Column("ACAssetTransferItemID")]
    public int AcassetTransferItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_ACAssetID")]
    public int FkAcassetId { get; set; }

    [Column("FK_HRFromRoomID")]
    public int FkHrfromRoomId { get; set; }

    [Column("FK_HRToRoomID")]
    public int FkHrtoRoomId { get; set; }

    [Column("FK_ACDepreciationCostAccountID")]
    public int? FkAcdepreciationCostAccountId { get; set; }

    [Column("ACAssetTransferItemQty", TypeName = "decimal(18, 5)")]
    public decimal? AcassetTransferItemQty { get; set; }

    [Column("ACAssetTransferItemDepreciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcassetTransferItemDepreciatedAmount { get; set; }

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

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_HRToDepartmentID")]
    public int? FkHrtoDepartmentId { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("AcassetTransferItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcassetTransferItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcdepreciationCostAccountId")]
    [InverseProperty("AcassetTransferItems")]
    public virtual Acaccount FkAcdepreciationCostAccount { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcassetTransferItems")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcassetTransferItems")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcassetTransferItemFkHrdepartments")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcassetTransferItemFkHrdepartmentRooms")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupId")]
    [InverseProperty("AcassetTransferItems")]
    public virtual HrdepartmentRoomGroup FkHrdepartmentRoomGroup { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("AcassetTransferItems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeUserId")]
    [InverseProperty("AcassetTransferItems")]
    public virtual Hremployee FkHremployeeUser { get; set; }

    [ForeignKey("FkHrfromRoomId")]
    [InverseProperty("AcassetTransferItemFkHrfromRooms")]
    public virtual HrdepartmentRoom FkHrfromRoom { get; set; }

    [ForeignKey("FkHrtoDepartmentId")]
    [InverseProperty("AcassetTransferItemFkHrtoDepartments")]
    public virtual Hrdepartment FkHrtoDepartment { get; set; }

    [ForeignKey("FkHrtoRoomId")]
    [InverseProperty("AcassetTransferItemFkHrtoRooms")]
    public virtual HrdepartmentRoom FkHrtoRoom { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("AcassetTransferItems")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("AcassetTransferItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
