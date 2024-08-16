using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARAllocations")]
public partial class Arallocation
{
    [Key]
    [Column("ARAllocationID")]
    public int ArallocationId { get; set; }

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
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRDriverEmployeeID")]
    public int? FkHrdriverEmployeeId { get; set; }

    [Column("FK_HRProposedEmployeeID")]
    public int? FkHrproposedEmployeeId { get; set; }

    [Column("FK_ARDeliveryPlanID")]
    public int? FkArdeliveryPlanId { get; set; }

    [Column("ARAllocationNo")]
    [StringLength(50)]
    public string ArallocationNo { get; set; }

    [Column("ARAllocationName")]
    [StringLength(100)]
    public string ArallocationName { get; set; }

    [Column("ARAllocationDesc")]
    [StringLength(512)]
    public string ArallocationDesc { get; set; }

    [Column("ARAllocationComment")]
    [StringLength(512)]
    public string ArallocationComment { get; set; }

    [Column("ARAllocationDate", TypeName = "datetime")]
    public DateTime? ArallocationDate { get; set; }

    [Column("ARAllocationStatus")]
    [StringLength(50)]
    public string ArallocationStatus { get; set; }

    [Column("ARAllocationExpediencyQty", TypeName = "decimal(18, 5)")]
    public decimal? ArallocationExpediencyQty { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_PMProjectID")]
    public int FkPmprojectId { get; set; }

    [InverseProperty("FkArallocation")]
    public virtual ICollection<ArallocationItem> ArallocationItems { get; set; } = new List<ArallocationItem>();

    [InverseProperty("FkArallocation")]
    public virtual ICollection<Arreception> Arreceptions { get; set; } = new List<Arreception>();

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("Arallocations")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Arallocations")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHrdriverEmployeeId")]
    [InverseProperty("ArallocationFkHrdriverEmployees")]
    public virtual Hremployee FkHrdriverEmployee { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArallocationFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrproposedEmployeeId")]
    [InverseProperty("ArallocationFkHrproposedEmployees")]
    public virtual Hremployee FkHrproposedEmployee { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("Arallocations")]
    public virtual Pmproject FkPmproject { get; set; }
}
