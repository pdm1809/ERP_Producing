using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSalesmans")]
public partial class Arsalesman
{
    [Key]
    [Column("ARSalesmanID")]
    public int ArsalesmanId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("ARSalesmanCommissionPercent", TypeName = "decimal(18, 5)")]
    public decimal? ArsalesmanCommissionPercent { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("ARSalesmanType")]
    [StringLength(50)]
    public string ArsalesmanType { get; set; }

    [Column("ARSalesmanName")]
    [StringLength(256)]
    public string ArsalesmanName { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("Arsalesmen")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Arsalesmen")]
    public virtual Hremployee FkHremployee { get; set; }
}
