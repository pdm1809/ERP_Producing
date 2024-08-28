using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDepartmentGroupOperations")]
public partial class HrdepartmentGroupOperation
{
    [Key]
    [Column("HRDepartmentGroupOperationID")]
    public int HrdepartmentGroupOperationId { get; set; }

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

    [Column("FK_HRDepartmentRoomGroupItemID")]
    public int? FkHrdepartmentRoomGroupItemId { get; set; }

    [Column("FK_MMOperationID")]
    public int? FkMmoperationId { get; set; }

    [Column("HRDepartmentGroupOperationNo")]
    [StringLength(50)]
    public string HrdepartmentGroupOperationNo { get; set; }

    [Column("HRDepartmentGroupOperationName")]
    [StringLength(50)]
    public string HrdepartmentGroupOperationName { get; set; }

    [Column("HRDepartmentGroupOperationDesc")]
    [StringLength(512)]
    public string HrdepartmentGroupOperationDesc { get; set; }

    [ForeignKey("FkHrdepartmentRoomGroupItemId")]
    [InverseProperty("HrdepartmentGroupOperations")]
    public virtual HrdepartmentRoomGroupItem FkHrdepartmentRoomGroupItem { get; set; }
}
