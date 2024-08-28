using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Keyless]
[Table("NganhHangOld")]
public partial class NganhHangOld
{
    [Column("ICDepartmentID")]
    public int IcdepartmentId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Required]
    [Column("ICDepartmentNo")]
    [StringLength(50)]
    public string IcdepartmentNo { get; set; }

    [Required]
    [Column("ICDepartmentName")]
    [StringLength(50)]
    public string IcdepartmentName { get; set; }

    [Column("ICDepartmentDesc")]
    [StringLength(512)]
    public string IcdepartmentDesc { get; set; }

    [Column("ICDepartmentActiveCheck")]
    public bool? IcdepartmentActiveCheck { get; set; }

    [Column("ICDepartmentMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode01Combo { get; set; }

    [Column("ICDepartmentMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode02Combo { get; set; }

    [Column("ICDepartmentMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode03Combo { get; set; }

    [Column("ICDepartmentMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode04Combo { get; set; }

    [Column("ICDepartmentMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode05Combo { get; set; }

    [Column("ICDepartmentMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode06Combo { get; set; }

    [Column("ICDepartmentMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode07Combo { get; set; }

    [Column("ICDepartmentMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode08Combo { get; set; }

    [Column("ICDepartmentMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode09Combo { get; set; }

    [Column("ICDepartmentMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode10Combo { get; set; }

    [Column("ICDepartmentMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode11Combo { get; set; }

    [Column("ICDepartmentMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcdepartmentMatchCode12Combo { get; set; }
}
