using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMChangeBOMInformations")]
public partial class MmchangeBominformation
{
    [Key]
    [Column("MMChangeBOMInformationID")]
    public int MmchangeBominformationId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_HREmployeeIDApproved")]
    public int? FkHremployeeIdapproved { get; set; }

    [Column("FK_HREmployeeIDValidated")]
    public int? FkHremployeeIdvalidated { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Required]
    [Column("MMChangeBOMInformationNo")]
    [StringLength(50)]
    public string MmchangeBominformationNo { get; set; }

    [Column("MMChangeBOMInformationDesc")]
    [StringLength(512)]
    public string MmchangeBominformationDesc { get; set; }

    [Column("MMChangeBOMInformationRequirement")]
    [StringLength(512)]
    public string MmchangeBominformationRequirement { get; set; }

    [Column("MMChangeBOMInformationDate", TypeName = "datetime")]
    public DateTime? MmchangeBominformationDate { get; set; }

    [Column("MMChangeBOMInformationStatus")]
    [StringLength(50)]
    public string MmchangeBominformationStatus { get; set; }

    [Column("MMChangeBOMInformationSaleOrderNo")]
    [StringLength(50)]
    public string MmchangeBominformationSaleOrderNo { get; set; }

    [Column("MMChangeBOMInformationInvoiceNo")]
    [StringLength(50)]
    public string MmchangeBominformationInvoiceNo { get; set; }

    [Column("MMChangeBOMInformationCustomerName")]
    [StringLength(50)]
    public string MmchangeBominformationCustomerName { get; set; }

    [Column("MMChangeBOMInformationProductDesc")]
    [StringLength(512)]
    public string MmchangeBominformationProductDesc { get; set; }

    [Column("MMChangeBOMInformationApprovedDate", TypeName = "datetime")]
    public DateTime? MmchangeBominformationApprovedDate { get; set; }

    [Column("MMChangeBOMInformationValidatedDate", TypeName = "datetime")]
    public DateTime? MmchangeBominformationValidatedDate { get; set; }

    [Column("MMChangeBOMInformationBatchProductDate", TypeName = "datetime")]
    public DateTime? MmchangeBominformationBatchProductDate { get; set; }

    [Column("FK_ACObjectID")]
    public int? FkAcobjectId { get; set; }

    [Column("MMObjectType")]
    [StringLength(50)]
    public string MmobjectType { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmchangeBominformations")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmchangeBominformations")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmchangeBominformationFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeIdapproved")]
    [InverseProperty("MmchangeBominformationFkHremployeeIdapprovedNavigations")]
    public virtual Hremployee FkHremployeeIdapprovedNavigation { get; set; }

    [ForeignKey("FkHremployeeIdvalidated")]
    [InverseProperty("MmchangeBominformationFkHremployeeIdvalidatedNavigations")]
    public virtual Hremployee FkHremployeeIdvalidatedNavigation { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmchangeBominformations")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmchangeBominformations")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmchangeBominformations")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [InverseProperty("FkMmchangeBominformation")]
    public virtual ICollection<MmchangeBominformationItem> MmchangeBominformationItems { get; set; } = new List<MmchangeBominformationItem>();
}
