using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADReportPermissions")]
public partial class AdreportPermission
{
    [Key]
    [Column("ADReportPermissionID")]
    public int AdreportPermissionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ADUserGroupID")]
    public int FkAduserGroupId { get; set; }

    [Column("FK_ADReportID")]
    public int FkAdreportId { get; set; }

    [Column("ADReportPermissionType")]
    public byte AdreportPermissionType { get; set; }

    [ForeignKey("FkAdreportId")]
    [InverseProperty("AdreportPermissions")]
    public virtual Adreport FkAdreport { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("AdreportPermissions")]
    public virtual AduserGroup FkAduserGroup { get; set; }
}
