using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEBanks")]
public partial class Gebank
{
    [Key]
    [Column("GEBankID")]
    public int GebankId { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("GEBankNo")]
    [StringLength(100)]
    public string GebankNo { get; set; }

    [Column("GEBankName")]
    [StringLength(512)]
    public string GebankName { get; set; }

    [InverseProperty("FkGebank")]
    public virtual ICollection<AclistAccountBank> AclistAccountBanks { get; set; } = new List<AclistAccountBank>();
}
