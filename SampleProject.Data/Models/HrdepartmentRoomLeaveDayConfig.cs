using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRDepartmentRoomLeaveDayConfigs")]
public partial class HrdepartmentRoomLeaveDayConfig
{
    [Key]
    [Column("HRDepartmentRoomLeaveDayConfigID")]
    public int HrdepartmentRoomLeaveDayConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("HRDepartmentRoomLeaveDayConfigNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string HrdepartmentRoomLeaveDayConfigNo { get; set; }

    [Column("HRDepartmentRoomLeaveDayConfigName")]
    [StringLength(100)]
    public string HrdepartmentRoomLeaveDayConfigName { get; set; }

    [Column("HRDepartmentRoomLeaveDayConfigQty", TypeName = "decimal(18, 5)")]
    public decimal? HrdepartmentRoomLeaveDayConfigQty { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("HrdepartmentRoomLeaveDayConfigs")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }
}
