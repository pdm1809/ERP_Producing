using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADUserGroupMembers")]
public partial class AduserGroupMember
{
    [Key]
    [Column("ADUserGroupMemberID")]
    public int AduserGroupMemberId { get; set; }

    [Required]
    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("FK_ADUserGroupID")]
    public int FkAduserGroupId { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("AduserGroupMembers")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("AduserGroupMembers")]
    public virtual Hremployee FkHremployee { get; set; }
}
