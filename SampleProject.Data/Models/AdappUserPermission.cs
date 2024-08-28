using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADAppUserPermissions")]
public partial class AdappUserPermission
{
    [Key]
    [Column("ADAppUserPermissionID")]
    public int AdappUserPermissionId { get; set; }

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

    [Column("FK_ADUserGroupID")]
    public int FkAduserGroupId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("ADAppUserPermissionFunctionCode")]
    [StringLength(100)]
    public string AdappUserPermissionFunctionCode { get; set; }

    [Column("ADAppUserPermissionFunctionName")]
    [StringLength(512)]
    public string AdappUserPermissionFunctionName { get; set; }

    [Column("ADAppUserPermissionActiveCheck")]
    public bool? AdappUserPermissionActiveCheck { get; set; }

    [Column("ADAppUserPermissionType")]
    [StringLength(50)]
    public string AdappUserPermissionType { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("AdappUserPermissions")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AdappUserPermissions")]
    public virtual Brbranch FkBrbranch { get; set; }
}
