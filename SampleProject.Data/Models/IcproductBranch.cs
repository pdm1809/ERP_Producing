using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductBranchs")]
public partial class IcproductBranch
{
    [Key]
    [Column("ICProductBranchID")]
    public int IcproductBranchId { get; set; }

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

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("ICProductBranchDesc")]
    [StringLength(524)]
    public string IcproductBranchDesc { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("IcproductBranches")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductBranches")]
    public virtual Icproduct FkIcproduct { get; set; }
}
