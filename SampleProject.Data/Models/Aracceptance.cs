using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARAcceptances")]
public partial class Aracceptance
{
    [Key]
    [Column("ARAcceptanceID")]
    public int AracceptanceId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ARAcceptanceNo")]
    [StringLength(50)]
    public string AracceptanceNo { get; set; }

    [Column("ARAcceptanceName")]
    [StringLength(128)]
    public string AracceptanceName { get; set; }

    [Column("ARAcceptanceDate", TypeName = "datetime")]
    public DateTime? AracceptanceDate { get; set; }

    [Column("ARAcceptanceDesc")]
    [StringLength(512)]
    public string AracceptanceDesc { get; set; }

    [Column("ARAcceptanceType")]
    [StringLength(50)]
    public string AracceptanceType { get; set; }

    [Column("ARAcceptanceStatus")]
    [StringLength(50)]
    public string AracceptanceStatus { get; set; }

    [Column("ARAcceptanceResult")]
    [StringLength(50)]
    public string AracceptanceResult { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("ARObjectType")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArobjectType { get; set; }

    [Column("ARAcceptanceReference")]
    [StringLength(128)]
    public string AracceptanceReference { get; set; }

    [Column("ARAcceptancePONo")]
    [StringLength(50)]
    public string AracceptancePono { get; set; }

    [Column("ARAcceptanceDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceDiscountPerCent { get; set; }

    [Column("ARAcceptanceDiscountFix", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceDiscountFix { get; set; }

    [Column("ARAcceptanceTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceTaxPercent { get; set; }

    [Column("ARAcceptanceTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceTaxAmount { get; set; }

    [Column("ARAcceptanceSubTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceSubTotalAmount { get; set; }

    [Column("ARAcceptanceTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceTotalAmount { get; set; }

    [Column("ARAcceptanceDepositBalance", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceDepositBalance { get; set; }

    [Column("ARAcceptanceTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? AracceptanceTotalCost { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("ARAcceptanceIsReceiveBill")]
    public bool? AracceptanceIsReceiveBill { get; set; }

    [Column("FK_ACCostCenterID")]
    public int? FkAccostCenterId { get; set; }

    [Column("FK_ARSaleContractID")]
    public int? FkArsaleContractId { get; set; }

    [Column("FK_PMTemplateID")]
    public int? FkPmtemplateId { get; set; }

    [Column("FK_ARInvoiceRequestID")]
    public int? FkArinvoiceRequestId { get; set; }

    [InverseProperty("FkAracceptance")]
    public virtual ICollection<AracceptanceItemWork> AracceptanceItemWorks { get; set; } = new List<AracceptanceItemWork>();

    [InverseProperty("FkAracceptance")]
    public virtual ICollection<AracceptanceItem> AracceptanceItems { get; set; } = new List<AracceptanceItem>();

    [InverseProperty("FkAracceptance")]
    public virtual ICollection<ArinvoiceItem> ArinvoiceItems { get; set; } = new List<ArinvoiceItem>();

    [ForeignKey("FkAccostCenterId")]
    [InverseProperty("Aracceptances")]
    public virtual AccostCenter FkAccostCenter { get; set; }

    [ForeignKey("FkArinvoiceRequestId")]
    [InverseProperty("Aracceptances")]
    public virtual ArinvoiceRequest FkArinvoiceRequest { get; set; }

    [ForeignKey("FkArsaleContractId")]
    [InverseProperty("Aracceptances")]
    public virtual ArsaleContract FkArsaleContract { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("Aracceptances")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Aracceptances")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Aracceptances")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("Aracceptances")]
    public virtual Pmproject FkPmproject { get; set; }

    [ForeignKey("FkPmtemplateId")]
    [InverseProperty("Aracceptances")]
    public virtual Pmtemplate FkPmtemplate { get; set; }
}
