using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICPackageNumbers")]
[Microsoft.EntityFrameworkCore.Index("IcpackageNumberDate", Name = "Idx_ICPackageNumbers")]
public partial class IcpackageNumber
{
    [Key]
    [Column("ICPackageNumberID")]
    public int IcpackageNumberId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("ICPackageNumberDate", TypeName = "datetime")]
    public DateTime IcpackageNumberDate { get; set; }

    [Column("ICPackageNumberStart")]
    public int IcpackageNumberStart { get; set; }
}
