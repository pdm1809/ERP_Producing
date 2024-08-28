using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPaintProcessess")]
public partial class MmpaintProcessess
{
    [Key]
    [Column("MMPaintProcessesID")]
    public int MmpaintProcessesId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductAttributeColorID")]
    public int FkIcproductAttributeColorId { get; set; }

    [Column("FK_ICProductAttributeHTID")]
    public int? FkIcproductAttributeHtid { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_APSupplierID")]
    public int? FkApsupplierId { get; set; }

    [Required]
    [Column("MMPaintProcessesNo")]
    [StringLength(50)]
    public string MmpaintProcessesNo { get; set; }

    [Column("MMPaintProcessesName")]
    [StringLength(256)]
    public string MmpaintProcessesName { get; set; }

    [Column("MMPaintProcessesDesc")]
    [StringLength(512)]
    public string MmpaintProcessesDesc { get; set; }

    [Column("MMPaintProcessesTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? MmpaintProcessesTotalAmount { get; set; }

    [Column("MMPaintProcessesPaintNo")]
    [StringLength(50)]
    public string MmpaintProcessesPaintNo { get; set; }

    [Column("MMPaintProcessesPaintName")]
    [StringLength(50)]
    public string MmpaintProcessesPaintName { get; set; }

    [Column("MMPaintProcessesGroupName")]
    [StringLength(256)]
    public string MmpaintProcessesGroupName { get; set; }

    [Required]
    [Column("MMPaintProcessesProductGroupName")]
    [StringLength(256)]
    public string MmpaintProcessesProductGroupName { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("MMPaintProcessesIsActive")]
    public bool? MmpaintProcessesIsActive { get; set; }

    [Column("MMPaintProcessesStatus")]
    [StringLength(100)]
    public string MmpaintProcessesStatus { get; set; }

    [ForeignKey("FkApsupplierId")]
    [InverseProperty("MmpaintProcessesses")]
    public virtual Apsupplier FkApsupplier { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmpaintProcessesses")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkIcproductAttributeColorId")]
    [InverseProperty("MmpaintProcessessFkIcproductAttributeColors")]
    public virtual IcproductAttribute FkIcproductAttributeColor { get; set; }

    [ForeignKey("FkIcproductAttributeHtid")]
    [InverseProperty("MmpaintProcessessFkIcproductAttributeHts")]
    public virtual IcproductAttribute FkIcproductAttributeHt { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmpaintProcessesses")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [InverseProperty("FkMmpaintProcesses")]
    public virtual ICollection<MmpaintProcessesItem> MmpaintProcessesItems { get; set; } = new List<MmpaintProcessesItem>();

    [InverseProperty("FkMmpaintProcesses")]
    public virtual ICollection<MmproductionNormItem> MmproductionNormItems { get; set; } = new List<MmproductionNormItem>();
}
