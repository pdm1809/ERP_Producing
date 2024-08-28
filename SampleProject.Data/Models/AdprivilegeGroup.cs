using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADPrivilegeGroups")]
public partial class AdprivilegeGroup
{
    [Key]
    [Column("ADPrivilegeGroupID")]
    public int AdprivilegeGroupId { get; set; }

    [Column("ADPrivilegeGroupDesc")]
    [StringLength(512)]
    public string AdprivilegeGroupDesc { get; set; }

    [Required]
    [Column("ADPrivilegeGroupName")]
    [StringLength(50)]
    public string AdprivilegeGroupName { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [InverseProperty("AdprivilegeGroup")]
    public virtual ICollection<Adprivilege> Adprivileges { get; set; } = new List<Adprivilege>();
}
