using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSellerProductGroups")]
public partial class ArsellerProductGroup
{
    [Key]
    [Column("ARSellerProductGroupID")]
    public int ArsellerProductGroupId { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("ARSellerID")]
    public int ArsellerId { get; set; }

    [Column("ICProductGroupID")]
    public int IcproductGroupId { get; set; }

    [Column("ARSellerProductGroupProvisionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerProductGroupProvisionPercent { get; set; }

    [Column("ARSellerProductGroupProvisionValue", TypeName = "decimal(18, 5)")]
    public decimal? ArsellerProductGroupProvisionValue { get; set; }

    [Column("ARSellerProductGroupDesc")]
    [StringLength(100)]
    public string ArsellerProductGroupDesc { get; set; }

    [ForeignKey("ArsellerId")]
    [InverseProperty("ArsellerProductGroups")]
    public virtual Arseller Arseller { get; set; }

    [ForeignKey("IcproductGroupId")]
    [InverseProperty("ArsellerProductGroups")]
    public virtual IcproductGroup IcproductGroup { get; set; }
}
