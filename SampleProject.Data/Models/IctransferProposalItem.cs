using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICTransferProposalItems")]
public partial class IctransferProposalItem
{
    [Key]
    [Column("ICTransferProposalItemID")]
    public int IctransferProposalItemId { get; set; }

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

    [Column("FK_ICTransferProposalID")]
    public int? FkIctransferProposalId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductSerieID")]
    public int? FkIcproductSerieId { get; set; }

    [Column("FK_ICFromStockID")]
    public int? FkIcfromStockId { get; set; }

    [Column("FK_ICToStockID")]
    public int? FkIctoStockId { get; set; }

    [Column("FK_ICTransitStockID")]
    public int? FkIctransitStockId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_ICProductAttributeColorID")]
    public int? FkIcproductAttributeColorId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("ICTransferProposalItemProductSerialNo")]
    [StringLength(50)]
    public string IctransferProposalItemProductSerialNo { get; set; }

    [Column("ICTransferProposalItemProductName")]
    [StringLength(255)]
    public string IctransferProposalItemProductName { get; set; }

    [Column("ICTransferProposalItemProductDesc")]
    [StringLength(512)]
    public string IctransferProposalItemProductDesc { get; set; }

    [Column("ICTransferProposalItemProductType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferProposalItemProductType { get; set; }

    [Column("ICTransferProposalItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductHeight { get; set; }

    [Column("ICTransferProposalItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductWidth { get; set; }

    [Column("ICTransferProposalItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductLength { get; set; }

    [Column("ICTransferProposalItemProductColorAttribute")]
    [StringLength(255)]
    public string IctransferProposalItemProductColorAttribute { get; set; }

    [Column("ICTransferProposalItemProductWoodAttribute")]
    [StringLength(255)]
    public string IctransferProposalItemProductWoodAttribute { get; set; }

    [Column("ICTransferProposalItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductQty { get; set; }

    [Column("ICTransferProposalItemProductOldQty", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductOldQty { get; set; }

    [Column("ICTransferProposalItemProductTransferredQty", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductTransferredQty { get; set; }

    [Column("ICTransferProposalItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductUnitPrice { get; set; }

    [Column("ICTransferProposalItemProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductUnitCost { get; set; }

    [Column("ICTransferProposalItemProductDiscountPercent", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductDiscountPercent { get; set; }

    [Column("ICTransferProposalItemProductDiscountAmount", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductDiscountAmount { get; set; }

    [Column("ICTransferProposalItemProductTaxPercent", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductTaxPercent { get; set; }

    [Column("ICTransferProposalItemProductTaxAmount", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductTaxAmount { get; set; }

    [Column("ICTransferProposalItemProductTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? IctransferProposalItemProductTotalAmount { get; set; }

    [Column("ICTransferProposalItemComment")]
    [StringLength(512)]
    public string IctransferProposalItemComment { get; set; }

    [Column("ICTransferProposalItemStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IctransferProposalItemStatus { get; set; }

    [Column("ICTransferProposalItemProductNo")]
    [StringLength(50)]
    public string IctransferProposalItemProductNo { get; set; }

    [Column("ICTransferProposalItemValidDate", TypeName = "datetime")]
    public DateTime? IctransferProposalItemValidDate { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("IctransferProposalItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcfromStockId")]
    [InverseProperty("IctransferProposalItemFkIcfromStocks")]
    public virtual Icstock FkIcfromStock { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IctransferProposalItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeColorId")]
    [InverseProperty("IctransferProposalItemFkIcproductAttributeColors")]
    public virtual IcproductAttribute FkIcproductAttributeColor { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("IctransferProposalItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("IctransferProposalItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductSerieId")]
    [InverseProperty("IctransferProposalItems")]
    public virtual IcproductSeries FkIcproductSerie { get; set; }

    [ForeignKey("FkIctoStockId")]
    [InverseProperty("IctransferProposalItemFkIctoStocks")]
    public virtual Icstock FkIctoStock { get; set; }

    [ForeignKey("FkIctransferProposalId")]
    [InverseProperty("IctransferProposalItems")]
    public virtual IctransferProposal FkIctransferProposal { get; set; }

    [ForeignKey("FkIctransitStockId")]
    [InverseProperty("IctransferProposalItemFkIctransitStocks")]
    public virtual Icstock FkIctransitStock { get; set; }
}
