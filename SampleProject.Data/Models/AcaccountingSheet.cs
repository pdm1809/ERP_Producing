using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ACAccountingSheets")]
public partial class AcaccountingSheet
{
    [Key]
    [Column("ACAccountingSheetID")]
    public int AcaccountingSheetId { get; set; }

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

    [Column("ACAccountingSheetNo")]
    [StringLength(50)]
    public string AcaccountingSheetNo { get; set; }

    [Column("ACAccountingSheetstatus")]
    [StringLength(100)]
    public string AcaccountingSheetstatus { get; set; }

    [Column("ACAccountingSheetName")]
    [StringLength(512)]
    public string AcaccountingSheetName { get; set; }

    [Column("ACAccountingSheetDesc")]
    [StringLength(512)]
    public string AcaccountingSheetDesc { get; set; }

    [Column("ACAccountingSheetFromDate", TypeName = "datetime")]
    public DateTime? AcaccountingSheetFromDate { get; set; }

    [Column("ACAccountingSheetToDate", TypeName = "datetime")]
    public DateTime? AcaccountingSheetToDate { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_BRBranchCentralID")]
    public int? FkBrbranchCentralId { get; set; }

    [InverseProperty("FkAcaccountingSheet")]
    public virtual ICollection<AcaccountingSheetDetail> AcaccountingSheetDetails { get; set; } = new List<AcaccountingSheetDetail>();

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("AcaccountingSheetFkBrbranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkBrbranchCentralId")]
    [InverseProperty("AcaccountingSheetFkBrbranchCentrals")]
    public virtual Brbranch FkBrbranchCentral { get; set; }
}
