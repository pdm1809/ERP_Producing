using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FATransferStockOutItemTransferStockInItems")]
public partial class FatransferStockOutItemTransferStockInItem
{
    [Key]
    [Column("FATransferStockOutItemTransferStockInItemID")]
    public int FatransferStockOutItemTransferStockInItemId { get; set; }

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

    [Column("FATransferStockOutItemID")]
    public int FatransferStockOutItemId { get; set; }

    [Column("FATransferStockInItemID")]
    public int FatransferStockInItemId { get; set; }

    [ForeignKey("FatransferStockInItemId")]
    [InverseProperty("FatransferStockOutItemTransferStockInItems")]
    public virtual FatransferStockInItem FatransferStockInItem { get; set; }

    [ForeignKey("FatransferStockOutItemId")]
    [InverseProperty("FatransferStockOutItemTransferStockInItems")]
    public virtual FatransferStockOutItem FatransferStockOutItem { get; set; }
}
