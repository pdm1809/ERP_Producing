using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeePayRollAudits")]
public partial class HremployeePayRollAudit
{
    [Key]
    [Column("HREmployeePayRollAuditID")]
    public int HremployeePayRollAuditId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRPayRollAuditID")]
    public int FkHrpayRollAuditId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("HREmployeePayRollAuditUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditUnitPrice { get; set; }

    [Column("HREmployeePayRollAuditWorkingSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditWorkingSalary { get; set; }

    [Column("HREmployeePayRollAuditOTSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditOtsalary { get; set; }

    [Column("HREmployeePayRollAuditLeaveSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditLeaveSalary { get; set; }

    [Column("HREmployeePayRollAuditExtraSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditExtraSalary { get; set; }

    [Column("HREmployeePayRollAuditSocialInsAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditSocialInsAmount { get; set; }

    [Column("HREmployeePayRollAuditHealthInsAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditHealthInsAmount { get; set; }

    [Column("HREmployeePayRollAuditOutOfWorkInsAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditOutOfWorkInsAmount { get; set; }

    [Column("HREmployeePayRollAuditSyndicateFee", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditSyndicateFee { get; set; }

    [Column("HREmployeePayRollAuditIncomeTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditIncomeTaxAmount { get; set; }

    [Column("HREmployeePayRollAuditCommission", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditCommission { get; set; }

    [Column("HREmployeePayRollAuditReward", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditReward { get; set; }

    [Column("HREmployeePayRollAuditDiscipline", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditDiscipline { get; set; }

    [Column("HREmployeePayRollAuditAdvance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditAdvance { get; set; }

    [Column("HREmployeePayRollAuditTotalSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditTotalSalary { get; set; }

    [Column("HREmployeePayRollAuditComment")]
    [StringLength(512)]
    public string HremployeePayRollAuditComment { get; set; }

    [Column("HREmployeePayRollAuditWorkingSlrAmt", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditWorkingSlrAmt { get; set; }

    [Column("HREmployeePayRollAuditContractSlrAmt", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditContractSlrAmt { get; set; }

    [Column("HREmployeePayRollAuditHoursPerDay", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditHoursPerDay { get; set; }

    [Column("HREmployeePayRollAuditSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditSalaryFactor { get; set; }

    [Column("HREmployeePayRollAuditDaysPerMonth", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditDaysPerMonth { get; set; }

    [Column("HREmployeeCardNumber")]
    [StringLength(50)]
    public string HremployeeCardNumber { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("HREmployeeDaysPerMonth", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeDaysPerMonth { get; set; }

    [Column("HREmployeeRealDaysPerMonth", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeRealDaysPerMonth { get; set; }

    [Column("HREmployeeHoursOT", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeHoursOt { get; set; }

    [Column("HREmployeeWorkingSlrAmtFull", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeWorkingSlrAmtFull { get; set; }

    [Column("HREmployeePieceworkSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePieceworkSalary { get; set; }

    [Column("HREmployeeOffsetSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeOffsetSalary { get; set; }

    [Column("HREmployeeLuongDaTru", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeLuongDaTru { get; set; }

    [Column("HREmployeeNoLuyTien", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeNoLuyTien { get; set; }

    [Column("HREmployeeSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeSalaryFactor { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Column("HREmployeePayRollAuditFuelTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditFuelTotalAmount { get; set; }

    [Column("HREmployeePayRollAuditBusAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditBusAllowance { get; set; }

    [Column("HREmployeePayRollAuditEffectiveAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditEffectiveAllowance { get; set; }

    [Column("HREmployeePayRollAuditDiligenceAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditDiligenceAllowance { get; set; }

    [Column("HREmployeePayRollAuditHeavyToxicAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditHeavyToxicAllowance { get; set; }

    [Column("HREmployeePayRollAuditPerennialAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditPerennialAllowance { get; set; }

    [Column("HREmployeePayRollAuditOtherAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditOtherAllowance { get; set; }

    [Column("HREmployeePayRollAuditNghiPhepNam", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditNghiPhepNam { get; set; }

    [Column("HREmployeePayRollAuditNghiLe", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditNghiLe { get; set; }

    [Column("HREmployeePayRollAuditNghiCheDo", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditNghiCheDo { get; set; }

    [Column("HREmployeePayRollAuditNghiCupDien", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditNghiCupDien { get; set; }

    [Column("HREmployeePayRollAuditNghiPhep", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditNghiPhep { get; set; }

    [Column("HREmployeePayRollAuditCtyChoNghi", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditCtyChoNghi { get; set; }

    [Column("HREmployeePayRollAuditNghiKPhep", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditNghiKphep { get; set; }

    [Column("HREmployeePayRollAuditBHTaiNan", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditBhtaiNan { get; set; }

    [Column("HREmployeePayRollAuditPhiTheTu", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditPhiTheTu { get; set; }

    [Column("HREmployeePayRollAuditPhiTheATM", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditPhiTheAtm { get; set; }

    [Column("HREmployeePayRollAuditPhiAo", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditPhiAo { get; set; }

    [Column("HREmployeePayRollAuditTruKhac", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditTruKhac { get; set; }

    [Column("HREmployeePayRollAuditTruThueTNCN", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditTruThueTncn { get; set; }

    [Column("HREmployeePayRollAuditTongThuNhap", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditTongThuNhap { get; set; }

    [Column("HREmployeePayRollAuditTongCacKhoanTru", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditTongCacKhoanTru { get; set; }

    [Column("HREmployeePayRollAuditProductivityAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditProductivityAllowance { get; set; }

    [Column("HREmployeePayRollAuditQualityAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditQualityAllowance { get; set; }

    [Column("HREmployeePayRollAuditMealAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditMealAllowance { get; set; }

    [Column("HREmployeePayRollAuditLodgingHouseAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditLodgingHouseAllowance { get; set; }

    [Column("HREmployeePayRollAuditTechnicalAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditTechnicalAllowance { get; set; }

    [Column("HREmployeePayRollAuditInsuranceAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditInsuranceAllowance { get; set; }

    [Column("HREmployeePayRollAuditManageAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditManageAllowance { get; set; }

    [Column("HREmployeePayRollAuditMealDeduction", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditMealDeduction { get; set; }

    [Column("HREmployeePayRollAuditElectricityDeduction", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditElectricityDeduction { get; set; }

    [Column("HREmployeePayRollAuditGarbageDeduction", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditGarbageDeduction { get; set; }

    [Column("HREmployeePayRollAuditDormitoryOtherDeduction", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditDormitoryOtherDeduction { get; set; }

    [Column("HREmployeePayRollAuditDaysOffAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditDaysOffAmount { get; set; }

    [Column("HREmployeePayRollAuditPermissionOTDaysOff", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditPermissionOtdaysOff { get; set; }

    [Column("HREmployeePayRollAuditNonPermissionOTDaysOff", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditNonPermissionOtdaysOff { get; set; }

    [Column("HREmployeePayRollAuditHolidayOTHours", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditHolidayOthours { get; set; }

    [Column("HREmployeePayRollAuditProWorkingSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditProWorkingSalary { get; set; }

    [Column("HREmployeeProWorkingSlrAmtFull", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeProWorkingSlrAmtFull { get; set; }

    [Column("HREmployeeProPieceworkSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeProPieceworkSalary { get; set; }

    [Column("HREmployeeProPayRollOTSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeProPayRollOtsalary { get; set; }

    [Column("HREmployeeProRealDaysPerMonth", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeProRealDaysPerMonth { get; set; }

    [Column("HREmployeePayRollProHoursOT", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollProHoursOt { get; set; }

    [Column("HREmployeeRealHoursPerMonth", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeRealHoursPerMonth { get; set; }

    [Column("HREmployeeProRealHoursPerMonth", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeProRealHoursPerMonth { get; set; }

    [Column("HREmployeePayrollAuditLeavedaySpecial", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollAuditLeavedaySpecial { get; set; }

    [Column("HREmployeePayRollAuditTransmitWorkingSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditTransmitWorkingSalary { get; set; }

    [Column("HREmployeePayRollAuditTransmitRealHour", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditTransmitRealHour { get; set; }

    [Column("HREmployeePayRollAuditAllowanceManageAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditAllowanceManageAmount { get; set; }

    [Column("HREmployeePayRollAuditMaternityAndSickLeaveAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditMaternityAndSickLeaveAmount { get; set; }

    [Column("HREmployeePayRollAuditBonusSale", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditBonusSale { get; set; }

    [Column("HREmployeePayRollAuditBonusDiLai", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditBonusDiLai { get; set; }

    [Column("HREmployeePayRollAuditNuoiConNho", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditNuoiConNho { get; set; }

    [Column("HREmployeePayRollAuditTruyLanh", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditTruyLanh { get; set; }

    [Column("HREmployeePayRollAuditThuongKPI", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditThuongKpi { get; set; }

    [Column("HREmployeePayRollAuditThuNhapChiuThue", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditThuNhapChiuThue { get; set; }

    [Column("HREmployeePayRollAuditSoNguoiPhuThuoc", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditSoNguoiPhuThuoc { get; set; }

    [Column("FK_HREmployeePayRollKPI")]
    [StringLength(50)]
    public string FkHremployeePayRollKpi { get; set; }

    [Column("HREmployeeRealNightsPerMonth", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeRealNightsPerMonth { get; set; }

    [Column("HREmployeePayRollAuditTotalWorkingSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditTotalWorkingSalary { get; set; }

    [Column("HREmployeePayRollAuditBonusSaleAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditBonusSaleAmount { get; set; }

    [Column("HREmployeePayRollAuditAllowanceNangSuat", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditAllowanceNangSuat { get; set; }

    [Column("HREmployeePayRollAuditJobPerformanceAmt", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditJobPerformanceAmt { get; set; }

    [Column("HREmployeePayRollAuditProductivity", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditProductivity { get; set; }

    [Column("HREmployeePayRollAuditQuality", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditQuality { get; set; }

    [Column("HREmployeePayRollAuditManagement", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditManagement { get; set; }

    [Column("HREmployeePayRollAuditExactly", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditExactly { get; set; }

    [Column("HREmployeePayRollAuditSkillCoefficient", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditSkillCoefficient { get; set; }

    [Column("HREmployeePayRollAuditSkillCoefficientAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditSkillCoefficientAmount { get; set; }

    [Column("HREmployeePayRollAuditFixedAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAuditFixedAllowance { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HremployeePayRollAudits")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeePayRollAudits")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeePayRollAudits")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HremployeePayRollAudits")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("FkHrpayRollAuditId")]
    [InverseProperty("HremployeePayRollAudits")]
    public virtual HrpayRollAudit FkHrpayRollAudit { get; set; }

    [InverseProperty("FkHremployeePayRollAudit")]
    public virtual ICollection<HremployeePayRollAuditDetail> HremployeePayRollAuditDetails { get; set; } = new List<HremployeePayRollAuditDetail>();
}
