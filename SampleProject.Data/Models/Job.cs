﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("Job", Schema = "HangFire")]
public partial class Job
{
    [Key]
    public long Id { get; set; }

    public long? StateId { get; set; }

    [StringLength(20)]
    public string StateName { get; set; }

    [Required]
    public string InvocationData { get; set; }

    [Required]
    public string Arguments { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpireAt { get; set; }

    [InverseProperty("Job")]
    public virtual ICollection<JobParameter> JobParameters { get; set; } = new List<JobParameter>();

    [InverseProperty("Job")]
    public virtual ICollection<State> States { get; set; } = new List<State>();
}
