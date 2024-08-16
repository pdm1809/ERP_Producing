using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACSalaryEntryTypeDetailParts")]
public partial class AcsalaryEntryTypeDetailPart
{
    [Key]
    [Column("ACSalaryEntryTypeDetailPartID")]
    public int AcsalaryEntryTypeDetailPartId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ACSalaryEntryTypeID")]
    public int FkAcsalaryEntryTypeId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("FK_HRDepartmentRoomID")]
    public int? FkHrdepartmentRoomId { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [ForeignKey("FkAcsalaryEntryTypeId")]
    [InverseProperty("AcsalaryEntryTypeDetailParts")]
    public virtual AcsalaryEntryType FkAcsalaryEntryType { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("AcsalaryEntryTypeDetailParts")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHrdepartmentRoomId")]
    [InverseProperty("AcsalaryEntryTypeDetailParts")]
    public virtual HrdepartmentRoom FkHrdepartmentRoom { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("AcsalaryEntryTypeDetailParts")]
    public virtual Hrlevel FkHrlevel { get; set; }
}
