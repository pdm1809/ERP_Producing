using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("FAShipmentHistorys")]
[Microsoft.EntityFrameworkCore.Index("FashipmentHistoryDate", Name = "Idx_FAShipmentHistorys")]
public partial class FashipmentHistory
{
    [Key]
    [Column("FAShipmentHistoryID")]
    public int FashipmentHistoryId { get; set; }

    [Column("AANumberString")]
    [StringLength(50)]
    [Unicode(false)]
    public string AanumberString { get; set; }

    [Column("AANumberInt")]
    public int? AanumberInt { get; set; }

    [Column("AAStat")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastat { get; set; }

    [Column("FAShipmentID")]
    public int? FashipmentId { get; set; }

    [Column("FACustomerID")]
    public int? FacustomerId { get; set; }

    [Column("FAUserID")]
    public int? FauserId { get; set; }

    [Column("FAUserName")]
    [StringLength(50)]
    public string FauserName { get; set; }

    [Column("FAShipmentHistoryDate", TypeName = "datetime")]
    public DateTime? FashipmentHistoryDate { get; set; }

    [Column("FAShipmentHistoryAction")]
    [StringLength(50)]
    public string FashipmentHistoryAction { get; set; }

    [Column("FAShipmentHistoryRelate")]
    [StringLength(50)]
    public string FashipmentHistoryRelate { get; set; }

    [Column("FAShipmentHistoryRelateID")]
    public int? FashipmentHistoryRelateId { get; set; }

    [Column("FAShipmentHistoryInfo")]
    [StringLength(100)]
    public string FashipmentHistoryInfo { get; set; }

    [Column("FAShipmentHistoryComment")]
    [StringLength(200)]
    public string FashipmentHistoryComment { get; set; }

    [ForeignKey("FacustomerId")]
    [InverseProperty("FashipmentHistories")]
    public virtual Arcustomer Facustomer { get; set; }

    [ForeignKey("FashipmentId")]
    [InverseProperty("FashipmentHistories")]
    public virtual Icshipment Fashipment { get; set; }

    [ForeignKey("FauserId")]
    [InverseProperty("FashipmentHistories")]
    public virtual Aduser Fauser { get; set; }
}
