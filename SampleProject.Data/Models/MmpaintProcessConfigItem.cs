using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMPaintProcessConfigItems")]
public partial class MmpaintProcessConfigItem
{
    [Key]
    [Column("MMPaintProcessConfigItemID")]
    public int MmpaintProcessConfigItemId { get; set; }

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

    [Column("FK_MMPaintProcessConfigID")]
    public int FkMmpaintProcessConfigId { get; set; }

    [Column("FK_MMFormulaIDPaintA")]
    public int? FkMmformulaIdpaintA { get; set; }

    [Column("FK_MMFormulaIDPaintB")]
    public int? FkMmformulaIdpaintB { get; set; }

    [Column("FK_MMFormulaIDPaintC")]
    public int? FkMmformulaIdpaintC { get; set; }

    [Required]
    [Column("ICProductColorPaintA")]
    [StringLength(256)]
    public string IcproductColorPaintA { get; set; }

    [Required]
    [Column("ICProductColorPaintB")]
    [StringLength(256)]
    public string IcproductColorPaintB { get; set; }

    [Required]
    [Column("ICProductColorPaintC")]
    [StringLength(256)]
    public string IcproductColorPaintC { get; set; }

    [Required]
    [Column("ICProductPaintProcessA")]
    [StringLength(256)]
    public string IcproductPaintProcessA { get; set; }

    [Required]
    [Column("ICProductPaintProcessB")]
    [StringLength(256)]
    public string IcproductPaintProcessB { get; set; }

    [Required]
    [Column("ICProductPaintProcessC")]
    [StringLength(256)]
    public string IcproductPaintProcessC { get; set; }

    [Required]
    [Column("ICProductColorAttribute")]
    [StringLength(512)]
    public string IcproductColorAttribute { get; set; }

    [ForeignKey("FkMmformulaIdpaintA")]
    [InverseProperty("MmpaintProcessConfigItemFkMmformulaIdpaintANavigations")]
    public virtual Mmformula FkMmformulaIdpaintANavigation { get; set; }

    [ForeignKey("FkMmformulaIdpaintB")]
    [InverseProperty("MmpaintProcessConfigItemFkMmformulaIdpaintBNavigations")]
    public virtual Mmformula FkMmformulaIdpaintBNavigation { get; set; }

    [ForeignKey("FkMmformulaIdpaintC")]
    [InverseProperty("MmpaintProcessConfigItemFkMmformulaIdpaintCNavigations")]
    public virtual Mmformula FkMmformulaIdpaintCNavigation { get; set; }

    [ForeignKey("FkMmpaintProcessConfigId")]
    [InverseProperty("MmpaintProcessConfigItems")]
    public virtual MmpaintProcessConfig FkMmpaintProcessConfig { get; set; }
}
