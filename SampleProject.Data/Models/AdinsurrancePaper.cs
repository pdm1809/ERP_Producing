using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADInsurrancePapers")]
public partial class AdinsurrancePaper
{
    [Key]
    [Column("ADInsurrancePaperID")]
    public int AdinsurrancePaperId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
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

    [Column("ADInsurrancePaperNo")]
    [StringLength(50)]
    public string AdinsurrancePaperNo { get; set; }

    [Column("ADInsurrancePaperName")]
    [StringLength(512)]
    public string AdinsurrancePaperName { get; set; }

    [Column("ADInsurrancePaperSocialID")]
    [StringLength(512)]
    public string AdinsurrancePaperSocialId { get; set; }

    [InverseProperty("FkAdinsurrancePaper")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItems { get; set; } = new List<HrsocialInsuranceDeclarationItem>();
}
