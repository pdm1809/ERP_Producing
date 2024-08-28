using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARAllocationItems")]
public partial class ArallocationItem
{
    [Key]
    [Column("ARAllocationItemID")]
    public int ArallocationItemId { get; set; }

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
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductIdentifiedEquipmentID")]
    public int? FkIcproductIdentifiedEquipmentId { get; set; }

    [Column("FK_ACAssetID")]
    public int? FkAcassetId { get; set; }

    [Column("FK_ARAllocationID")]
    public int? FkArallocationId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("ARAllocationItemNo")]
    [StringLength(50)]
    public string ArallocationItemNo { get; set; }

    [Column("ARAllocationItemName")]
    [StringLength(100)]
    public string ArallocationItemName { get; set; }

    [Column("ARAllocationItemDesc")]
    [StringLength(512)]
    public string ArallocationItemDesc { get; set; }

    [Column("ARAllocationItemComment")]
    [StringLength(512)]
    public string ArallocationItemComment { get; set; }

    [Column("ARAllocationItemQty", TypeName = "decimal(18, 5)")]
    public decimal? ArallocationItemQty { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ARDeliveryPlanWorkAssetID")]
    public int? FkArdeliveryPlanWorkAssetId { get; set; }

    [Column("ARAllocationItemReceiptQty", TypeName = "decimal(18, 5)")]
    public decimal? ArallocationItemReceiptQty { get; set; }

    [Column("FK_ARDeliveryPlanWorkID")]
    public int? FkArdeliveryPlanWorkId { get; set; }

    [InverseProperty("FkArallocationItem")]
    public virtual ICollection<ArreceptionItem> ArreceptionItems { get; set; } = new List<ArreceptionItem>();

    [ForeignKey("FkAcassetId")]
    [InverseProperty("ArallocationItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkArallocationId")]
    [InverseProperty("ArallocationItems")]
    public virtual Arallocation FkArallocation { get; set; }

    [ForeignKey("FkArdeliveryPlanWorkId")]
    [InverseProperty("ArallocationItems")]
    public virtual ArdeliveryPlanWork FkArdeliveryPlanWork { get; set; }

    [ForeignKey("FkArdeliveryPlanWorkAssetId")]
    [InverseProperty("ArallocationItems")]
    public virtual ArdeliveryPlanWorkAsset FkArdeliveryPlanWorkAsset { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArallocationItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArallocationItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductIdentifiedEquipmentId")]
    [InverseProperty("ArallocationItems")]
    public virtual IcproductIdentifiedEquipment FkIcproductIdentifiedEquipment { get; set; }
}
