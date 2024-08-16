using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMDepartmentCapacityDetails")]
public partial class MmdepartmentCapacityDetail
{
    [Key]
    [Column("MMDepartmentCapacityDetailID")]
    public int MmdepartmentCapacityDetailId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    public string Aastatus { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("MMProductGroupType")]
    [StringLength(50)]
    public string MmproductGroupType { get; set; }

    [Column("MMDepartmentCapacityDetailDate", TypeName = "datetime")]
    public DateTime? MmdepartmentCapacityDetailDate { get; set; }

    [Column("MMDepartmentCapacityDetailQtyPerDay", TypeName = "decimal(18, 5)")]
    public decimal? MmdepartmentCapacityDetailQtyPerDay { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmdepartmentCapacityDetails")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmdepartmentCapacityDetails")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
