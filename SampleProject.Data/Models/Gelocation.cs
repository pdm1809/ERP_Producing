using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GELocations")]
[Microsoft.EntityFrameworkCore.Index("GelocationType", Name = "Idx_GELocations")]
public partial class Gelocation
{
    [Key]
    [Column("GELocationID")]
    public int GelocationId { get; set; }

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

    [Required]
    [Column("GELocationName")]
    [StringLength(50)]
    public string GelocationName { get; set; }

    [Column("GELocationDesc")]
    [StringLength(512)]
    public string GelocationDesc { get; set; }

    [Required]
    [Column("GELocationType")]
    [StringLength(50)]
    [Unicode(false)]
    public string GelocationType { get; set; }

    [Column("GELocationParentID")]
    public int? GelocationParentId { get; set; }

    [Column("GELocationCode")]
    [StringLength(50)]
    public string GelocationCode { get; set; }

    [Column("FK_GEObjectID")]
    public int? FkGeobjectId { get; set; }

    [Column("GELocationAbbreviation")]
    [StringLength(50)]
    public string GelocationAbbreviation { get; set; }

    [InverseProperty("FkGelocation")]
    public virtual ICollection<AcrevenueBudgetDetail> AcrevenueBudgetDetails { get; set; } = new List<AcrevenueBudgetDetail>();

    [InverseProperty("FkGelocation")]
    public virtual ICollection<ArcustomerContact> ArcustomerContacts { get; set; } = new List<ArcustomerContact>();

    [InverseProperty("FkGelocationId1Navigation")]
    public virtual ICollection<Arcustomer> ArcustomerFkGelocationId1Navigations { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkGelocationId2Navigation")]
    public virtual ICollection<Arcustomer> ArcustomerFkGelocationId2Navigations { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkGelocationId3Navigation")]
    public virtual ICollection<Arcustomer> ArcustomerFkGelocationId3Navigations { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkGelocation")]
    public virtual ICollection<Arcustomer> ArcustomerFkGelocations { get; set; } = new List<Arcustomer>();

    [InverseProperty("FkGelocation")]
    public virtual ICollection<ArprospectCustomer> ArprospectCustomers { get; set; } = new List<ArprospectCustomer>();

    [InverseProperty("FkGelocation")]
    public virtual ICollection<Brbranch> Brbranches { get; set; } = new List<Brbranch>();

    [ForeignKey("GelocationParentId")]
    [InverseProperty("InverseGelocationParent")]
    public virtual Gelocation GelocationParent { get; set; }

    [InverseProperty("FkGelocation")]
    public virtual ICollection<IcfeeConfig> IcfeeConfigs { get; set; } = new List<IcfeeConfig>();

    [InverseProperty("GelocationParent")]
    public virtual ICollection<Gelocation> InverseGelocationParent { get; set; } = new List<Gelocation>();

    [InverseProperty("FkGelocation")]
    public virtual ICollection<MmworkShop> MmworkShops { get; set; } = new List<MmworkShop>();

    [InverseProperty("FkGelocation")]
    public virtual ICollection<PmprojectContact> PmprojectContacts { get; set; } = new List<PmprojectContact>();

    [InverseProperty("FkGelocation")]
    public virtual ICollection<PmprojectLocation> PmprojectLocations { get; set; } = new List<PmprojectLocation>();

    [InverseProperty("FkGelocation")]
    public virtual ICollection<Pmproject> Pmprojects { get; set; } = new List<Pmproject>();
}
