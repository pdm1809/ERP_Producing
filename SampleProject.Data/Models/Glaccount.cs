using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GLAccounts")]
[Microsoft.EntityFrameworkCore.Index("GlaccountNo", Name = "Idx_GLAccounts")]
public partial class Glaccount
{
    [Key]
    [Column("GLAccountID")]
    public int GlaccountId { get; set; }

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

    [Column("FK_GLAccountParentID")]
    public int? FkGlaccountParentId { get; set; }

    [Column("GLAccountNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string GlaccountNo { get; set; }

    [Column("GLAccountName")]
    [StringLength(50)]
    public string GlaccountName { get; set; }

    [Column("GLAccountDesc")]
    [StringLength(500)]
    public string GlaccountDesc { get; set; }

    [Column("GLAccountActiveCheck")]
    public bool? GlaccountActiveCheck { get; set; }

    [Column("GLAccountTypeCombo")]
    [StringLength(50)]
    public string GlaccountTypeCombo { get; set; }

    [Column("GLAccountBalanceCombo")]
    [StringLength(50)]
    [Unicode(false)]
    public string GlaccountBalanceCombo { get; set; }
}
