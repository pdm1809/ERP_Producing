using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductFormulaPriceConfigs")]
public partial class IcproductFormulaPriceConfig
{
    [Key]
    [Column("ICProductFormulaPriceConfigID")]
    public int IcproductFormulaPriceConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("ICProductFormulaPriceConfigNo")]
    [StringLength(128)]
    public string IcproductFormulaPriceConfigNo { get; set; }

    [Column("ICProductFormulaPriceConfigName")]
    [StringLength(128)]
    public string IcproductFormulaPriceConfigName { get; set; }

    [Column("ICProductFormulaPriceConfigDesc")]
    [StringLength(256)]
    public string IcproductFormulaPriceConfigDesc { get; set; }

    [Column("ICProductFormulaPriceConfigType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductFormulaPriceConfigType { get; set; }

    [Column("ICProductFormulaPriceConfigHeightOperation")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductFormulaPriceConfigHeightOperation { get; set; }

    [Column("ICProductFormulaPriceConfigWidthOperation")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductFormulaPriceConfigWidthOperation { get; set; }

    [Column("ICProductFormulaPriceConfigLengthOperation")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductFormulaPriceConfigLengthOperation { get; set; }

    [Column("ICProductFormulaPriceConfigQtyOperation")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductFormulaPriceConfigQtyOperation { get; set; }

    [Column("ICProductFormulaPriceConfigUnitPriceOperation")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductFormulaPriceConfigUnitPriceOperation { get; set; }

    [Column("ICProductFormulaPriceConfigComponentUnitPriceOperation")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductFormulaPriceConfigComponentUnitPriceOperation { get; set; }

    [InverseProperty("FkIcproductFormulaPriceConfig")]
    public virtual ICollection<ArproposalAreaItem> ArproposalAreaItems { get; set; } = new List<ArproposalAreaItem>();

    [InverseProperty("FkIcproductFormulaPriceConfig")]
    public virtual ICollection<ArproposalItem> ArproposalItems { get; set; } = new List<ArproposalItem>();

    [InverseProperty("FkIcproductFormulaPriceConfig")]
    public virtual ICollection<ArsaleOrderItem> ArsaleOrderItems { get; set; } = new List<ArsaleOrderItem>();

    [InverseProperty("FkIcproductFormulaPriceConfig")]
    public virtual ICollection<IcproductApplyPriceItem> IcproductApplyPriceItems { get; set; } = new List<IcproductApplyPriceItem>();

    [InverseProperty("FkIcproductFormulaPriceConfig")]
    public virtual ICollection<IcproductTemplateItem> IcproductTemplateItems { get; set; } = new List<IcproductTemplateItem>();

    [InverseProperty("FkIcproductFormulaPriceConfig")]
    public virtual ICollection<Icproduct> Icproducts { get; set; } = new List<Icproduct>();
}
