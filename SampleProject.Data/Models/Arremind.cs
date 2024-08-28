using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARReminds")]
public partial class Arremind
{
    [Key]
    [Column("ARRemindID")]
    public int ArremindId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerID")]
    public int FkArcustomerId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARProposalID")]
    public int? FkArproposalId { get; set; }

    [Required]
    [Column("ARRemindNo")]
    [StringLength(50)]
    public string ArremindNo { get; set; }

    [Column("ARRemindName")]
    [StringLength(100)]
    public string ArremindName { get; set; }

    [Column("ARRemindDesc")]
    [StringLength(512)]
    public string ArremindDesc { get; set; }

    [Column("ARRemindDate", TypeName = "datetime")]
    public DateTime? ArremindDate { get; set; }

    [Required]
    [Column("ARRemindType")]
    [StringLength(50)]
    public string ArremindType { get; set; }

    [Column("ARRemindStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArremindStatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("Arreminds")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArproposalId")]
    [InverseProperty("Arreminds")]
    public virtual Arproposal FkArproposal { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("Arreminds")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Arreminds")]
    public virtual Hremployee FkHremployee { get; set; }
}
