using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARProposalAreaItems")]
public partial class ArproposalAreaItem
{
    [Key]
    [Column("ARProposalAreaItemID")]
    public int ArproposalAreaItemId { get; set; }

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

    [Column("FK_ICProductTemplateID")]
    public int? FkIcproductTemplateId { get; set; }

    [Column("FK_ICProductTemplateItemID")]
    public int? FkIcproductTemplateItemId { get; set; }

    [Column("ARProposalAreaItemSortOrder")]
    public int? ArproposalAreaItemSortOrder { get; set; }

    [Column("ARProposalAreaItemType")]
    [StringLength(50)]
    public string ArproposalAreaItemType { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ARProposalAreaItemProductNo")]
    [StringLength(128)]
    public string ArproposalAreaItemProductNo { get; set; }

    [Column("ARProposalAreaItemProductName")]
    [StringLength(512)]
    public string ArproposalAreaItemProductName { get; set; }

    [Column("ARProposalAreaItemProductDesc")]
    [StringLength(1024)]
    public string ArproposalAreaItemProductDesc { get; set; }

    [Column("ARProposalAreaItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalAreaItemProductQty { get; set; }

    [Column("ARProposalAreaItemFormulaPriceConfigQty", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalAreaItemFormulaPriceConfigQty { get; set; }

    [Column("ARProposalAreaItemProductUnitPrice", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalAreaItemProductUnitPrice { get; set; }

    [Column("ARProposalAreaItemTotalAmount", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalAreaItemTotalAmount { get; set; }

    [Column("ARProposalAreaItemLength", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalAreaItemLength { get; set; }

    [Column("ARProposalAreaItemWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalAreaItemWidth { get; set; }

    [Column("ARProposalAreaItemHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArproposalAreaItemHeight { get; set; }

    [Column("FK_ICProductFormulaPriceConfigID")]
    public int? FkIcproductFormulaPriceConfigId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ARProposalAreaID")]
    public int? FkArproposalAreaId { get; set; }

    [ForeignKey("FkArproposalAreaId")]
    [InverseProperty("ArproposalAreaItems")]
    public virtual ArproposalArea FkArproposalArea { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArproposalAreaItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArproposalAreaItems")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductFormulaPriceConfigId")]
    [InverseProperty("ArproposalAreaItems")]
    public virtual IcproductFormulaPriceConfig FkIcproductFormulaPriceConfig { get; set; }

    [ForeignKey("FkIcproductTemplateId")]
    [InverseProperty("ArproposalAreaItems")]
    public virtual IcproductTemplate FkIcproductTemplate { get; set; }

    [ForeignKey("FkIcproductTemplateItemId")]
    [InverseProperty("ArproposalAreaItems")]
    public virtual IcproductTemplateItem FkIcproductTemplateItem { get; set; }
}
