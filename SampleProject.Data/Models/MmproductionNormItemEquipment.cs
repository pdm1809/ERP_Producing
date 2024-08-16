using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionNormItemEquipments")]
public partial class MmproductionNormItemEquipment
{
    [Key]
    [Column("MMProductionNormItemEquipmentID")]
    public int MmproductionNormItemEquipmentId { get; set; }

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

    [Column("MMProductionNormItemEquipmentProductName")]
    [StringLength(50)]
    public string MmproductionNormItemEquipmentProductName { get; set; }

    [Column("MMProductionNormItemEquipmentProductDesc")]
    [StringLength(524)]
    public string MmproductionNormItemEquipmentProductDesc { get; set; }

    [Column("MMProductionNormItemEquipmentDesc")]
    [StringLength(524)]
    public string MmproductionNormItemEquipmentDesc { get; set; }

    [Column("MMProductionNormItemEquipmentQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionNormItemEquipmentQty { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmproductionNormItemEquipments")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionNormItemEquipmentFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAlternativeId")]
    [InverseProperty("MmproductionNormItemEquipmentFkIcproductAlternatives")]
    public virtual Icproduct FkIcproductAlternative { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionNormItemEquipments")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionNormItemId")]
    [InverseProperty("MmproductionNormItemEquipments")]
    public virtual MmproductionNormItem FkMmproductionNormItem { get; set; }
}
