using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductCustomers")]
public partial class IcproductCustomer
{
    [Key]
    [Column("ICProductCustomerID")]
    public int IcproductCustomerId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("ICProductCustomerName")]
    [StringLength(256)]
    public string IcproductCustomerName { get; set; }

    [Column("ICProductCustomerPackagingDetail")]
    [StringLength(512)]
    public string IcproductCustomerPackagingDetail { get; set; }

    [Column("ICProductCustomerProductionComment")]
    [StringLength(512)]
    public string IcproductCustomerProductionComment { get; set; }

    [Column("ICProductCustomerNumber")]
    [StringLength(512)]
    public string IcproductCustomerNumber { get; set; }

    [Column("ICProductCustomerPackagingInfoVietnam")]
    [StringLength(1024)]
    public string IcproductCustomerPackagingInfoVietnam { get; set; }

    [Column("ICProductCustomerLogoPrintingInstructions")]
    [StringLength(256)]
    public string IcproductCustomerLogoPrintingInstructions { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("IcproductCustomers")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductCustomers")]
    public virtual Icproduct FkIcproduct { get; set; }
}
