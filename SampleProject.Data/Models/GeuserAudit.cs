using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEUserAudits")]
public partial class GeuserAudit
{
    [Key]
    [Column("GEUserAuditID")]
    public int GeuserAuditId { get; set; }

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

    [Column("ADUserID")]
    public int AduserId { get; set; }

    [Required]
    [Column("ADUserName")]
    [StringLength(50)]
    public string AduserName { get; set; }

    [Required]
    [Column("GEUserAuditModuleName")]
    [StringLength(50)]
    public string GeuserAuditModuleName { get; set; }

    [Column("GEUserAuditBeginDate", TypeName = "datetime")]
    public DateTime GeuserAuditBeginDate { get; set; }

    /// <summary>
    /// 0:Create
    /// 1:Modify
    /// 2:Delete
    /// </summary>
    [Required]
    [Column("GEUserAuditAction")]
    [StringLength(50)]
    [Unicode(false)]
    public string GeuserAuditAction { get; set; }

    [Column("GEUserAuditParameter")]
    [StringLength(50)]
    [Unicode(false)]
    public string GeuserAuditParameter { get; set; }
}
