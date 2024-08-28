using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[PrimaryKey("ArcustomerContactGroupId", "Rev")]
[Table("ARCustomerContactGroups_HISTORYS", Schema = "CRM_VINMUS_AUDIT")]
public partial class ArcustomerContactGroupsHistory
{
    [Key]
    [Column("ARCustomerContactGroupID")]
    public int ArcustomerContactGroupId { get; set; }

    [Key]
    [Column("REV")]
    public int Rev { get; set; }

    [Column("REVTYPE")]
    public short? Revtype { get; set; }

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARCustomerContactID")]
    public int? FkArcustomerContactId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [ForeignKey("Rev")]
    [InverseProperty("ArcustomerContactGroupsHistories")]
    public virtual Revinfo RevNavigation { get; set; }
}
