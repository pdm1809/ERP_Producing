using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADDiscounts")]
public partial class Addiscount
{
    [Key]
    [Column("ADDiscountID")]
    public int AddiscountId { get; set; }

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

    [Column("ADDiscountDesc")]
    [StringLength(200)]
    public string AddiscountDesc { get; set; }

    [Column("ADDiscountName")]
    [StringLength(50)]
    public string AddiscountName { get; set; }

    [Column("ADDiscountOrder")]
    public int? AddiscountOrder { get; set; }

    [Column("ADDiscountKind")]
    [StringLength(50)]
    public string AddiscountKind { get; set; }

    [Column("ADDiscountSum", TypeName = "decimal(18, 5)")]
    public decimal? AddiscountSum { get; set; }

    [Column("ADDiscountPerCent", TypeName = "decimal(18, 5)")]
    public decimal? AddiscountPerCent { get; set; }

    [InverseProperty("FkAddiscount")]
    public virtual ICollection<ArcustomerDiscount> ArcustomerDiscounts { get; set; } = new List<ArcustomerDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FacreditNoteDiscount> FacreditNoteDiscounts { get; set; } = new List<FacreditNoteDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FacreditNoteItemDiscount> FacreditNoteItemDiscounts { get; set; } = new List<FacreditNoteItemDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FainvoiceDiscount> FainvoiceDiscounts { get; set; } = new List<FainvoiceDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FaproposalDiscount> FaproposalDiscounts { get; set; } = new List<FaproposalDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FaproposalItemDiscount> FaproposalItemDiscounts { get; set; } = new List<FaproposalItemDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FapurchaseOrderDiscount> FapurchaseOrderDiscounts { get; set; } = new List<FapurchaseOrderDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FapurchaseOrderItemDiscount> FapurchaseOrderItemDiscounts { get; set; } = new List<FapurchaseOrderItemDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FareceiptDiscount> FareceiptDiscounts { get; set; } = new List<FareceiptDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FareceiptItemDiscount> FareceiptItemDiscounts { get; set; } = new List<FareceiptItemDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FasellOrderDiscount> FasellOrderDiscounts { get; set; } = new List<FasellOrderDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FasellReturnDiscount> FasellReturnDiscounts { get; set; } = new List<FasellReturnDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FasellReturnItemDiscount> FasellReturnItemDiscounts { get; set; } = new List<FasellReturnItemDiscount>();

    [InverseProperty("Fadiscount")]
    public virtual ICollection<FashipmentDiscount> FashipmentDiscounts { get; set; } = new List<FashipmentDiscount>();
}
