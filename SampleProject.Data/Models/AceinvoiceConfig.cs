using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEInvoiceConfigs")]
public partial class AceinvoiceConfig
{
    [Key]
    [Column("ACEInvoiceConfigID")]
    public int AceinvoiceConfigId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ACEInvoiceConfigAccount")]
    [StringLength(100)]
    public string AceinvoiceConfigAccount { get; set; }

    [Column("ACEInvoiceConfigACpass")]
    [StringLength(50)]
    public string AceinvoiceConfigAcpass { get; set; }

    [Column("ACEInvoiceConfigUsername")]
    [StringLength(100)]
    public string AceinvoiceConfigUsername { get; set; }

    [Column("ACEInvoiceConfigPassword")]
    [StringLength(50)]
    public string AceinvoiceConfigPassword { get; set; }

    [Column("ACEInvoiceConfigCertStr")]
    [StringLength(100)]
    public string AceinvoiceConfigCertStr { get; set; }

    [Column("ACEInvoiceConfigLinkWS")]
    [StringLength(512)]
    public string AceinvoiceConfigLinkWs { get; set; }

    [Column("ACEInvoiceConfigBkavPartnerGUID")]
    [StringLength(512)]
    public string AceinvoiceConfigBkavPartnerGuid { get; set; }

    [Column("ACEInvoiceConfigBkavPartnerToken")]
    [StringLength(512)]
    public string AceinvoiceConfigBkavPartnerToken { get; set; }

    [Column("ACEInvoiceConfigTaxNumber")]
    [StringLength(50)]
    public string AceinvoiceConfigTaxNumber { get; set; }

    [Column("FK_ACTaxUnitID")]
    public int? FkActaxUnitId { get; set; }

    [Column("ACEInvoiceConfigPartnerType")]
    [StringLength(100)]
    public string AceinvoiceConfigPartnerType { get; set; }

    [ForeignKey("FkActaxUnitId")]
    [InverseProperty("AceinvoiceConfigs")]
    public virtual ActaxUnit FkActaxUnit { get; set; }
}
