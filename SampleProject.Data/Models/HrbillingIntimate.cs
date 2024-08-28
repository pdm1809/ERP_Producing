using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRBillingIntimates")]
public partial class HrbillingIntimate
{
    [Key]
    [Column("HRBillingIntimateID")]
    public int HrbillingIntimateId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("HRBillingIntimateBankAccount1")]
    [StringLength(100)]
    [Unicode(false)]
    public string HrbillingIntimateBankAccount1 { get; set; }

    [Column("HRBillingIntimateBankNo")]
    [StringLength(100)]
    public string HrbillingIntimateBankNo { get; set; }

    [Column("HRBillingIntimateTaxNumber")]
    [StringLength(100)]
    [Unicode(false)]
    public string HrbillingIntimateTaxNumber { get; set; }

    [Column("HRBillingIntimateBankName")]
    [StringLength(100)]
    public string HrbillingIntimateBankName { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrbillingIntimates")]
    public virtual Hremployee FkHremployee { get; set; }
}
