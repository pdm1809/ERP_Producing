using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNormItemHardwares")]
public partial class MmproductionNormItemHardware
{
    [Key]
    [Column("MMProductionNormItemHardwareID")]
    public int MmproductionNormItemHardwareId { get; set; }

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

    [Column("FK_ICProductAlternativeID")]
    public int? FkIcproductAlternativeId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMProductionNormItemID")]
    public int? FkMmproductionNormItemId { get; set; }

    [Column("MMProductionNormItemHardwareProductName")]
    [StringLength(50)]
    public string MmproductionNormItemHardwareProductName { get; set; }

    [Column("MMProductionNormItemHardwareProductDesc")]
    [StringLength(524)]
    public string MmproductionNormItemHardwareProductDesc { get; set; }

    [Column("MMProductionNormItemHardwareDesc")]
    [StringLength(524)]
    public string MmproductionNormItemHardwareDesc { get; set; }

    [Column("MMProductionNormItemHardwareQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemHardwareQty { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmproductionNormItemHardwares")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionNormItemHardwareFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAlternativeId")]
    [InverseProperty("MmproductionNormItemHardwareFkIcproductAlternatives")]
    public virtual Icproduct FkIcproductAlternative { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionNormItemHardwares")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("MmproductionNormItemHardwares")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }
}
