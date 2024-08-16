using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRCalendars")]
[Microsoft.EntityFrameworkCore.Index("HrcalendarNo", "HrcalendarType", Name = "Idx_HRCalendars")]
public partial class Hrcalendar
{
    [Key]
    [Column("HRCalendarID")]
    public int HrcalendarId { get; set; }

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
    [Column("HRCalendarNo")]
    [StringLength(50)]
    public string HrcalendarNo { get; set; }

    [Required]
    [Column("HRCalendarName")]
    [StringLength(50)]
    public string HrcalendarName { get; set; }

    [Column("HRCalendarDesc")]
    [StringLength(512)]
    public string HrcalendarDesc { get; set; }

    [Required]
    [Column("HRCalendarType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrcalendarType { get; set; }

    [Column("HRCalendarYear")]
    public int HrcalendarYear { get; set; }

    [InverseProperty("FkHrcalendar")]
    public virtual ICollection<HrcalendarEntry> HrcalendarEntries { get; set; } = new List<HrcalendarEntry>();
}
