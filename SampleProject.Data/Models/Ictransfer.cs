using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICTransfers")]
[Microsoft.EntityFrameworkCore.Index("IctransferNo", "IctransferDate", "FkBrbranchId", "IctransferReference", "IctransferType", Name = "Idx_ICTransfers")]
public partial class Ictransfer
{
    [Key]
    [Column("ICTransferID")]
    public int IctransferId { get; set; }

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

    [Column("AAIsPrinted")]
    public bool? AaisPrinted { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICFromStockID")]
    public int FkIcfromStockId { get; set; }

    [Column("FK_ICToStockID")]
    public int FkIctoStockId { get; set; }

    [Column("FK_ICTransitStockID")]
    public int? FkIctransitStockId { get; set; }

    [Column("FK_ICTransferParentID")]
    public int? FkIctransferParentId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("ICTransferNo")]
    [StringLength(50)]
    public string IctransferNo { get; set; }

    [Column("ICTransferName")]
    [StringLength(100)]
    public string IctransferName { get; set; }

    [Column("ICTransferDesc")]
    [StringLength(512)]
    public string IctransferDesc { get; set; }

    [Column("ICTransferDate", TypeName = "datetime")]
    public DateTime? IctransferDate { get; set; }

    [Column("ICTransferExpiredDate", TypeName = "datetime")]
    public DateTime? IctransferExpiredDate { get; set; }

    [Column("ICTransferActiveCheck")]
    public bool? IctransferActiveCheck { get; set; }

    [Column("ICTransferReference")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferReference { get; set; }

    [Column("ICTransferType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferType { get; set; }

    [Column("ICTransferStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferStatus { get; set; }

    [Column("ICTransferMatchCode01Combo")]
    [StringLength(100)]
    public string IctransferMatchCode01Combo { get; set; }

    [Column("ICTransferMatchCode02Combo")]
    [StringLength(256)]
    public string IctransferMatchCode02Combo { get; set; }

    [Column("ICTransferMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferMatchCode03Combo { get; set; }

    [Column("ICTransferMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferMatchCode04Combo { get; set; }

    [Column("ICTransferMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferMatchCode05Combo { get; set; }

    [Column("ICTransferMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferMatchCode06Combo { get; set; }

    [Column("ICTransferMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferMatchCode07Combo { get; set; }

    [Column("ICTransferMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferMatchCode08Combo { get; set; }

    [Column("ICTransferMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferMatchCode09Combo { get; set; }

    [Column("ICTransferMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferMatchCode10Combo { get; set; }

    [Column("ICTransferMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferMatchCode11Combo { get; set; }

    [Column("ICTransferMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferMatchCode12Combo { get; set; }

    public bool? IsTransferred { get; set; }

    [Column("ICTransferTransferredDate", TypeName = "datetime")]
    public DateTime? IctransferTransferredDate { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("ICTransferTransferType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferTransferType { get; set; }

    [Column("FK_APPurchaseOrderID")]
    public int? FkAppurchaseOrderId { get; set; }

    [Column("FK_HREmployeeReceverID")]
    public int? FkHremployeeReceverId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AcobjectType { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ICTransferExchangeRate", TypeName = "decimal(18, 5)")]
    public decimal? IctransferExchangeRate { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("ICTransferPostedStatus")]
    [StringLength(64)]
    public string IctransferPostedStatus { get; set; }

    [Column("STToolbarActionName")]
    [StringLength(256)]
    public string SttoolbarActionName { get; set; }

    [InverseProperty("FkIctransfer")]
    public virtual ICollection<ApfeePaymentTransfer> ApfeePaymentTransfers { get; set; } = new List<ApfeePaymentTransfer>();

    [InverseProperty("FkIctransfer")]
    public virtual ICollection<ArdeliveryPlanItem> ArdeliveryPlanItems { get; set; } = new List<ArdeliveryPlanItem>();

    [InverseProperty("FkIctransfer")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [InverseProperty("FkIctransfer")]
    public virtual ICollection<ArdeliveryPlanTruckPoint> ArdeliveryPlanTruckPoints { get; set; } = new List<ArdeliveryPlanTruckPoint>();

    [ForeignKey("FkAppurchaseOrderId")]
    [InverseProperty("Ictransfers")]
    public virtual AppurchaseOrder FkAppurchaseOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Ictransfers")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("Ictransfers")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Ictransfers")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Ictransfers")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IctransferFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeReceverId")]
    [InverseProperty("IctransferFkHremployeeRecevers")]
    public virtual Hremployee FkHremployeeRecever { get; set; }

    [ForeignKey("FkIcfromStockId")]
    [InverseProperty("IctransferFkIcfromStocks")]
    public virtual Icstock FkIcfromStock { get; set; }

    [ForeignKey("FkIctoStockId")]
    [InverseProperty("IctransferFkIctoStocks")]
    public virtual Icstock FkIctoStock { get; set; }

    [ForeignKey("FkIctransferParentId")]
    [InverseProperty("InverseFkIctransferParent")]
    public virtual Ictransfer FkIctransferParent { get; set; }

    [ForeignKey("FkIctransitStockId")]
    [InverseProperty("IctransferFkIctransitStocks")]
    public virtual Icstock FkIctransitStock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("Ictransfers")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [InverseProperty("FkIctransfer")]
    public virtual ICollection<IctransferItem> IctransferItems { get; set; } = new List<IctransferItem>();

    [InverseProperty("FkIctransferParent")]
    public virtual ICollection<Ictransfer> InverseFkIctransferParent { get; set; } = new List<Ictransfer>();
}
