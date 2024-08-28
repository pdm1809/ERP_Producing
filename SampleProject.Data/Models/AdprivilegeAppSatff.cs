using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADPrivilegeAppSatffs")]
public partial class AdprivilegeAppSatff
{
    [Key]
    [Column("ADPrivilegeAppSatffID")]
    public int AdprivilegeAppSatffId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADPrivilegeAppSatffNo")]
    [StringLength(512)]
    public string AdprivilegeAppSatffNo { get; set; }

    [Required]
    [Column("ADPrivilegeAppSatffName")]
    [StringLength(512)]
    public string AdprivilegeAppSatffName { get; set; }

    [Column("ADPrivilegeAppSatffDesc")]
    [StringLength(512)]
    public string AdprivilegeAppSatffDesc { get; set; }

    [Required]
    [Column("ADPrivilegeAppSatffCaption")]
    [StringLength(100)]
    public string AdprivilegeAppSatffCaption { get; set; }

    [Column("ADPrivilegeAppSatffGroup")]
    [StringLength(512)]
    public string AdprivilegeAppSatffGroup { get; set; }

    [InverseProperty("FkAdprivilegeAppSatff")]
    public virtual ICollection<AddataViewPermissionAppStaff> AddataViewPermissionAppStaffs { get; set; } = new List<AddataViewPermissionAppStaff>();
}
