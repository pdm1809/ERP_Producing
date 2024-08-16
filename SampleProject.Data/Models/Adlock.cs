using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADLocks")]
public partial class Adlock
{
    [Key]
    [Column("ADLockID")]
    public int AdlockId { get; set; }

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

    [Column("ADLockFromDate", TypeName = "datetime")]
    public DateTime? AdlockFromDate { get; set; }

    [Column("ADLockToDate", TypeName = "datetime")]
    public DateTime? AdlockToDate { get; set; }

    [Column("ADLockDesc")]
    [StringLength(512)]
    public string AdlockDesc { get; set; }

    public bool? IsLocked { get; set; }
}
