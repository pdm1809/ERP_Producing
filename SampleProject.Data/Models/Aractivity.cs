using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARActivitys")]
public partial class Aractivity
{
    [Key]
    [Column("ARActivityID")]
    public int AractivityId { get; set; }

    [Column("ARActivityObjectType")]
    [StringLength(100)]
    public string AractivityObjectType { get; set; }

    [Column("ARActivityObjectTypeID")]
    public long? AractivityObjectTypeId { get; set; }

    [Column("ARActivityObjectTypeName")]
    [StringLength(100)]
    public string AractivityObjectTypeName { get; set; }

    [Column("ARActivityStatus")]
    [StringLength(100)]
    public string AractivityStatus { get; set; }

    [Column("ARActivityType")]
    [StringLength(100)]
    public string AractivityType { get; set; }

    [Column("ARActivityAddress")]
    [StringLength(200)]
    public string AractivityAddress { get; set; }

    [Column("ARActivityAssignedTo")]
    [StringLength(50)]
    public string AractivityAssignedTo { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("CreatedUserID")]
    public int? CreatedUserId { get; set; }

    [Column("ARActivityNameDescription")]
    [StringLength(2000)]
    public string AractivityNameDescription { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ARActivityEndDate", TypeName = "datetime")]
    public DateTime? AractivityEndDate { get; set; }

    [Column("ARActivityEventType")]
    [StringLength(100)]
    public string AractivityEventType { get; set; }

    [Required]
    [Column("ARActivityName")]
    [StringLength(100)]
    public string AractivityName { get; set; }

    [Column("REV")]
    public long? Rev { get; set; }

    [Column("REVTYPE")]
    public long? Revtype { get; set; }

    [Column("ARActivityStartDate", TypeName = "datetime")]
    public DateTime? AractivityStartDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("UpdatedUserID")]
    public int? UpdatedUserId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ARActivityWorkType")]
    [StringLength(200)]
    public string AractivityWorkType { get; set; }

    public bool IsShare { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("Aractivities")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Aractivities")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Aractivities")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrgroupId")]
    [InverseProperty("Aractivities")]
    public virtual Hrgroup FkHrgroup { get; set; }
}
