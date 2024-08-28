using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("CRMCallCenterManagers")]
public partial class CrmcallCenterManager
{
    [Key]
    [Column("CRMCallCenterManagerID")]
    public long CrmcallCenterManagerId { get; set; }

    [Column("CRMCallCenterManagerAnswertime", TypeName = "datetime")]
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

    [Column("CRMCallCenterManagerCallernumber")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerCallernumber { get; set; }

    [Column("CRMCallCenterManagerCalltype")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerCalltype { get; set; }

    [Column("CRMCallCenterManagerCausetxt")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerCausetxt { get; set; }

    [Column("CRMCallCenterManagerChildcalluuid")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerChildcalluuid { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(255)]
    [Unicode(false)]
    public string AacreatedUser { get; set; }

    [Column("CRMCallCenterManagerDatereceived", TypeName = "datetime")]
    public DateTime? CrmcallCenterManagerDatereceived { get; set; }

    [Column("CRMCallCenterManagerDestinationnumber")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerDestinationnumber { get; set; }

    [Column("CRMCallCenterManagerDirection")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerDirection { get; set; }

    [Column("CRMCallCenterManagerDisposition")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerDisposition { get; set; }

    [Column("CRMCallCenterManagerDnis")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerDnis { get; set; }

    [Column("CRMCallCenterManagerEndtime", TypeName = "datetime")]
    public DateTime? CrmcallCenterManagerEndtime { get; set; }

    [Column("CRMCallCenterManagerParentcalluuid")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerParentcalluuid { get; set; }

    [Column("CRMCallCenterManagerQueue")]
    [StringLength(255)]
    [Unicode(false)]
    public string CrmcallCenterManagerQueue { get; set; }

    [Column("CRMCallCenterManagerStarttime", TypeName = "datetime")]
    public DateTime? CrmcallCenterManagerStarttime { get; set; }

    [Column("AAStatus")]
    [StringLength(255)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("CRMCallCenterManagerTotalduration")]
    public double? CrmcallCenterManagerTotalduration { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(255)]
    [Unicode(false)]
    public string AaupdatedUser { get; set; }
}
