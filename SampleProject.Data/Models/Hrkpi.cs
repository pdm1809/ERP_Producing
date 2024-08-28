using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRKPIs")]
public partial class Hrkpi
{
    [Key]
    [Column("HRKPIID")]
    public int Hrkpiid { get; set; }

    [Column("AAStatus")]
    [StringLength(64)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(64)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(64)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("HRKPINo")]
    [StringLength(50)]
    public string Hrkpino { get; set; }

    [Required]
    [Column("HRKPIName")]
    [StringLength(256)]
    public string Hrkpiname { get; set; }

    [Column("HRKPIMeasurementMethod")]
    [StringLength(1000)]
    public string HrkpimeasurementMethod { get; set; }

    [Column("HRKPIIsActive")]
    public bool? HrkpiisActive { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("HRKPITarget", TypeName = "decimal(18, 5)")]
    public decimal? Hrkpitarget { get; set; }

    public bool? IsReverseTarget { get; set; }

    [Column("HRKPIGuide")]
    [StringLength(256)]
    public string Hrkpiguide { get; set; }

    [Column("HRKPIDepartment")]
    [StringLength(256)]
    public string Hrkpidepartment { get; set; }

    [Column("HRKPIStore")]
    [StringLength(256)]
    public string Hrkpistore { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("Hrkpis")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("Hrkpis")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [InverseProperty("FkHrkpi")]
    public virtual ICollection<HrkpievaluationItemTarget> HrkpievaluationItemTargets { get; set; } = new List<HrkpievaluationItemTarget>();

    [InverseProperty("FkHrkpi")]
    public virtual ICollection<HrkpievaluationItem> HrkpievaluationItems { get; set; } = new List<HrkpievaluationItem>();

    [InverseProperty("FkHrkpi")]
    public virtual ICollection<HrkpiformItem> HrkpiformItems { get; set; } = new List<HrkpiformItem>();

    [InverseProperty("FkHrkpi")]
    public virtual ICollection<HrkpiregistrationItemTarget> HrkpiregistrationItemTargets { get; set; } = new List<HrkpiregistrationItemTarget>();

    [InverseProperty("FkHrkpi")]
    public virtual ICollection<HrkpiregistrationItem> HrkpiregistrationItems { get; set; } = new List<HrkpiregistrationItem>();
}
