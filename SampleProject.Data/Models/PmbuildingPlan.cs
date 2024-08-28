using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMBuildingPlans")]
public partial class PmbuildingPlan
{
    [Key]
    [Column("PMBuildingPlanID")]
    public int PmbuildingPlanId { get; set; }

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

    [Column("FK_PMBuidingCommandID")]
    public int? FkPmbuidingCommandId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_PMProjectID")]
    public int? FkPmprojectId { get; set; }

    [Column("PMBuildingPlanNo")]
    [StringLength(50)]
    public string PmbuildingPlanNo { get; set; }

    [Column("PMBuildingPlanDesc")]
    [StringLength(512)]
    public string PmbuildingPlanDesc { get; set; }

    [Column("PMBuildingPlanDate", TypeName = "datetime")]
    public DateTime? PmbuildingPlanDate { get; set; }

    [Column("PMBuildingPlanStatus")]
    [StringLength(50)]
    public string PmbuildingPlanStatus { get; set; }

    [Column("PMBuildingPlanValidateDate", TypeName = "datetime")]
    public DateTime? PmbuildingPlanValidateDate { get; set; }

    [Column("PMBuildingPlanApprovedDate", TypeName = "datetime")]
    public DateTime? PmbuildingPlanApprovedDate { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("PmbuildingPlans")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("PmbuildingPlans")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("PmbuildingPlanFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApproved")]
    [InverseProperty("PmbuildingPlanFkHremployeeApprovedNavigations")]
    public virtual Hremployee FkHremployeeApprovedNavigation { get; set; }

    [ForeignKey("FkHremployeeValidated")]
    [InverseProperty("PmbuildingPlanFkHremployeeValidatedNavigations")]
    public virtual Hremployee FkHremployeeValidatedNavigation { get; set; }

    [ForeignKey("FkPmbuidingCommandId")]
    [InverseProperty("PmbuildingPlans")]
    public virtual PmbuidingCommand FkPmbuidingCommand { get; set; }

    [ForeignKey("FkPmprojectId")]
    [InverseProperty("PmbuildingPlans")]
    public virtual Pmproject FkPmproject { get; set; }

    [InverseProperty("FkPmbuildingPlan")]
    public virtual ICollection<PmbuildingAllocationItem> PmbuildingAllocationItems { get; set; } = new List<PmbuildingAllocationItem>();

    [InverseProperty("FkPmbuildingPlan")]
    public virtual ICollection<PmbuildingAllocation> PmbuildingAllocations { get; set; } = new List<PmbuildingAllocation>();

    [InverseProperty("FkPmbuildingPlan")]
    public virtual ICollection<PmbuildingPlanItem> PmbuildingPlanItems { get; set; } = new List<PmbuildingPlanItem>();
}
