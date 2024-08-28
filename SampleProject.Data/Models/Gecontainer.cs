using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEContainers")]
public partial class Gecontainer
{
    [Key]
    [Column("GEContainerID")]
    public int GecontainerId { get; set; }

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
    [Column("GEContainerNo")]
    [StringLength(50)]
    public string GecontainerNo { get; set; }

    [Required]
    [Column("GEContainerName")]
    [StringLength(512)]
    public string GecontainerName { get; set; }

    [Column("GEContainerType")]
    [StringLength(50)]
    public string GecontainerType { get; set; }

    [Column("GEContainerLenght", TypeName = "decimal(18, 5)")]
    public decimal? GecontainerLenght { get; set; }

    [Column("GEContainerWidth", TypeName = "decimal(18, 5)")]
    public decimal? GecontainerWidth { get; set; }

    [Column("GEContainerHeight", TypeName = "decimal(18, 5)")]
    public decimal? GecontainerHeight { get; set; }

    [Column("GEContainerQuantity", TypeName = "decimal(18, 5)")]
    public decimal? GecontainerQuantity { get; set; }

    [InverseProperty("FkGecontainer")]
    public virtual ICollection<ApfeePaymentFeeConfig> ApfeePaymentFeeConfigs { get; set; } = new List<ApfeePaymentFeeConfig>();

    [InverseProperty("FkGecontainer")]
    public virtual ICollection<ArcontainerLoader> ArcontainerLoaders { get; set; } = new List<ArcontainerLoader>();

    [InverseProperty("FkGecontainer")]
    public virtual ICollection<ArsaleOrderItemContainer> ArsaleOrderItemContainers { get; set; } = new List<ArsaleOrderItemContainer>();

    [InverseProperty("FkGecontainer")]
    public virtual ICollection<GeunitCostContainer> GeunitCostContainers { get; set; } = new List<GeunitCostContainer>();

    [InverseProperty("FkGecontainer")]
    public virtual ICollection<IcreceiptItemContFee> IcreceiptItemContFees { get; set; } = new List<IcreceiptItemContFee>();

    [InverseProperty("FkGecontainer")]
    public virtual ICollection<IcreceiptItemCont> IcreceiptItemConts { get; set; } = new List<IcreceiptItemCont>();

    [InverseProperty("FkGecontainer")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();
}
