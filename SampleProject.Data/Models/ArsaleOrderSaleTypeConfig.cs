using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderSaleTypeConfigs")]
public partial class ArsaleOrderSaleTypeConfig
{
    [Key]
    [Column("ARSaleOrderSaleTypeConfigID")]
    public int ArsaleOrderSaleTypeConfigId { get; set; }

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

    [Required]
    [Column("ARSaleOrderSaleType")]
    [StringLength(100)]
    public string ArsaleOrderSaleType { get; set; }

    [Required]
    [Column("ARSaleOrderItemGrantedFrom")]
    [StringLength(100)]
    public string ArsaleOrderItemGrantedFrom { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [ForeignKey("FkGecurrencyId")]
    [InverseProperty("ArsaleOrderSaleTypeConfigs")]
    public virtual Gecurrency FkGecurrency { get; set; }
}
