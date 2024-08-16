using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeePieceWorks")]
public partial class HremployeePieceWork
{
    [Key]
    [Column("HREmployeePieceWorkID")]
    public int HremployeePieceWorkId { get; set; }

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

    [Column("HREmployeePieceWorkAmount", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePieceWorkAmount { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("HREmployeePieceWorkFromDate", TypeName = "datetime")]
    public DateTime? HremployeePieceWorkFromDate { get; set; }

    [Column("HREmployeePieceWorkToDate", TypeName = "datetime")]
    public DateTime? HremployeePieceWorkToDate { get; set; }

    [Column("HREmployeePieceWorkQuantity", TypeName = "decimal(18, 5)")]
    public decimal? HremployeePieceWorkQuantity { get; set; }

    [Column("HREmployeePieceWorkRemark")]
    [StringLength(512)]
    public string HremployeePieceWorkRemark { get; set; }

    [Column("HREmployeePieceWorkNo")]
    [StringLength(50)]
    public string HremployeePieceWorkNo { get; set; }

    [Column("FK_ADMatchCodeBatchComponent")]
    public int? FkAdmatchCodeBatchComponent { get; set; }

    [ForeignKey("FkAdmatchCodeBatchComponent")]
    [InverseProperty("HremployeePieceWorks")]
    public virtual AdmatchCode FkAdmatchCodeBatchComponentNavigation { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("HremployeePieceWorks")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("HremployeePieceWorks")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("HremployeePieceWorks")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
