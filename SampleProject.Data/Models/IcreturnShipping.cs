using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICReturnShippings")]
public partial class IcreturnShipping
{
    [Key]
    [Column("ICReturnShippingID")]
    public int IcreturnShippingId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_ICShipmentSaleOrderID")]
    public int? FkIcshipmentSaleOrderId { get; set; }

    [Required]
    [Column("ICReturnShippingNo")]
    [StringLength(50)]
    public string IcreturnShippingNo { get; set; }

    [Column("ICReturnShippingName")]
    [StringLength(100)]
    public string IcreturnShippingName { get; set; }

    [Column("ICReturnShippingDesc")]
    [StringLength(512)]
    public string IcreturnShippingDesc { get; set; }

    [Column("ICReturnShippingDate", TypeName = "datetime")]
    public DateTime? IcreturnShippingDate { get; set; }

    [Column("ICReturnShippingStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcreturnShippingStatus { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IcreturnShippings")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("IcreturnShippings")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcshipmentSaleOrderId")]
    [InverseProperty("IcreturnShippings")]
    public virtual Icshipment FkIcshipmentSaleOrder { get; set; }

    [InverseProperty("FkIcreturnShipping")]
    public virtual ICollection<IcreturnShippingItem> IcreturnShippingItems { get; set; } = new List<IcreturnShippingItem>();
}
