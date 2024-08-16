using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("VMVehicles")]
[Microsoft.EntityFrameworkCore.Index("VmvehicleNo", "VmvehicleType", Name = "Idx_VMVehicles")]
public partial class Vmvehicle
{
    [Key]
    [Column("VMVehicleID")]
    public int VmvehicleId { get; set; }

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

    [Column("FK_VMVehicleGroupID")]
    public int? FkVmvehicleGroupId { get; set; }

    [Required]
    [Column("VMVehicleNo")]
    [StringLength(50)]
    public string VmvehicleNo { get; set; }

    [Required]
    [Column("VMVehicleName")]
    [StringLength(100)]
    public string VmvehicleName { get; set; }

    [Required]
    [Column("VMVehicleNoPlate")]
    [StringLength(50)]
    public string VmvehicleNoPlate { get; set; }

    [Column("VMVehicleDesc")]
    [StringLength(512)]
    public string VmvehicleDesc { get; set; }

    [Column("VMVehicleType")]
    [StringLength(100)]
    public string VmvehicleType { get; set; }

    [Column("VMVehicleFuelType")]
    [StringLength(100)]
    public string VmvehicleFuelType { get; set; }

    [Column("VMVehiclePurchaseDate", TypeName = "datetime")]
    public DateTime? VmvehiclePurchaseDate { get; set; }

    [Column("VMVehicleOdometerOnPurchase")]
    public int? VmvehicleOdometerOnPurchase { get; set; }

    [Column("VMVehicleCapacity", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleCapacity { get; set; }

    [Column("VMVehicleFuelNorm", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleFuelNorm { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("VMVehicleCompanyName")]
    [StringLength(500)]
    public string VmvehicleCompanyName { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("VMVehicleCargoTonnage", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleCargoTonnage { get; set; }

    [Column("VMVehicleTruckLoad", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleTruckLoad { get; set; }

    [Column("VMVehicleWidth", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleWidth { get; set; }

    [Column("VMVehicleHight", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleHight { get; set; }

    [Column("VMVehicleLength", TypeName = "decimal(18, 5)")]
    public decimal? VmvehicleLength { get; set; }

    [Column("VMVehicleCarLife")]
    [StringLength(50)]
    public string VmvehicleCarLife { get; set; }

    [Column("VMVehicleCar")]
    [StringLength(200)]
    public string VmvehicleCar { get; set; }

    [Column("VMVehicleInsuranceTerm", TypeName = "datetime")]
    public DateTime? VmvehicleInsuranceTerm { get; set; }

    [Column("VMVehicleRegistrationDeadline", TypeName = "datetime")]
    public DateTime? VmvehicleRegistrationDeadline { get; set; }

    [Column("VMVehicleStatus")]
    [StringLength(50)]
    public string VmvehicleStatus { get; set; }

    [Column("VMDeliveryPlanTruckType")]
    [StringLength(50)]
    public string VmdeliveryPlanTruckType { get; set; }

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<AcaccountingBill> AcaccountingBills { get; set; } = new List<AcaccountingBill>();

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<AcactualCostBudgetDetail> AcactualCostBudgetDetails { get; set; } = new List<AcactualCostBudgetDetail>();

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<AcbankTransactionItem> AcbankTransactionItems { get; set; } = new List<AcbankTransactionItem>();

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<AcdocumentEntry> AcdocumentEntries { get; set; } = new List<AcdocumentEntry>();

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<ApfeePaymentFeeConfig> ApfeePaymentFeeConfigs { get; set; } = new List<ApfeePaymentFeeConfig>();

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<ApinvoiceInItem> ApinvoiceInItems { get; set; } = new List<ApinvoiceInItem>();

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<AppaymentVoucherItem> AppaymentVoucherItems { get; set; } = new List<AppaymentVoucherItem>();

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<Ardelivery> Ardeliveries { get; set; } = new List<Ardelivery>();

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<ArdeliveryPlanTruck> ArdeliveryPlanTrucks { get; set; } = new List<ArdeliveryPlanTruck>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Vmvehicles")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("Vmvehicles")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkVmvehicleGroupId")]
    [InverseProperty("Vmvehicles")]
    public virtual VmvehicleGroup FkVmvehicleGroup { get; set; }

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<HradvanceRefundItemInvoice> HradvanceRefundItemInvoices { get; set; } = new List<HradvanceRefundItemInvoice>();

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<VmvehicleEmployee> VmvehicleEmployees { get; set; } = new List<VmvehicleEmployee>();

    [InverseProperty("FkVmvehicle")]
    public virtual ICollection<VmvehicleFuelLog> VmvehicleFuelLogs { get; set; } = new List<VmvehicleFuelLog>();
}
