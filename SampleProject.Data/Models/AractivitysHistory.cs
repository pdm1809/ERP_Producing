using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("AractivityId", "Rev")]
[Table("ARActivitys_HISTORYS", Schema = "CRM_VINMUS_AUDIT")]
public partial class AractivitysHistory
{
    [Key]
    [Column("ARActivityID")]
    public int AractivityId { get; set; }

    [Key]
    [Column("REV")]
    public int Rev { get; set; }

    [Column("REVTYPE")]
    public short? Revtype { get; set; }

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

    [Column("ARActivityName")]
    [StringLength(100)]
    public string AractivityName { get; set; }

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

    public bool IsShare { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("Rev")]
    [InverseProperty("AractivitysHistories")]
    public virtual Revinfo RevNavigation { get; set; }
}
