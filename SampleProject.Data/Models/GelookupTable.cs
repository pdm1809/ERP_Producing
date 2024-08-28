using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GELookupTables")]
public partial class GelookupTable
{
    [Key]
    [Column("GELookupTableID")]
    public int GelookupTableId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("GELookupTableName")]
    [StringLength(200)]
    public string GelookupTableName { get; set; }

    [Column("GELookupTableDesc")]
    [StringLength(200)]
    public string GelookupTableDesc { get; set; }

    [Column("GELookupTableDisplayColumn")]
    [StringLength(200)]
    public string GelookupTableDisplayColumn { get; set; }

    [Column("GELookupTableValueColumn")]
    [StringLength(512)]
    [Unicode(false)]
    public string GelookupTableValueColumn { get; set; }

    [Column("GELookupTableLookupColumns")]
    [StringLength(512)]
    [Unicode(false)]
    public string GelookupTableLookupColumns { get; set; }
}
