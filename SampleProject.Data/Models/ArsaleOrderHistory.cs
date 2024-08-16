using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderHistorys")]
public partial class ArsaleOrderHistory
{
    [Key]
    [Column("ARSaleOrderHistoryID")]
    public int ArsaleOrderHistoryId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_ADUserID")]
    public int? FkAduserId { get; set; }

    [Column("ARSaleOrderHistoryDate", TypeName = "datetime")]
    public DateTime? ArsaleOrderHistoryDate { get; set; }

    [Column("ARSaleOrderStatus")]
    [StringLength(50)]
    public string ArsaleOrderStatus { get; set; }

    [InverseProperty("FkArsaleOrderHistory")]
    public virtual ICollection<ArsaleOrderHistoryDetail> ArsaleOrderHistoryDetails { get; set; } = new List<ArsaleOrderHistoryDetail>();

    [ForeignKey("FkAduserId")]
    [InverseProperty("ArsaleOrderHistories")]
    public virtual Aduser FkAduser { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArsaleOrderHistories")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("ArsaleOrderHistories")]
    public virtual Hremployee FkHremployee { get; set; }
}
