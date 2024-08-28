using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductSizeSchemaItemNames")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductSizeSchemaItemId", Name = "Idx_ICProductSizeSchemaItemNames")]
public partial class IcproductSizeSchemaItemName
{
    [Key]
    [Column("ICProductSizeSchemaItemNameID")]
    public int IcproductSizeSchemaItemNameId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_GELanguageID")]
    public int? FkGelanguageId { get; set; }

    [Column("FK_ICProductSizeSchemaItemID")]
    public int? FkIcproductSizeSchemaItemId { get; set; }

    [Column("ICProductSizeSchemaItemName")]
    [StringLength(50)]
    public string IcproductSizeSchemaItemName1 { get; set; }

    [ForeignKey("FkGelanguageId")]
    [InverseProperty("IcproductSizeSchemaItemNames")]
    public virtual Gelanguage FkGelanguage { get; set; }

    [ForeignKey("FkIcproductSizeSchemaItemId")]
    [InverseProperty("IcproductSizeSchemaItemNames")]
    public virtual IcproductSizeSchemaItem FkIcproductSizeSchemaItem { get; set; }
}
