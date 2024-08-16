using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductInputItems")]
public partial class MmbatchProductInputItem
{
    [Key]
    [Column("MMBatchProductInputItemID")]
    public int MmbatchProductInputItemId { get; set; }

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
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("MMBatchProductInputItemProductName")]
    [StringLength(50)]
    public string MmbatchProductInputItemProductName { get; set; }

    [Column("MMBatchProductInputItemProductDesc")]
    [StringLength(1024)]
    public string MmbatchProductInputItemProductDesc { get; set; }

    [Column("MMBatchProductInputItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemHeight { get; set; }

    [Column("MMBatchProductInputItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemWidth { get; set; }

    [Column("MMBatchProductInputItemLength", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemLength { get; set; }

    [Column("MMBatchProductInputItemHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemHeightMin { get; set; }

    [Column("MMBatchProductInputItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemWidthMin { get; set; }

    [Column("MMBatchProductInputItemLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemLengthMin { get; set; }

    [Column("MMBatchProductInputItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemHeightMax { get; set; }

    [Column("MMBatchProductInputItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemWidthMax { get; set; }

    [Column("MMBatchProductInputItemLengthMax", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemLengthMax { get; set; }

    [Column("MMBatchProductInputItemQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemQty { get; set; }

    [Column("MMBatchProductInputItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemWoodQty { get; set; }

    [Column("MMBatchProductInputItemComment")]
    [StringLength(50)]
    public string MmbatchProductInputItemComment { get; set; }

    [Column("MMBatchProductInputItemProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemProductPerimeter { get; set; }

    [Column("MMBatchProductInputItemCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductInputItemCanceledQty { get; set; }

    [Column("MMBatchProductInputItemProductSerialNo")]
    [StringLength(50)]
    public string MmbatchProductInputItemProductSerialNo { get; set; }

    [Column("MMBatchProductInputItemLotNo")]
    [StringLength(50)]
    public string MmbatchProductInputItemLotNo { get; set; }

    [InverseProperty("FkMmbatchProductInputItem")]
    public virtual ICollection<ApproposalItem> ApproposalItems { get; set; } = new List<ApproposalItem>();

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmbatchProductInputItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmbatchProductInputItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("MmbatchProductInputItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("MmbatchProductInputItems")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbatchProductInputItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }
}
