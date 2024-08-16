using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEquipmentTransferItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductId", "FkIcproductSerieId", Name = "Idx_ACEquipmentTransferItems")]
public partial class AcequipmentTransferItem
{
    [Key]
    [Column("ACEquipmentTransferItemID")]
    public int AcequipmentTransferItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_HRFromRoomID")]
    public int FkHrfromRoomId { get; set; }

    [Column("FK_HRToRoomID")]
    public int FkHrtoRoomId { get; set; }

    [Column("FK_ACDepreciationCostAccountID")]
    public int? FkAcdepreciationCostAccountId { get; set; }

    [Column("ICProductSerieNo")]
    [StringLength(50)]
    public string IcproductSerieNo { get; set; }

    [Column("ACEquipmentTransferItemQty", TypeName = "decimal(18, 5)")]
    public decimal? AcequipmentTransferItemQty { get; set; }

    [Column("ACEquipmentTransferItemUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? AcequipmentTransferItemUnitPrice { get; set; }

    [Column("ACEquipmentTransferItemDepreciatedAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcequipmentTransferItemDepreciatedAmount { get; set; }

    [Column("ACEquipmentTransferItemRemainedQty", TypeName = "decimal(18, 5)")]
    public decimal? AcequipmentTransferItemRemainedQty { get; set; }

    [Column("FK_ICEquipmentShipmentItemID")]
    public int? FkIcequipmentShipmentItemId { get; set; }

    [Column("FK_ACEquipmentTransferItemID")]
    public int? FkAcequipmentTransferItemId { get; set; }

    [Column("FK_ICProductIdentifiedEquipmentID")]
    public int? FkIcproductIdentifiedEquipmentId { get; set; }

    [Column("ACEquipmentTransferItemProductIdentifiedEquipmentNo")]
    [StringLength(50)]
    public string AcequipmentTransferItemProductIdentifiedEquipmentNo { get; set; }

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

    [Column("FK_ICModelID")]
    public int? FkIcmodelId { get; set; }

    [Column("FK_ICModelDetailID")]
    public int? FkIcmodelDetailId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRFromDepartmentID")]
    public int? FkHrfromDepartmentId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("ACEquipmentTransferItemType")]
    [StringLength(50)]
    public string AcequipmentTransferItemType { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcdepreciationCostAccountId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual Acaccount FkAcdepreciationCostAccount { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcequipmentTransferItemFkHrdepartments")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcequipmentTransferItemFkHrdepartmentRooms")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual HrdepartmentRoomGroup FkHrdepartmentRoomGroup { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHremployeeUserId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual Hremployee FkHremployeeUser { get; set; }

    [ForeignKey("FkHrfromDepartmentId")]
    [InverseProperty("AcequipmentTransferItemFkHrfromDepartments")]
    public virtual Hrdepartment FkHrfromDepartment { get; set; }

    [ForeignKey("FkHrfromRoomId")]
    [InverseProperty("AcequipmentTransferItemFkHrfromRooms")]
    public virtual HrdepartmentRoom FkHrfromRoom { get; set; }

    [ForeignKey("FkHrtoRoomId")]
    [InverseProperty("AcequipmentTransferItemFkHrtoRooms")]
    public virtual HrdepartmentRoom FkHrtoRoom { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcmodelId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual Icmodel FkIcmodel { get; set; }

    [ForeignKey("FkIcmodelDetailId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual IcmodelDetail FkIcmodelDetail { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductIdentifiedEquipmentId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual IcproductIdentifiedEquipment FkIcproductIdentifiedEquipment { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("AcequipmentTransferItems")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
