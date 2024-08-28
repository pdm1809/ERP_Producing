using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRCalendarEntrys")]
[Microsoft.EntityFrameworkCore.Index("HrcalendarEntryDate", "FkHrcalendarId", Name = "Idx_HRCalendarEntrys")]
public partial class HrcalendarEntry
{
    [Key]
    [Column("HRCalendarEntryID")]
    public int HrcalendarEntryId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HRCalendarID")]
    public int FkHrcalendarId { get; set; }

    [Column("HRCalendarEntryDate", TypeName = "datetime")]
    public DateTime HrcalendarEntryDate { get; set; }

    [Column("HRCalendarEntryDesc")]
    [StringLength(512)]
    public string HrcalendarEntryDesc { get; set; }

    [ForeignKey("FkHrcalendarId")]
    [InverseProperty("HrcalendarEntries")]
    public virtual Hrcalendar FkHrcalendar { get; set; }
}
