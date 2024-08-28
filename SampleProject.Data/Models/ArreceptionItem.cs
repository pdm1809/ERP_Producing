using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARReceptionItems")]
public partial class ArreceptionItem
{
    [Key]
    [Column("ARReceptionItemID")]
    public int ArreceptionItemId { get; set; }

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

    [Column("FK_ARReceptionID")]
    public int? FkArreceptionId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("ARReceptionItemNo")]
    [StringLength(50)]
    public string ArreceptionItemNo { get; set; }

    [Column("ARReceptionItemName")]
    [StringLength(100)]
    public string ArreceptionItemName { get; set; }

    [Column("ARReceptionItemDesc")]
    [StringLength(512)]
    public string ArreceptionItemDesc { get; set; }

    [Column("ARReceptionItemComment")]
    [StringLength(512)]
    public string ArreceptionItemComment { get; set; }

    [Column("ARReceptionItemQty", TypeName = "decimal(18, 5)")]
    public decimal? ArreceptionItemQty { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ARAllocationItemID")]
    public int? FkArallocationItemId { get; set; }

    [ForeignKey("FkAcassetId")]
    [InverseProperty("ArreceptionItems")]
    public virtual Acasset FkAcasset { get; set; }

    [ForeignKey("FkArallocationItemId")]
    [InverseProperty("ArreceptionItems")]
    public virtual ArallocationItem FkArallocationItem { get; set; }

    [ForeignKey("FkArreceptionId")]
    [InverseProperty("ArreceptionItems")]
    public virtual Arreception FkArreception { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArreceptionItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArreceptionItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductIdentifiedEquipmentId")]
    [InverseProperty("ArreceptionItems")]
    public virtual IcproductIdentifiedEquipment FkIcproductIdentifiedEquipment { get; set; }
}
