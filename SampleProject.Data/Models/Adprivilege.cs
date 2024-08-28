using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADPrivileges")]
[Microsoft.EntityFrameworkCore.Index("AdprivilegeNo", Name = "Idx_ADPrivileges")]
public partial class Adprivilege
{
    [Key]
    [Column("ADPrivilegeID")]
    public int AdprivilegeId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADPrivilegeNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdprivilegeNo { get; set; }

    [Required]
    [Column("ADPrivilegeName")]
    [StringLength(100)]
    [Unicode(false)]
    public string AdprivilegeName { get; set; }

    [Column("ADPrivilegeDesc")]
    [StringLength(512)]
    public string AdprivilegeDesc { get; set; }

    [Column("FK_STModuleID")]
    public int FkStmoduleId { get; set; }

    [Required]
    [Column("ADPrivilegeCaption")]
    [StringLength(100)]
    public string AdprivilegeCaption { get; set; }

    [Column("ADPrivilegeGroupID")]
    public int? AdprivilegeGroupId { get; set; }

    [InverseProperty("FkAdprivilege")]
    public virtual ICollection<AdprivilegeDetail> AdprivilegeDetails { get; set; } = new List<AdprivilegeDetail>();

    [ForeignKey("AdprivilegeGroupId")]
    [InverseProperty("Adprivileges")]
    public virtual AdprivilegeGroup AdprivilegeGroup { get; set; }

    [InverseProperty("FkAdprivilege")]
    public virtual ICollection<AdprivilegeUserGroup> AdprivilegeUserGroups { get; set; } = new List<AdprivilegeUserGroup>();

    [ForeignKey("FkStmoduleId")]
    [InverseProperty("Adprivileges")]
    public virtual Stmodule FkStmodule { get; set; }
}
