using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADPrivilegeUserGroups")]
public partial class AdprivilegeUserGroup
{
    [Key]
    [Column("ADPrivilegeUserGroupID")]
    public int AdprivilegeUserGroupId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ADPrivilegeID")]
    public int FkAdprivilegeId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int FkAduserGroupId { get; set; }

    [Column("ADPrivilegeUserGroupCheck")]
    public bool AdprivilegeUserGroupCheck { get; set; }

    [ForeignKey("FkAdprivilegeId")]
    [InverseProperty("AdprivilegeUserGroups")]
    public virtual Adprivilege FkAdprivilege { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("AdprivilegeUserGroups")]
    public virtual AduserGroup FkAduserGroup { get; set; }
}
