using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("APPriceSheetItems")]
public partial class AppriceSheetItem
{
    [Key]
    [Column("APPriceSheetItemID")]
    public int AppriceSheetItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_APPriceSheetID")]
    public int? FkAppriceSheetId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("APPriceSheetItemProductName")]
    [StringLength(50)]
    public string AppriceSheetItemProductName { get; set; }

    [Column("APPriceSheetItemProductDesc")]
    [StringLength(512)]
    public string AppriceSheetItemProductDesc { get; set; }

    [Column("APPriceSheetItemQty", TypeName = "decimal(18, 5)")]
    public decimal? AppriceSheetItemQty { get; set; }

    [Column("APPriceSheetItemBasicPrice", TypeName = "decimal(18, 5)")]
    public decimal? AppriceSheetItemBasicPrice { get; set; }

    [Column("APPriceSheetItemPrice", TypeName = "decimal(18, 5)")]
    public decimal? AppriceSheetItemPrice { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("APObjectType")]
    [StringLength(50)]
    public string ApobjectType { get; set; }

    [Column("ACObjectAccessKey")]
    [StringLength(100)]
    public string AcobjectAccessKey { get; set; }

    [Column("FK_GECurrencyID")]
    public int? FkGecurrencyId { get; set; }

    [Column("APPriceSheetItemProductFactor", TypeName = "decimal(18, 5)")]
    public decimal? AppriceSheetItemProductFactor { get; set; }

    [Column("APPriceSheetItemProductExchangeQty", TypeName = "decimal(18, 5)")]
    public decimal? AppriceSheetItemProductExchangeQty { get; set; }

    [ForeignKey("FkAppriceSheetId")]
    [InverseProperty("AppriceSheetItems")]
    public virtual AppriceSheet FkAppriceSheet { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("AppriceSheetItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("AppriceSheetItems")]
    public virtual Icproduct FkIcproduct { get; set; }
}
