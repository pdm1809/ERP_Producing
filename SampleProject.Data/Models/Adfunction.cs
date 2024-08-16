using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADFunctions")]
public partial class Adfunction
{
    [Key]
    [Column("ADFunctionID")]
    public int AdfunctionId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("ADFunctionName")]
    [StringLength(50)]
    public string AdfunctionName { get; set; }

    [Column("ADFunctionDesc")]
    [StringLength(250)]
    public string AdfunctionDesc { get; set; }

    [Column("ADFunctionModule")]
    [StringLength(250)]
    public string AdfunctionModule { get; set; }

    [Column("ADFunctionEnum")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdfunctionEnum { get; set; }
}
