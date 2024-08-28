using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GETemps")]
public partial class Getemp
{
    [Key]
    [Column("GETempID")]
    public int GetempId { get; set; }

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

    [Column("GETempCustomerSearchCount")]
    public int? GetempCustomerSearchCount { get; set; }

    [Column("GETempPath")]
    [StringLength(500)]
    public string GetempPath { get; set; }

    [Column("GETempWIFASDotNetVersion")]
    [StringLength(500)]
    public string GetempWifasdotNetVersion { get; set; }

    [Column("GETempWIFASERPVersion")]
    [StringLength(500)]
    public string GetempWifaserpversion { get; set; }
}
