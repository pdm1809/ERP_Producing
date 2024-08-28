using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ICProductTemplates")]
public partial class IcproductTemplate
{
    [Key]
    [Column("ICProductTemplateID")]
    public int IcproductTemplateId { get; set; }

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

    [Column("ICProductTemplateNo")]
    [StringLength(50)]
    public string IcproductTemplateNo { get; set; }

    [Column("ICProductTemplateName")]
    [StringLength(256)]
    public string IcproductTemplateName { get; set; }

    [Column("ICProductTemplateDesc")]
    [StringLength(512)]
    public string IcproductTemplateDesc { get; set; }

    [Column("ICProductTemplateStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string IcproductTemplateStatus { get; set; }

    [Column("ICProductTemplateDate", TypeName = "datetime")]
    public DateTime? IcproductTemplateDate { get; set; }

    [Column("FK_ICProductID")]
    public int FkIcproductId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [InverseProperty("FkIcproductTemplate")]
    public virtual ICollection<ArproposalAreaItem> ArproposalAreaItems { get; set; } = new List<ArproposalAreaItem>();

    [InverseProperty("FkIcproductTemplate")]
    public virtual ICollection<ArproposalArea> ArproposalAreas { get; set; } = new List<ArproposalArea>();

    [ForeignKey("FkIcproductId")]
    [InverseProperty("IcproductTemplates")]
    public virtual Icproduct FkIcproduct { get; set; }

    [InverseProperty("FkIcproductTemplate")]
    public virtual ICollection<IcproductTemplateItem> IcproductTemplateItems { get; set; } = new List<IcproductTemplateItem>();
}
