using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADDefaultDescConfigs")]
public partial class AddefaultDescConfig
{
    [Key]
    [Column("ADDefaultDescConfigID")]
    public int AddefaultDescConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_STModuleID")]
    public int? FkStmoduleId { get; set; }

    [Column("ADSaleOrderSaleType")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdsaleOrderSaleType { get; set; }

    [Column("ADDefaultDescConfigDescValue")]
    public byte[] AddefaultDescConfigDescValue { get; set; }
}
