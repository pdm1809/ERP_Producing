using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARNotifications")]
public partial class Arnotification
{
    [Key]
    [Column("ARNotificationID")]
    public int ArnotificationId { get; set; }

    [Column("AACreatedDate", TypeName = "datetime")]
    public DateTime? AacreatedDate { get; set; }

    [Column("AACreatedUser")]
    [StringLength(50)]
    public string AacreatedUser { get; set; }

    [Column("ARNotificationEndDate", TypeName = "datetime")]
    public DateTime? ArnotificationEndDate { get; set; }

    [Column("ARNotificationLocation")]
    [StringLength(255)]
    public string ArnotificationLocation { get; set; }

    [Column("ARNotificationObjectID")]
    public long? ArnotificationObjectId { get; set; }

    [Column("ARNotificationObjectName")]
    [StringLength(255)]
    public string ArnotificationObjectName { get; set; }

    [Column("ARNotificationType")]
    [StringLength(255)]
    public string ArnotificationType { get; set; }

    [Column("ARNotificationRead")]
    public short? ArnotificationRead { get; set; }

    [Column("ARNotificationStartDate", TypeName = "datetime")]
    public DateTime? ArnotificationStartDate { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("AAUpdatedDate", TypeName = "datetime")]
    public DateTime? AaupdatedDate { get; set; }

    [Column("AAUpdatedUser")]
    [StringLength(50)]
    public string AaupdatedUser { get; set; }

    [Column("FK_BRBranchID")]
    public int? FkBrbranchId { get; set; }

    [Column("FK_HREmployeeID")]
    public int? FkHremployeeId { get; set; }

    [Column("FK_HRGroupID")]
    public int? FkHrgroupId { get; set; }

    [Column("FK_ADUserGroupID")]
    public int? FkAduserGroupId { get; set; }

    [ForeignKey("FkAduserGroupId")]
    [InverseProperty("Arnotifications")]
    public virtual AduserGroup FkAduserGroup { get; set; }

    [ForeignKey("FkBrbranchId")]
    [InverseProperty("Arnotifications")]
    public virtual Brbranch FkBrbranch { get; set; }

    [ForeignKey("FkHremployeeId")]
    [InverseProperty("Arnotifications")]
    public virtual Hremployee FkHremployee { get; set; }

    [ForeignKey("FkHrgroupId")]
    [InverseProperty("Arnotifications")]
    public virtual Hrgroup FkHrgroup { get; set; }
}
