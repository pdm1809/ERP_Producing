using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRLabouringConfigItems")]
public partial class HrlabouringConfigItem
{
    [Key]
    [Column("HRLabouringConfigItemID")]
    public int HrlabouringConfigItemId { get; set; }

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

    [Column("FK_HRLabouringConfigID")]
    public int? FkHrlabouringConfigId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("HRLabouringConfigItemQty", TypeName = "decimal(18, 5)")]
    public decimal? HrlabouringConfigItemQty { get; set; }

    [Column("HRLabouringConfigItemOverTimeQty", TypeName = "decimal(18, 5)")]
    public decimal? HrlabouringConfigItemOverTimeQty { get; set; }

    [Column("HRLabouringConfigItemTotalQty", TypeName = "decimal(18, 5)")]
    public decimal? HrlabouringConfigItemTotalQty { get; set; }

    [Column("HRLabouringConfigItemOverTimeRate", TypeName = "decimal(18, 5)")]
    public decimal? HrlabouringConfigItemOverTimeRate { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrlabouringConfigItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HrlabouringConfigItems")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("HrlabouringConfigItems")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }

    [ForeignKey("FkHrlabouringConfigId")]
    [InverseProperty("HrlabouringConfigItems")]
    public virtual HrlabouringConfig FkHrlabouringConfig { get; set; }

    [ForeignKey("FkMmoperationId")]
    [InverseProperty("HrlabouringConfigItems")]
    public virtual Mmoperation FkMmoperation { get; set; }
}
