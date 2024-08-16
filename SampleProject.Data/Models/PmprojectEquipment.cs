using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("PMProjectEquipments")]
[Microsoft.EntityFrameworkCore.Index("PmprojectEquipmentNo", "PmprojectEquipmentDate", Name = "Idx_PMProjectEquipments")]
public partial class PmprojectEquipment
{
    [Key]
    [Column("PMProjectEquipmentID")]
    public int PmprojectEquipmentId { get; set; }

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
    [Column("PMProjectEquipmentNo")]
    [StringLength(50)]
    public string PmprojectEquipmentNo { get; set; }

    [Column("PMProjectEquipmentName")]
    [StringLength(50)]
    public string PmprojectEquipmentName { get; set; }

    [Column("PMProjectEquipmentDesc")]
    [StringLength(255)]
    public string PmprojectEquipmentDesc { get; set; }

    [Column("PMProjectEquipmentRemark")]
    [StringLength(500)]
    public string PmprojectEquipmentRemark { get; set; }

    [Column("PMProjectEquipmentActiveCheck")]
    public bool? PmprojectEquipmentActiveCheck { get; set; }

    [Column("PMProjectEquipmentMatchCode01Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode01Combo { get; set; }

    [Column("PMProjectEquipmentMatchCode02Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode02Combo { get; set; }

    [Column("PMProjectEquipmentMatchCode03Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode03Combo { get; set; }

    [Column("PMProjectEquipmentMatchCode04Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode04Combo { get; set; }

    [Column("PMProjectEquipmentMatchCode05Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode05Combo { get; set; }

    [Column("PMProjectEquipmentMatchCode06Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode06Combo { get; set; }

    [Column("PMProjectEquipmentMatchCode07Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode07Combo { get; set; }

    [Column("PMProjectEquipmentMatchCode08Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode08Combo { get; set; }

    [Column("PMProjectEquipmentMatchCode09Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode09Combo { get; set; }

    [Column("PMProjectEquipmentMatchCode10Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode10Combo { get; set; }

    [Column("PMProjectEquipmentMatchCode11Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode11Combo { get; set; }

    [Column("PMProjectEquipmentMatchCode12Combo")]
    [StringLength(50)]
    [Unicode(false)]
    public string PmprojectEquipmentMatchCode12Combo { get; set; }

    [Column("PMProjectEquipmentStartDate", TypeName = "datetime")]
    public DateTime? PmprojectEquipmentStartDate { get; set; }

    [Column("PMProjectEquipmentDate", TypeName = "datetime")]
    public DateTime? PmprojectEquipmentDate { get; set; }

    [Column("PMProjectEquipmentTotalCost", TypeName = "decimal(18, 5)")]
    public decimal? PmprojectEquipmentTotalCost { get; set; }
}
