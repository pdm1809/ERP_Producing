using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductColorSchemas")]
public partial class IcproductColorSchema
{
    [Key]
    [Column("ICProductColorSchemaID")]
    public int IcproductColorSchemaId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ICProductColorSchemaName")]
    [StringLength(50)]
    public string IcproductColorSchemaName { get; set; }

    [Column("ICProductColorSchemaDesc")]
    [StringLength(100)]
    public string IcproductColorSchemaDesc { get; set; }

    [InverseProperty("FkIcproductColorSchema")]
    public virtual ICollection<IcproductColorSchemaItem> IcproductColorSchemaItems { get; set; } = new List<IcproductColorSchemaItem>();
}
