using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployees")]
public partial class Hremployee
{
    [Key]
    [Column("HREmployeeID")]
    public int HremployeeId { get; set; }

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

    public bool? IsTransferred { get; set; }

    [Column("AATransferredDate", TypeName = "datetime")]
    public DateTime? AatransferredDate { get; set; }

    [Column("FK_HRDepartmentID")]
    public int FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Column("FK_HRTimeSheetScaleID")]
    public int? FkHrtimeSheetScaleId { get; set; }

    [Column("FK_BRBranchID")]
    public int FkBrbranchId { get; set; }

    [Required]
    [Column("HREmployeeNo")]
    [StringLength(50)]
    public string HremployeeNo { get; set; }

    [Column("HREmployeeName")]
    [StringLength(200)]
    public string HremployeeName { get; set; }

    [Column("HREmployeeGenderCombo")]
    [StringLength(50)]
    public string HremployeeGenderCombo { get; set; }

    [Column("HREmployeeDob", TypeName = "datetime")]
    public DateTime? HremployeeDob { get; set; }

    [Column("HREmployeeBirthPlace")]
    [StringLength(200)]
    public string HremployeeBirthPlace { get; set; }

    [Column("HREmployeeTypeCombo")]
    [StringLength(50)]
    public string HremployeeTypeCombo { get; set; }

    [Column("HREmployeeStatusCombo")]
    [StringLength(50)]
    public string HremployeeStatusCombo { get; set; }

    [Column("HREmployeeDesc")]
    [StringLength(255)]
    public string HremployeeDesc { get; set; }

    [Column("HREmployeePicture")]
    public byte[] HremployeePicture { get; set; }

    [Column("HREmployeeIDNumber")]
    [StringLength(50)]
    public string HremployeeIdnumber { get; set; }

    [Column("HREmployeeIDCardPlace")]
    [StringLength(150)]
    public string HremployeeIdcardPlace { get; set; }

    [Column("HREmployeeIDCardDate", TypeName = "datetime")]
    public DateTime? HremployeeIdcardDate { get; set; }

    [Column("HREmployeeCardNumber")]
    [StringLength(50)]
    public string HremployeeCardNumber { get; set; }

    [Column("HREmployeePassportNo")]
    [StringLength(50)]
    public string HremployeePassportNo { get; set; }

    [Column("HREmployeePassportIssuedDate", TypeName = "datetime")]
    public DateTime? HremployeePassportIssuedDate { get; set; }

    [Column("HREmployeePassportIssuedPlace", TypeName = "datetime")]
    public DateTime? HremployeePassportIssuedPlace { get; set; }

    [Column("HREmployeeSlrPmtMthdCombo")]
    [StringLength(50)]
    public string HremployeeSlrPmtMthdCombo { get; set; }

    [Column("HREmployeeWorkingSlrAmt", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeWorkingSlrAmt { get; set; }

    [Column("HREmployeeContractSlrAmt", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeContractSlrAmt { get; set; }

    [Column("HREmployeeReligion")]
    [StringLength(50)]
    public string HremployeeReligion { get; set; }

    [Column("HREmployeeTaxNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeTaxNumber { get; set; }

    [Column("HREmployeeActiveCheck")]
    public bool? HremployeeActiveCheck { get; set; }

    [Column("HREmployeeStartWorkingDate", TypeName = "datetime")]
    public DateTime? HremployeeStartWorkingDate { get; set; }

    [Column("HREmployeeEndWorkingDate", TypeName = "datetime")]
    public DateTime? HremployeeEndWorkingDate { get; set; }

    [Column("HREmployeeStartWorkingTime", TypeName = "datetime")]
    public DateTime? HremployeeStartWorkingTime { get; set; }

    [Column("HREmployeeEndWorkingTime", TypeName = "datetime")]
    public DateTime? HremployeeEndWorkingTime { get; set; }

    [Column("HREmployeeTel1")]
    [StringLength(50)]
    public string HremployeeTel1 { get; set; }

    [Column("HREmployeeTel2")]
    [StringLength(50)]
    public string HremployeeTel2 { get; set; }

    [Column("HREmployeeTel3")]
    [StringLength(50)]
    public string HremployeeTel3 { get; set; }

    [Column("HREmployeeEmail1")]
    [StringLength(50)]
    public string HremployeeEmail1 { get; set; }

    [Column("HREmployeePassword1")]
    [StringLength(50)]
    public string HremployeePassword1 { get; set; }

    [Column("HREmployeeEmail2")]
    [StringLength(50)]
    public string HremployeeEmail2 { get; set; }

    [Column("HREmployeeFax")]
    [StringLength(50)]
    public string HremployeeFax { get; set; }

    [Column("HREmployeeContactAddressStreet")]
    [StringLength(200)]
    public string HremployeeContactAddressStreet { get; set; }

    [Column("HREmployeeContactAddressLine1")]
    [StringLength(200)]
    public string HremployeeContactAddressLine1 { get; set; }

    [Column("HREmployeeContactAddressLine2")]
    [StringLength(200)]
    public string HremployeeContactAddressLine2 { get; set; }

    [Column("HREmployeeContactAddressLine3")]
    [StringLength(200)]
    public string HremployeeContactAddressLine3 { get; set; }

    [Column("HREmployeeContactAddressCity")]
    [StringLength(50)]
    public string HremployeeContactAddressCity { get; set; }

    [Column("HREmployeeContactAddressPostalCode")]
    [StringLength(50)]
    public string HremployeeContactAddressPostalCode { get; set; }

    [Column("HREmployeeContactAddressStateProvince")]
    [StringLength(50)]
    public string HremployeeContactAddressStateProvince { get; set; }

    [Column("HREmployeeContactAddressZipCode")]
    [StringLength(50)]
    public string HremployeeContactAddressZipCode { get; set; }

    [Column("HREmployeeContactAddressCountry")]
    [StringLength(50)]
    public string HremployeeContactAddressCountry { get; set; }

    [Column("HREmployeeBankCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeBankCode { get; set; }

    [Column("HREmployeeBankName")]
    [StringLength(50)]
    public string HremployeeBankName { get; set; }

    [Column("HREmployeeBankAccount1")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeBankAccount1 { get; set; }

    [Column("HREmployeeBankAccountCurrency1")]
    public int? HremployeeBankAccountCurrency1 { get; set; }

    [Column("HREmployeeBankAccount2")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeBankAccount2 { get; set; }

    [Column("HREmployeeBankAccountCurrency2")]
    public int? HremployeeBankAccountCurrency2 { get; set; }

    [Column("HREmployeeBankAccount3")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeBankAccount3 { get; set; }

    [Column("HREmployeeBankAccountCurrency3")]
    public int? HremployeeBankAccountCurrency3 { get; set; }

    [Column("HREmployeeBankAccount4")]
    [StringLength(50)]
    [Unicode(false)]
    public string HremployeeBankAccount4 { get; set; }

    [Column("HREmployeeBankAccountCurrency4")]
    public int? HremployeeBankAccountCurrency4 { get; set; }

    [Column("HRInsCalculatedSalaryType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrinsCalculatedSalaryType { get; set; }

    [Column("HREmployeeSocialInsNo")]
    [StringLength(50)]
    public string HremployeeSocialInsNo { get; set; }

    [Column("HREmployeeSocialInsRegisteredDate", TypeName = "datetime")]
    public DateTime? HremployeeSocialInsRegisteredDate { get; set; }

    [Column("HREmployeeSocialInsExpiryDate", TypeName = "datetime")]
    public DateTime? HremployeeSocialInsExpiryDate { get; set; }

    [Column("HREmployeeSocialInsPaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSocialInsPaymentPercent { get; set; }

    [Column("HREmployeeHealthInsNo")]
    [StringLength(50)]
    public string HremployeeHealthInsNo { get; set; }

    [Column("HREmployeeHealthInsRegisteredPlace")]
    [StringLength(50)]
    public string HremployeeHealthInsRegisteredPlace { get; set; }

    [Column("HREmployeeHealthInsRegisteredDate", TypeName = "datetime")]
    public DateTime? HremployeeHealthInsRegisteredDate { get; set; }

    [Column("HREmployeeHealthInsExpiryDate", TypeName = "datetime")]
    public DateTime? HremployeeHealthInsExpiryDate { get; set; }

    [Column("HREmployeeHealthInsPaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeHealthInsPaymentPercent { get; set; }

    [Column("HREmployeeOutOfWorkInsPaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeOutOfWorkInsPaymentPercent { get; set; }

    [Column("HREmployeeSyndicatePaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSyndicatePaymentPercent { get; set; }

    [Column("HREmployeeTaxPaymentPercent", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeTaxPaymentPercent { get; set; }

    [Column("HREmployeeSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSalaryFactor { get; set; }

    [Column("HREmployeeExtraSalary1", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeExtraSalary1 { get; set; }

    [Column("HREmployeeExtraSalary2", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeExtraSalary2 { get; set; }

    [Column("HREmployeeExtraSalary3", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeExtraSalary3 { get; set; }

    [Column("HREmployeeExtraSalary4", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeExtraSalary4 { get; set; }

    [Column("HRPayRollCalculatedSalaryType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrpayRollCalculatedSalaryType { get; set; }

    [Column("HREmployeeHoursPerDay", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeHoursPerDay { get; set; }

    [Column("HREmployeeDaysPerMonth", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeDaysPerMonth { get; set; }

    [Column("HREmployeeWorkingHourlySalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeWorkingHourlySalary { get; set; }

    [Column("HREmployeeWorkingDailySalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeWorkingDailySalary { get; set; }

    [Column("HREmployeeContractHourlySalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeContractHourlySalary { get; set; }

    [Column("HREmployeeContractDailySalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeContractDailySalary { get; set; }

    [Column("FK_HREmployeePayrollFormulaID")]
    public int FkHremployeePayrollFormulaId { get; set; }

    [Column("FK_GENativeStateProvinceID")]
    public int? FkGenativeStateProvinceId { get; set; }

    [Column("HREmployeeMaritalStatusCombo")]
    [StringLength(512)]
    public string HremployeeMaritalStatusCombo { get; set; }

    [Column("HREmployeeEducation")]
    [StringLength(512)]
    public string HremployeeEducation { get; set; }

    [Column("FK_GEIDCardStateProvinceID")]
    public int? FkGeidcardStateProvinceId { get; set; }

    [Column("FK_GENationalityID")]
    public int? FkGenationalityId { get; set; }

    [Column("FK_GEReligionID")]
    public int? FkGereligionId { get; set; }

    [Column("FK_GEStateProvinceIDBHXH")]
    public int? FkGestateProvinceIdbhxh { get; set; }

    [Column("HREmployeeWorkingMonths", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeWorkingMonths { get; set; }

    [Column("HREmployeeUniform")]
    public bool? HremployeeUniform { get; set; }

    [Column("HREmployeeDobString")]
    [StringLength(50)]
    public string HremployeeDobString { get; set; }

    [Column("HREmployeeProbationaryMonth")]
    public int? HremployeeProbationaryMonth { get; set; }

    [Column("HREmployeeStopWorkingDate", TypeName = "datetime")]
    public DateTime? HremployeeStopWorkingDate { get; set; }

    [Column("HREmployeeLeaveDays", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLeaveDays { get; set; }

    [Column("HREmployeeSyndicatePaymentAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSyndicatePaymentAmount { get; set; }

    [Column("HREmployeeIsUnionMember")]
    public bool? HremployeeIsUnionMember { get; set; }

    [Column("HREmployeeUnionMemberFee", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeUnionMemberFee { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("HREmployeeTrainingCourseID")]
    [StringLength(500)]
    public string HremployeeTrainingCourseId { get; set; }

    [Column("HREmployeeTrainingCourseValue")]
    [StringLength(500)]
    public string HremployeeTrainingCourseValue { get; set; }

    [Column("HREmployeeAnnualLeaveRemain")]
    public int? HremployeeAnnualLeaveRemain { get; set; }

    [Column("HREmployeePictureFileName")]
    [StringLength(1000)]
    public string HremployeePictureFileName { get; set; }

    [Column("FK_ACAccountDepositID")]
    public int? FkAcaccountDepositId { get; set; }

    [Column("FK_ACAccountPurchaseID")]
    public int? FkAcaccountPurchaseId { get; set; }

    [Column("FK_ACAccountSaleID")]
    public int? FkAcaccountSaleId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("HREmployeeBonusSale", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeBonusSale { get; set; }

    [Column("HREmployeeHaveInsurrance")]
    public bool? HremployeeHaveInsurrance { get; set; }

    [Column("HREmployeeProbationaryDateTo", TypeName = "datetime")]
    public DateTime? HremployeeProbationaryDateTo { get; set; }

    [Column("HREmployeeProbationaryDateFrom", TypeName = "datetime")]
    public DateTime? HremployeeProbationaryDateFrom { get; set; }

    [Column("HREmployeeProbationarySalaryAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeProbationarySalaryAmount { get; set; }

    [Column("FK_HRWorkingShiftID")]
    public int? FkHrworkingShiftId { get; set; }

    [Column("HREmployeePayRollCalculatedWorkType")]
    [StringLength(50)]
    public string HremployeePayRollCalculatedWorkType { get; set; }

    [Column("FK_HRConfigRankID")]
    public int? FkHrconfigRankId { get; set; }

    [Column("FK_HRConfigScaleID")]
    public int? FkHrconfigScaleId { get; set; }

    [Column("HREmployeeOutOfWorkIns", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeOutOfWorkIns { get; set; }

    [Column("HREmployeeSalarySocialInsurance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSalarySocialInsurance { get; set; }

    [Column("HREmployeePercentContractSlrAmt", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePercentContractSlrAmt { get; set; }

    [Column("HREmployeeApprenticeDay", TypeName = "datetime")]
    public DateTime? HremployeeApprenticeDay { get; set; }

    [Column("HREmployeeIsAllowedLeave")]
    public bool? HremployeeIsAllowedLeave { get; set; }

    [Column("HREmployeeStartPauseDate", TypeName = "datetime")]
    public DateTime? HremployeeStartPauseDate { get; set; }

    [Column("HREmployeeAllowanceHouse", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceHouse { get; set; }

    [Column("HREmployeeAllowancePhone", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowancePhone { get; set; }

    [Column("FK_HRDepartmentRoomGroupTeamItemID")]
    public int? FkHrdepartmentRoomGroupTeamItemId { get; set; }

    [Column("FK_HRTimeSheetParamID")]
    public int? FkHrtimeSheetParamId { get; set; }

    [Column("HREmployeeEndPauseDate", TypeName = "datetime")]
    public DateTime? HremployeeEndPauseDate { get; set; }

    [Column("HREmployeeSkillCoefficient", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSkillCoefficient { get; set; }

    [Column("HREmployeeJobPerformanceAmt", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeJobPerformanceAmt { get; set; }

    [Column("HREmployeeAllowanceGas", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeAllowanceGas { get; set; }

    [Column("HREmployeeHaveOutOfWorkIns")]
    public bool? HremployeeHaveOutOfWorkIns { get; set; }

    [Column("HREmployeeMeasureUnitType")]
    [StringLength(50)]
    public string HremployeeMeasureUnitType { get; set; }

    [Column("HREmployeeIsPieceWage")]
    public bool? HremployeeIsPieceWage { get; set; }

    [Column("HREmployeeProbationarySalaryPercent", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeProbationarySalaryPercent { get; set; }

    [Column("FK_HRAllowanceManageConfigID")]
    public int? FkHrallowanceManageConfigId { get; set; }

    [Column("FK_GEStateProvinceBirthPlaceID")]
    public int? FkGestateProvinceBirthPlaceId { get; set; }

    [InverseProperty("FkHremployeeUser")]
    public virtual ICollection<AcassetReceiptItem> AcassetReceiptItems { get; set; } = new List<AcassetReceiptItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AcassetReceipt> AcassetReceipts { get; set; } = new List<AcassetReceipt>();

    [InverseProperty("FkHremployeeUser")]
    public virtual ICollection<AcassetShipmentItem> AcassetShipmentItems { get; set; } = new List<AcassetShipmentItem>();

    [InverseProperty("FkHremployeeUser")]
    public virtual ICollection<AcassetTransferItem> AcassetTransferItems { get; set; } = new List<AcassetTransferItem>();

    [InverseProperty("FkHremployeeUser")]
    public virtual ICollection<Acasset> Acassets { get; set; } = new List<Acasset>();

    [InverseProperty("FkHremployeeApproved")]
    public virtual ICollection<AcbankTransaction> AcbankTransactionFkHremployeeApproveds { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkHremployeeCompleted")]
    public virtual ICollection<AcbankTransaction> AcbankTransactionFkHremployeeCompleteds { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AcbankTransaction> AcbankTransactionFkHremployees { get; set; } = new List<AcbankTransaction>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AcclearingDebt> AcclearingDebts { get; set; } = new List<AcclearingDebt>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Acdevice> Acdevices { get; set; } = new List<Acdevice>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Acdocument> Acdocuments { get; set; } = new List<Acdocument>();

    [InverseProperty("FkHremployeeUser")]
    public virtual ICollection<AcequipmentTransferItem> AcequipmentTransferItems { get; set; } = new List<AcequipmentTransferItem>();

    [InverseProperty("FkHremployeeApproved")]
    public virtual ICollection<AcmoneyChange> AcmoneyChangeFkHremployeeApproveds { get; set; } = new List<AcmoneyChange>();

    [InverseProperty("FkHremployeeCompleted")]
    public virtual ICollection<AcmoneyChange> AcmoneyChangeFkHremployeeCompleteds { get; set; } = new List<AcmoneyChange>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AcmoneyChange> AcmoneyChangeFkHremployees { get; set; } = new List<AcmoneyChange>();

    [InverseProperty("FkArseller")]
    public virtual ICollection<AcretailVat> AcretailVatFkArsellers { get; set; } = new List<AcretailVat>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AcretailVat> AcretailVatFkHremployees { get; set; } = new List<AcretailVat>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AcsalaryCalculation> AcsalaryCalculations { get; set; } = new List<AcsalaryCalculation>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AdremindWorking> AdremindWorkings { get; set; } = new List<AdremindWorking>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AduserGroupMember> AduserGroupMembers { get; set; } = new List<AduserGroupMember>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Aduser> Adusers { get; set; } = new List<Aduser>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ApallocationCost> ApallocationCosts { get; set; } = new List<ApallocationCost>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ApcancelPurchaseOrder> ApcancelPurchaseOrders { get; set; } = new List<ApcancelPurchaseOrder>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ApcancelPurchaseProposal> ApcancelPurchaseProposals { get; set; } = new List<ApcancelPurchaseProposal>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ApclearInvoiceIn> ApclearInvoiceIns { get; set; } = new List<ApclearInvoiceIn>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceIns { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ApopenDocument> ApopenDocuments { get; set; } = new List<ApopenDocument>();

    [InverseProperty("FkHremployeeAccountant")]
    public virtual ICollection<AppaymentProposal> AppaymentProposalFkHremployeeAccountants { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkHremployeeHeadAccountant")]
    public virtual ICollection<AppaymentProposal> AppaymentProposalFkHremployeeHeadAccountants { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkHremployeeHeadDepartment")]
    public virtual ICollection<AppaymentProposal> AppaymentProposalFkHremployeeHeadDepartments { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkHremployeeManager")]
    public virtual ICollection<AppaymentProposal> AppaymentProposalFkHremployeeManagers { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AppaymentProposal> AppaymentProposalFkHremployees { get; set; } = new List<AppaymentProposal>();

    [InverseProperty("FkHremployeeApproved")]
    public virtual ICollection<AppaymentVoucher> AppaymentVoucherFkHremployeeApproveds { get; set; } = new List<AppaymentVoucher>();

    [InverseProperty("FkHremployeeCompleted")]
    public virtual ICollection<AppaymentVoucher> AppaymentVoucherFkHremployeeCompleteds { get; set; } = new List<AppaymentVoucher>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AppaymentVoucher> AppaymentVoucherFkHremployees { get; set; } = new List<AppaymentVoucher>();

    [InverseProperty("FkHrapprovedEmployee")]
    public virtual ICollection<AppriceSheet> AppriceSheetFkHrapprovedEmployees { get; set; } = new List<AppriceSheet>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AppriceSheet> AppriceSheetFkHremployees { get; set; } = new List<AppriceSheet>();

    [InverseProperty("ApproposalProposedEmployee")]
    public virtual ICollection<Approposal> ApproposalApproposalProposedEmployees { get; set; } = new List<Approposal>();

    [InverseProperty("FkAppurchasingStaff")]
    public virtual ICollection<Approposal> ApproposalFkAppurchasingStaffs { get; set; } = new List<Approposal>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Approposal> ApproposalFkHremployees { get; set; } = new List<Approposal>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AppurchaseContract> AppurchaseContracts { get; set; } = new List<AppurchaseContract>();

    [InverseProperty("AppurchaseOrderProposedEmployee")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrderAppurchaseOrderProposedEmployees { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkAppurchasingStaff")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrderFkAppurchasingStaffs { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrderFkHremployees { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ApreturnSupplier> ApreturnSuppliers { get; set; } = new List<ApreturnSupplier>();

    [InverseProperty("FkHremployeeApproved")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPaymentFkHremployeeApproveds { get; set; } = new List<ApsupplierPayment>();

    [InverseProperty("FkHremployeeCompleted")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPaymentFkHremployeeCompleteds { get; set; } = new List<ApsupplierPayment>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ApsupplierPayment> ApsupplierPaymentFkHremployees { get; set; } = new List<ApsupplierPayment>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Aracceptance> Aracceptances { get; set; } = new List<Aracceptance>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Aractivity> Aractivities { get; set; } = new List<Aractivity>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AradjustSaleOrderQuantity> AradjustSaleOrderQuantities { get; set; } = new List<AradjustSaleOrderQuantity>();

    [InverseProperty("FkHrdriverEmployee")]
    public virtual ICollection<Arallocation> ArallocationFkHrdriverEmployees { get; set; } = new List<Arallocation>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arallocation> ArallocationFkHremployees { get; set; } = new List<Arallocation>();

    [InverseProperty("FkHrproposedEmployee")]
    public virtual ICollection<Arallocation> ArallocationFkHrproposedEmployees { get; set; } = new List<Arallocation>();

    [InverseProperty("FkHremployeeApproved")]
    public virtual ICollection<ArcalculateDiscountItem> ArcalculateDiscountItems { get; set; } = new List<ArcalculateDiscountItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArcalculateDiscount> ArcalculateDiscounts { get; set; } = new List<ArcalculateDiscount>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arcampaign> Arcampaigns { get; set; } = new List<Arcampaign>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArcancelSaleForecast> ArcancelSaleForecasts { get; set; } = new List<ArcancelSaleForecast>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArcancelVoucher> ArcancelVouchers { get; set; } = new List<ArcancelVoucher>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArcanceledDeliveryPlan> ArcanceledDeliveryPlans { get; set; } = new List<ArcanceledDeliveryPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArclearInvoice> ArclearInvoices { get; set; } = new List<ArclearInvoice>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arcomment> Arcomments { get; set; } = new List<Arcomment>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArcontainerLoader> ArcontainerLoaders { get; set; } = new List<ArcontainerLoader>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arcoordinator> Arcoordinators { get; set; } = new List<Arcoordinator>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArcreditNote> ArcreditNotes { get; set; } = new List<ArcreditNote>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArcustomerContact> ArcustomerContacts { get; set; } = new List<ArcustomerContact>();

    [InverseProperty("FkHremployeeManagement")]
    public virtual ICollection<Arcustomer> ArcustomerFkHremployeeManagements { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arcustomer> ArcustomerFkHremployees { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkHremployeeCompleted")]
    public virtual ICollection<ArcustomerPayment> ArcustomerPaymentFkHremployeeCompleteds { get; set; } = new List<ArcustomerPayment>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArcustomerPayment> ArcustomerPaymentFkHremployees { get; set; } = new List<ArcustomerPayment>();

    [InverseProperty("FkHrdeliveryEmployee")]
    public virtual ICollection<Ardelivery> ArdeliveryFkHrdeliveryEmployees { get; set; } = new List<Ardelivery>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Ardelivery> ArdeliveryFkHremployees { get; set; } = new List<Ardelivery>();

    [InverseProperty("FkHremployeeApproved")]
    public virtual ICollection<ArdeliveryPlan> ArdeliveryPlanFkHremployeeApproveds { get; set; } = new List<ArdeliveryPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArdeliveryPlan> ArdeliveryPlanFkHremployees { get; set; } = new List<ArdeliveryPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArdeliveryPlanReportIssue> ArdeliveryPlanReportIssues { get; set; } = new List<ArdeliveryPlanReportIssue>();

    [InverseProperty("FkHremployeeDelivery")]
    public virtual ICollection<ArdeliveryPlanTruck> ArdeliveryPlanTruckFkHremployeeDeliveries { get; set; } = new List<ArdeliveryPlanTruck>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArdeliveryPlanTruck> ArdeliveryPlanTruckFkHremployees { get; set; } = new List<ArdeliveryPlanTruck>();

    [InverseProperty("FkHremployeeOwner")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTaskFkHremployeeOwners { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArdeliveryPlanWorkTask> ArdeliveryPlanWorkTaskFkHremployees { get; set; } = new List<ArdeliveryPlanWorkTask>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArdiscountProgram> ArdiscountPrograms { get; set; } = new List<ArdiscountProgram>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AremailTracking> AremailTrackings { get; set; } = new List<AremailTracking>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arestimate> Arestimates { get; set; } = new List<Arestimate>();

    [InverseProperty("FkArassociatedSeller")]
    public virtual ICollection<Arinvoice> ArinvoiceFkArassociatedSellers { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkArseller")]
    public virtual ICollection<Arinvoice> ArinvoiceFkArsellers { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkHrdeliveryEmployee")]
    public virtual ICollection<Arinvoice> ArinvoiceFkHrdeliveryEmployees { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arinvoice> ArinvoiceFkHremployees { get; set; } = new List<Arinvoice>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arnotification> Arnotifications { get; set; } = new List<Arnotification>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<AropenDocument> AropenDocuments { get; set; } = new List<AropenDocument>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Aropportunity> Aropportunities { get; set; } = new List<Aropportunity>();

    [InverseProperty("FkHremployeeAccountant")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposalFkHremployeeAccountants { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkHremployeeHeadAccountant")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposalFkHremployeeHeadAccountants { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkHremployeeHeadDepartment")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposalFkHremployeeHeadDepartments { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkHremployeeManager")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposalFkHremployeeManagers { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkHremployeeReceiptNavigation")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposalFkHremployeeReceiptNavigations { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArpaymentProposal> ArpaymentProposalFkHremployees { get; set; } = new List<ArpaymentProposal>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArpriceSheet> ArpriceSheets { get; set; } = new List<ArpriceSheet>();

    [InverseProperty("FkHremployeeApproved")]
    public virtual ICollection<ArproductionPlanning> ArproductionPlanningFkHremployeeApproveds { get; set; } = new List<ArproductionPlanning>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArproductionPlanning> ArproductionPlanningFkHremployees { get; set; } = new List<ArproductionPlanning>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArproposalItemWorkTask> ArproposalItemWorkTasks { get; set; } = new List<ArproposalItemWorkTask>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArprospectCustomer> ArprospectCustomers { get; set; } = new List<ArprospectCustomer>();

    [InverseProperty("FkHremployeeCompleted")]
    public virtual ICollection<ArreceiptVoucher> ArreceiptVoucherFkHremployeeCompleteds { get; set; } = new List<ArreceiptVoucher>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArreceiptVoucher> ArreceiptVoucherFkHremployees { get; set; } = new List<ArreceiptVoucher>();

    [InverseProperty("FkHrdriverEmployee")]
    public virtual ICollection<Arreception> ArreceptionFkHrdriverEmployees { get; set; } = new List<Arreception>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arreception> ArreceptionFkHremployees { get; set; } = new List<Arreception>();

    [InverseProperty("FkHrreturnEmployee")]
    public virtual ICollection<Arreception> ArreceptionFkHrreturnEmployees { get; set; } = new List<Arreception>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arremind> Arreminds { get; set; } = new List<Arremind>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArrevenueForecast> ArrevenueForecasts { get; set; } = new List<ArrevenueForecast>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArsaleContract> ArsaleContracts { get; set; } = new List<ArsaleContract>();

    [InverseProperty("FkArassociatedSeller")]
    public virtual ICollection<ArsaleForecast> ArsaleForecastFkArassociatedSellers { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkArseller")]
    public virtual ICollection<ArsaleForecast> ArsaleForecastFkArsellers { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArsaleForecast> ArsaleForecastFkHremployees { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkArassociatedSeller")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkArassociatedSellers { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkArseller")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkArsellers { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkArshipper")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkArshippers { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkArsubSeller")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkArsubSellers { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkHremployee2D")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkHremployee2Ds { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkHremployee3D")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkHremployee3Ds { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkHremployeeManager2D")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkHremployeeManager2Ds { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkHremployeeManager3D")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkHremployeeManager3Ds { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArsaleOrder> ArsaleOrderFkHremployees { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArsaleOrderHistory> ArsaleOrderHistories { get; set; } = new List<ArsaleOrderHistory>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArsaleOrderItemWorkTask> ArsaleOrderItemWorkTasks { get; set; } = new List<ArsaleOrderItemWorkTask>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<ArsaleReturn> ArsaleReturns { get; set; } = new List<ArsaleReturn>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Arsalesman> Arsalesmen { get; set; } = new List<Arsalesman>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Brposs> Brposses { get; set; } = new List<Brposs>();

    [ForeignKey("FkAcaccountDepositId")]
    [InverseProperty("HremployeeFkAcaccountDeposits")]
    public virtual Acaccount FkAcaccountDeposit { get; set; }

    [ForeignKey("FkAcaccountPurchaseId")]
    [InverseProperty("HremployeeFkAcaccountPurchases")]
    public virtual Acaccount FkAcaccountPurchase { get; set; }

    [ForeignKey("FkAcaccountSaleId")]
    [InverseProperty("HremployeeFkAcaccountSales")]
    public virtual Acaccount FkAcaccountSale { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Hremployees")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkGeidcardStateProvinceId")]
    [InverseProperty("HremployeeFkGeidcardStateProvinces")]
    public virtual GestateProvince FkGeidcardStateProvince { get; set; }

    [ForeignKey("FkGenationalityId")]
    [InverseProperty("Hremployees")]
    public virtual Genationality FkGenationality { get; set; }

    [ForeignKey("FkGenativeStateProvinceId")]
    [InverseProperty("HremployeeFkGenativeStateProvinces")]
    public virtual GestateProvince FkGenativeStateProvince { get; set; }

    [ForeignKey("FkGereligionId")]
    [InverseProperty("Hremployees")]
    public virtual Gereligion FkGereligion { get; set; }

    [ForeignKey("FkGestateProvinceBirthPlaceId")]
    [InverseProperty("HremployeeFkGestateProvinceBirthPlaces")]
    public virtual GestateProvince FkGestateProvinceBirthPlace { get; set; }

    [ForeignKey("FkGestateProvinceIdbhxh")]
    [InverseProperty("HremployeeFkGestateProvinceIdbhxhNavigations")]
    public virtual GestateProvince FkGestateProvinceIdbhxhNavigation { get; set; }

    [ForeignKey("FkHrallowanceManageConfigId")]
    [InverseProperty("Hremployees")]
    public virtual HrallowanceManageConfig FkHrallowanceManageConfig { get; set; }

    [ForeignKey("FkHrconfigRankId")]
    [InverseProperty("Hremployees")]
    public virtual HrconfigRank FkHrconfigRank { get; set; }

    [ForeignKey("FkHrconfigScaleId")]
    [InverseProperty("Hremployees")]
    public virtual HrconfigScale FkHrconfigScale { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Hremployees")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Hremployees")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("Hremployees")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupTeamItemId")]
    [InverseProperty("Hremployees")]
    public virtual HrdepartmentRoomGroupTeamItem FkHrdepartmentRoomGroupTeamItem { get; set; }

    [ForeignKey("FkHremployeePayrollFormulaId")]
    [InverseProperty("Hremployees")]
    public virtual HremployeePayrollFormula FkHremployeePayrollFormula { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("Hremployees")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("FkHrtimeSheetParamId")]
    [InverseProperty("Hremployees")]
    public virtual HrtimeSheetParam FkHrtimeSheetParam { get; set; }

    [ForeignKey("FkHrtimeSheetScaleId")]
    [InverseProperty("Hremployees")]
    public virtual HrtimeSheetScale FkHrtimeSheetScale { get; set; }

    [ForeignKey("FkHrworkingShiftId")]
    [InverseProperty("Hremployees")]
    public virtual HrworkingShift FkHrworkingShift { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("Hremployees")]
    public virtual MmworkShop FkMmworkShop { get; set; }

    [InverseProperty("FkHremployeeCompleted")]
    public virtual ICollection<HradvanceRefund> HradvanceRefundFkHremployeeCompleteds { get; set; } = new List<HradvanceRefund>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HradvanceRefund> HradvanceRefundFkHremployees { get; set; } = new List<HradvanceRefund>();

    [InverseProperty("FkHremployeeCompleted")]
    public virtual ICollection<HradvanceRequest> HradvanceRequestFkHremployeeCompleteds { get; set; } = new List<HradvanceRequest>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HradvanceRequest> HradvanceRequestFkHremployees { get; set; } = new List<HradvanceRequest>();

    [InverseProperty("FkHremployeeUserChange")]
    public virtual ICollection<HrallowanceManageConfigHistory> HrallowanceManageConfigHistories { get; set; } = new List<HrallowanceManageConfigHistory>();

    [InverseProperty("FkHrapproveEmployee")]
    public virtual ICollection<HrapproveEditEmployee> HrapproveEditEmployeeFkHrapproveEmployees { get; set; } = new List<HrapproveEditEmployee>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrapproveEditEmployee> HrapproveEditEmployeeFkHremployees { get; set; } = new List<HrapproveEditEmployee>();

    [InverseProperty("FkHrapproveEmployee")]
    public virtual ICollection<HrapproveLeaveDay> HrapproveLeaveDayFkHrapproveEmployees { get; set; } = new List<HrapproveLeaveDay>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrapproveLeaveDay> HrapproveLeaveDayFkHremployees { get; set; } = new List<HrapproveLeaveDay>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrarrangementShiftEntry> HrarrangementShiftEntries { get; set; } = new List<HrarrangementShiftEntry>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrarrangementShift> HrarrangementShifts { get; set; } = new List<HrarrangementShift>();

    [InverseProperty("FkHremployeeAuthorizationSignerNavigation")]
    public virtual ICollection<Hrauthorization> HrauthorizationFkHremployeeAuthorizationSignerNavigations { get; set; } = new List<Hrauthorization>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Hrauthorization> HrauthorizationFkHremployees { get; set; } = new List<Hrauthorization>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrbillingIntimate> HrbillingIntimates { get; set; } = new List<HrbillingIntimate>();

    [InverseProperty("FkHremployeeId2Navigation")]
    public virtual ICollection<HrbonusSaleItem> HrbonusSaleItemFkHremployeeId2Navigations { get; set; } = new List<HrbonusSaleItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrbonusSaleItem> HrbonusSaleItemFkHremployees { get; set; } = new List<HrbonusSaleItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrbonusSale> HrbonusSales { get; set; } = new List<HrbonusSale>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrbugManagementTemplate> HrbugManagementTemplates { get; set; } = new List<HrbugManagementTemplate>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrbugManagement> HrbugManagements { get; set; } = new List<HrbugManagement>();

    [InverseProperty("FkHremployeeApproved")]
    public virtual ICollection<HrconfigSalesFormulaPayroll> HrconfigSalesFormulaPayrollFkHremployeeApproveds { get; set; } = new List<HrconfigSalesFormulaPayroll>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrconfigSalesFormulaPayroll> HrconfigSalesFormulaPayrollFkHremployees { get; set; } = new List<HrconfigSalesFormulaPayroll>();

    [InverseProperty("FkHremployeeApproved")]
    public virtual ICollection<HrconfigSalesTarget> HrconfigSalesTargetFkHremployeeApproveds { get; set; } = new List<HrconfigSalesTarget>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrconfigSalesTarget> HrconfigSalesTargetFkHremployees { get; set; } = new List<HrconfigSalesTarget>();

    [InverseProperty("FkHremployeeRequestNavigation")]
    public virtual ICollection<Hrdiscipline> Hrdisciplines { get; set; } = new List<Hrdiscipline>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Hrdormitory> Hrdormitories { get; set; } = new List<Hrdormitory>();

    [InverseProperty("FkHremployeeStudent")]
    public virtual ICollection<HremployeeAbsence> HremployeeAbsenceFkHremployeeStudents { get; set; } = new List<HremployeeAbsence>();

    [InverseProperty("FkHremployeeTeacher")]
    public virtual ICollection<HremployeeAbsence> HremployeeAbsenceFkHremployeeTeachers { get; set; } = new List<HremployeeAbsence>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeAllowance> HremployeeAllowances { get; set; } = new List<HremployeeAllowance>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeArrangementShift> HremployeeArrangementShifts { get; set; } = new List<HremployeeArrangementShift>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeArrearSocialInsurance> HremployeeArrearSocialInsurances { get; set; } = new List<HremployeeArrearSocialInsurance>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeAtmcardManage> HremployeeAtmcardManages { get; set; } = new List<HremployeeAtmcardManage>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeAtmcardPayroll> HremployeeAtmcardPayrolls { get; set; } = new List<HremployeeAtmcardPayroll>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeCertificate> HremployeeCertificates { get; set; } = new List<HremployeeCertificate>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeComissionItem> HremployeeComissionItems { get; set; } = new List<HremployeeComissionItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeContactPerson> HremployeeContactPeople { get; set; } = new List<HremployeeContactPerson>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeContact> HremployeeContacts { get; set; } = new List<HremployeeContact>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeContract> HremployeeContractFkHremployees { get; set; } = new List<HremployeeContract>();

    [InverseProperty("HremployeeContractSignerNavigation")]
    public virtual ICollection<HremployeeContract> HremployeeContractHremployeeContractSignerNavigations { get; set; } = new List<HremployeeContract>();

    [InverseProperty("FkHremployeeId2Navigation")]
    public virtual ICollection<HremployeeDiscipline> HremployeeDisciplineFkHremployeeId2Navigations { get; set; } = new List<HremployeeDiscipline>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeDiscipline> HremployeeDisciplineFkHremployees { get; set; } = new List<HremployeeDiscipline>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeEvaluation> HremployeeEvaluations { get; set; } = new List<HremployeeEvaluation>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeGroupAppStaff> HremployeeGroupAppStaffs { get; set; } = new List<HremployeeGroupAppStaff>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeGroupOrderWeb> HremployeeGroupOrderWebs { get; set; } = new List<HremployeeGroupOrderWeb>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeGroup> HremployeeGroups { get; set; } = new List<HremployeeGroup>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeIdentityCardTemplate> HremployeeIdentityCardTemplates { get; set; } = new List<HremployeeIdentityCardTemplate>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeKpievaluationItem> HremployeeKpievaluationItems { get; set; } = new List<HremployeeKpievaluationItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeKpiregistrationItem> HremployeeKpiregistrationItems { get; set; } = new List<HremployeeKpiregistrationItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeLreg> HremployeeLregs { get; set; } = new List<HremployeeLreg>();

    [InverseProperty("FkHremployeeId2Navigation")]
    public virtual ICollection<HremployeeOt> HremployeeOtFkHremployeeId2Navigations { get; set; } = new List<HremployeeOt>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeOt> HremployeeOtFkHremployees { get; set; } = new List<HremployeeOt>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeOtfactor> HremployeeOtfactors { get; set; } = new List<HremployeeOtfactor>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeePause> HremployeePauses { get; set; } = new List<HremployeePause>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeePayRollAudit> HremployeePayRollAudits { get; set; } = new List<HremployeePayRollAudit>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeePayRollConfig> HremployeePayRollConfigs { get; set; } = new List<HremployeePayRollConfig>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeePayRoll> HremployeePayRolls { get; set; } = new List<HremployeePayRoll>();

    [InverseProperty("FkHremployeeId2Navigation")]
    public virtual ICollection<HremployeePieceWageItem> HremployeePieceWageItemFkHremployeeId2Navigations { get; set; } = new List<HremployeePieceWageItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeePieceWageItem> HremployeePieceWageItemFkHremployees { get; set; } = new List<HremployeePieceWageItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeReward> HremployeeRewards { get; set; } = new List<HremployeeReward>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeSchedule> HremployeeSchedules { get; set; } = new List<HremployeeSchedule>();

    [InverseProperty("FkHradjustSocialInsurance")]
    public virtual ICollection<HremployeeSocialInsuranceChange> HremployeeSocialInsuranceChangeFkHradjustSocialInsurances { get; set; } = new List<HremployeeSocialInsuranceChange>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeSocialInsuranceChange> HremployeeSocialInsuranceChangeFkHremployees { get; set; } = new List<HremployeeSocialInsuranceChange>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeTimeSheetAudit> HremployeeTimeSheetAudits { get; set; } = new List<HremployeeTimeSheetAudit>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeTimeSheet> HremployeeTimeSheets { get; set; } = new List<HremployeeTimeSheet>();

    [InverseProperty("FkHremployeeReceived")]
    public virtual ICollection<HremployeeTranfer> HremployeeTranferFkHremployeeReceiveds { get; set; } = new List<HremployeeTranfer>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeTranfer> HremployeeTranferFkHremployees { get; set; } = new List<HremployeeTranfer>();

    [InverseProperty("HremployeeTranferSignerNavigation")]
    public virtual ICollection<HremployeeTranfer> HremployeeTranferHremployeeTranferSignerNavigations { get; set; } = new List<HremployeeTranfer>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeTransmitItem> HremployeeTransmitItems { get; set; } = new List<HremployeeTransmitItem>();

    [InverseProperty("FkHremployeeWorkSchedule")]
    public virtual ICollection<HremployeeWorkScheduleItem> HremployeeWorkScheduleItemFkHremployeeWorkSchedules { get; set; } = new List<HremployeeWorkScheduleItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeWorkScheduleItem> HremployeeWorkScheduleItemFkHremployees { get; set; } = new List<HremployeeWorkScheduleItem>();

    [InverseProperty("FkHremployeeApprove")]
    public virtual ICollection<HremployeeWorkSchedule> HremployeeWorkSchedules { get; set; } = new List<HremployeeWorkSchedule>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HremployeeWorkingShift> HremployeeWorkingShifts { get; set; } = new List<HremployeeWorkingShift>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrevaluationDetail> HrevaluationDetails { get; set; } = new List<HrevaluationDetail>();

    [InverseProperty("FkCreatedUser")]
    public virtual ICollection<Hrgroup> Hrgroups { get; set; } = new List<Hrgroup>();

    [InverseProperty("FkHremployeeId2Navigation")]
    public virtual ICollection<Hrkpievaluation> HrkpievaluationFkHremployeeId2Navigations { get; set; } = new List<Hrkpievaluation>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Hrkpievaluation> HrkpievaluationFkHremployees { get; set; } = new List<Hrkpievaluation>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Hrkpiform> Hrkpiforms { get; set; } = new List<Hrkpiform>();

    [InverseProperty("FkHremployeeId2Navigation")]
    public virtual ICollection<Hrkpiregistration> HrkpiregistrationFkHremployeeId2Navigations { get; set; } = new List<Hrkpiregistration>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Hrkpiregistration> HrkpiregistrationFkHremployees { get; set; } = new List<Hrkpiregistration>();

    [InverseProperty("FkHremployeeApprove")]
    public virtual ICollection<HrleaveApplication> HrleaveApplicationFkHremployeeApproves { get; set; } = new List<HrleaveApplication>();

    [InverseProperty("FkHremployeeLeave")]
    public virtual ICollection<HrleaveApplication> HrleaveApplicationFkHremployeeLeaves { get; set; } = new List<HrleaveApplication>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrleaveApplication> HrleaveApplicationFkHremployees { get; set; } = new List<HrleaveApplication>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrleaveDay> HrleaveDays { get; set; } = new List<HrleaveDay>();

    [InverseProperty("FkHremployeeApprover")]
    public virtual ICollection<HrlevelDetail> HrlevelDetailFkHremployeeApprovers { get; set; } = new List<HrlevelDetail>();

    [InverseProperty("FkHremployeeConsider")]
    public virtual ICollection<HrlevelDetail> HrlevelDetailFkHremployeeConsiders { get; set; } = new List<HrlevelDetail>();

    [InverseProperty("FkHremployeeEditer")]
    public virtual ICollection<HrlevelDetail> HrlevelDetailFkHremployeeEditers { get; set; } = new List<HrlevelDetail>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Hrmail> Hrmails { get; set; } = new List<Hrmail>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItems { get; set; } = new List<HrmanufactureTimeSheetItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrmanufactureTimeSheet> HrmanufactureTimeSheets { get; set; } = new List<HrmanufactureTimeSheet>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrotherLeaveDayConfig> HrotherLeaveDayConfigs { get; set; } = new List<HrotherLeaveDayConfig>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrpayRollAudit> HrpayRollAudits { get; set; } = new List<HrpayRollAudit>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrpayRoll> HrpayRolls { get; set; } = new List<HrpayRoll>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrquarterReward> HrquarterRewards { get; set; } = new List<HrquarterReward>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrrecruitmentNeed> HrrecruitmentNeeds { get; set; } = new List<HrrecruitmentNeed>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrrecruitmentPlan> HrrecruitmentPlans { get; set; } = new List<HrrecruitmentPlan>();

    [InverseProperty("FkHremployeeManagerNavigation")]
    public virtual ICollection<HrregisterDormitory> HrregisterDormitoryFkHremployeeManagerNavigations { get; set; } = new List<HrregisterDormitory>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrregisterDormitory> HrregisterDormitoryFkHremployees { get; set; } = new List<HrregisterDormitory>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrregisterDormitoryItem> HrregisterDormitoryItems { get; set; } = new List<HrregisterDormitoryItem>();

    [InverseProperty("FkHrapproveEmployee")]
    public virtual ICollection<HrrequestEditEmployee> HrrequestEditEmployeeFkHrapproveEmployees { get; set; } = new List<HrrequestEditEmployee>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrrequestEditEmployee> HrrequestEditEmployeeFkHremployees { get; set; } = new List<HrrequestEditEmployee>();

    [InverseProperty("FkHrapproveEmployee")]
    public virtual ICollection<HrrequestLeaveDay> HrrequestLeaveDayFkHrapproveEmployees { get; set; } = new List<HrrequestLeaveDay>();

    [InverseProperty("FkHremployeeLeave")]
    public virtual ICollection<HrrequestLeaveDay> HrrequestLeaveDayFkHremployeeLeaves { get; set; } = new List<HrrequestLeaveDay>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrrequestLeaveDay> HrrequestLeaveDayFkHremployees { get; set; } = new List<HrrequestLeaveDay>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Hrschedule> Hrschedules { get; set; } = new List<Hrschedule>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItems { get; set; } = new List<HrsocialInsuranceDeclarationItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrsocialInsuranceDeclaration> HrsocialInsuranceDeclarations { get; set; } = new List<HrsocialInsuranceDeclaration>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrtimeSheetAuditEntry> HrtimeSheetAuditEntries { get; set; } = new List<HrtimeSheetAuditEntry>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrtimeSheetAudit> HrtimeSheetAudits { get; set; } = new List<HrtimeSheetAudit>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrtimeSheetEntry> HrtimeSheetEntries { get; set; } = new List<HrtimeSheetEntry>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrtimeSheet> HrtimeSheets { get; set; } = new List<HrtimeSheet>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrtrainningEmployee> HrtrainningEmployees { get; set; } = new List<HrtrainningEmployee>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<HrtrainningSchedule> HrtrainningSchedules { get; set; } = new List<HrtrainningSchedule>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Icadjustment> Icadjustments { get; set; } = new List<Icadjustment>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Icbarcode> Icbarcodes { get; set; } = new List<Icbarcode>();

    [InverseProperty("FkHremployeeApprove")]
    public virtual ICollection<Iccollection> IccollectionFkHremployeeApproves { get; set; } = new List<Iccollection>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Iccollection> IccollectionFkHremployees { get; set; } = new List<Iccollection>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<IcconversionProposal> IcconversionProposals { get; set; } = new List<IcconversionProposal>();

    [InverseProperty("FkIcinventoryStockCount")]
    public virtual ICollection<IcinventoryStockCountItem> IcinventoryStockCountItems { get; set; } = new List<IcinventoryStockCountItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<IcinventoryStockCount> IcinventoryStockCounts { get; set; } = new List<IcinventoryStockCount>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<IcpriceAdjustment> IcpriceAdjustments { get; set; } = new List<IcpriceAdjustment>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<IcproductApplyPrice> IcproductApplyPrices { get; set; } = new List<IcproductApplyPrice>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<IcproductConversion> IcproductConversions { get; set; } = new List<IcproductConversion>();

    [InverseProperty("FkHremployeeUser")]
    public virtual ICollection<IcproductIdentifiedEquipment> IcproductIdentifiedEquipments { get; set; } = new List<IcproductIdentifiedEquipment>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<IcproductTask> IcproductTasks { get; set; } = new List<IcproductTask>();

    [InverseProperty("FkHremployeeUser")]
    public virtual ICollection<IcreceiptCditem> IcreceiptCditems { get; set; } = new List<IcreceiptCditem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<IcreceiptCd> IcreceiptCds { get; set; } = new List<IcreceiptCd>();

    [InverseProperty("FkHrdeliveryEmployee")]
    public virtual ICollection<Icreceipt> IcreceiptFkHrdeliveryEmployees { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Icreceipt> IcreceiptFkHremployees { get; set; } = new List<Icreceipt>();

    [InverseProperty("IcreceiptProposedEmployee")]
    public virtual ICollection<Icreceipt> IcreceiptIcreceiptProposedEmployees { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkHremployeeUser")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<IcreturnShipping> IcreturnShippings { get; set; } = new List<IcreturnShipping>();

    [InverseProperty("FkArassociatedSeller")]
    public virtual ICollection<Icshipment> IcshipmentFkArassociatedSellers { get; set; } = new List<Icshipment>();

    [InverseProperty("FkArseller")]
    public virtual ICollection<Icshipment> IcshipmentFkArsellers { get; set; } = new List<Icshipment>();

    [InverseProperty("FkHremployeeRecever")]
    public virtual ICollection<Icshipment> IcshipmentFkHremployeeRecevers { get; set; } = new List<Icshipment>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Icshipment> IcshipmentFkHremployees { get; set; } = new List<Icshipment>();

    [InverseProperty("FkHremployeeUser")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkHremployeeApproved")]
    public virtual ICollection<IcshipmentPlan> IcshipmentPlanFkHremployeeApproveds { get; set; } = new List<IcshipmentPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<IcshipmentPlan> IcshipmentPlanFkHremployees { get; set; } = new List<IcshipmentPlan>();

    [InverseProperty("FkHrapprovedEmployee")]
    public virtual ICollection<IcshipmentProposal> IcshipmentProposalFkHrapprovedEmployees { get; set; } = new List<IcshipmentProposal>();

    [InverseProperty("FkHrdiscardEmployee")]
    public virtual ICollection<IcshipmentProposal> IcshipmentProposalFkHrdiscardEmployees { get; set; } = new List<IcshipmentProposal>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<IcshipmentProposal> IcshipmentProposalFkHremployees { get; set; } = new List<IcshipmentProposal>();

    [InverseProperty("FkHrproposalEmployee")]
    public virtual ICollection<IcshipmentProposal> IcshipmentProposalFkHrproposalEmployees { get; set; } = new List<IcshipmentProposal>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Ictask> Ictasks { get; set; } = new List<Ictask>();

    [InverseProperty("FkHremployeeRecever")]
    public virtual ICollection<Ictransfer> IctransferFkHremployeeRecevers { get; set; } = new List<Ictransfer>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Ictransfer> IctransferFkHremployees { get; set; } = new List<Ictransfer>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<IctransferProposal> IctransferProposals { get; set; } = new List<IctransferProposal>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmallocationPlan> MmallocationPlans { get; set; } = new List<MmallocationPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmallocationProposal> MmallocationProposalFkHremployees { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("MmallocationProposalProposedEmployee")]
    public virtual ICollection<MmallocationProposal> MmallocationProposalMmallocationProposalProposedEmployees { get; set; } = new List<MmallocationProposal>();

    [InverseProperty("FkHremployeeApprovedNavigation")]
    public virtual ICollection<MmbatchItemPlan> MmbatchItemPlanFkHremployeeApprovedNavigations { get; set; } = new List<MmbatchItemPlan>();

    [InverseProperty("FkHremployeeValidatedNavigation")]
    public virtual ICollection<MmbatchItemPlan> MmbatchItemPlanFkHremployeeValidatedNavigations { get; set; } = new List<MmbatchItemPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmbatchItemPlan> MmbatchItemPlanFkHremployees { get; set; } = new List<MmbatchItemPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmbatchProduct> MmbatchProducts { get; set; } = new List<MmbatchProduct>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmcancelAllocationPlan> MmcancelAllocationPlans { get; set; } = new List<MmcancelAllocationPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmcancelAllocationProposal> MmcancelAllocationProposalFkHremployees { get; set; } = new List<MmcancelAllocationProposal>();

    [InverseProperty("MmcancelAllocationProposalApprovedEmployeeNavigation")]
    public virtual ICollection<MmcancelAllocationProposal> MmcancelAllocationProposalMmcancelAllocationProposalApprovedEmployeeNavigations { get; set; } = new List<MmcancelAllocationProposal>();

    [InverseProperty("FkHremployeeApprovedNavigation")]
    public virtual ICollection<MmcanceledPurchasePlan> MmcanceledPurchasePlanFkHremployeeApprovedNavigations { get; set; } = new List<MmcanceledPurchasePlan>();

    [InverseProperty("FkHremployeeValidatedNavigation")]
    public virtual ICollection<MmcanceledPurchasePlan> MmcanceledPurchasePlanFkHremployeeValidatedNavigations { get; set; } = new List<MmcanceledPurchasePlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmcanceledPurchasePlan> MmcanceledPurchasePlanFkHremployees { get; set; } = new List<MmcanceledPurchasePlan>();

    [InverseProperty("FkHremployeeIdapprovedNavigation")]
    public virtual ICollection<MmchangeBominformation> MmchangeBominformationFkHremployeeIdapprovedNavigations { get; set; } = new List<MmchangeBominformation>();

    [InverseProperty("FkHremployeeIdvalidatedNavigation")]
    public virtual ICollection<MmchangeBominformation> MmchangeBominformationFkHremployeeIdvalidatedNavigations { get; set; } = new List<MmchangeBominformation>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmchangeBominformation> MmchangeBominformationFkHremployees { get; set; } = new List<MmchangeBominformation>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmchangeDeliveryDateBatchProduct> MmchangeDeliveryDateBatchProducts { get; set; } = new List<MmchangeDeliveryDateBatchProduct>();

    [InverseProperty("FkHrcheckerEmployee")]
    public virtual ICollection<MmfalseConditional> MmfalseConditionalFkHrcheckerEmployees { get; set; } = new List<MmfalseConditional>();

    [InverseProperty("FkHrreceiverEmployee")]
    public virtual ICollection<MmfalseConditional> MmfalseConditionalFkHrreceiverEmployees { get; set; } = new List<MmfalseConditional>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Mmformula> Mmformulas { get; set; } = new List<Mmformula>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmjobTicketItemEmployee> MmjobTicketItemEmployees { get; set; } = new List<MmjobTicketItemEmployee>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmjobTicket> MmjobTickets { get; set; } = new List<MmjobTicket>();

    [InverseProperty("FkHremployeeApprove")]
    public virtual ICollection<MmmergeBomchangeBatchProduct> MmmergeBomchangeBatchProducts { get; set; } = new List<MmmergeBomchangeBatchProduct>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmmergeBomchange> MmmergeBomchanges { get; set; } = new List<MmmergeBomchange>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmnormTemplate> MmnormTemplates { get; set; } = new List<MmnormTemplate>();

    [InverseProperty("FkHremployeeIdapprovedNavigation")]
    public virtual ICollection<MmoperationDetailPlanCancel> MmoperationDetailPlanCancelFkHremployeeIdapprovedNavigations { get; set; } = new List<MmoperationDetailPlanCancel>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmoperationDetailPlanCancel> MmoperationDetailPlanCancelFkHremployees { get; set; } = new List<MmoperationDetailPlanCancel>();

    [InverseProperty("FkHremployeeIdapprovedNavigation")]
    public virtual ICollection<MmoperationDetailPlanCapacity> MmoperationDetailPlanCapacityFkHremployeeIdapprovedNavigations { get; set; } = new List<MmoperationDetailPlanCapacity>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmoperationDetailPlanCapacity> MmoperationDetailPlanCapacityFkHremployees { get; set; } = new List<MmoperationDetailPlanCapacity>();

    [InverseProperty("FkHremployeeGive")]
    public virtual ICollection<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItemFkHremployeeGives { get; set; } = new List<MmoperationDetailPlanCapacityItem>();

    [InverseProperty("FkHremployeeQc")]
    public virtual ICollection<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItemFkHremployeeQcs { get; set; } = new List<MmoperationDetailPlanCapacityItem>();

    [InverseProperty("FkHremployeeTake")]
    public virtual ICollection<MmoperationDetailPlanCapacityItem> MmoperationDetailPlanCapacityItemFkHremployeeTakes { get; set; } = new List<MmoperationDetailPlanCapacityItem>();

    [InverseProperty("FkHremployeeIdapprovedNavigation")]
    public virtual ICollection<MmoperationDetailPlan> MmoperationDetailPlanFkHremployeeIdapprovedNavigations { get; set; } = new List<MmoperationDetailPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmoperationDetailPlan> MmoperationDetailPlanFkHremployees { get; set; } = new List<MmoperationDetailPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmpaintProcessConfig> MmpaintProcessConfigs { get; set; } = new List<MmpaintProcessConfig>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Mmprocesss> Mmprocessses { get; set; } = new List<Mmprocesss>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmproductionCostDirectLaborCost> MmproductionCostDirectLaborCosts { get; set; } = new List<MmproductionCostDirectLaborCost>();

    [InverseProperty("FkHremployeeEquipmentValidateNavigation")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployeeEquipmentValidateNavigations { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployeeHardwareApproveNavigation")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployeeHardwareApproveNavigations { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployeeHardwareValidateNavigation")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployeeHardwareValidateNavigations { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployeeOperationApproveNavigation")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployeeOperationApproveNavigations { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployeeOperationValidateNavigation")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployeeOperationValidateNavigations { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployeePackingMaterialApproveNavigation")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployeePackingMaterialApproveNavigations { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployeePackingMaterialValidateNavigation")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployeePackingMaterialValidateNavigations { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployeePaintApproveNavigation")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployeePaintApproveNavigations { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployeePaintValidateNavigation")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployeePaintValidateNavigations { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployeeWoodApproveNavigation")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployeeWoodApproveNavigations { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployeeWoodValidateNavigation")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployeeWoodValidateNavigations { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmproductionNorm> MmproductionNormFkHremployees { get; set; } = new List<MmproductionNorm>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmprofileManagementItem> MmprofileManagementItems { get; set; } = new List<MmprofileManagementItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Mmproposal> Mmproposals { get; set; } = new List<Mmproposal>();

    [InverseProperty("FkHremployeeApprovedNavigation")]
    public virtual ICollection<MmpurchasePlan> MmpurchasePlanFkHremployeeApprovedNavigations { get; set; } = new List<MmpurchasePlan>();

    [InverseProperty("FkHremployeeValidatedNavigation")]
    public virtual ICollection<MmpurchasePlan> MmpurchasePlanFkHremployeeValidatedNavigations { get; set; } = new List<MmpurchasePlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmpurchasePlan> MmpurchasePlanFkHremployees { get; set; } = new List<MmpurchasePlan>();

    [InverseProperty("FkHremployeeIdapprovedNavigation")]
    public virtual ICollection<MmupdatePosition> MmupdatePositionFkHremployeeIdapprovedNavigations { get; set; } = new List<MmupdatePosition>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmupdatePosition> MmupdatePositionFkHremployees { get; set; } = new List<MmupdatePosition>();

    [InverseProperty("FkHremployeeApprovedNavigation")]
    public virtual ICollection<MmwoodPlan> MmwoodPlanFkHremployeeApprovedNavigations { get; set; } = new List<MmwoodPlan>();

    [InverseProperty("FkHremployeeValidatedNavigation")]
    public virtual ICollection<MmwoodPlan> MmwoodPlanFkHremployeeValidatedNavigations { get; set; } = new List<MmwoodPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<MmwoodPlan> MmwoodPlanFkHremployees { get; set; } = new List<MmwoodPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<PmbuidingCommandItem> PmbuidingCommandItems { get; set; } = new List<PmbuidingCommandItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<PmbuidingProposal> PmbuidingProposals { get; set; } = new List<PmbuidingProposal>();

    [InverseProperty("FkHremployeeApprovedNavigation")]
    public virtual ICollection<PmbuildingAllocation> PmbuildingAllocationFkHremployeeApprovedNavigations { get; set; } = new List<PmbuildingAllocation>();

    [InverseProperty("FkHremployeeValidatedNavigation")]
    public virtual ICollection<PmbuildingAllocation> PmbuildingAllocationFkHremployeeValidatedNavigations { get; set; } = new List<PmbuildingAllocation>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<PmbuildingAllocation> PmbuildingAllocationFkHremployees { get; set; } = new List<PmbuildingAllocation>();

    [InverseProperty("FkHremployeeOwner")]
    public virtual ICollection<PmbuildingAllocationItem> PmbuildingAllocationItemFkHremployeeOwners { get; set; } = new List<PmbuildingAllocationItem>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<PmbuildingAllocationItem> PmbuildingAllocationItemFkHremployees { get; set; } = new List<PmbuildingAllocationItem>();

    [InverseProperty("FkHremployeeApprovedNavigation")]
    public virtual ICollection<PmbuildingPlan> PmbuildingPlanFkHremployeeApprovedNavigations { get; set; } = new List<PmbuildingPlan>();

    [InverseProperty("FkHremployeeValidatedNavigation")]
    public virtual ICollection<PmbuildingPlan> PmbuildingPlanFkHremployeeValidatedNavigations { get; set; } = new List<PmbuildingPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<PmbuildingPlan> PmbuildingPlanFkHremployees { get; set; } = new List<PmbuildingPlan>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Pmproject> PmprojectFkHremployees { get; set; } = new List<Pmproject>();

    [InverseProperty("FkHrprojectOwnerEmployee")]
    public virtual ICollection<Pmproject> PmprojectFkHrprojectOwnerEmployees { get; set; } = new List<Pmproject>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<PmprojectNormHistory> PmprojectNormHistories { get; set; } = new List<PmprojectNormHistory>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<PmprojectNormTask> PmprojectNormTasks { get; set; } = new List<PmprojectNormTask>();

    [InverseProperty("FkHremployeeApproved")]
    public virtual ICollection<PmsaleWork> PmsaleWorkFkHremployeeApproveds { get; set; } = new List<PmsaleWork>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<PmsaleWork> PmsaleWorkFkHremployees { get; set; } = new List<PmsaleWork>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<PmsaleWorkItem> PmsaleWorkItems { get; set; } = new List<PmsaleWorkItem>();

    [InverseProperty("FkHremployeeCreated")]
    public virtual ICollection<Pmtask> PmtaskFkHremployeeCreateds { get; set; } = new List<Pmtask>();

    [InverseProperty("FkHremployeeUpdated")]
    public virtual ICollection<Pmtask> PmtaskFkHremployeeUpdateds { get; set; } = new List<Pmtask>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<PmtaskReportIssue> PmtaskReportIssues { get; set; } = new List<PmtaskReportIssue>();

    [InverseProperty("FkHremployeeApprove")]
    public virtual ICollection<Pmtemplate> PmtemplateFkHremployeeApproves { get; set; } = new List<Pmtemplate>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<Pmtemplate> PmtemplateFkHremployees { get; set; } = new List<Pmtemplate>();

    [InverseProperty("FkHremployee")]
    public virtual ICollection<PmtemplateItemTask> PmtemplateItemTasks { get; set; } = new List<PmtemplateItemTask>();
}
