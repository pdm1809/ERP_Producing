using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMExchangeMeasureUnitConfigs")]
public partial class MmexchangeMeasureUnitConfig
{
    [Key]
    [Column("MMExchangeMeasureUnitConfigID")]
    public int MmexchangeMeasureUnitConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICFromMeasureUnitID")]
    public int? FkIcfromMeasureUnitId { get; set; }

    [Column("FK_ICToMeasureUnitID")]
    public int? FkIctoMeasureUnitId { get; set; }

    [Column("MMExchangeMeasureUnitConfigHeightOperation")]
    [StringLength(50)]
    public string MmexchangeMeasureUnitConfigHeightOperation { get; set; }

    [Column("MMExchangeMeasureUnitConfigWidthOperation")]
    [StringLength(50)]
    public string MmexchangeMeasureUnitConfigWidthOperation { get; set; }

    [Column("MMExchangeMeasureUnitConfigLengthOperation")]
    [StringLength(50)]
    public string MmexchangeMeasureUnitConfigLengthOperation { get; set; }

    [Column("MMExchangeMeasureUnitConfigRatio", TypeName = "decimal(18, 5)")]
    public decimal? MmexchangeMeasureUnitConfigRatio { get; set; }

    [Column("MMExchangeMeasureUnitConfigSpecifiCation")]
    [StringLength(512)]
    public string MmexchangeMeasureUnitConfigSpecifiCation { get; set; }

    [Column("MMExchangeMeasureUnitConfigSize", TypeName = "decimal(18, 5)")]
    public decimal? MmexchangeMeasureUnitConfigSize { get; set; }

    [Column("MMExchangeMeasureUnitConfigQuantity")]
    [StringLength(512)]
    public string MmexchangeMeasureUnitConfigQuantity { get; set; }

    [ForeignKey("FkIcfromMeasureUnitId")]
    [InverseProperty("MmexchangeMeasureUnitConfigFkIcfromMeasureUnits")]
    public virtual IcmeasureUnit FkIcfromMeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmexchangeMeasureUnitConfigs")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIctoMeasureUnitId")]
    [InverseProperty("MmexchangeMeasureUnitConfigFkIctoMeasureUnits")]
    public virtual IcmeasureUnit FkIctoMeasureUnit { get; set; }
}
