﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("Schema", Schema = "HangFire")]
public partial class Schema
{
    [Key]
    public int Version { get; set; }
}
