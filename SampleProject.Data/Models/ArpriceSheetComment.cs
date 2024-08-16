using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARPriceSheetComments")]
public partial class ArpriceSheetComment
{
    [Key]
    [Column("ARPriceSheetCommentID")]
    public int ArpriceSheetCommentId { get; set; }

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

    [Column("FK_ARPriceSheetID")]
    public int? FkArpriceSheetId { get; set; }

    [Column("ARPriceSheetCommentNote")]
    public byte[] ArpriceSheetCommentNote { get; set; }

    [ForeignKey("FkArpriceSheetId")]
    [InverseProperty("ArpriceSheetComments")]
    public virtual ArpriceSheet FkArpriceSheet { get; set; }
}
