using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMChangeDeliveryDateBatchProducts")]
public partial class MmchangeDeliveryDateBatchProduct
{
    [Key]
    [Column("MMChangeDeliveryDateBatchProductID")]
    public int MmchangeDeliveryDateBatchProductId { get; set; }

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
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("MMChangeDeliveryDateBatchProductNo")]
    [StringLength(50)]
    public string MmchangeDeliveryDateBatchProductNo { get; set; }

    [Column("MMChangeDeliveryDateBatchProductDate", TypeName = "datetime")]
    public DateTime? MmchangeDeliveryDateBatchProductDate { get; set; }

    [Column("MMChangeDeliveryDateBatchProductStatus")]
    [StringLength(50)]
    public string MmchangeDeliveryDateBatchProductStatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("MMChangeDeliveryDateBatchProductDesc")]
    [StringLength(512)]
    public string MmchangeDeliveryDateBatchProductDesc { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmchangeDeliveryDateBatchProducts")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("MmchangeDeliveryDateBatchProducts")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmchangeDeliveryDateBatchProducts")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmchangeDeliveryDateBatchProducts")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [InverseProperty("FkMmchangeDeliveryDateBatchProduct")]
    public virtual ICollection<MmchangeDeliveryDateBatchProductItem> MmchangeDeliveryDateBatchProductItems { get; set; } = new List<MmchangeDeliveryDateBatchProductItem>();
}
