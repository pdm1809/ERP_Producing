using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMConsumableConfigs")]
public partial class MmconsumableConfig
{
    [Key]
    [Column("MMConsumableConfigID")]
    public int MmconsumableConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("MMConsumableConfigNo")]
    [StringLength(50)]
    public string MmconsumableConfigNo { get; set; }

    [Required]
    [Column("MMConsumableConfigAttributeValue")]
    [StringLength(100)]
    public string MmconsumableConfigAttributeValue { get; set; }

    [Column("MMConsumableConfigValue", TypeName = "decimal(18, 5)")]
    public decimal? MmconsumableConfigValue { get; set; }

    [Column("FK_ICProductAttributeID")]
    public int FkIcproductAttributeId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmconsumableConfigs")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeId")]
    [InverseProperty("MmconsumableConfigs")]
    public virtual IcproductAttribute FkIcproductAttribute { get; set; }
}
