using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductProductionNormItemHardwares")]
public partial class MmbatchProductProductionNormItemHardware
{
    [Key]
    [Column("MMBatchProductProductionNormItemHardwareID")]
    public int MmbatchProductProductionNormItemHardwareId { get; set; }

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

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [Column("MMBatchProductProductionNormItemHardwareProductName")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemHardwareProductName { get; set; }

    [Column("MMBatchProductProductionNormItemHardwareProductDesc")]
    [StringLength(524)]
    public string MmbatchProductProductionNormItemHardwareProductDesc { get; set; }

    [Column("MMBatchProductProductionNormItemHardwareDesc")]
    [StringLength(524)]
    public string MmbatchProductProductionNormItemHardwareDesc { get; set; }

    [Column("MMBatchProductProductionNormItemHardwareQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemHardwareQty { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmbatchProductProductionNormItemHardwares")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmbatchProductProductionNormItemHardwareFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAlternativeId")]
    [InverseProperty("MmbatchProductProductionNormItemHardwareFkIcproductAlternatives")]
    public virtual Icproduct FkIcproductAlternative { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbatchProductProductionNormItemHardwares")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmbatchProductProductionNormItemHardwares")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmbatchProductProductionNormItemHardwares")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmbatchProductProductionNormItemHardwares")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("MmbatchProductProductionNormItemHardwares")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }
}
