using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProcessInfos")]
public partial class MmprocessInfo
{
    [Key]
    [Column("MMProcessInfoID")]
    public int MmprocessInfoId { get; set; }

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

    [Column("FK_ICProductAttributeItemID")]
    public int? FkIcproductAttributeItemId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMProcessInfoSetupTime", TypeName = "decimal(18, 5)")]
    public decimal? MmprocessInfoSetupTime { get; set; }

    [Column("MMProcessInfoProcessTime", TypeName = "decimal(18, 5)")]
    public decimal? MmprocessInfoProcessTime { get; set; }

    [Column("MMProcessInfoLeadTime", TypeName = "decimal(18, 5)")]
    public decimal? MmprocessInfoLeadTime { get; set; }

    [Column("MMProcessInfoCapacity", TypeName = "decimal(18, 5)")]
    public decimal? MmprocessInfoCapacity { get; set; }

    [Column("MMProcessInfoResource", TypeName = "decimal(18, 5)")]
    public decimal? MmprocessInfoResource { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmprocessInfos")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmprocessInfos")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeItemId")]
    [InverseProperty("MmprocessInfos")]
    public virtual IcproductAttributeItem FkIcproductAttributeItem { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmprocessInfos")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
