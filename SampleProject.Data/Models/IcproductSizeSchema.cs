using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductSizeSchemas")]
public partial class IcproductSizeSchema
{
    [Key]
    [Column("ICProductSizeSchemaID")]
    public int IcproductSizeSchemaId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ICProductSizeSchemaName")]
    [StringLength(50)]
    public string IcproductSizeSchemaName { get; set; }

    [Column("ICProductSizeSchemaDesc")]
    [StringLength(100)]
    public string IcproductSizeSchemaDesc { get; set; }

    [InverseProperty("IcproductSizeSchema")]
    public virtual ICollection<IcproductSizeSchemaItem> IcproductSizeSchemaItems { get; set; } = new List<IcproductSizeSchemaItem>();
}
