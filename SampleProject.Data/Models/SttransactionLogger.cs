using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("STTransactionLoggers")]
public partial class SttransactionLogger
{
    [Key]
    [Column("STTransactionLoggerID")]
    public Guid SttransactionLoggerId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("STModuleName")]
    [StringLength(255)]
    public string StmoduleName { get; set; }

    [Column("STTransactionType")]
    [StringLength(50)]
    [Unicode(false)]
    public string SttransactionType { get; set; }

    [Column("STTransactionActionName")]
    [StringLength(50)]
    [Unicode(false)]
    public string SttransactionActionName { get; set; }

    [Column("STTransactionObjectID")]
    public int? SttransactionObjectId { get; set; }

    [Column("STTransactionObjectRefID")]
    [Unicode(false)]
    public string SttransactionObjectRefId { get; set; }

    [Column("STTransactionErrorMessage")]
    public string SttransactionErrorMessage { get; set; }

    [Column("STTransactionFixed")]
    public bool? SttransactionFixed { get; set; }
}
