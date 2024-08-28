using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADPriceGroups")]
public partial class AdpriceGroup
{
    [Key]
    [Column("ADPriceGroupID")]
    public int AdpriceGroupId { get; set; }

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

    [Required]
    [Column("ADPriceGroupName")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdpriceGroupName { get; set; }

    [Column("ADPriceGroupDesc")]
    [StringLength(100)]
    public string AdpriceGroupDesc { get; set; }

    [Column("ADPriceGroupKalkuExcel")]
    [StringLength(50)]
    public string AdpriceGroupKalkuExcel { get; set; }
}
