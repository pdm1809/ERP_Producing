using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACEquipmentStates")]
public partial class AcequipmentState
{
    [Key]
    [Column("ACEquipmentStateID")]
    public int AcequipmentStateId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("ACEquipmentStateNo")]
    [StringLength(512)]
    public string AcequipmentStateNo { get; set; }

    [Column("ACEquipmentStateName")]
    [StringLength(512)]
    public string AcequipmentStateName { get; set; }

    [InverseProperty("FkAcequipmentState")]
    public virtual ICollection<Arreception> Arreceptions { get; set; } = new List<Arreception>();
}
