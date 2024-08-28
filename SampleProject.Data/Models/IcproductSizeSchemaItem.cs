using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductSizeSchemaItems")]
public partial class IcproductSizeSchemaItem
{
    [Key]
    [Column("ICProductSizeSchemaItemID")]
    public int IcproductSizeSchemaItemId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ICProductSizeSchemaID")]
    public int? IcproductSizeSchemaId { get; set; }

    [Column("ICProductSizeSchemaItemDesc")]
    [StringLength(100)]
    public string IcproductSizeSchemaItemDesc { get; set; }

    [ForeignKey("IcproductSizeSchemaId")]
    [InverseProperty("IcproductSizeSchemaItems")]
    public virtual IcproductSizeSchema IcproductSizeSchema { get; set; }

    [InverseProperty("FkIcproductSizeSchemaItem")]
    public virtual ICollection<IcproductSizeSchemaItemName> IcproductSizeSchemaItemNames { get; set; } = new List<IcproductSizeSchemaItemName>();
}
