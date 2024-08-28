using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADMatchCodes")]
public partial class AdmatchCode
{
    [Key]
    [Column("ADMatchCodeID")]
    public int AdmatchCodeId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Required]
    [Column("ADMatchCodeColumnName")]
    [StringLength(50)]
    public string AdmatchCodeColumnName { get; set; }

    [Column("ADMatchCodeValue")]
    [StringLength(50)]
    [Unicode(false)]
    public string AdmatchCodeValue { get; set; }

    [InverseProperty("FkAdmatchCodeBatchComponentNavigation")]
    public virtual ICollection<HremployeePieceWork> HremployeePieceWorks { get; set; } = new List<HremployeePieceWork>();
}
