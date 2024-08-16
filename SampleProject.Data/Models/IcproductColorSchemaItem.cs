using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductColorSchemaItems")]
[Microsoft.EntityFrameworkCore.Index("FkIcproductColorSchemaId", Name = "Idx_ICProductColorSchemaItems")]
public partial class IcproductColorSchemaItem
{
    [Key]
    [Column("ICProductColorSchemaItemID")]
    public int IcproductColorSchemaItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductColorSchemaID")]
    public int? FkIcproductColorSchemaId { get; set; }

    [Column("ICProductColorSchemaItemDesc")]
    [StringLength(100)]
    public string IcproductColorSchemaItemDesc { get; set; }

    [ForeignKey("FkIcproductColorSchemaId")]
    [InverseProperty("IcproductColorSchemaItems")]
    public virtual IcproductColorSchema FkIcproductColorSchema { get; set; }

    [InverseProperty("FkIcproductColorSchemaItem")]
    public virtual ICollection<IcproductColorSchemaItemName> IcproductColorSchemaItemNames { get; set; } = new List<IcproductColorSchemaItemName>();
}
