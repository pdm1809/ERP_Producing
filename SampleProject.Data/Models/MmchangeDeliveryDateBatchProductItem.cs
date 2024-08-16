using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMChangeDeliveryDateBatchProductItems")]
public partial class MmchangeDeliveryDateBatchProductItem
{
    [Key]
    [Column("MMChangeDeliveryDateBatchProductItemID")]
    public int MmchangeDeliveryDateBatchProductItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_MMChangeDeliveryDateBatchProductID")]
    public int? FkMmchangeDeliveryDateBatchProductId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("MMChangeDDBatchProductItemSaleOrderDate", TypeName = "datetime")]
    public DateTime? MmchangeDdbatchProductItemSaleOrderDate { get; set; }

    [Column("MMChangeDDBatchProductItemProductDesc")]
    [StringLength(512)]
    public string MmchangeDdbatchProductItemProductDesc { get; set; }

    [Column("MMChangeDDBatchProductItemSaleOrderDeliveryDate", TypeName = "datetime")]
    public DateTime? MmchangeDdbatchProductItemSaleOrderDeliveryDate { get; set; }

    [Column("MMChangeDDBatchProductItemBatchProductDeliveryDate", TypeName = "datetime")]
    public DateTime? MmchangeDdbatchProductItemBatchProductDeliveryDate { get; set; }

    [Column("MMChangeDDBatchProductItemDate", TypeName = "datetime")]
    public DateTime? MmchangeDdbatchProductItemDate { get; set; }

    [Column("MMChangeDDBatchProductItemDateETD", TypeName = "datetime")]
    public DateTime? MmchangeDdbatchProductItemDateEtd { get; set; }

    [Column("MMChangeDDBatchProductItemContNo")]
    [StringLength(100)]
    public string MmchangeDdbatchProductItemContNo { get; set; }

    [Column("MMChangeDDBatchProductItemDatechangDDLatest", TypeName = "datetime")]
    public DateTime? MmchangeDdbatchProductItemDatechangDdlatest { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("MMChangeDDBatchProductItemParentID")]
    public int? MmchangeDdbatchProductItemParentId { get; set; }

    [Column("MMChangeDDBatchProductItemSaleOrderQty", TypeName = "decimal(18, 5)")]
    public decimal? MmchangeDdbatchProductItemSaleOrderQty { get; set; }

    [Column("MMChangeDDBatchProductItemBatchProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmchangeDdbatchProductItemBatchProductQty { get; set; }

    [Column("MMChangeDDBatchProductItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmchangeDdbatchProductItemProductQty { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmchangeDeliveryDateBatchProductItems")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmchangeDeliveryDateBatchProductItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmchangeDeliveryDateBatchProductItems")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmchangeDeliveryDateBatchProductItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmchangeDeliveryDateBatchProductItems")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmchangeDeliveryDateBatchProductItems")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmchangeDeliveryDateBatchProductId")]
    [InverseProperty("MmchangeDeliveryDateBatchProductItems")]
    public virtual MmchangeDeliveryDateBatchProduct FkMmchangeDeliveryDateBatchProduct { get; set; }
}
