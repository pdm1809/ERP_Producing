using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEAccountingFormulaItems")]
public partial class GeaccountingFormulaItem
{
    [Key]
    [Column("GEAccountingFormulaItemID")]
    public int GeaccountingFormulaItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GEAccountingFormulaID")]
    public int? FkGeaccountingFormulaId { get; set; }

    [Column("GEAccountingFormulaItemNumber")]
    public int? GeaccountingFormulaItemNumber { get; set; }

    [Column("GEAccountingFormulaItemShowPrint")]
    public bool? GeaccountingFormulaItemShowPrint { get; set; }

    [Column("GEAccountingFormulaItemBold")]
    [StringLength(50)]
    public string GeaccountingFormulaItemBold { get; set; }

    [Column("GEAccountingFormulaItemCategory")]
    [StringLength(512)]
    public string GeaccountingFormulaItemCategory { get; set; }

    [Column("GEAccountingFormulaItemCategoryEnglish")]
    [StringLength(512)]
    public string GeaccountingFormulaItemCategoryEnglish { get; set; }

    [Column("GEAccountingFormulaItemAccountNo")]
    [StringLength(50)]
    public string GeaccountingFormulaItemAccountNo { get; set; }

    [Column("GEAccountingFormulaItemType")]
    [StringLength(50)]
    public string GeaccountingFormulaItemType { get; set; }

    [Column("GEAccountingFormulaItemAccount")]
    [StringLength(50)]
    public string GeaccountingFormulaItemAccount { get; set; }

    [Column("GEAccountingFormulaItemDemonstration")]
    [StringLength(50)]
    public string GeaccountingFormulaItemDemonstration { get; set; }

    [Column("GEAccountingFormulaItemFormula")]
    [StringLength(512)]
    public string GeaccountingFormulaItemFormula { get; set; }

    [Column("GEAccountingFormulaItemSpot")]
    [StringLength(10)]
    public string GeaccountingFormulaItemSpot { get; set; }

    [Column("GEAccountingFormulaItemAccountDebit")]
    [StringLength(256)]
    public string GeaccountingFormulaItemAccountDebit { get; set; }

    [Column("GEAccountingFormulaItemAccountCredit")]
    [StringLength(256)]
    public string GeaccountingFormulaItemAccountCredit { get; set; }

    [Column("GEAccountingFormulaItemExceptAccountDebit")]
    [StringLength(256)]
    public string GeaccountingFormulaItemExceptAccountDebit { get; set; }

    [Column("GEAccountingFormulaItemExceptAccountCredit")]
    [StringLength(256)]
    public string GeaccountingFormulaItemExceptAccountCredit { get; set; }

    [ForeignKey("FkGeaccountingFormulaId")]
    [InverseProperty("GeaccountingFormulaItems")]
    public virtual GeaccountingFormula FkGeaccountingFormula { get; set; }
}
