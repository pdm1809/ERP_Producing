using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADGroupOrderWebs")]
public partial class AdgroupOrderWeb
{
    [Key]
    [Column("ADGroupOrderWebID")]
    public int AdgroupOrderWebId { get; set; }

    [Column("ADGroupOrderWebDesc")]
    [StringLength(200)]
    public string AdgroupOrderWebDesc { get; set; }

    [Required]
    [Column("ADGroupOrderWebName")]
    [StringLength(100)]
    public string AdgroupOrderWebName { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ADGroupOrderWebRole")]
    [StringLength(128)]
    [Unicode(false)]
    public string AdgroupOrderWebRole { get; set; }

    [InverseProperty("FkAdgroupOrderWeb")]
    public virtual ICollection<HremployeeGroupOrderWeb> HremployeeGroupOrderWebs { get; set; } = new List<HremployeeGroupOrderWeb>();
}
