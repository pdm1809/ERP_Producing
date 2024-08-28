using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBPOperationDepartments")]
public partial class MmbpoperationDepartment
{
    [Key]
    [Column("MMBPOperationDepartmentID")]
    public int MmbpoperationDepartmentId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_MMBatchProductItemID")]
    public int? FkMmbatchProductItemId { get; set; }

    [Column("MMBPOperationDepartmentProductSerial")]
    [StringLength(100)]
    public string MmbpoperationDepartmentProductSerial { get; set; }

    [Column("MMBPOperationDepartmentProductName")]
    [StringLength(512)]
    public string MmbpoperationDepartmentProductName { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("MMBPOperationDepartmentProductNo")]
    [StringLength(100)]
    public string MmbpoperationDepartmentProductNo { get; set; }

    [Column("MMBPOperationDepartmentIndex")]
    [StringLength(50)]
    public string MmbpoperationDepartmentIndex { get; set; }

    [Column("MMBPOperationDepartmentFromDate", TypeName = "datetime")]
    public DateTime? MmbpoperationDepartmentFromDate { get; set; }

    [Column("MMBPOperationDepartmentToDate", TypeName = "datetime")]
    public DateTime? MmbpoperationDepartmentToDate { get; set; }

    [Column("MMBPOperationDepartmentProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbpoperationDepartmentProductQty { get; set; }

    [Column("FK_MMWorkShopID")]
    public int? FkMmworkShopId { get; set; }

    [Column("FK_MMLineID")]
    public int? FkMmlineId { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("MmbpoperationDepartments")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("MmbpoperationDepartments")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmbpoperationDepartments")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbpoperationDepartments")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmbatchProductItemId")]
    [InverseProperty("MmbpoperationDepartments")]
    public virtual MmbatchProductItem FkMmbatchProductItem { get; set; }

    [ForeignKey("FkMmlineId")]
    [InverseProperty("MmbpoperationDepartments")]
    public virtual Mmline FkMmline { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmbpoperationDepartments")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmworkShopId")]
    [InverseProperty("MmbpoperationDepartments")]
    public virtual MmworkShop FkMmworkShop { get; set; }
}
