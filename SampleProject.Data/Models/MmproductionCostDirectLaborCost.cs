using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("MMProductionCostDirectLaborCosts")]
public partial class MmproductionCostDirectLaborCost
{
    [Key]
    [Column("MMProductionCostDirectLaborCostID")]
    public int MmproductionCostDirectLaborCostId { get; set; }

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

    [Column("FK_MMProductionCostID")]
    public int? FkMmproductionCostId { get; set; }

    [Column("FK_MMBatchProductID")]
    public int? FkMmbatchProductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICStockID")]
    public int? FkIcstockId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_MMProductionNormID")]
    public int? FkMmproductionNormId { get; set; }

    [Column("FK_ICProductIDForBatch")]
    public int? FkIcproductIdforBatch { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_MMProposalID")]
    public int? FkMmproposalId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("MMProductionCostDirectLaborCostReferenceNo")]
    [StringLength(50)]
    public string MmproductionCostDirectLaborCostReferenceNo { get; set; }

    [Column("MMProductionCostDirectLaborCostReferenceType")]
    [StringLength(50)]
    public string MmproductionCostDirectLaborCostReferenceType { get; set; }

    [Column("MMProductionCostDirectLaborCostProductNo")]
    [StringLength(100)]
    public string MmproductionCostDirectLaborCostProductNo { get; set; }

    [Column("MMProductionCostDirectLaborCostProductName")]
    [StringLength(100)]
    public string MmproductionCostDirectLaborCostProductName { get; set; }

    [Column("MMProductionCostDirectLaborCostProductDesc")]
    [StringLength(512)]
    public string MmproductionCostDirectLaborCostProductDesc { get; set; }

    [Column("MMProductionCostDirectLaborCostProductSerialNo")]
    [StringLength(50)]
    public string MmproductionCostDirectLaborCostProductSerialNo { get; set; }

    [Column("MMProductionCostDirectLaborCostProductAttribute")]
    [StringLength(200)]
    public string MmproductionCostDirectLaborCostProductAttribute { get; set; }

    [Column("MMProductionCostDirectLaborCostProductUnitCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostDirectLaborCostProductUnitCost { get; set; }

    [Column("MMProductionCostDirectLaborCostProductQty", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostDirectLaborCostProductQty { get; set; }

    [Column("MMProductionCostDirectLaborCostTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? MmproductionCostDirectLaborCostTotalCost { get; set; }

    [Column("MMProductionCostDirectLaborCostBatchComponent")]
    public int? MmproductionCostDirectLaborCostBatchComponent { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("MmproductionCostDirectLaborCosts")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("MmproductionCostDirectLaborCosts")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("MmproductionCostDirectLaborCosts")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("MmproductionCostDirectLaborCosts")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("MmproductionCostDirectLaborCostFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("MmproductionCostDirectLaborCosts")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductIdforBatch")]
    [InverseProperty("MmproductionCostDirectLaborCostFkIcproductIdforBatchNavigations")]
    public virtual Icproduct FkIcproductIdforBatchNavigation { get; set; }

    [ForeignKey("FkIcstockId")]
    [InverseProperty("MmproductionCostDirectLaborCosts")]
    public virtual Icstock FkIcstock { get; set; }

    [ForeignKey("FkMmbatchProductId")]
    [InverseProperty("MmproductionCostDirectLaborCosts")]
    public virtual MmbatchProduct FkMmbatchProduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("MmproductionCostDirectLaborCosts")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionCostId")]
    [InverseProperty("MmproductionCostDirectLaborCosts")]
    public virtual MmproductionCost FkMmproductionCost { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("MmproductionCostDirectLaborCosts")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmproposalId")]
    [InverseProperty("MmproductionCostDirectLaborCosts")]
    public virtual Mmproposal FkMmproposal { get; set; }
}
