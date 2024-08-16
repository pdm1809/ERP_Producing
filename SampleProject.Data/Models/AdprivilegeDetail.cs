using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADPrivilegeDetails")]
public partial class AdprivilegeDetail
{
    [Key]
    [Column("ARPrivilegeDetailID")]
    public int ArprivilegeDetailId { get; set; }

    [Column("ARPrivilegeDetailDesc")]
    [StringLength(512)]
    public string ArprivilegeDetailDesc { get; set; }

    [Required]
    [Column("ARPrivilegeDetailName")]
    [StringLength(50)]
    public string ArprivilegeDetailName { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ARPrivilegeDetailValue")]
    [StringLength(200)]
    [Unicode(false)]
    public string ArprivilegeDetailValue { get; set; }

    [Column("FK_ADPrivilegeID")]
    public int? FkAdprivilegeId { get; set; }

    [ForeignKey("FkAdprivilegeId")]
    [InverseProperty("AdprivilegeDetails")]
    public virtual Adprivilege FkAdprivilege { get; set; }
}
