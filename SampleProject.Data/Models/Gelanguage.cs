using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GELanguages")]
[Microsoft.EntityFrameworkCore.Index("GelanguageNo", Name = "Idx_GELanguages")]
public partial class Gelanguage
{
    [Key]
    [Column("GELanguageID")]
    public int GelanguageId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("GELanguageNo")]
    [StringLength(50)]
    public string GelanguageNo { get; set; }

    [Column("GELanguageCultur")]
    [StringLength(50)]
    [Unicode(false)]
    public string GelanguageCultur { get; set; }

    [Required]
    [Column("GELanguageName")]
    [StringLength(50)]
    public string GelanguageName { get; set; }

    [Column("GELanguageDesc")]
    [StringLength(255)]
    public string GelanguageDesc { get; set; }

    [InverseProperty("FkGelanguage")]
    public virtual ICollection<Adreport> Adreports { get; set; } = new List<Adreport>();

    [InverseProperty("AdlanguageIdcomboNavigation")]
    public virtual ICollection<AduserGroup> AduserGroups { get; set; } = new List<AduserGroup>();

    [InverseProperty("FkGelanguage")]
    public virtual ICollection<ApinvoiceIn> ApinvoiceIns { get; set; } = new List<ApinvoiceIn>();

    [InverseProperty("FkGelanguage")]
    public virtual ICollection<AppurchaseOrder> AppurchaseOrders { get; set; } = new List<AppurchaseOrder>();

    [InverseProperty("FkGelanguage")]
    public virtual ICollection<Apsupplier> Apsuppliers { get; set; } = new List<Apsupplier>();

    [InverseProperty("FkArsellerContactLanguageIdcomboNavigation")]
    public virtual ICollection<Arseller> ArsellerFkArsellerContactLanguageIdcomboNavigations { get; set; } = new List<Arseller>();

    [InverseProperty("FkGelanguage")]
    public virtual ICollection<Arseller> ArsellerFkGelanguages { get; set; } = new List<Arseller>();

    [InverseProperty("FkGelanguage")]
    public virtual ICollection<Cscompany> Cscompanies { get; set; } = new List<Cscompany>();

    [InverseProperty("FalanguageIdcomboNavigation")]
    public virtual ICollection<Facontact> Facontacts { get; set; } = new List<Facontact>();

    [InverseProperty("FalanguageIdcomboNavigation")]
    public virtual ICollection<FacreditNote> FacreditNotes { get; set; } = new List<FacreditNote>();

    [InverseProperty("FalanguageIdcomboNavigation")]
    public virtual ICollection<FapurchaseOrder> FapurchaseOrders { get; set; } = new List<FapurchaseOrder>();

    [InverseProperty("FalanguageIdcomboNavigation")]
    public virtual ICollection<FareturnSupplier> FareturnSuppliers { get; set; } = new List<FareturnSupplier>();

    [InverseProperty("FalanguageIdcomboNavigation")]
    public virtual ICollection<FasellReturn> FasellReturns { get; set; } = new List<FasellReturn>();

    [InverseProperty("GelanguageIdcomboNavigation")]
    public virtual ICollection<Getext> Getexts { get; set; } = new List<Getext>();

    [InverseProperty("FkGelanguage")]
    public virtual ICollection<IcproductColorSchemaItemName> IcproductColorSchemaItemNames { get; set; } = new List<IcproductColorSchemaItemName>();

    [InverseProperty("FkGelanguage")]
    public virtual ICollection<IcproductDesc> IcproductDescs { get; set; } = new List<IcproductDesc>();

    [InverseProperty("FkGelanguage")]
    public virtual ICollection<IcproductSizeSchemaItemName> IcproductSizeSchemaItemNames { get; set; } = new List<IcproductSizeSchemaItemName>();

    [InverseProperty("FkGelanguage")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();

    [InverseProperty("FkGelanguage")]
    public virtual ICollection<Icstock> Icstocks { get; set; } = new List<Icstock>();

    [InverseProperty("Gelanguage")]
    public virtual ICollection<Oeproposal> Oeproposals { get; set; } = new List<Oeproposal>();

    [InverseProperty("Stlanguage")]
    public virtual ICollection<StmoduleDescription> StmoduleDescriptions { get; set; } = new List<StmoduleDescription>();
}
