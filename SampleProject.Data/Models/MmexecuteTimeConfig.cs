using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMExecuteTimeConfigs")]
public partial class MmexecuteTimeConfig
{
    [Key]
    [Column("MMExecuteTimeConfigID")]
    public int MmexecuteTimeConfigId { get; set; }

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

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("MMProductGroupType")]
    [StringLength(50)]
    public string MmproductGroupType { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("MMExecuteTimeConfigExecuteTime", TypeName = "decimal(18, 5)")]
    public decimal? MmexecuteTimeConfigExecuteTime { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmexecuteTimeConfigs")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmexecuteTimeConfigs")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmexecuteTimeConfigs")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
