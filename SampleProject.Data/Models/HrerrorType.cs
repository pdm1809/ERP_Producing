using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRErrorTypes")]
public partial class HrerrorType
{
    [Key]
    [Column("HRErrorTypeID")]
    public int HrerrorTypeId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
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

    [Column("HRErrorTypeNo")]
    [StringLength(50)]
    public string HrerrorTypeNo { get; set; }

    [Column("HRErrorTypeName")]
    [StringLength(512)]
    public string HrerrorTypeName { get; set; }

    [Column("HRBugManagementHandleType")]
    [StringLength(512)]
    public string HrbugManagementHandleType { get; set; }

    [InverseProperty("FkHrerrorType")]
    public virtual ICollection<HrbugManagement> HrbugManagements { get; set; } = new List<HrbugManagement>();
}
