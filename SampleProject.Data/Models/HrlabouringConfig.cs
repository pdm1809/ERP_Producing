using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLabouringConfigs")]
public partial class HrlabouringConfig
{
    [Key]
    [Column("HRLabouringConfigID")]
    public int HrlabouringConfigId { get; set; }

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

    [Column("HRLabouringConfigNo")]
    [StringLength(50)]
    public string HrlabouringConfigNo { get; set; }

    [Column("HRLabouringConfigDateType")]
    [StringLength(50)]
    public string HrlabouringConfigDateType { get; set; }

    [Column("HRLabouringConfigDate", TypeName = "datetime")]
    public DateTime HrlabouringConfigDate { get; set; }

    [Column("HRLabouringConfigDesc")]
    [StringLength(2000)]
    public string HrlabouringConfigDesc { get; set; }

    [InverseProperty("FkHrlabouringConfig")]
    public virtual ICollection<HrlabouringConfigItem> HrlabouringConfigItems { get; set; } = new List<HrlabouringConfigItem>();
}
