using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GENationalitys")]
public partial class Genationality
{
    [Key]
    [Column("GENationalityID")]
    public int GenationalityId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Required]
    [Column("GENationalityCode")]
    [StringLength(50)]
    public string GenationalityCode { get; set; }

    [Required]
    [Column("GENationalityName")]
    [StringLength(512)]
    public string GenationalityName { get; set; }

    [InverseProperty("FkGenationality")]
    public virtual ICollection<Hrcandidate> Hrcandidates { get; set; } = new List<Hrcandidate>();

    [InverseProperty("FkGenationality")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();

    [InverseProperty("FkGenationality")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItems { get; set; } = new List<HrsocialInsuranceDeclarationItem>();
}
