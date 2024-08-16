using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACSalaryDocumentTypes")]
public partial class AcsalaryDocumentType
{
    [Key]
    [Column("ACSalaryDocumentTypeID")]
    public int AcsalaryDocumentTypeId { get; set; }

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
    [Column("ACSalaryDocumentTypeName")]
    [StringLength(100)]
    public string AcsalaryDocumentTypeName { get; set; }

    [Required]
    [Column("ACSalaryDocumentTypeDesc")]
    [StringLength(512)]
    public string AcsalaryDocumentTypeDesc { get; set; }

    [Column("ACSalaryDocumentTypeTakeEmployee")]
    public bool? AcsalaryDocumentTypeTakeEmployee { get; set; }

    [InverseProperty("FkAcsalaryDocumentType")]
    public virtual ICollection<AcsalaryCalculation> AcsalaryCalculations { get; set; } = new List<AcsalaryCalculation>();

    [InverseProperty("FkAcsalaryDocumentType")]
    public virtual ICollection<AcsalaryDocumentTypePayRollDetail> AcsalaryDocumentTypePayRollDetails { get; set; } = new List<AcsalaryDocumentTypePayRollDetail>();

    [InverseProperty("FkAcsalaryDocumentType")]
    public virtual ICollection<AcsalaryEntryTypeDetail> AcsalaryEntryTypeDetails { get; set; } = new List<AcsalaryEntryTypeDetail>();
}
