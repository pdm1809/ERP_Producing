using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMNormTemplateProducts")]
public partial class MmnormTemplateProduct
{
    [Key]
    [Column("MMNormTemplateProductID")]
    public int MmnormTemplateProductId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("MMNormTemplateProductDesc")]
    [StringLength(1024)]
    public string MmnormTemplateProductDesc { get; set; }

    [Column("FK_MMNormTemplateID")]
    public int? FkMmnormTemplateId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmnormTemplateProducts")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmnormTemplateId")]
    [InverseProperty("MmnormTemplateProducts")]
    public virtual MmnormTemplate FkMmnormTemplate { get; set; }
}
