using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMBatchItemPlans")]
public partial class MmbatchItemPlan
{
    [Key]
    [Column("MMBatchItemPlanID")]
    public int MmbatchItemPlanId { get; set; }

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

    [Column("FK_HREmployeeValidated")]
    public int? FkHremployeeValidated { get; set; }

    [Column("FK_HREmployeeApproved")]
    public int? FkHremployeeApproved { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("FK_ICProductAttributeTTMTID")]
    public int? FkIcproductAttributeTtmtid { get; set; }

    [Required]
    [Column("MMBatchItemPlanNo")]
    [StringLength(50)]
    public string MmbatchItemPlanNo { get; set; }

    [Column("MMBatchItemPlanDesc")]
    [StringLength(512)]
    public string MmbatchItemPlanDesc { get; set; }

    [Column("MMBatchItemPlanDate", TypeName = "datetime")]
    public DateTime? MmbatchItemPlanDate { get; set; }

    [Column("MMBatchItemPlanStatus")]
    [StringLength(50)]
    public string MmbatchItemPlanStatus { get; set; }

    [Column("MMBatchItemPlanValidateDate", TypeName = "datetime")]
    public DateTime? MmbatchItemPlanValidateDate { get; set; }

    [Column("MMBatchItemPlanApprovedDate", TypeName = "datetime")]
    public DateTime? MmbatchItemPlanApprovedDate { get; set; }

    [Column("MMBatchItemPlanProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmbatchItemPlanProductQty { get; set; }

    [Column("MMBatchItemPlanBatchSaleOrderNo")]
    [StringLength(50)]
    public string MmbatchItemPlanBatchSaleOrderNo { get; set; }

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("MmbatchItemPlans")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmbatchItemPlans")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmbatchItemPlanFkHremployees")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHremployeeApproved")]
    [InverseProperty("MmbatchItemPlanFkHremployeeApprovedNavigations")]
    public virtual Hremployee FkHremployeeApprovedNavigation { get; set; }

    [ForeignKey("FkHremployeeValidated")]
    [InverseProperty("MmbatchItemPlanFkHremployeeValidatedNavigations")]
    public virtual Hremployee FkHremployeeValidatedNavigation { get; set; }

    [ForeignKey("FkIcproductAttributeTtmtid")]
    [InverseProperty("MmbatchItemPlans")]
    public virtual IcproductAttribute FkIcproductAttributeTtmt { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmbatchItemPlans")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [InverseProperty("FkMmbatchItemPlan")]
    public virtual ICollection<MmbatchItemWood> MmbatchItemWoods { get; set; } = new List<MmbatchItemWood>();
}
