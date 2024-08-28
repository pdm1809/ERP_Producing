using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjects")]
[Microsoft.EntityFrameworkCore.Index("PmprojectNo", "PmprojectDate", "PmprojectType", Name = "Idx_PMProjects")]
public partial class Pmproject
{
    [Key]
    [Column("PMProjectID")]
    public int PmprojectId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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
    [Column("PMProjectNo")]
    [StringLength(50)]
    public string PmprojectNo { get; set; }

    [Column("PMProjectName")]
    [StringLength(50)]
    public string PmprojectName { get; set; }

    [Column("PMProjectDesc")]
    [StringLength(255)]
    public string PmprojectDesc { get; set; }

    [Column("PMProjectRemark")]
    [StringLength(500)]
    public string PmprojectRemark { get; set; }

    [Column("PMProjectInfo", TypeName = "ntext")]
    public string PmprojectInfo { get; set; }

    [Column("PMProjectActiveCheck")]
    public bool? PmprojectActiveCheck { get; set; }

    [Column("PMProjectStartDate", TypeName = "datetime")]
    public DateTime? PmprojectStartDate { get; set; }

    [Column("PMProjectDate", TypeName = "datetime")]
    public DateTime? PmprojectDate { get; set; }

    [Column("PMProjectMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode01Combo { get; set; }

    [Column("PMProjectMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode02Combo { get; set; }

    [Column("PMProjectMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode03Combo { get; set; }

    [Column("PMProjectMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode04Combo { get; set; }

    [Column("PMProjectMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode05Combo { get; set; }

    [Column("PMProjectMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode06Combo { get; set; }

    [Column("PMProjectMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode07Combo { get; set; }

    [Column("PMProjectMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode08Combo { get; set; }

    [Column("PMProjectMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode09Combo { get; set; }

    [Column("PMProjectMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode10Combo { get; set; }

    [Column("PMProjectMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode11Combo { get; set; }

    [Column("PMProjectMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectMatchCode12Combo { get; set; }

    [Column("FK_PMProjectProfileID")]
    public int? FkPmprojectProfileId { get; set; }

    [Column("PMProjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectType { get; set; }

    [Column("PMProjectStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectStatus { get; set; }

    [Column("PMProjectEstimatedStartDate", TypeName = "datetime")]
    public DateTime? PmprojectEstimatedStartDate { get; set; }

    [Column("PMProjectActualStartDate", TypeName = "datetime")]
    public DateTime? PmprojectActualStartDate { get; set; }

    [Column("PMProjectEstimatedEndDate", TypeName = "datetime")]
    public DateTime? PmprojectEstimatedEndDate { get; set; }

    [Column("PMProjectActualEndDate", TypeName = "datetime")]
    public DateTime? PmprojectActualEndDate { get; set; }

    [Column("PMProjectEstimatedTotalDays")]
    public int? PmprojectEstimatedTotalDays { get; set; }

    [Column("PMProjectActualTotalDays")]
    public int? PmprojectActualTotalDays { get; set; }

    [Column("PMProjectEstimatedTotalHours")]
    public int? PmprojectEstimatedTotalHours { get; set; }

    [Column("PMProjectActualTotalHours")]
    public int? PmprojectActualTotalHours { get; set; }

    [Column("PMProjectEstimatedExtendDays")]
    public int? PmprojectEstimatedExtendDays { get; set; }

    [Column("PMProjectActualExtendDays")]
    public int? PmprojectActualExtendDays { get; set; }

    [Column("PMProjectEstimatedExtendHours")]
    public int? PmprojectEstimatedExtendHours { get; set; }

    [Column("PMProjectActualExtendHours")]
    public int? PmprojectActualExtendHours { get; set; }

    [Column("PMProjectEstimatedTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEstimatedTotalCost { get; set; }

    [Column("PMProjectActualTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectActualTotalCost { get; set; }

    [Column("FK_HRProjectOwnerEmployeeID")]
    public int? FkHrprojectOwnerEmployeeId { get; set; }

    [Column("PMProjectOwnerEmployeeName")]
    [StringLength(50)]
    public string PmprojectOwnerEmployeeName { get; set; }

    [Column("PMProjectOwnerEmployeeTel1")]
    [StringLength(50)]
    public string PmprojectOwnerEmployeeTel1 { get; set; }

    [Column("PMProjectOwnerEmployeeTel2")]
    [StringLength(50)]
    public string PmprojectOwnerEmployeeTel2 { get; set; }

    [Column("PMProjectOwnerEmployeeTel3")]
    [StringLength(50)]
    public string PmprojectOwnerEmployeeTel3 { get; set; }

    [Column("PMProjectOwnerEmployeeEmail")]
    [StringLength(50)]
    public string PmprojectOwnerEmployeeEmail { get; set; }

    [Column("PMProjectOwnerEmployeeFax")]
    [StringLength(50)]
    public string PmprojectOwnerEmployeeFax { get; set; }

    [Column("PMProjectOwnerEmployeeAddressStreet")]
    [StringLength(200)]
    public string PmprojectOwnerEmployeeAddressStreet { get; set; }

    [Column("PMProjectOwnerEmployeeAddressLine1")]
    [StringLength(200)]
    public string PmprojectOwnerEmployeeAddressLine1 { get; set; }

    [Column("PMProjectOwnerEmployeeAddressLine2")]
    [StringLength(200)]
    public string PmprojectOwnerEmployeeAddressLine2 { get; set; }

    [Column("PMProjectOwnerEmployeeAddressLine3")]
    [StringLength(200)]
    public string PmprojectOwnerEmployeeAddressLine3 { get; set; }

    [Column("PMProjectOwnerEmployeeAddressCity")]
    [StringLength(50)]
    public string PmprojectOwnerEmployeeAddressCity { get; set; }

    [Column("PMProjectOwnerEmployeeAddressPostalCode")]
    [StringLength(50)]
    public string PmprojectOwnerEmployeeAddressPostalCode { get; set; }

    [Column("PMProjectOwnerEmployeeAddressStateProvince")]
    [StringLength(50)]
    public string PmprojectOwnerEmployeeAddressStateProvince { get; set; }

    [Column("PMProjectOwnerEmployeeAddressZipCode")]
    [StringLength(50)]
    public string PmprojectOwnerEmployeeAddressZipCode { get; set; }

    [Column("PMProjectOwnerEmployeeAddressCountry")]
    [StringLength(50)]
    public string PmprojectOwnerEmployeeAddressCountry { get; set; }

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_PMProjectTypeID")]
    public int? FkPmprojectTypeId { get; set; }

    [Column("PMProjectIntrodurePerson")]
    [StringLength(256)]
    public string PmprojectIntrodurePerson { get; set; }

    [Column("PMProjectAddress")]
    [StringLength(512)]
    public string PmprojectAddress { get; set; }

    [Column("FK_GELocationID")]
    public int? FkGelocationId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_GEStateProvinceID")]
    public int? FkGestateProvinceId { get; set; }

    [Column("FK_GEDistrictID")]
    public int? FkGedistrictId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("PMProjectPriority")]
    [StringLength(50)]
    public string PmprojectPriority { get; set; }

    [Column("FK_ARProspectCustomerID")]
    public int? FkArprospectCustomerId { get; set; }

    [Column("PMProjectAgreementNo")]
    [StringLength(50)]
    public string PmprojectAgreementNo { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("PMObjectType")]
    [StringLength(50)]
    public string PmobjectType { get; set; }

    [Column("FK_ACAssObjectID")]
    public int? FkAcassObjectId { get; set; }

    [Column("PMAssObjectType")]
    [StringLength(50)]
    public string PmassObjectType { get; set; }

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcallocationCostObjectTran> AcallocationCostObjectTrans { get; set; } = new List<AcallocationCostObjectTran>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcallocationEquipmentTran> AcallocationEquipmentTrans { get; set; } = new List<AcallocationEquipmentTran>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItems { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcbankTransaction> AcbankTransactions { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AccostObjectItem> AccostObjectItems { get; set; } = new List<AccostObjectItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AccostObject> AccostObjects { get; set; } = new List<AccostObject>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcdepreciationAssetTran> AcdepreciationAssetTrans { get; set; } = new List<AcdepreciationAssetTran>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntries { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<Acdocument> Acdocuments { get; set; } = new List<Acdocument>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcendingAllocationDeclarationItemReceife> AcendingAllocationDeclarationItemReceives { get; set; } = new List<AcendingAllocationDeclarationItemReceife>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcendingAllocationDeclarationItem> AcendingAllocationDeclarationItems { get; set; } = new List<AcendingAllocationDeclarationItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcloanAgreement> AcloanAgreements { get; set; } = new List<AcloanAgreement>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcloanReceipt> AcloanReceipts { get; set; } = new List<AcloanReceipt>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AcsalaryCalculationDetail> AcsalaryCalculationDetails { get; set; } = new List<AcsalaryCalculationDetail>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ApcancelPurchaseOrderItem> ApcancelPurchaseOrderItems { get; set; } = new List<ApcancelPurchaseOrderItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceIns { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AppaymentProposal> AppaymentProposals { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItems { get; set; } = new List<AppaymentVoucherItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AppaymentVoucher> AppaymentVouchers { get; set; } = new List<AppaymentVoucher>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<Approposal> Approposals { get; set; } = new List<Approposal>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AppurchaseContract> AppurchaseContracts { get; set; } = new List<AppurchaseContract>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ApreturnSupplierItem> ApreturnSupplierItems { get; set; } = new List<ApreturnSupplierItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPayments { get; set; } = new List<ApsupplierPayment>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<Aracceptance> Aracceptances { get; set; } = new List<Aracceptance>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<Arallocation> Arallocations { get; set; } = new List<Arallocation>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ArcancelVoucher> ArcancelVouchers { get; set; } = new List<ArcancelVoucher>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ArcanceledDeliveryPlan> ArcanceledDeliveryPlans { get; set; } = new List<ArcanceledDeliveryPlan>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ArcustomerPayment> ArcustomerPayments { get; set; } = new List<ArcustomerPayment>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ArdeliveryPlan> ArdeliveryPlans { get; set; } = new List<ArdeliveryPlan>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ArestimateItem> ArestimateItems { get; set; } = new List<ArestimateItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<Arestimate> Arestimates { get; set; } = new List<Arestimate>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<Arinvoice> Arinvoices { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposals { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ArreceiptVoucher> ArreceiptVouchers { get; set; } = new List<ArreceiptVoucher>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ArsaleContract> ArsaleContracts { get; set; } = new List<ArsaleContract>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<ArsaleReturn> ArsaleReturns { get; set; } = new List<ArsaleReturn>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("Pmprojects")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArprospectCustomerId")]
    [InverseProperty("Pmprojects")]
    public virtual ArprospectCustomer FkArprospectCustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Pmprojects")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGedistrictId")]
    [InverseProperty("Pmprojects")]
    public virtual Gedistrict FkGedistrict { get; set; }

    [ForeignKey("FkGelocationId")]
    [InverseProperty("Pmprojects")]
    public virtual Gelocation FkGelocation { get; set; }

    [ForeignKey("FkGestateProvinceId")]
    [InverseProperty("Pmprojects")]
    public virtual GestateProvince FkGestateProvince { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmprojectFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrprojectOwnerEmployeeId")]
    [InverseProperty("PmprojectFkHrprojectOwnerEmployees")]
    public virtual Hremployee FkHrprojectOwnerEmployee { get; set; }

    [ForeignKey("FkPmprojectProfileId")]
    [InverseProperty("Pmprojects")]
    public virtual PmprojectProfile FkPmprojectProfile { get; set; }

    [ForeignKey("FkPmprojectTypeId")]
    [InverseProperty("Pmprojects")]
    public virtual PmprojectType FkPmprojectType { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("Pmprojects")]
    public virtual Pmtemplate FkPmtemplate { get; set; }

    [InverseProperty("FkPmproject")]
    public virtual ICollection<HradvanceRefundItemInvoice> HradvanceRefundItemInvoices { get; set; } = new List<HradvanceRefundItemInvoice>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<HradvanceRefund> HradvanceRefunds { get; set; } = new List<HradvanceRefund>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<HradvanceRequest> HradvanceRequests { get; set; } = new List<HradvanceRequest>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<MmproductionCostCalculationAllocation> MmproductionCostCalculationAllocations { get; set; } = new List<MmproductionCostCalculationAllocation>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<MmproductionCostCalculationItem> MmproductionCostCalculationItems { get; set; } = new List<MmproductionCostCalculationItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<MmproductionCostCalculationPrice> MmproductionCostCalculationPrices { get; set; } = new List<MmproductionCostCalculationPrice>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmbuidingCommand> PmbuidingCommands { get; set; } = new List<PmbuidingCommand>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmbuidingProposal> PmbuidingProposals { get; set; } = new List<PmbuidingProposal>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmbuildingAllocation> PmbuildingAllocations { get; set; } = new List<PmbuildingAllocation>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmbuildingPlan> PmbuildingPlans { get; set; } = new List<PmbuildingPlan>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmprojectBidsProfile> PmprojectBidsProfiles { get; set; } = new List<PmprojectBidsProfile>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmprojectContact> PmprojectContacts { get; set; } = new List<PmprojectContact>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmprojectLocation> PmprojectLocations { get; set; } = new List<PmprojectLocation>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmprojectMaterialItem> PmprojectMaterialItems { get; set; } = new List<PmprojectMaterialItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmprojectNormHistory> PmprojectNormHistories { get; set; } = new List<PmprojectNormHistory>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmprojectNormItem> PmprojectNormItems { get; set; } = new List<PmprojectNormItem>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmprojectNormTask> PmprojectNormTasks { get; set; } = new List<PmprojectNormTask>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmprojectNorm> PmprojectNorms { get; set; } = new List<PmprojectNorm>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmprojectPhase> PmprojectPhases { get; set; } = new List<PmprojectPhase>();

    [InverseProperty("FkPmproject")]
    public virtual ICollection<PmprojectTemplateRelationship> PmprojectTemplateRelationships { get; set; } = new List<PmprojectTemplateRelationship>();
}
