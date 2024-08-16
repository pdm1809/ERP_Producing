using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRATMCardManages")]
public partial class HratmcardManage
{
    [Key]
    [Column("HRATMCardManageID")]
    public int HratmcardManageId { get; set; }

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
    [Column("HRATMCardManageNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string HratmcardManageNo { get; set; }

    [Column("HRATMCardManageName")]
    [StringLength(50)]
    public string HratmcardManageName { get; set; }

    [Column("HRATMCardManageDesc")]
    [StringLength(255)]
    public string HratmcardManageDesc { get; set; }

    [Column("HRATMCardManageDate", TypeName = "datetime")]
    public DateTime? HratmcardManageDate { get; set; }

    [Column("HRATMCardManageStatus")]
    [StringLength(50)]
    public string HratmcardManageStatus { get; set; }

    [InverseProperty("FkHratmcardManage")]
    public virtual ICollection<HremployeeAtmcardManage> HremployeeAtmcardManages { get; set; } = new List<HremployeeAtmcardManage>();
}
