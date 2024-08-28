using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HREmployeeCertificates")]
public partial class HremployeeCertificate
{
    [Key]
    [Column("HREmployeeCertificateID")]
    public int HremployeeCertificateId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(512)]
    public string AacreatedUser { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(512)]
    public string AaupdatedUser { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    public string Aastatus { get; set; }

    [Column("FK_HREmployeeID")]
    public int FkHremployeeId { get; set; }

    [Required]
    [Column("HREmployeeCertificateName")]
    [StringLength(512)]
    public string HremployeeCertificateName { get; set; }

    [Column("HREmployeeCertificateTypeCombo")]
    [StringLength(512)]
    public string HremployeeCertificateTypeCombo { get; set; }

    [Column("HREmployeeCertificateIssuedDate", TypeName = "datetime")]
    public DateTime? HremployeeCertificateIssuedDate { get; set; }

    [Column("HREmployeeCertificateIssuedUser")]
    [StringLength(512)]
    public string HremployeeCertificateIssuedUser { get; set; }

    [Column("HREmployeeCertificateDurationDate", TypeName = "datetime")]
    public DateTime? HremployeeCertificateDurationDate { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("HremployeeCertificates")]
    public virtual Hremployee FkHremployee { get; set; }
}
