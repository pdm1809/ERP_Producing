using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEPaymentTerms")]
public partial class GepaymentTerm
{
    [Key]
    [Column("GEPaymentTermID")]
    public int GepaymentTermId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("GEPaymentTermNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string GepaymentTermNo { get; set; }

    [Required]
    [Column("GEPaymentTermName")]
    [StringLength(256)]
    public string GepaymentTermName { get; set; }

    [Column("GEPaymentTermDay")]
    public int? GepaymentTermDay { get; set; }

    [Column("GEPaymentTermActiveCheck")]
    public bool? GepaymentTermActiveCheck { get; set; }

    [Column("GEPaymentTermType")]
    [StringLength(50)]
    public string GepaymentTermType { get; set; }

    [Column("GEPaymentTermPercentPayment")]
    public int? GepaymentTermPercentPayment { get; set; }

    [Column("GEPaymentTermIsContract")]
    public bool? GepaymentTermIsContract { get; set; }

    [Column("GEPaymentTermIsBeforeDelivery")]
    public bool? GepaymentTermIsBeforeDelivery { get; set; }

    [Column("GEPaymentTermIsAfterDelivery")]
    public bool? GepaymentTermIsAfterDelivery { get; set; }

    [InverseProperty("FkGepaymentTerm")]
    public virtual ICollection<ApbillOfLading> ApbillOfLadings { get; set; } = new List<ApbillOfLading>();

    [InverseProperty("FkGepaymentTerm")]
    public virtual ICollection<AppurchaseOrderPaymentTime> AppurchaseOrderPaymentTimes { get; set; } = new List<AppurchaseOrderPaymentTime>();

    [InverseProperty("FkGepaymentTerm")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkGepaymentTerm")]
    public virtual ICollection<Apsupplier> Apsuppliers { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkGepaymentTerm")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkGepaymentTerm")]
    public virtual ICollection<ArproposalPaymentTime> ArproposalPaymentTimes { get; set; } = new List<ArproposalPaymentTime>();

    [InverseProperty("FkGepaymentTerm")]
    public virtual ICollection<Arproposal> Arproposals { get; set; } = new List<Arproposal>();

    [InverseProperty("FkGepaymentTerm")]
    public virtual ICollection<ArsaleForecast> ArsaleForecasts { get; set; } = new List<ArsaleForecast>();

    [InverseProperty("FkGepaymentTerm")]
    public virtual ICollection<ArsaleOrderPaymentTime> ArsaleOrderPaymentTimes { get; set; } = new List<ArsaleOrderPaymentTime>();

    [InverseProperty("FkGepaymentTerm")]
    public virtual ICollection<ArsaleOrder> ArsaleOrders { get; set; } = new List<ArsaleOrder>();

    [InverseProperty("FkGepaymentTerm")]
    public virtual ICollection<GepaymentTermItem> GepaymentTermItems { get; set; } = new List<GepaymentTermItem>();
}
