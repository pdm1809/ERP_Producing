using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACActualCostBudgetDetails")]
public partial class AcactualCostBudgetDetail
{
    [Key]
    [Column("ACActualCostBudgetDetailID")]
    public int AcactualCostBudgetDetailId { get; set; }

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

    [Column("FK_ACActualCostBudgetID")]
    public int FkAcactualCostBudgetId { get; set; }

    [Column("ACActualCostBudgetDetailFromDate", TypeName = "datetime")]
    public DateTime? AcactualCostBudgetDetailFromDate { get; set; }

    [Column("ACActualCostBudgetDetailToDate", TypeName = "datetime")]
    public DateTime? AcactualCostBudgetDetailToDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_ACCreditAccountID")]
    public int FkAccreditAccountId { get; set; }

    [Column("FK_ACDebitAccountID")]
    public int? FkAcdebitAccountId { get; set; }

    [Column("ACActualCostBudgetDetailAmount", TypeName = "decimal(18, 0)")]
    public decimal? AcactualCostBudgetDetailAmount { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("ACActualCostBudgetDetailExchangeRate", TypeName = "decimal(18, 0)")]
    public decimal? AcactualCostBudgetDetailExchangeRate { get; set; }

    [Column("ACActualCostBudgetDetailDocumentNo")]
    [StringLength(50)]
    public string AcactualCostBudgetDetailDocumentNo { get; set; }

    [Column("ACActualCostBudgetDetailModuleName")]
    [StringLength(50)]
    public string AcactualCostBudgetDetailModuleName { get; set; }

    [Column("ACActualCostBudgetDetailDate", TypeName = "datetime")]
    public DateTime? AcactualCostBudgetDetailDate { get; set; }

    [Column("ACActualCostBudgetDetailNo")]
    [StringLength(50)]
    public string AcactualCostBudgetDetailNo { get; set; }

    [Column("ACActualCostBudgetDetailType")]
    [StringLength(50)]
    public string AcactualCostBudgetDetailType { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [Column("ACActualCostBudgetDetailExchangeAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcactualCostBudgetDetailExchangeAmount { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_APInvoiceInID")]
    public int? FkApinvoiceInId { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    public string AcobjectType { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("FK_VMVehicleID")]
    public int? FkVmvehicleId { get; set; }

    [Column("FK_ACDocumentTypeID")]
    public int? FkAcdocumentTypeId { get; set; }

    [Column("ACActualCostBudgetDetailReference")]
    [StringLength(512)]
    public string AcactualCostBudgetDetailReference { get; set; }

    [Column("ACActualCostBudgetDetailOrder")]
    public int? AcactualCostBudgetDetailOrder { get; set; }

    [Column("FK_ARSellerID")]
    public int? FkArsellerId { get; set; }

    [ForeignKey("FkAcactualCostBudgetId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual AcactualCostBudget FkAcactualCostBudget { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAccreditAccountId")]
    [InverseProperty("AcactualCostBudgetDetailFkAccreditAccounts")]
    public virtual Acaccount FkAccreditAccount { get; set; }

    [ForeignKey("FkAcdebitAccountId")]
    [InverseProperty("AcactualCostBudgetDetailFkAcdebitAccounts")]
    public virtual Acaccount FkAcdebitAccount { get; set; }

    [ForeignKey("FkAcdocumentTypeId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual AcdocumentType FkAcdocumentType { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkApinvoiceInId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual ApinvoiceIn FkApinvoiceIn { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsellerId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual Arseller FkArseller { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual Gecurrency FkGecurrency { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("AcactualCostBudgetDetails")]
    public virtual Vmvehicle FkVmvehicle { get; set; }

    [InverseProperty("FkAcactualCostBudgetDetail")]
    public virtual ICollection<MmproductionCostGeneralCostAllocationCollectDocument> MmproductionCostGeneralCostAllocationCollectDocuments { get; set; } = new List<MmproductionCostGeneralCostAllocationCollectDocument>();
}
