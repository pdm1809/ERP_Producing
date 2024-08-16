using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAcceptanceItems")]
public partial class AcacceptanceItem
{
    [Key]
    [Column("ACAcceptanceItemID")]
    public int AcacceptanceItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ACAcceptanceID")]
    public int? FkAcacceptanceId { get; set; }

    [Column("FK_ACDeviceID")]
    public int? FkAcdeviceId { get; set; }

    [Column("FK_ACDeviceItemID")]
    public int? FkAcdeviceItemId { get; set; }

    [Column("ACAcceptanceItemDeviceName")]
    [StringLength(50)]
    public string AcacceptanceItemDeviceName { get; set; }

    [Column("ACAcceptanceItemDeviceItemName")]
    [StringLength(50)]
    public string AcacceptanceItemDeviceItemName { get; set; }

    [Column("FK_ACMaintainTypeConfigID")]
    public int? FkAcmaintainTypeConfigId { get; set; }

    [Column("FK_ACErrorID")]
    public int? FkAcerrorId { get; set; }

    [Column("FK_ACMaintainProposalID")]
    public int? FkAcmaintainProposalId { get; set; }

    [Column("ACAcceptanceItemReason")]
    [StringLength(200)]
    public string AcacceptanceItemReason { get; set; }

    [Column("ACAcceptanceItemDesc")]
    [StringLength(200)]
    public string AcacceptanceItemDesc { get; set; }

    [Column("FK_ACMaintainPlanID")]
    public int? FkAcmaintainPlanId { get; set; }

    [Column("FK_ACDetectProblemID")]
    public int? FkAcdetectProblemId { get; set; }

    [Column("FK_ACMaintainProposalItemID")]
    public int? FkAcmaintainProposalItemId { get; set; }

    [Column("ACAcceptanceItemProductIdentified")]
    [StringLength(50)]
    public string AcacceptanceItemProductIdentified { get; set; }

    [Column("ACAcceptanceItemStatus")]
    [StringLength(50)]
    public string AcacceptanceItemStatus { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICParentProductID")]
    public int? FkIcparentProductId { get; set; }

    [Column("ACAcceptanceItemIdentifierType")]
    [StringLength(50)]
    public string AcacceptanceItemIdentifierType { get; set; }

    [Column("ACMaintainProposalItemStatus")]
    [StringLength(50)]
    public string AcmaintainProposalItemStatus { get; set; }
}
