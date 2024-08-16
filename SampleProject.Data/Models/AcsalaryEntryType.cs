using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACSalaryEntryTypes")]
public partial class AcsalaryEntryType
{
    [Key]
    [Column("ACSalaryEntryTypeID")]
    public int AcsalaryEntryTypeId { get; set; }

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
    [Column("ACSalaryEntryTypeName")]
    [StringLength(100)]
    public string AcsalaryEntryTypeName { get; set; }

    [Required]
    [Column("ACSalaryEntryTypeDesc")]
    [StringLength(512)]
    public string AcsalaryEntryTypeDesc { get; set; }

    [InverseProperty("FkAcsalaryEntryType")]
    public virtual ICollection<AcsalaryCalculationDetail> AcsalaryCalculationDetails { get; set; } = new List<AcsalaryCalculationDetail>();

    [InverseProperty("FkAcsalaryEntryType")]
    public virtual ICollection<AcsalaryEntryTypeDetailPart> AcsalaryEntryTypeDetailParts { get; set; } = new List<AcsalaryEntryTypeDetailPart>();

    [InverseProperty("FkAcsalaryEntryType")]
    public virtual ICollection<AcsalaryEntryTypeDetail> AcsalaryEntryTypeDetails { get; set; } = new List<AcsalaryEntryTypeDetail>();
}
