using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductConversionItems")]
public partial class IcproductConversionItem
{
    [Key]
    [Column("ICProductConversionItemID")]
    public int IcproductConversionItemId { get; set; }

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

    [Column("FK_ICProductConversionID")]
    public int? FkIcproductConversionId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICFromProductID")]
    public int? FkIcfromProductId { get; set; }

    [Column("ICProductConversionItemProductName")]
    [StringLength(256)]
    public string IcproductConversionItemProductName { get; set; }

    [Column("ICProductConversionItemProductDesc")]
    [StringLength(512)]
    public string IcproductConversionItemProductDesc { get; set; }

    [Column("ICProductConversionItemProductQty", TypeName = "decimal(18, 6)")]
    public decimal? IcproductConversionItemProductQty { get; set; }

    [Column("ICProductConversionItemRate", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemRate { get; set; }

    [Column("ICProductConversionItemType")]
    [StringLength(50)]
    public string IcproductConversionItemType { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int FkIcstockId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("ICProductConversionItemProductSerialNo")]
    [StringLength(50)]
    public string IcproductConversionItemProductSerialNo { get; set; }

    [Column("ICProductConversionItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemProductFactor { get; set; }

    [Column("ICProductConversionItemProductExchangeQty", TypeName = "decimal(18, 6)")]
    public decimal? IcproductConversionItemProductExchangeQty { get; set; }

    [Column("ICProductConversionItemUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemUnitCost { get; set; }

    [Column("ICProductConversionItemTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemTotalCost { get; set; }

    [Column("ICProductConversionItemIsAverageCalculation")]
    public bool? IcproductConversionItemIsAverageCalculation { get; set; }

    [Column("ICProductConversionItemIsSpecificCalculation")]
    public bool? IcproductConversionItemIsSpecificCalculation { get; set; }

    [Column("FK_ACAccountID")]
    public int? FkAcaccountId { get; set; }

    [Column("ICProductConversionItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemProductUnitPrice { get; set; }

    [Column("ICProductConversionItemConfigType")]
    [StringLength(50)]
    public string IcproductConversionItemConfigType { get; set; }

    [Column("ICProductConversionItemConfigValue", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemConfigValue { get; set; }

    [Column("ICProductConversionItemCost", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemCost { get; set; }

    [Column("ICProductConversionItemParentID")]
    public int? IcproductConversionItemParentId { get; set; }

    [Column("VirtualID")]
    [StringLength(50)]
    public string VirtualId { get; set; }

    [Column("VirtualParentID")]
    [StringLength(50)]
    public string VirtualParentId { get; set; }

    [Column("ICProductConversionItemWoodQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemWoodQty { get; set; }

    [Column("ICProductConversionItemLengthMin", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemLengthMin { get; set; }

    [Column("ICProductConversionItemWidthMin", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemWidthMin { get; set; }

    [Column("ICProductConversionItemHeightMin", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemHeightMin { get; set; }

    [Column("ICProductConversionItemLengthMax", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemLengthMax { get; set; }

    [Column("ICProductConversionItemWidthMax", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemWidthMax { get; set; }

    [Column("ICProductConversionItemHeightMax", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemHeightMax { get; set; }

    [Column("ICProductConversionItemPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemPerimeter { get; set; }

    [Column("ICProductConversionItemLotNo")]
    [StringLength(50)]
    public string IcproductConversionItemLotNo { get; set; }

    [Column("ICProductConversionItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemProductLength { get; set; }

    [Column("ICProductConversionItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemProductWidth { get; set; }

    [Column("ICProductConversionItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemProductHeight { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("FK_ICReceiptItemID")]
    public int? FkIcreceiptItemId { get; set; }

    [Column("ICProductConversionItemSplitQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemSplitQty { get; set; }

    [Column("ICProductConversionItemSplitRate", TypeName = "decimal(18, 5)")]
    public decimal? IcproductConversionItemSplitRate { get; set; }

    [Column("FK_ICConversionProposalID")]
    public int? FkIcconversionProposalId { get; set; }

    [Column("FK_ICConversionProposalItemID")]
    public int? FkIcconversionProposalItemId { get; set; }

    [ForeignKey("FkAcaccountId")]
    [InverseProperty("IcproductConversionItems")]
    public virtual Acaccount FkAcaccount { get; set; }

    [ForeignKey("FkIcconversionProposalId")]
    [InverseProperty("IcproductConversionItems")]
    public virtual IcconversionProposal FkIcconversionProposal { get; set; }

    [ForeignKey("FkIcconversionProposalItemId")]
    [InverseProperty("IcproductConversionItems")]
    public virtual IcconversionProposalItem FkIcconversionProposalItem { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("IcproductConversionItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductConversionItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductConversionId")]
    [InverseProperty("IcproductConversionItems")]
    public virtual IcproductConversion FkIcproductConversion { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IcproductConversionItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("IcproductConversionItems")]
    public virtual Icstock FkIcstock { get; set; }
}
