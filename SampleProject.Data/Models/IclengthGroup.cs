using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICLengthGroups")]
public partial class IclengthGroup
{
    [Key]
    [Column("ICLengthGroupID")]
    public int IclengthGroupId { get; set; }

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

    [Column("ICLengthGroupName")]
    [StringLength(100)]
    public string IclengthGroupName { get; set; }

    [Column("ICLengthGroupMinValue", TypeName = "decimal(18, 5)")]
    public decimal? IclengthGroupMinValue { get; set; }

    [Column("ICLengthGroupMaxValue", TypeName = "decimal(18, 5)")]
    public decimal? IclengthGroupMaxValue { get; set; }

    [InverseProperty("FkIclengthGroup")]
    public virtual ICollection<AppurchaseOrderItem> AppurchaseOrderItems { get; set; } = new List<AppurchaseOrderItem>();

    [InverseProperty("FkIclengthGroup")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIclengthGroup")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();

    [InverseProperty("FkIclengthGroup")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIclengthGroup")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();
}
