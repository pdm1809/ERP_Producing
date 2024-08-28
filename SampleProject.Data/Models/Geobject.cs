using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEObjects")]
public partial class Geobject
{
    [Key]
    [Column("GEObjectID")]
    public int GeobjectId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("GEObjectObjectID")]
    public int GeobjectObjectId { get; set; }

    [Column("GEObjectObjectType")]
    [StringLength(50)]
    public string GeobjectObjectType { get; set; }

    [Column("GEObjectIsTransfered")]
    public bool? GeobjectIsTransfered { get; set; }
}
