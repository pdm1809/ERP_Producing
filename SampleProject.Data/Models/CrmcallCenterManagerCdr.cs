using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("CRMCallCenterManagerCdrs")]
public partial class CrmcallCenterManagerCdr
{
    [Key]
    [Column("CRMCallCenterManagerCdrID")]
    public long CrmcallCenterManagerCdrId { get; set; }

    [Column("CRMCallCenterManagerAnswertime")]
    public DateTime? CrmcallCenterManagerAnswertime { get; set; }

    [Column("CRMCallCenterManagerBillduration")]
    public double? CrmcallCenterManagerBillduration { get; set; }

    [Column("CRMCallCenterManagerCallStatus")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerCallStatus { get; set; }

    [Column("CRMCallCenterManagerCallUuid")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerCallUuid { get; set; }

    [Column("AACreatedDate")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(255)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("CRMCallCenterManagerDisposition")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerDisposition { get; set; }

    [Column("CRMCallCenterManagerEndtime")]
    public DateTime? CrmcallCenterManagerEndtime { get; set; }

    [Column("CRMCallCenterManagerStarttime")]
    public DateTime? CrmcallCenterManagerStarttime { get; set; }

    [Column("AAStatus")]
    [StringLength(255)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("CRMCallCenterManagerTotalduration")]
    public double? CrmcallCenterManagerTotalduration { get; set; }

    [Column("AAUpdatedDate")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(255)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }
}
