using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRSocialInsuranceDeclarationItems")]
public partial class HrsocialInsuranceDeclarationItem
{
    [Key]
    [Column("HRSocialInsuranceDeclarationItemID")]
    public int HrsocialInsuranceDeclarationItemId { get; set; }

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

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRLevelID")]
    public int? FkHrlevelId { get; set; }

    [Column("FK_ADInsurrancePlanID")]
    public int? FkAdinsurrancePlanId { get; set; }

    [Column("FK_HRSocialInsuranceDeclarationID")]
    public int? FkHrsocialInsuranceDeclarationId { get; set; }

    [Required]
    [Column("HRSocialInsuranceDeclarationItemBHXHNumber")]
    [StringLength(50)]
    public string HrsocialInsuranceDeclarationItemBhxhnumber { get; set; }

    [Required]
    [Column("HRSocialInsuranceDeclarationItemBHXHNo")]
    [StringLength(50)]
    public string HrsocialInsuranceDeclarationItemBhxhno { get; set; }

    [Column("HRSocialInsuranceDeclarationItemEmployeeBirthday", TypeName = "datetime")]
    public DateTime? HrsocialInsuranceDeclarationItemEmployeeBirthday { get; set; }

    [Column("HRSocialInsuranceDeclarationItemIsFemale")]
    public bool? HrsocialInsuranceDeclarationItemIsFemale { get; set; }

    [Column("HRSocialInsuranceDeclarationItemMucLuongBHXH", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemMucLuongBhxh { get; set; }

    [Column("HRSocialInsuranceDeclarationItemHeso", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemHeso { get; set; }

    [Column("HRSocialInsuranceDeclarationItemPhucapCV", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemPhucapCv { get; set; }

    [Column("HRSocialInsuranceDeclarationItemThamNienVK", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemThamNienVk { get; set; }

    [Column("HRSocialInsuranceDeclarationItemThamnienNghe", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemThamnienNghe { get; set; }

    [Column("HRSocialInsuranceDeclarationItemPhucapLuong", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemPhucapLuong { get; set; }

    [Column("HRSocialInsuranceDeclarationItemCacKhoanBoSung", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemCacKhoanBoSung { get; set; }

    [Column("HRSocialInsuranceDeclarationItemDate", TypeName = "datetime")]
    public DateTime? HrsocialInsuranceDeclarationItemDate { get; set; }

    [Column("HRSocialInsuranceDeclarationItemDateTo", TypeName = "datetime")]
    public DateTime? HrsocialInsuranceDeclarationItemDateTo { get; set; }

    [Column("HRSocialInsuranceDeclarationItemEmployeeContractNo")]
    [StringLength(50)]
    public string HrsocialInsuranceDeclarationItemEmployeeContractNo { get; set; }

    [Column("HREmployeeContractType")]
    [StringLength(50)]
    public string HremployeeContractType { get; set; }

    [Column("HRSocialInsuranceDeclarationItemContractSignDate", TypeName = "datetime")]
    public DateTime? HrsocialInsuranceDeclarationItemContractSignDate { get; set; }

    [Column("HRSocialInsuranceDeclarationItemTyLeDong", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemTyLeDong { get; set; }

    [Column("FK_ADInsurranceConditionID")]
    public int? FkAdinsurranceConditionId { get; set; }

    [Column("HRSocialInsuranceDeclarationItemHasDecreased")]
    public bool? HrsocialInsuranceDeclarationItemHasDecreased { get; set; }

    [Column("HRSocialInsuranceDeclarationItemTHGiam")]
    [StringLength(50)]
    public string HrsocialInsuranceDeclarationItemThgiam { get; set; }

    [Column("HRSocialInsuranceDeclarationItemNotReturnBHYT")]
    public bool? HrsocialInsuranceDeclarationItemNotReturnBhyt { get; set; }

    [Column("HRSocialInsuranceDeclarationItemBHYTNo")]
    [StringLength(100)]
    public string HrsocialInsuranceDeclarationItemBhytno { get; set; }

    [Column("HRSocialInsuranceDeclarationItemBHYTReturnDate", TypeName = "datetime")]
    public DateTime? HrsocialInsuranceDeclarationItemBhytreturnDate { get; set; }

    [Column("HRSocialInsuranceDeclarationItemProposalPayBHAllMonth")]
    public bool? HrsocialInsuranceDeclarationItemProposalPayBhallMonth { get; set; }

    [Column("FK_GEDistrictID")]
    public int? FkGedistrictId { get; set; }

    [Column("FK_HRDepartmentID")]
    public int? FkHrdepartmentId { get; set; }

    [Column("HRSocialInsuranceDeclarationItemContentChange")]
    [StringLength(512)]
    public string HrsocialInsuranceDeclarationItemContentChange { get; set; }

    [Column("HRSocialInsuranceDeclarationItemFileRefer")]
    [StringLength(512)]
    public string HrsocialInsuranceDeclarationItemFileRefer { get; set; }

    [Column("HRSocialInsuranceDeclarationItemBankAccount")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrsocialInsuranceDeclarationItemBankAccount { get; set; }

    [Column("HRSocialInsuranceDeclarationItemBankNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrsocialInsuranceDeclarationItemBankNo { get; set; }

    [Column("HRSocialInsuranceDeclarationItemBankName")]
    [StringLength(256)]
    public string HrsocialInsuranceDeclarationItemBankName { get; set; }

    [Column("HRSocialInsuranceDeclarationItemBankBranch")]
    [StringLength(512)]
    public string HrsocialInsuranceDeclarationItemBankBranch { get; set; }

    [Column("FK_GENationalityID")]
    public int? FkGenationalityId { get; set; }

    [Column("HRSocialInsuranceDeclarationItemEmployeeIDNumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrsocialInsuranceDeclarationItemEmployeeIdnumber { get; set; }

    [Column("HRSocialInsuranceDeclarationItemEmployeeIDCardDate", TypeName = "datetime")]
    public DateTime? HrsocialInsuranceDeclarationItemEmployeeIdcardDate { get; set; }

    [Column("FK_GEIDCardStateProvinceID")]
    public int? FkGeidcardStateProvinceId { get; set; }

    [Column("HRSocialInsuranceDeclarationItemEmployeeTel1")]
    [StringLength(50)]
    [Unicode(false)]
    public string HrsocialInsuranceDeclarationItemEmployeeTel1 { get; set; }

    [Column("HRSocialInsuranceDeclarationItemGuardians")]
    [StringLength(256)]
    public string HrsocialInsuranceDeclarationItemGuardians { get; set; }

    [Column("FK_GEIDCardStateProvinceID2")]
    public int? FkGeidcardStateProvinceId2 { get; set; }

    [Column("HRSocialInsuranceDeclarationItemHospitalNo")]
    [StringLength(100)]
    public string HrsocialInsuranceDeclarationItemHospitalNo { get; set; }

    [Column("FK_GEWardIDKhaiSinh")]
    public int? FkGewardIdkhaiSinh { get; set; }

    [Column("FK_GEWardIDThuongTru")]
    public int? FkGewardIdthuongTru { get; set; }

    [Column("HRSocialInsuranceDeclarationItemContactAddressThuongTru")]
    [StringLength(100)]
    public string HrsocialInsuranceDeclarationItemContactAddressThuongTru { get; set; }

    [Column("FK_GEWardIDLienHe")]
    public int? FkGewardIdlienHe { get; set; }

    [Column("HRSocialInsuranceDeclarationItemContactAddressLienHe")]
    [StringLength(100)]
    public string HrsocialInsuranceDeclarationItemContactAddressLienHe { get; set; }

    [Column("HRSocialInsuranceDeclarationItemContactPersonCode")]
    [StringLength(100)]
    public string HrsocialInsuranceDeclarationItemContactPersonCode { get; set; }

    [Column("HRSocialInsuranceDeclarationItemContactPersonName")]
    [StringLength(100)]
    public string HrsocialInsuranceDeclarationItemContactPersonName { get; set; }

    [Column("HRSocialInsuranceDeclarationItemContactPersonPhone")]
    [StringLength(100)]
    public string HrsocialInsuranceDeclarationItemContactPersonPhone { get; set; }

    [Column("HRSocialInsuranceDeclarationItemContactPersonNumberBook")]
    [StringLength(100)]
    public string HrsocialInsuranceDeclarationItemContactPersonNumberBook { get; set; }

    [Column("FK_ADInsurrancePaperID")]
    public int? FkAdinsurrancePaperId { get; set; }

    [Column("FK_GEWardIDChuHo")]
    public int? FkGewardIdchuHo { get; set; }

    [Column("HRSocialInsuranceDeclarationItemContactAddressChuHo")]
    [StringLength(100)]
    public string HrsocialInsuranceDeclarationItemContactAddressChuHo { get; set; }

    [Column("HRSocialInsuranceDeclarationItemMucLuongBHXHOld", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemMucLuongBhxhold { get; set; }

    [Column("HRSocialInsuranceDeclarationItemHesoOld", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemHesoOld { get; set; }

    [Column("HRSocialInsuranceDeclarationItemPhucapCVOld", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemPhucapCvold { get; set; }

    [Column("HRSocialInsuranceDeclarationItemThamNienVKOld", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemThamNienVkold { get; set; }

    [Column("HRSocialInsuranceDeclarationItemThamnienNgheOld", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemThamnienNgheOld { get; set; }

    [Column("HRSocialInsuranceDeclarationItemPhucapLuongOld", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemPhucapLuongOld { get; set; }

    [Column("HRSocialInsuranceDeclarationItemCacKhoanBoSungOld", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemCacKhoanBoSungOld { get; set; }

    [Column("HRSocialInsuranceDeclarationItemPCChenhLechOld", TypeName = "decimal(18, 5)")]
    public decimal? HrsocialInsuranceDeclarationItemPcchenhLechOld { get; set; }

    [Column("HRSocialInsuranceDeclarationItemEmail")]
    [StringLength(256)]
    public string HrsocialInsuranceDeclarationItemEmail { get; set; }

    [Column("HRSocialInsuranceDeclarationItemGuardiansOther")]
    [StringLength(256)]
    public string HrsocialInsuranceDeclarationItemGuardiansOther { get; set; }

    [Column("FK_GECountryID")]
    public int? FkGecountryId { get; set; }

    [Column("HRSocialInsuranceDeclarationItemObject")]
    [StringLength(256)]
    public string HrsocialInsuranceDeclarationItemObject { get; set; }

    [ForeignKey("FkAdinsurranceConditionId")]
    [InverseProperty("HrsocialInsuranceDeclarationItems")]
    public virtual AdinsurranceCondition FkAdinsurranceCondition { get; set; }

    [ForeignKey("FkAdinsurrancePaperId")]
    [InverseProperty("HrsocialInsuranceDeclarationItems")]
    public virtual AdinsurrancePaper FkAdinsurrancePaper { get; set; }

    [ForeignKey("FkAdinsurrancePlanId")]
    [InverseProperty("HrsocialInsuranceDeclarationItems")]
    public virtual AdinsurrancePlan FkAdinsurrancePlan { get; set; }

    [ForeignKey("FkGecountryId")]
    [InverseProperty("HrsocialInsuranceDeclarationItems")]
    public virtual Gecountry FkGecountry { get; set; }

    [ForeignKey("FkGedistrictId")]
    [InverseProperty("HrsocialInsuranceDeclarationItems")]
    public virtual Gedistrict FkGedistrict { get; set; }

    [ForeignKey("FkGeidcardStateProvinceId")]
    [InverseProperty("HrsocialInsuranceDeclarationItemFkGeidcardStateProvinces")]
    public virtual GestateProvince FkGeidcardStateProvince { get; set; }

    [ForeignKey("FkGeidcardStateProvinceId2")]
    [InverseProperty("HrsocialInsuranceDeclarationItemFkGeidcardStateProvinceId2Navigations")]
    public virtual GestateProvince FkGeidcardStateProvinceId2Navigation { get; set; }

    [ForeignKey("FkGenationalityId")]
    [InverseProperty("HrsocialInsuranceDeclarationItems")]
    public virtual Genationality FkGenationality { get; set; }

    [ForeignKey("FkGewardIdchuHo")]
    [InverseProperty("HrsocialInsuranceDeclarationItemFkGewardIdchuHoNavigations")]
    public virtual Geward FkGewardIdchuHoNavigation { get; set; }

    [ForeignKey("FkGewardIdkhaiSinh")]
    [InverseProperty("HrsocialInsuranceDeclarationItemFkGewardIdkhaiSinhNavigations")]
    public virtual Geward FkGewardIdkhaiSinhNavigation { get; set; }

    [ForeignKey("FkGewardIdlienHe")]
    [InverseProperty("HrsocialInsuranceDeclarationItemFkGewardIdlienHeNavigations")]
    public virtual Geward FkGewardIdlienHeNavigation { get; set; }

    [ForeignKey("FkGewardIdthuongTru")]
    [InverseProperty("HrsocialInsuranceDeclarationItemFkGewardIdthuongTruNavigations")]
    public virtual Geward FkGewardIdthuongTruNavigation { get; set; }

    [ForeignKey("FkHrdepartmentId")]
    [InverseProperty("HrsocialInsuranceDeclarationItems")]
    public virtual Hrdepartment FkHrdepartment { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HrsocialInsuranceDeclarationItems")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrlevelId")]
    [InverseProperty("HrsocialInsuranceDeclarationItems")]
    public virtual Hrlevel FkHrlevel { get; set; }

    [ForeignKey("FkHrsocialInsuranceDeclarationId")]
    [InverseProperty("HrsocialInsuranceDeclarationItems")]
    public virtual HrsocialInsuranceDeclaration FkHrsocialInsuranceDeclaration { get; set; }
}
