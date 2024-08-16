using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchProductProductionNormItemEquipments")]
public partial class MmbatchProductProductionNormItemEquipment
{
    [Key]
    [Column("MMBatchProductProductionNormItemEquipmentID")]
    public int MmbatchProductProductionNormItemEquipmentId { get; set; }

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

    [Column("MMBatchProductProductionNormItemEquipmentProductName")]
    [StringLength(50)]
    public string MmbatchProductProductionNormItemEquipmentProductName { get; set; }

    [Column("MMBatchProductProductionNormItemEquipmentProductDesc")]
    [StringLength(524)]
    public string MmbatchProductProductionNormItemEquipmentProductDesc { get; set; }

    [Column("MMBatchProductProductionNormItemEquipmentDesc")]
    [StringLength(524)]
    public string MmbatchProductProductionNormItemEquipmentDesc { get; set; }

    [Column("MMBatchProductProductionNormItemEquipmentQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchProductProductionNormItemEquipmentQty { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmbatchProductProductionNormItemEquipments")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmbatchProductProductionNormItemEquipmentFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAlternativeId")]
    [InverseProperty("MmbatchProductProductionNormItemEquipmentFkIcproductAlternatives")]
    public virtual Icproduct FkIcproductAlternative { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbatchProductProductionNormItemEquipments")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmbatchProductProductionNormItemEquipments")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("MmbatchProductProductionNormItemEquipments")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmbatchProductProductionNormItemEquipments")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("MmbatchProductProductionNormItemEquipments")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }
}
