using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEPaymentTermItems")]
public partial class GepaymentTermItem
{
    [Key]
    [Column("GEPaymentTermItemID")]
    public int GepaymentTermItemId { get; set; }

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

    [Column("FK_GEPaymentTermID")]
    public int FkGepaymentTermId { get; set; }

    [Column("GEPaymentTermItemDay")]
    public int? GepaymentTermItemDay { get; set; }

    [Required]
    [Column("GEPaymentTermItemType")]
    [StringLength(50)]
    public string GepaymentTermItemType { get; set; }

    [Column("GEPaymentTermItemPercentPayment")]
    public int? GepaymentTermItemPercentPayment { get; set; }

    [Column("GEPaymentTermItemPaymentDate")]
    [StringLength(50)]
    [Unicode(false)]
    public string GepaymentTermItemPaymentDate { get; set; }

    [Required]
    [Column("GEPaymentTermItemPaymentType")]
    [StringLength(50)]
    public string GepaymentTermItemPaymentType { get; set; }

    [Column("GEWeekDay")]
    [StringLength(50)]
    public string GeweekDay { get; set; }

    [Column("GEMonthDay")]
    [StringLength(50)]
    public string GemonthDay { get; set; }

    [Column("GEPaymentTermItemDesc")]
    [StringLength(512)]
    public string GepaymentTermItemDesc { get; set; }

    [Column("GEPaymentTermItemEnglishDesc")]
    [StringLength(512)]
    public string GepaymentTermItemEnglishDesc { get; set; }

    [Column("GEPaymentTermItemComment")]
    [StringLength(1024)]
    public string GepaymentTermItemComment { get; set; }

    [InverseProperty("FkGepaymentTermItem")]
    public virtual ICollection<AppurchaseOrderPaymentTime> AppurchaseOrderPaymentTimes { get; set; } = new List<AppurchaseOrderPaymentTime>();

    [InverseProperty("FkGepaymentTermItem")]
    public virtual ICollection<ArproposalPaymentTime> ArproposalPaymentTimes { get; set; } = new List<ArproposalPaymentTime>();

    [InverseProperty("FkGepaymentTermItem")]
    public virtual ICollection<ArsaleOrderPaymentTime> ArsaleOrderPaymentTimes { get; set; } = new List<ArsaleOrderPaymentTime>();

    [ForeignKey("FkGepaymentTermId")]
    [InverseProperty("GepaymentTermItems")]
    public virtual GepaymentTerm FkGepaymentTerm { get; set; }
}
