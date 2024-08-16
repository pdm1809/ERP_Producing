using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACVATs")]
public partial class Acvat
{
    [Key]
    [Column("ACVATID")]
    public int Acvatid { get; set; }

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

    [Required]
    [Column("ACVATNo")]
    [StringLength(50)]
    public string Acvatno { get; set; }

    [Required]
    [Column("ACVATInvoiceType")]
    [StringLength(500)]
    public string AcvatinvoiceType { get; set; }

    [Required]
    [Column("ACVATDocumentType")]
    [StringLength(500)]
    public string AcvatdocumentType { get; set; }

    [Column("ACVATInvoiceNo")]
    [StringLength(50)]
    public string AcvatinvoiceNo { get; set; }

    [Column("ACVATStatus")]
    [StringLength(100)]
    public string Acvatstatus { get; set; }

    [Column("ACVATSymbol")]
    [StringLength(50)]
    public string Acvatsymbol { get; set; }

    [Column("ACVATInvoiceDate", TypeName = "datetime")]
    public DateTime AcvatinvoiceDate { get; set; }

    [Column("FK_ACObjectID")]
    public int FkAcobjectId { get; set; }

    [Column("ACObjectType")]
    [StringLength(50)]
    public string AcobjectType { get; set; }

    [Column("ACVATObjectName")]
    [StringLength(200)]
    public string AcvatobjectName { get; set; }

    [Column("ACVATObjectAddress")]
    [StringLength(200)]
    public string AcvatobjectAddress { get; set; }

    [Column("ACVATObjectTaxNumber")]
    [StringLength(50)]
    public string AcvatobjectTaxNumber { get; set; }

    [Column("ACVATObjectCareer")]
    [StringLength(100)]
    public string AcvatobjectCareer { get; set; }

    [Column("ACVATDesc")]
    [StringLength(500)]
    public string Acvatdesc { get; set; }

    [Column("ACVATAmount", TypeName = "decimal(18, 5)")]
    public decimal? Acvatamount { get; set; }

    [Column("ACVATTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? AcvattaxPercent { get; set; }

    [Column("ACVATTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcvattaxAmount { get; set; }

    [Column("ACVATTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? AcvattotalAmount { get; set; }

    [Column("ACVATInvoiceDeliveryDate", TypeName = "datetime")]
    public DateTime? AcvatinvoiceDeliveryDate { get; set; }

    [Column("ACVATInvoiceDeliveryName")]
    [StringLength(100)]
    public string AcvatinvoiceDeliveryName { get; set; }

    [Column("ACVATReceiver")]
    [StringLength(100)]
    public string Acvatreceiver { get; set; }

    [Column("ACVATComment")]
    [StringLength(500)]
    public string Acvatcomment { get; set; }

    [Column("ACVATInvoiceComment")]
    [StringLength(500)]
    public string AcvatinvoiceComment { get; set; }

    [Column("ACVATDocumentNo")]
    [StringLength(50)]
    public string AcvatdocumentNo { get; set; }

    [Column("ACVATModuleName")]
    [StringLength(50)]
    public string AcvatmoduleName { get; set; }

    [Column("ACVATDate", TypeName = "datetime")]
    public DateTime? Acvatdate { get; set; }
}
