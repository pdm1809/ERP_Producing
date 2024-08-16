using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeGroupOrderWebs")]
public partial class HremployeeGroupOrderWeb
{
    [Key]
    [Column("HREmployeeGroupOrderWebID")]
    public int HremployeeGroupOrderWebId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("FK_ADGroupOrderWebID")]
    public int FkAdgroupOrderWebId { get; set; }

    [ForeignKey("FkAdgroupOrderWebId")]
    [InverseProperty("HremployeeGroupOrderWebs")]
    public virtual AdgroupOrderWeb FkAdgroupOrderWeb { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeGroupOrderWebs")]
    public virtual Hremployee FkHremployee { get; set; }
}
