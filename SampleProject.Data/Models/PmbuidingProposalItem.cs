using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMBuidingProposalItems")]
public partial class PmbuidingProposalItem
{
    [Key]
    [Column("PMBuidingProposalItemID")]
    public int PmbuidingProposalItemId { get; set; }

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

    [Column("FK_PMBuidingProposalID")]
    public int? FkPmbuidingProposalId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("PMBuidingProposalItemProductType")]
    [StringLength(50)]
    public string PmbuidingProposalItemProductType { get; set; }

    [Column("PMBuidingProposalItemSortOrder")]
    public int? PmbuidingProposalItemSortOrder { get; set; }

    [Column("PMBuidingProposalItemProductNo")]
    [StringLength(50)]
    public string PmbuidingProposalItemProductNo { get; set; }

    [Column("PMBuidingProposalItemProductName")]
    [StringLength(50)]
    public string PmbuidingProposalItemProductName { get; set; }

    [Column("PMBuidingProposalItemProductDesc", TypeName = "ntext")]
    public string PmbuidingProposalItemProductDesc { get; set; }

    [Column("PMBuidingProposalItemProductQty", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingProposalItemProductQty { get; set; }

    [Column("PMBuidingProposalItemComment")]
    [StringLength(50)]
    public string PmbuidingProposalItemComment { get; set; }

    [Column("PMBuidingProposalItemStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmbuidingProposalItemStatus { get; set; }

    [Column("PMBuidingProposalItemDeliveryDate", TypeName = "datetime")]
    public DateTime? PmbuidingProposalItemDeliveryDate { get; set; }

    [Column("PMBuidingProposalItemIsNewProduct")]
    public bool? PmbuidingProposalItemIsNewProduct { get; set; }

    [Column("PMBuidingProposalItemIsJoinComponent")]
    public bool? PmbuidingProposalItemIsJoinComponent { get; set; }

    [Column("PMBuidingProposalItemHardwareRemark")]
    [StringLength(256)]
    public string PmbuidingProposalItemHardwareRemark { get; set; }

    [Column("PMBuidingProposalItemPackagingRequimentType")]
    [StringLength(50)]
    public string PmbuidingProposalItemPackagingRequimentType { get; set; }

    [Column("PMBuidingProposalItemLabelCorlor")]
    public bool? PmbuidingProposalItemLabelCorlor { get; set; }

    [Column("PMBuidingProposalItemProductCard")]
    public bool? PmbuidingProposalItemProductCard { get; set; }

    [Column("PMBuidingProposalItemProductFSCCard")]
    public bool? PmbuidingProposalItemProductFsccard { get; set; }

    [Column("PMBuidingProposalItemProductLabel")]
    public bool? PmbuidingProposalItemProductLabel { get; set; }

    [Column("PMBuidingProposalItemProductHDLR")]
    public bool? PmbuidingProposalItemProductHdlr { get; set; }

    [Column("PMBuidingProposalItemProductHDSD")]
    public bool? PmbuidingProposalItemProductHdsd { get; set; }

    [Column("PMBuidingProposalItemProductBarcode")]
    public bool? PmbuidingProposalItemProductBarcode { get; set; }

    [Column("PMBuidingProposalItemProductWarranty")]
    public bool? PmbuidingProposalItemProductWarranty { get; set; }

    [Column("PMBuidingProposalItemProductPerimeter", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingProposalItemProductPerimeter { get; set; }

    [Column("PMBuidingProposalItemProductHeight", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingProposalItemProductHeight { get; set; }

    [Column("PMBuidingProposalItemProductWidth", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingProposalItemProductWidth { get; set; }

    [Column("PMBuidingProposalItemProductLength", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingProposalItemProductLength { get; set; }

    [Column("PMBuidingProposalItemProductMinHeight", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingProposalItemProductMinHeight { get; set; }

    [Column("PMBuidingProposalItemProductMinWidth", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingProposalItemProductMinWidth { get; set; }

    [Column("PMBuidingProposalItemProductMinLength", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingProposalItemProductMinLength { get; set; }

    [Column("PMBuidingProposalItemProductMaxHeight", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingProposalItemProductMaxHeight { get; set; }

    [Column("PMBuidingProposalItemProductMaxWidth", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingProposalItemProductMaxWidth { get; set; }

    [Column("PMBuidingProposalItemProductMaxLength", TypeName = "decimal(18, 0)")]
    public decimal? PmbuidingProposalItemProductMaxLength { get; set; }

    [Column("FK_ICProductAttributeQualityID")]
    public int? FkIcproductAttributeQualityId { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("PmbuidingProposalItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("PmbuidingProposalItems")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("PmbuidingProposalItems")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("PmbuidingProposalItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("PmbuidingProposalItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("PmbuidingProposalItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("PmbuidingProposalItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkPmbuidingProposalId")]
    [InverseProperty("PmbuidingProposalItems")]
    public virtual PmbuidingProposal FkPmbuidingProposal { get; set; }

    [InverseProperty("FkPmbuidingProposalItem")]
    public virtual ICollection<PmbuidingCommandItem> PmbuidingCommandItems { get; set; } = new List<PmbuidingCommandItem>();
}
