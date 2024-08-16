using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRTimesheetGroups")]
public partial class HrtimesheetGroup
{
    [Key]
    [Column("HRTimesheetGroupID")]
    public int HrtimesheetGroupId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("HRTimesheetGroupName")]
    [StringLength(50)]
    public string HrtimesheetGroupName { get; set; }

    [Column("HRTimesheetGroupRemarks")]
    [StringLength(512)]
    public string HrtimesheetGroupRemarks { get; set; }
}
