using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADPushNotifications")]
public partial class AdpushNotification
{
    [Key]
    [Column("ADPushNotificationID")]
    public int AdpushNotificationId { get; set; }

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

    [Column("FK_ADUserID")]
    public int? FkAduserId { get; set; }

    [Column("ADPushNotificationDeviceId")]
    [StringLength(512)]
    public string AdpushNotificationDeviceId { get; set; }

    [Column("ADPushNotificationDeviceToken")]
    [StringLength(1024)]
    public string AdpushNotificationDeviceToken { get; set; }

    [Column("ADPushNotificationOS")]
    public bool? AdpushNotificationOs { get; set; }

    [ForeignKey("FkAduserId")]
    [InverseProperty("AdpushNotifications")]
    public virtual Aduser FkAduser { get; set; }
}
