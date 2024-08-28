using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRManufactureTimeSheets")]
public partial class HrmanufactureTimeSheet
{
    [Key]
    [Column("HRManufactureTimeSheetID")]
    public int HrmanufactureTimeSheetId { get; set; }

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
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("HRManufactureTimeSheetNo")]
    [StringLength(50)]
    public string HrmanufactureTimeSheetNo { get; set; }

    [Column("HRManufactureTimeSheetName")]
    [StringLength(256)]
    public string HrmanufactureTimeSheetName { get; set; }

    [Column("HRManufactureTimeSheetDate", TypeName = "datetime")]
    public DateTime HrmanufactureTimeSheetDate { get; set; }

    [Column("HRManufactureTimeSheetDesc")]
    [StringLength(512)]
    public string HrmanufactureTimeSheetDesc { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrmanufactureTimeSheets")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrmanufactureTimeSheet")]
    public virtual ICollection<HrmanufactureTimeSheetItem> HrmanufactureTimeSheetItems { get; set; } = new List<HrmanufactureTimeSheetItem>();
}
