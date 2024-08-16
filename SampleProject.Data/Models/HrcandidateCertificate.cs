using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("HRCandidateCertificates")]
public partial class HrcandidateCertificate
{
    [Key]
    [Column("HRCandidateCertificateID")]
    public int HrcandidateCertificateId { get; set; }

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

    [Column("FK_HRCandidateID")]
    public int FkHrcandidateId { get; set; }

    [Required]
    [Column("HRCandidateCertificateName")]
    [StringLength(512)]
    public string HrcandidateCertificateName { get; set; }

    [Column("HRCandidateCertificateType")]
    [StringLength(512)]
    public string HrcandidateCertificateType { get; set; }

    [Column("HRCandidateCertificateClassification")]
    [StringLength(100)]
    public string HrcandidateCertificateClassification { get; set; }

    [Column("HRCandidateCertificateIssuedDate", TypeName = "datetime")]
    public DateTime? HrcandidateCertificateIssuedDate { get; set; }

    [Column("HRCandidateCertificateIssuedUser")]
    [StringLength(512)]
    public string HrcandidateCertificateIssuedUser { get; set; }

    [ForeignKey("FkHrcandidateId")]
    [InverseProperty("HrcandidateCertificates")]
    public virtual Hrcandidate FkHrcandidate { get; set; }
}
