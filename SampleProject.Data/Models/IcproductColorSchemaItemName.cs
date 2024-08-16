using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductColorSchemaItemNames")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductColorSchemaItemId", Name = "Idx_ICProductColorSchemaItemNames")]
public partial class IcproductColorSchemaItemName
{
    [Key]
    [Column("ICProductColorSchemaItemNameID")]
    public int IcproductColorSchemaItemNameId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GELanguageID")]
    public int? FkGelanguageId { get; set; }

    [Column("FK_ICProductColorSchemaItemID")]
    public int? FkIcproductColorSchemaItemId { get; set; }

    [Column("ICProductColorSchemaItemName")]
    [StringLength(50)]
    public string IcproductColorSchemaItemName1 { get; set; }

    [ForeignKey("FkGelanguageId")]
    [InverseProperty("IcproductColorSchemaItemNames")]
    public virtual Gelanguage FkGelanguage { get; set; }

    [ForeignKey("FkIcproductColorSchemaItemId")]
    [InverseProperty("IcproductColorSchemaItemNames")]
    public virtual IcproductColorSchemaItem FkIcproductColorSchemaItem { get; set; }
}
