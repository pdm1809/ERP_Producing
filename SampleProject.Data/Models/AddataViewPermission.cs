using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADDataViewPermissions")]
[Microsoft.EntityFrameworkCore.Index("FkBrbranchId", Name = "Idx_ADDataViewPermissions")]
public partial class AddataViewPermission
{
    [Key]
    [Column("ADDataViewPermissionID")]
    public int AddataViewPermissionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("FK_ADUserID")]
    public int FkAduserId { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_STModuleOrReportID")]
    public int? FkStmoduleOrReportId { get; set; }

    [Column("ADDataViewPermissionType")]
    [StringLength(50)]
    public string AddataViewPermissionType { get; set; }

    [ForeignKey("FkAduserId")]
    [InverseProperty("AddataViewPermissions")]
    public virtual Aduser FkAduser { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AddataViewPermissions")]
    public virtual Brbranch FkBrbranch { get; set; }
}
