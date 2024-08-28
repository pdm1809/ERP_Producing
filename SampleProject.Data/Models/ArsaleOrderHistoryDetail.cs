using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARSaleOrderHistoryDetails")]
public partial class ArsaleOrderHistoryDetail
{
    [Key]
    [Column("ARSaleOrderHistoryDetailID")]
    public int ArsaleOrderHistoryDetailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARSaleOrderHistoryID")]
    public int FkArsaleOrderHistoryId { get; set; }

    [Column("ARSaleOrderHistoryDetailDesc")]
    [StringLength(256)]
    public string ArsaleOrderHistoryDetailDesc { get; set; }

    [Required]
    [Column("ARSaleOrderHistoryDetailTableName")]
    [StringLength(50)]
    [Unicode(false)]
    public string ArsaleOrderHistoryDetailTableName { get; set; }

    [Required]
    [Column("ARSaleOrderHistoryDetailColumnName")]
    [StringLength(100)]
    [Unicode(false)]
    public string ArsaleOrderHistoryDetailColumnName { get; set; }

    [Required]
    [Column("ARSaleOrderHistoryDetailOldValue")]
    [StringLength(512)]
    public string ArsaleOrderHistoryDetailOldValue { get; set; }

    [Required]
    [Column("ARSaleOrderHistoryDetailNewValue")]
    [StringLength(512)]
    public string ArsaleOrderHistoryDetailNewValue { get; set; }

    [ForeignKey("FkArsaleOrderHistoryId")]
    [InverseProperty("ArsaleOrderHistoryDetails")]
    public virtual ArsaleOrderHistory FkArsaleOrderHistory { get; set; }
}
