using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("Queue", "Id")]
[Table("JobQueue", Schema = "HangFire")]
public partial class JobQueue
{
    [Key]
    public int Id { get; set; }

    public long JobId { get; set; }

    [Key]
    [StringLength(50)]
    public string Queue { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FetchedAt { get; set; }
}
