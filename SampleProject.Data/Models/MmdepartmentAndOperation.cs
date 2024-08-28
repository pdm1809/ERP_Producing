using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMDepartmentAndOperations")]
public partial class MmdepartmentAndOperation
{
    [Key]
    [Column("MMDepartmentAndOperationID")]
    public int MmdepartmentAndOperationId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmdepartmentAndOperations")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
