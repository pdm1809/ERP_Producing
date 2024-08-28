using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeePayRolls")]
public partial class HremployeePayRoll
{
    [Key]
    [Column("HREmployeePayRollID")]
    public int HremployeePayRollId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_HRPayRollID")]
    public int FkHrpayRollId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("HREmployeePayRollUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollUnitPrice { get; set; }

    [Column("HREmployeePayRollWorkingSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollWorkingSalary { get; set; }

    [Column("HREmployeePayRollOTSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollOtsalary { get; set; }

    [Column("HREmployeePayRollLeaveSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollLeaveSalary { get; set; }

    [Column("HREmployeePayRollExtraSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollExtraSalary { get; set; }

    [Column("HREmployeePayRollSocialInsAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollSocialInsAmount { get; set; }

    [Column("HREmployeePayRollHealthInsAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollHealthInsAmount { get; set; }

    [Column("HREmployeePayRollOutOfWorkInsAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollOutOfWorkInsAmount { get; set; }

    [Column("HREmployeePayRollSyndicateFee", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollSyndicateFee { get; set; }

    [Column("HREmployeePayRollIncomeTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollIncomeTaxAmount { get; set; }

    [Column("HREmployeePayRollCommission", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollCommission { get; set; }

    [Column("HREmployeePayRollReward", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollReward { get; set; }

    [Column("HREmployeePayRollDiscipline", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollDiscipline { get; set; }

    [Column("HREmployeePayRollAdvance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAdvance { get; set; }

    [Column("HREmployeePayRollTotalSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollTotalSalary { get; set; }

    [Column("HREmployeePayRollComment")]
    [StringLength(512)]
    public string HremployeePayRollComment { get; set; }

    [Column("HREmployeePayRollWorkingSlrAmt", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollWorkingSlrAmt { get; set; }

    [Column("HREmployeePayRollContractSlrAmt", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollContractSlrAmt { get; set; }

    [Column("HREmployeePayRollHoursPerDay", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollHoursPerDay { get; set; }

    [Column("HREmployeePayRollSalaryFactor", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollSalaryFactor { get; set; }

    [Column("HREmployeePayRollDaysPerMonth", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollDaysPerMonth { get; set; }

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

    [Column("HREmployeePayRollFuelTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollFuelTotalAmount { get; set; }

    [Column("HREmployeePayRollBusAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollBusAllowance { get; set; }

    [Column("HREmployeePayRollEffectiveAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollEffectiveAllowance { get; set; }

    [Column("HREmployeePayRollDiligenceAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollDiligenceAllowance { get; set; }

    [Column("HREmployeePayRollHeavyToxicAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollHeavyToxicAllowance { get; set; }

    [Column("HREmployeePayRollPerennialAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollPerennialAllowance { get; set; }

    [Column("HREmployeePayRollOtherAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollOtherAllowance { get; set; }

    [Column("HREmployeePayrollNghiPhepNam", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollNghiPhepNam { get; set; }

    [Column("HREmployeePayrollNghiLe", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollNghiLe { get; set; }

    [Column("HREmployeePayrollNghiCheDo", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollNghiCheDo { get; set; }

    [Column("HREmployeePayrollNghiCupDien", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollNghiCupDien { get; set; }

    [Column("HREmployeePayrollNghiPhep", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollNghiPhep { get; set; }

    [Column("HREmployeePayrollCtyChoNghi", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollCtyChoNghi { get; set; }

    [Column("HREmployeePayrollNghiKPhep", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollNghiKphep { get; set; }

    [Column("HREmployeePayrollBHTaiNan", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollBhtaiNan { get; set; }

    [Column("HREmployeePayrollPhiTheTu", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollPhiTheTu { get; set; }

    [Column("HREmployeePayrollPhiTheATM", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollPhiTheAtm { get; set; }

    [Column("HREmployeePayrollPhiAo", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollPhiAo { get; set; }

    [Column("HREmployeePayrollTruKhac", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollTruKhac { get; set; }

    [Column("HREmployeePayrollTruThueTNCN", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollTruThueTncn { get; set; }

    [Column("HREmployeePayrollTongThuNhap", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollTongThuNhap { get; set; }

    [Column("HREmployeePayrollTongCacKhoanTru", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollTongCacKhoanTru { get; set; }

    [Column("HREmployeePayRollProductivityAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollProductivityAllowance { get; set; }

    [Column("HREmployeePayRollQualityAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollQualityAllowance { get; set; }

    [Column("HREmployeePayRollMealAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollMealAllowance { get; set; }

    [Column("HREmployeePayRollLodgingHouseAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollLodgingHouseAllowance { get; set; }

    [Column("HREmployeePayRollTechnicalAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollTechnicalAllowance { get; set; }

    [Column("HREmployeePayRollInsuranceAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollInsuranceAllowance { get; set; }

    [Column("HREmployeePayRollManageAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollManageAllowance { get; set; }

    [Column("HREmployeePayRollMealDeduction", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollMealDeduction { get; set; }

    [Column("HREmployeePayRollElectricityDeduction", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollElectricityDeduction { get; set; }

    [Column("HREmployeePayRollGarbageDeduction", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollGarbageDeduction { get; set; }

    [Column("HREmployeePayRollDormitoryOtherDeduction", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollDormitoryOtherDeduction { get; set; }

    [Column("HREmployeePayRollDaysOffAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollDaysOffAmount { get; set; }

    [Column("HREmployeePayRollPermissionOTDaysOff", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollPermissionOtdaysOff { get; set; }

    [Column("HREmployeePayRollNonPermissionOTDaysOff", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollNonPermissionOtdaysOff { get; set; }

    [Column("HREmployeePayRollHolidayOTHours", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollHolidayOthours { get; set; }

    [Column("HREmployeePayRollProWorkingSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollProWorkingSalary { get; set; }

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

    [Column("HREmployeePayrollLeavedaySpecial", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayrollLeavedaySpecial { get; set; }

    [Column("HREmployeePayRollTransmitWorkingSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollTransmitWorkingSalary { get; set; }

    [Column("HREmployeePayRollTransmitRealHour", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollTransmitRealHour { get; set; }

    [Column("HREmployeePayRollAllowanceManageAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAllowanceManageAmount { get; set; }

    [Column("HREmployeePayRollMaternityAndSickLeaveAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollMaternityAndSickLeaveAmount { get; set; }

    [Column("HREmployeePayRollBonusSale", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollBonusSale { get; set; }

    [Column("HREmployeePayRollBonusDiLai", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollBonusDiLai { get; set; }

    [Column("HREmployeePayRollNuoiConNho", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollNuoiConNho { get; set; }

    [Column("HREmployeePayRollTruyLanh", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollTruyLanh { get; set; }

    [Column("HREmployeePayRollThuongKPI", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollThuongKpi { get; set; }

    [Column("HREmployeePayRollThuNhapChiuThue", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollThuNhapChiuThue { get; set; }

    [Column("HREmployeePayRollSoNguoiPhuThuoc", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollSoNguoiPhuThuoc { get; set; }

    [Column("FK_HREmployeePayRollKPI")]
    [StringLength(50)]
    public string FkHremployeePayRollKpi { get; set; }

    [Column("HREmployeeRealNightsPerMonth", TypeName = "decimal(18, 5)")]
    public decimal? HremployeeRealNightsPerMonth { get; set; }

    [Column("HREmployeePayRollTotalWorkingSalary", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollTotalWorkingSalary { get; set; }

    [Column("HREmployeePayRollBonusSaleAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollBonusSaleAmount { get; set; }

    [Column("HREmployeePayRollAllowanceNangSuat", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollAllowanceNangSuat { get; set; }

    [Column("HREmployeePayRollJobPerformanceAmt", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollJobPerformanceAmt { get; set; }

    [Column("HREmployeePayRollProductivity", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollProductivity { get; set; }

    [Column("HREmployeePayRollQuality", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollQuality { get; set; }

    [Column("HREmployeePayRollManagement", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollManagement { get; set; }

    [Column("HREmployeePayRollExactly", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollExactly { get; set; }

    [Column("HREmployeePayRollSkillCoefficient", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollSkillCoefficient { get; set; }

    [Column("HREmployeePayRollSkillCoefficientAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollSkillCoefficientAmount { get; set; }

    [Column("HREmployeePayRollFixedAllowance", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePayRollFixedAllowance { get; set; }

    [Column("FK_HREmployeePayRollAllowance")]
    [StringLength(64)]
    [Unicode(false)]
    public string FkHremployeePayRollAllowance { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HremployeePayRolls")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HremployeePayRolls")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeePayRolls")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HremployeePayRolls")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("FkHrpayRollId")]
    [InverseProperty("HremployeePayRolls")]
    public virtual HrpayRoll FkHrpayRoll { get; set; }

    [InverseProperty("FkHremployeePayroll")]
    public virtual ICollection<HremployeePayrollDetail> HremployeePayrollDetails { get; set; } = new List<HremployeePayrollDetail>();
}
