using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEReligions")]
public partial class Gereligion
{
    [Key]
    [Column("GEReligionID")]
    public int GereligionId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Required]
    [Column("GEReligionName")]
    [StringLength(512)]
    public string GereligionName { get; set; }

    [InverseProperty("FkGereligion")]
    public virtual ICollection<Hrcandidate> Hrcandidates { get; set; } = new List<Hrcandidate>();

    [InverseProperty("FkGereligion")]
    public virtual ICollection<Hremployee> Hremployees { get; set; } = new List<Hremployee>();
}
