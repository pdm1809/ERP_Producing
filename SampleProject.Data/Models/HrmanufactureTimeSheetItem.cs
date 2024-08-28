using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRManufactureTimeSheetItems")]
public partial class HrmanufactureTimeSheetItem
{
    [Key]
    [Column("HRManufactureTimeSheetItemID")]
    public int HrmanufactureTimeSheetItemId { get; set; }

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
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("FK_HRManufactureTimeSheetID")]
    public int? FkHrmanufactureTimeSheetId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

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

    [Column("HRManufactureTimeSheetItemBatchComponent")]
    public int? HrmanufactureTimeSheetItemBatchComponent { get; set; }

    [Column("HRManufactureTimeSheetItemComments")]
    [StringLength(512)]
    public string HrmanufactureTimeSheetItemComments { get; set; }

    [Column("HRManufactureTimeSheetItemProductNo")]
    [StringLength(50)]
    public string HrmanufactureTimeSheetItemProductNo { get; set; }

    [Column("HRManufactureTimeSheetItemProductName")]
    [StringLength(256)]
    public string HrmanufactureTimeSheetItemProductName { get; set; }

    [Column("HRManufactureTimeSheetItemProductDesc")]
    [StringLength(512)]
    public string HrmanufactureTimeSheetItemProductDesc { get; set; }

    [Column("HRManufactureTimeSheetItemProductSerialNo")]
    [StringLength(50)]
    public string HrmanufactureTimeSheetItemProductSerialNo { get; set; }

    [Column("HRManufactureTimeSheetItemProductAttributes")]
    [StringLength(256)]
    public string HrmanufactureTimeSheetItemProductAttributes { get; set; }

    [Column("HRManufactureTimeSheetItemProductQty", TypeName = "decimal(18, 5)")]
    public decimal? HrmanufactureTimeSheetItemProductQty { get; set; }

    [Column("HRManufactureTimeSheetItemOperationStatus")]
    public bool? HrmanufactureTimeSheetItemOperationStatus { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("HrmanufactureTimeSheetItems")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrmanufactureTimeSheetItems")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrmanufactureTimeSheetId")]
    [InverseProperty("HrmanufactureTimeSheetItems")]
    public virtual HrmanufactureTimeSheet FkHrmanufactureTimeSheet { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("HrmanufactureTimeSheetItems")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("HrmanufactureTimeSheetItems")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("HrmanufactureTimeSheetItemFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("HrmanufactureTimeSheetItems")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkIcproductIdforBatch")]
    [InverseProperty("HrmanufactureTimeSheetItemFkIcproductIdforBatchNavigations")]
    public virtual Icproduct FkIcproductIdforBatchNavigation { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("HrmanufactureTimeSheetItems")]
    public virtual Mmoperation FkMmoperation { get; set; }

    [ForeignKey("FkMmproductionNormId")]
    [InverseProperty("HrmanufactureTimeSheetItems")]
    public virtual MmproductionNorm FkMmproductionNorm { get; set; }

    [ForeignKey("FkMmproposalId")]
    [InverseProperty("HrmanufactureTimeSheetItems")]
    public virtual Mmproposal FkMmproposal { get; set; }
}
