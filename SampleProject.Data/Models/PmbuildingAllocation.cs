using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMBuildingAllocations")]
public partial class PmbuildingAllocation
{
    [Key]
    [Column("PMBuildingAllocationID")]
    public int PmbuildingAllocationId { get; set; }

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
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HREmployeeValidated")]
    public int? FkHremployeeValidated { get; set; }

    [Column("FK_HREmployeeApproved")]
    public int? FkHremployeeApproved { get; set; }

    [Column("FK_PMBuildingPlanID")]
    public int? FkPmbuildingPlanId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("PMPMBuildingAllocationNo")]
    [StringLength(50)]
    public string PmpmbuildingAllocationNo { get; set; }

    [Column("PMPMBuildingAllocationDesc")]
    [StringLength(512)]
    public string PmpmbuildingAllocationDesc { get; set; }

    [Column("PMPMBuildingAllocationDate", TypeName = "datetime")]
    public DateTime? PmpmbuildingAllocationDate { get; set; }

    [Column("PMPMBuildingAllocationStatus")]
    [StringLength(50)]
    public string PmpmbuildingAllocationStatus { get; set; }

    [Column("PMPMBuildingAllocationValidateDate", TypeName = "datetime")]
    public DateTime? PmpmbuildingAllocationValidateDate { get; set; }

    [Column("PMPMBuildingAllocationApprovedDate", TypeName = "datetime")]
    public DateTime? PmpmbuildingAllocationApprovedDate { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmbuildingAllocationFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApproved")]
    [InverseProperty("PmbuildingAllocationFkHremployeeApprovedNavigations")]
    public virtual Hremployee FkHremployeeApprovedNavigation { get; set; }

    [ForeignKey("FkHremployeeValidated")]
    [InverseProperty("PmbuildingAllocationFkHremployeeValidatedNavigations")]
    public virtual Hremployee FkHremployeeValidatedNavigation { get; set; }

    [ForeignKey("FkPmbuildingPlanId")]
    [InverseProperty("PmbuildingAllocations")]
    public virtual PmbuildingPlan FkPmbuildingPlan { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmbuildingAllocations")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkPmbuildingAllocation")]
    public virtual ICollection<PmbuildingAllocationItem> PmbuildingAllocationItems { get; set; } = new List<PmbuildingAllocationItem>();
}
