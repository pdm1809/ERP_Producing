using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductPackingDetails")]
public partial class IcproductPackingDetail
{
    [Key]
    [Column("ICProductPackingDetailID")]
    public int IcproductPackingDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICProductAttributeSpecialityID")]
    public int? FkIcproductAttributeSpecialityId { get; set; }

    [Column("ICProductPackingDetailLength", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackingDetailLength { get; set; }

    [Column("ICProductPackingDetailWidth", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackingDetailWidth { get; set; }

    [Column("ICProductPackingDetailHeight", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackingDetailHeight { get; set; }

    [Column("ICProductPackingDetailQty", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackingDetailQty { get; set; }

    [Column("ICProductPackingDetailVolume", TypeName = "decimal(18, 5)")]
    public decimal? IcproductPackingDetailVolume { get; set; }

    [Column("FK_ICProdAttPackingMaterialWeightPerVolumeID")]
    public int? FkIcprodAttPackingMaterialWeightPerVolumeId { get; set; }

    [ForeignKey("FkIcprodAttPackingMaterialWeightPerVolumeId")]
    [InverseProperty("IcproductPackingDetailFkIcprodAttPackingMaterialWeightPerVolumes")]
    public virtual IcproductAttribute FkIcprodAttPackingMaterialWeightPerVolume { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductPackingDetails")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductAttributeSpecialityId")]
    [InverseProperty("IcproductPackingDetailFkIcproductAttributeSpecialities")]
    public virtual IcproductAttribute FkIcproductAttributeSpeciality { get; set; }
}
