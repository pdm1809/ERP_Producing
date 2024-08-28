using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProposalItems")]
public partial class MmproposalItem
{
    [Key]
    [Column("MMProposalItemID")]
    public int MmproposalItemId { get; set; }

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

    [Column("FK_MMProposalID")]
    public int FkMmproposalId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int FkIcmeasureUnitId { get; set; }

    [Column("FK_ICProductAttributeWoodTypeID")]
    public int? FkIcproductAttributeWoodTypeId { get; set; }

    [Column("FK_ICProductAttributeHTTypeID")]
    public int? FkIcproductAttributeHttypeId { get; set; }

    [Column("FK_ICProductAttributeColorID")]
    public int? FkIcproductAttributeColorId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("MMProposalItemProductType")]
    [StringLength(50)]
    public string MmproposalItemProductType { get; set; }

    [Column("MMProposalItemSortOrder")]
    public int? MmproposalItemSortOrder { get; set; }

    [Column("MMProposalItemProductNo")]
    [StringLength(50)]
    public string MmproposalItemProductNo { get; set; }

    [Column("MMProposalItemProductName")]
    [StringLength(50)]
    public string MmproposalItemProductName { get; set; }

    [Column("MMProposalItemProductDesc", TypeName = "ntext")]
    public string MmproposalItemProductDesc { get; set; }

    [Column("MMProposalItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductQty { get; set; }

    [Column("MMProposalItemComment")]
    [StringLength(50)]
    public string MmproposalItemComment { get; set; }

    [Column("MMProposalItemStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string MmproposalItemStatus { get; set; }

    [Column("MMProposalItemDeliveryDate", TypeName = "datetime")]
    public DateTime? MmproposalItemDeliveryDate { get; set; }

    [Column("MMProposalItemIsNewProduct")]
    public bool? MmproposalItemIsNewProduct { get; set; }

    [Column("MMProposalItemIsJoinComponent")]
    public bool? MmproposalItemIsJoinComponent { get; set; }

    [Column("MMProposalItemHardwareRemark")]
    [StringLength(256)]
    public string MmproposalItemHardwareRemark { get; set; }

    [Column("MMProposalItemPackagingRequimentType")]
    [StringLength(50)]
    public string MmproposalItemPackagingRequimentType { get; set; }

    [Column("MMProposalItemLabelCorlor")]
    public bool? MmproposalItemLabelCorlor { get; set; }

    [Column("MMProposalItemProductCard")]
    public bool? MmproposalItemProductCard { get; set; }

    [Column("MMProposalItemProductFSCCard")]
    public bool? MmproposalItemProductFsccard { get; set; }

    [Column("MMProposalItemProductLabel")]
    public bool? MmproposalItemProductLabel { get; set; }

    [Column("MMProposalItemProductHDLR")]
    public bool? MmproposalItemProductHdlr { get; set; }

    [Column("MMProposalItemProductHDSD")]
    public bool? MmproposalItemProductHdsd { get; set; }

    [Column("MMProposalItemProductBarcode")]
    public bool? MmproposalItemProductBarcode { get; set; }

    [Column("MMProposalItemProductWarranty")]
    public bool? MmproposalItemProductWarranty { get; set; }

    [Column("MMProposalItemProductPerimeter", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductPerimeter { get; set; }

    [Column("MMProposalItemProductHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductHeight { get; set; }

    [Column("MMProposalItemProductWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductWidth { get; set; }

    [Column("MMProposalItemProductLength", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductLength { get; set; }

    [Column("MMProposalItemProductMinHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductMinHeight { get; set; }

    [Column("MMProposalItemProductMinWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductMinWidth { get; set; }

    [Column("MMProposalItemProductMinLength", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductMinLength { get; set; }

    [Column("MMProposalItemProductMaxHeight", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductMaxHeight { get; set; }

    [Column("MMProposalItemProductMaxWidth", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductMaxWidth { get; set; }

    [Column("MMProposalItemProductMaxLength", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductMaxLength { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [Column("MMProposalItemProductAttributeColor")]
    [StringLength(512)]
    public string MmproposalItemProductAttributeColor { get; set; }

    [Column("MMProposalItemProductAttributeHTType")]
    [StringLength(512)]
    public string MmproposalItemProductAttributeHttype { get; set; }

    [Column("MMProposalItemWoodTypeID")]
    [StringLength(50)]
    public string MmproposalItemWoodTypeId { get; set; }

    [Column("MMProposalItemWoodTypeText")]
    [StringLength(512)]
    public string MmproposalItemWoodTypeText { get; set; }

    [Column("MMProposalItemColorID")]
    [StringLength(50)]
    public string MmproposalItemColorId { get; set; }

    [Column("MMProposalItemHTID")]
    [StringLength(50)]
    public string MmproposalItemHtid { get; set; }

    [Column("MMProposalItemPONo")]
    [StringLength(50)]
    public string MmproposalItemPono { get; set; }

    [Column("MMProposalItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemTotalAmount { get; set; }

    [Column("MMProposalItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? MmproposalItemProductUnitPrice { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmproposalItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("MmproposalItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmproposalItems")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmproposalItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmproposalItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproposalItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeColorId")]
    [InverseProperty("MmproposalItemFkIcproductAttributeColors")]
    public virtual IcproductAttribute FkIcproductAttributeColor { get; set; }

    [ForeignKey("FkIcproductAttributeHttypeId")]
    [InverseProperty("MmproposalItemFkIcproductAttributeHttypes")]
    public virtual IcproductAttribute FkIcproductAttributeHttype { get; set; }

    [ForeignKey("FkIcproductAttributeQualityId")]
    [InverseProperty("MmproposalItemFkIcproductAttributeQualities")]
    public virtual IcproductAttribute FkIcproductAttributeQuality { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmproposalItemFkIcproductAttributeTtmts")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkIcproductAttributeWoodTypeId")]
    [InverseProperty("MmproposalItemFkIcproductAttributeWoodTypes")]
    public virtual IcproductAttribute FkIcproductAttributeWoodType { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmproposalItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmproposalId")]
    [InverseProperty("MmproposalItems")]
    public virtual Mmproposal FkMmproposal { get; set; }
}
