using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GETexts")]
public partial class Getext
{
    [Key]
    [Column("GETextID")]
    public int GetextId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("GELanguageIDCombo")]
    public int? GelanguageIdcombo { get; set; }

    [Column("GETextName")]
    [StringLength(50)]
    public string GetextName { get; set; }

    [Required]
    [Column("GETextSearch")]
    [StringLength(50)]
    public string GetextSearch { get; set; }

    [Column("GETextOrder")]
    public int GetextOrder { get; set; }

    [Column("GETextSpezification1")]
    [StringLength(50)]
    public string GetextSpezification1 { get; set; }

    [Column("GETextSpezification2")]
    [StringLength(50)]
    public string GetextSpezification2 { get; set; }

    [Column("GETextDesc", TypeName = "ntext")]
    public string GetextDesc { get; set; }

    [InverseProperty("FatextIdcomboNavigation")]
    public virtual ICollection<FacreditNoteItem> FacreditNoteItems { get; set; } = new List<FacreditNoteItem>();

    [InverseProperty("FatextIdcomboNavigation")]
    public virtual ICollection<FaproposalItem> FaproposalItems { get; set; } = new List<FaproposalItem>();

    [InverseProperty("FatextIdcomboNavigation")]
    public virtual ICollection<FapurchaseOrderItem> FapurchaseOrderItems { get; set; } = new List<FapurchaseOrderItem>();

    [InverseProperty("FatextIdcomboNavigation")]
    public virtual ICollection<FareturnSupplierItem> FareturnSupplierItems { get; set; } = new List<FareturnSupplierItem>();

    [InverseProperty("FatextIdcomboNavigation")]
    public virtual ICollection<FasellReturnItem> FasellReturnItems { get; set; } = new List<FasellReturnItem>();

    [InverseProperty("FatextIdcomboNavigation")]
    public virtual ICollection<FatransferStockInItem> FatransferStockInItems { get; set; } = new List<FatransferStockInItem>();

    [InverseProperty("FatextIdcomboNavigation")]
    public virtual ICollection<FatransferStockOutItem> FatransferStockOutItems { get; set; } = new List<FatransferStockOutItem>();

    [ForeignKey("GelanguageIdcombo")]
    [InverseProperty("Getexts")]
    public virtual Gelanguage GelanguageIdcomboNavigation { get; set; }
}
