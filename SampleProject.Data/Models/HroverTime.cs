using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HROverTimes")]
public partial class HroverTime
{
    [Key]
    [Column("HROverTimeID")]
    public int HroverTimeId { get; set; }

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

    [Required]
    [Column("HROverTimeNo")]
    [StringLength(50)]
    public string HroverTimeNo { get; set; }

    [Required]
    [Column("HROverTimeName")]
    [StringLength(100)]
    public string HroverTimeName { get; set; }

    [Column("HROverTimeDesc")]
    [StringLength(512)]
    public string HroverTimeDesc { get; set; }

    [Column("HROverTimeFromDate", TypeName = "datetime")]
    public DateTime HroverTimeFromDate { get; set; }

    [Column("HROverTimeToDate", TypeName = "datetime")]
    public DateTime HroverTimeToDate { get; set; }

    [Column("HROverTimeDate", TypeName = "datetime")]
    public DateTime? HroverTimeDate { get; set; }

    [Column("HREmployeeCardNumber")]
    [StringLength(200)]
    public string HremployeeCardNumber { get; set; }

    [Column("HREmployeeName")]
    [StringLength(200)]
    public string HremployeeName { get; set; }

    [Column("HROverTimeHaveMeal")]
    public bool? HroverTimeHaveMeal { get; set; }

    [Column("HROverTimeDateEnd", TypeName = "datetime")]
    public DateTime? HroverTimeDateEnd { get; set; }

    [Column("HROverTimeStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HroverTimeStatus { get; set; }

    [InverseProperty("FkHroverTime")]
    public virtual ICollection<HremployeeOt> HremployeeOts { get; set; } = new List<HremployeeOt>();
}
