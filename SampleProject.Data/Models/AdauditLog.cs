using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADAuditLogs")]
public partial class AdauditLog
{
    [Key]
    [Column("ADAuditLogID")]
    public int AdauditLogId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    public int? UserId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string ServiceName { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string MethodName { get; set; }

    public string Parameters { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExecutionTime { get; set; }

    public int? ExecutionDuration { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ClientIpAddress { get; set; }

    [StringLength(200)]
    public string ClientName { get; set; }

    [StringLength(200)]
    public string BrowserInfo { get; set; }

    public string Exception { get; set; }

    public string CustomData { get; set; }
}
