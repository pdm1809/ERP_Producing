using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GETableHistorys")]
public partial class GetableHistory
{
    [Key]
    [Column("GETableHistoryID")]
    public int GetableHistoryId { get; set; }

    [Column("GETableHistoryUserName")]
    [StringLength(50)]
    public string GetableHistoryUserName { get; set; }

    [Column("GETableHistoryChangeDate", TypeName = "datetime")]
    public DateTime? GetableHistoryChangeDate { get; set; }

    [Column("GETableHistoryTableName")]
    [StringLength(100)]
    public string GetableHistoryTableName { get; set; }

    [Column("GETableHistoryObjectID")]
    public int? GetableHistoryObjectId { get; set; }

    [Column("GETableHistoryColumnName")]
    [StringLength(100)]
    public string GetableHistoryColumnName { get; set; }

    [Column("GETableHistoryOldValue")]
    [StringLength(524)]
    public string GetableHistoryOldValue { get; set; }

    [Column("GETableHistoryNewValue")]
    [StringLength(524)]
    public string GetableHistoryNewValue { get; set; }

    [Column("GETableHistoryDesc")]
    [StringLength(524)]
    public string GetableHistoryDesc { get; set; }

    [Column("GETableHistoryActionType")]
    [StringLength(50)]
    public string GetableHistoryActionType { get; set; }
}
