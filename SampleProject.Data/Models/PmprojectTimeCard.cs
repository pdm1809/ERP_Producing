using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectTimeCards")]
[Microsoft.EntityFrameworkCore.Index("PmprojectTimeCardNo", "PmprojectTimeCardDate", Name = "Idx_PMProjectTimeCards")]
public partial class PmprojectTimeCard
{
    [Key]
    [Column("PMProjectTimeCardID")]
    public int PmprojectTimeCardId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Required]
    [Column("PMProjectTimeCardNo")]
    [StringLength(50)]
    public string PmprojectTimeCardNo { get; set; }

    [Column("PMProjectTimeCardName")]
    [StringLength(50)]
    public string PmprojectTimeCardName { get; set; }

    [Column("PMProjectTimeCardDesc")]
    [StringLength(255)]
    public string PmprojectTimeCardDesc { get; set; }

    [Column("PMProjectTimeCardRemark")]
    [StringLength(500)]
    public string PmprojectTimeCardRemark { get; set; }

    [Column("PMProjectTimeCardActiveCheck")]
    public bool? PmprojectTimeCardActiveCheck { get; set; }

    [Column("PMProjectTimeCardMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode01Combo { get; set; }

    [Column("PMProjectTimeCardMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode02Combo { get; set; }

    [Column("PMProjectTimeCardMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode03Combo { get; set; }

    [Column("PMProjectTimeCardMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode04Combo { get; set; }

    [Column("PMProjectTimeCardMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode05Combo { get; set; }

    [Column("PMProjectTimeCardMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode06Combo { get; set; }

    [Column("PMProjectTimeCardMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode07Combo { get; set; }

    [Column("PMProjectTimeCardMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode08Combo { get; set; }

    [Column("PMProjectTimeCardMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode09Combo { get; set; }

    [Column("PMProjectTimeCardMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode10Combo { get; set; }

    [Column("PMProjectTimeCardMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode11Combo { get; set; }

    [Column("PMProjectTimeCardMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectTimeCardMatchCode12Combo { get; set; }

    [Column("PMProjectTimeCardStartDate", TypeName = "datetime")]
    public DateTime? PmprojectTimeCardStartDate { get; set; }

    [Column("PMProjectTimeCardDate", TypeName = "datetime")]
    public DateTime? PmprojectTimeCardDate { get; set; }

    [Column("PMProjectTimeCardTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectTimeCardTotalCost { get; set; }
}
