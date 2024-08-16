using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("GEWards")]
public partial class Geward
{
    [Key]
    [Column("GEWardID")]
    public int GewardId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("FK_GEDistrictID")]
    public int? FkGedistrictId { get; set; }

    [Column("GEWardCode")]
    [StringLength(50)]
    public string GewardCode { get; set; }

    [Required]
    [Column("GEWardName")]
    [StringLength(256)]
    public string GewardName { get; set; }

    [InverseProperty("FkGedeliveryWard")]
    public virtual ICollection<Arcustomer> Arcustomers { get; set; } = new List<Arcustomer>();

    [ForeignKey("FkGedistrictId")]
    [InverseProperty("Gewards")]
    public virtual Gedistrict FkGedistrict { get; set; }

    [InverseProperty("FkGeward")]
    public virtual ICollection<Gestreet> Gestreets { get; set; } = new List<Gestreet>();

    [InverseProperty("FkGeward")]
    public virtual ICollection<HremployeeContact> HremployeeContacts { get; set; } = new List<HremployeeContact>();

    [InverseProperty("FkGewardIdchuHoNavigation")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItemFkGewardIdchuHoNavigations { get; set; } = new List<HrsocialInsuranceDeclarationItem>();

    [InverseProperty("FkGewardIdkhaiSinhNavigation")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItemFkGewardIdkhaiSinhNavigations { get; set; } = new List<HrsocialInsuranceDeclarationItem>();

    [InverseProperty("FkGewardIdlienHeNavigation")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItemFkGewardIdlienHeNavigations { get; set; } = new List<HrsocialInsuranceDeclarationItem>();

    [InverseProperty("FkGewardIdthuongTruNavigation")]
    public virtual ICollection<HrsocialInsuranceDeclarationItem> HrsocialInsuranceDeclarationItemFkGewardIdthuongTruNavigations { get; set; } = new List<HrsocialInsuranceDeclarationItem>();
}
