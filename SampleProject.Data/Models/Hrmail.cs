using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRMails")]
[Microsoft.EntityFrameworkCore.Index("HrmailDate", "FkHremployeeId", Name = "Idx_HRMails")]
public partial class Hrmail
{
    [Key]
    [Column("HRMailID")]
    public int HrmailId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Column("HRMailSubject")]
    [StringLength(255)]
    public string HrmailSubject { get; set; }

    [Required]
    [Column("HRMailType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrmailType { get; set; }

    [Column("HRMailSubType")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrmailSubType { get; set; }

    [Column("HRMailStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrmailStatus { get; set; }

    [Column("HRMailDate", TypeName = "datetime")]
    public DateTime? HrmailDate { get; set; }

    [Column("HRMailSendFrom")]
    [StringLength(50)]
    public string HrmailSendFrom { get; set; }

    [Column("HRMailSendTo")]
    [StringLength(512)]
    public string HrmailSendTo { get; set; }

    [Column("HRMailPriority")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrmailPriority { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Hrmails")]
    public virtual Hremployee FkHremployee { get; set; }

    [InverseProperty("FkHrmail")]
    public virtual ICollection<HrmailAttachment> HrmailAttachments { get; set; } = new List<HrmailAttachment>();
}
