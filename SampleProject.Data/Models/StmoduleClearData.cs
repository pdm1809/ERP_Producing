using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STModuleClearDatas")]
public partial class StmoduleClearData
{
    [Key]
    [Column("STModuleClearDataID")]
    public int StmoduleClearDataId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("STModuleID")]
    public int? StmoduleId { get; set; }

    [Column("STModuleClearDataFunction")]
    [StringLength(512)]
    [Unicode(false)]
    public string StmoduleClearDataFunction { get; set; }
}
