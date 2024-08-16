using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICImportAndExportReasons")]
public partial class IcimportAndExportReason
{
    [Key]
    [Column("ICImportAndExportReasonID")]
    public int IcimportAndExportReasonId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("FK_ACAcountID")]
    public int? FkAcacountId { get; set; }

    [Column("ICImportAndExportReasonNo")]
    [StringLength(50)]
    public string IcimportAndExportReasonNo { get; set; }

    [Column("ICImportAndExportReasonName")]
    [StringLength(100)]
    public string IcimportAndExportReasonName { get; set; }

    [Column("ICImportAndExportReasonType")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcimportAndExportReasonType { get; set; }

    [Column("FK_STModuleID")]
    public int? FkStmoduleId { get; set; }

    [ForeignKey("FkAcacountId")]
    [InverseProperty("IcimportAndExportReasons")]
    public virtual Acaccount FkAcacount { get; set; }

    [InverseProperty("FkIcimportAndExportReason")]
    public virtual ICollection<IcreceiptItem> IcreceiptItems { get; set; } = new List<IcreceiptItem>();

    [InverseProperty("FkIcimportAndExportReason")]
    public virtual ICollection<Icreceipt> Icreceipts { get; set; } = new List<Icreceipt>();

    [InverseProperty("FkIcimportAndExportReason")]
    public virtual ICollection<IcshipmentItem> IcshipmentItems { get; set; } = new List<IcshipmentItem>();

    [InverseProperty("FkIcimportAndExportReason")]
    public virtual ICollection<Icshipment> Icshipments { get; set; } = new List<Icshipment>();
}
