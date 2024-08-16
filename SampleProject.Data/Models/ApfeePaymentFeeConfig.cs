using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APFeePaymentFeeConfigs")]
public partial class ApfeePaymentFeeConfig
{
    [Key]
    [Column("APFeePaymentFeeConfigID")]
    public int ApfeePaymentFeeConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACDocumentID")]
    public int FkAcdocumentId { get; set; }

    [Column("FK_ICFeeConfigID")]
    public int FkIcfeeConfigId { get; set; }

    [Column("APFeePaymentFeeConfigAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentFeeConfigAmount { get; set; }

    [Column("APFeePaymentFeeConfigSpecialConsumptionTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentFeeConfigSpecialConsumptionTaxPercent { get; set; }

    [Column("APFeePaymentFeeConfigSpecialConsumptionTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentFeeConfigSpecialConsumptionTaxAmount { get; set; }

    [Column("APFeePaymentFeeConfigImportAndExportTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentFeeConfigImportAndExportTaxPercent { get; set; }

    [Column("APFeePaymentFeeConfigImportAndExportTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentFeeConfigImportAndExportTaxAmount { get; set; }

    [Column("APFeePaymentFeeConfigEnvironmentalProtectionTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentFeeConfigEnvironmentalProtectionTaxPercent { get; set; }

    [Column("APFeePaymentFeeConfigEnvironmentalProtectionTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentFeeConfigEnvironmentalProtectionTaxAmount { get; set; }

    [Column("APFeePaymentFeeConfigInvoiceDate", TypeName = "datetime")]
    public DateTime? ApfeePaymentFeeConfigInvoiceDate { get; set; }

    [Column("APFeePaymentFeeConfigVATSymbol")]
    [StringLength(50)]
    public string ApfeePaymentFeeConfigVatsymbol { get; set; }

    [Column("APFeePaymentFeeConfigInvoiceNumber")]
    [StringLength(50)]
    public string ApfeePaymentFeeConfigInvoiceNumber { get; set; }

    [Column("APFeePaymentFeeConfigVATFormNo")]
    [StringLength(50)]
    public string ApfeePaymentFeeConfigVatformNo { get; set; }

    [Column("APInputVATDocumentType")]
    [StringLength(50)]
    public string ApinputVatdocumentType { get; set; }

    [Column("APFeePaymentFeeConfigTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentFeeConfigTaxPercent { get; set; }

    [Column("APFeePaymentFeeConfigTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentFeeConfigTaxAmount { get; set; }

    [Column("FK_ACSegmentID")]
    public int? FkAcsegmentId { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("APFeePaymentFeeConfigComment")]
    [StringLength(512)]
    public string ApfeePaymentFeeConfigComment { get; set; }

    [Column("APFeePaymentFeeConfigTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentFeeConfigTotalAmount { get; set; }

    [Column("APFeePaymentFeeConfigVATStatus")]
    [StringLength(64)]
    public string ApfeePaymentFeeConfigVatstatus { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    public string ApobjectType { get; set; }

    [Column("APFeePaymentFeeConfigObjectName")]
    [StringLength(50)]
    public string ApfeePaymentFeeConfigObjectName { get; set; }

    [Column("APFeePaymentFeeConfigObjectTaxNumber")]
    [StringLength(50)]
    public string ApfeePaymentFeeConfigObjectTaxNumber { get; set; }

    [Column("FK_VMVehicleID")]
    public int? FkVmvehicleId { get; set; }

    [Column("FK_ACEInvoiceTypeID")]
    public int? FkAceinvoiceTypeId { get; set; }

    [Column("APFeePaymentFeeConfigType")]
    [StringLength(50)]
    public string ApfeePaymentFeeConfigType { get; set; }

    [Column("APFeePaymentFeeConfigNo")]
    [StringLength(50)]
    public string ApfeePaymentFeeConfigNo { get; set; }

    [Column("FK_GETerminalID")]
    public int? FkGeterminalId { get; set; }

    [Column("FK_GEContainerID")]
    public int? FkGecontainerId { get; set; }

    [Column("FK_GEUnitCostID")]
    public int? FkGeunitCostId { get; set; }

    [Column("APFeePaymentFeeConfigQty", TypeName = "decimal(18, 5)")]
    public decimal? ApfeePaymentFeeConfigQty { get; set; }

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("ApfeePaymentFeeConfigs")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkAcdocumentId")]
    [InverseProperty("ApfeePaymentFeeConfigs")]
    public virtual Acdocument FkAcdocument { get; set; }

    [ForeignKey("FkAceinvoiceTypeId")]
    [InverseProperty("ApfeePaymentFeeConfigs")]
    public virtual AceinvoiceType FkAceinvoiceType { get; set; }

    [ForeignKey("FkAcsegmentId")]
    [InverseProperty("ApfeePaymentFeeConfigs")]
    public virtual Acsegment FkAcsegment { get; set; }

    [ForeignKey("FkGecontainerId")]
    [InverseProperty("ApfeePaymentFeeConfigs")]
    public virtual Gecontainer FkGecontainer { get; set; }

    [ForeignKey("FkGeterminalId")]
    [InverseProperty("ApfeePaymentFeeConfigs")]
    public virtual Geterminal FkGeterminal { get; set; }

    [ForeignKey("FkGeunitCostId")]
    [InverseProperty("ApfeePaymentFeeConfigs")]
    public virtual GeunitCost FkGeunitCost { get; set; }

    [ForeignKey("FkIcfeeConfigId")]
    [InverseProperty("ApfeePaymentFeeConfigs")]
    public virtual IcfeeConfig FkIcfeeConfig { get; set; }

    [ForeignKey("FkVmvehicleId")]
    [InverseProperty("ApfeePaymentFeeConfigs")]
    public virtual Vmvehicle FkVmvehicle { get; set; }
}
