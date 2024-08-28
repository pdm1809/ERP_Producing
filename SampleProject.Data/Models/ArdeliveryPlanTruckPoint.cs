using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARDeliveryPlanTruckPoints")]
public partial class ArdeliveryPlanTruckPoint
{
    [Key]
    [Column("ARDeliveryPlanTruckPointID")]
    public int ArdeliveryPlanTruckPointId { get; set; }

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

    [Column("AAStatus")]
    [StringLength(10)]
    [Unicode(false)]
    public string Aastatus { get; set; }

    [Column("FK_ARDeliveryPlanID")]
    public int? FkArdeliveryPlanId { get; set; }

    [Column("FK_ARDeliveryPlanTruckID")]
    public int? FkArdeliveryPlanTruckId { get; set; }

    [Column("ARDeliveryPlanTruckPointAddress")]
    [StringLength(512)]
    public string ArdeliveryPlanTruckPointAddress { get; set; }

    [Column("ARDeliveryPlanTruckPointLongitude", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckPointLongitude { get; set; }

    [Column("ARDeliveryPlanTruckPointLatitude", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckPointLatitude { get; set; }

    [Column("ARDeliveryPlanTruckPointEstimateDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanTruckPointEstimateDate { get; set; }

    [Column("ARDeliveryPlanTruckPointActualDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanTruckPointActualDate { get; set; }

    [Column("ARDeliveryPlanTruckPointStatus")]
    [StringLength(50)]
    public string ArdeliveryPlanTruckPointStatus { get; set; }

    [Column("ARDeliveryPlanTruckPointNo")]
    [StringLength(50)]
    public string ArdeliveryPlanTruckPointNo { get; set; }

    [Column("ARDeliveryPlanTruckPointNote")]
    [StringLength(256)]
    public string ArdeliveryPlanTruckPointNote { get; set; }

    [Column("ARDeliveryPlanTruckPointDriverLongitude", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckPointDriverLongitude { get; set; }

    [Column("ARDeliveryPlanTruckPointDriverLatitude", TypeName = "decimal(18, 5)")]
    public decimal? ArdeliveryPlanTruckPointDriverLatitude { get; set; }

    [Column("ARDeliveryPlanTruckPointDriverLastDate", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanTruckPointDriverLastDate { get; set; }

    [Column("ARDeliveryPlanTruckPointStreet")]
    [StringLength(256)]
    public string ArdeliveryPlanTruckPointStreet { get; set; }

    [Column("ARDeliveryPlanTruckPointWard")]
    [StringLength(256)]
    public string ArdeliveryPlanTruckPointWard { get; set; }

    [Column("FK_GEDeliveryDistrictID")]
    public int? FkGedeliveryDistrictId { get; set; }

    [Column("FK_GEDeliveryStateProvinceID")]
    public int? FkGedeliveryStateProvinceId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARCustomerID")]
    public int? FkArcustomerId { get; set; }

    [Column("ARDeliveryPlanTruckPointDesc")]
    [StringLength(512)]
    public string ArdeliveryPlanTruckPointDesc { get; set; }

    [Column("FK_ICProductTruckID")]
    public int? FkIcproductTruckId { get; set; }

    [Column("ARDeliveryPlanTruckPointEstimatedHour", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanTruckPointEstimatedHour { get; set; }

    [Column("ARDeliveryPlanTruckPointArrivalTime", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanTruckPointArrivalTime { get; set; }

    [Column("ARDeliveryPlanTruckPointSubmitArrivalTime", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanTruckPointSubmitArrivalTime { get; set; }

    [Column("ARDeliveryPlanTruckPointArrivalDescription")]
    [StringLength(1024)]
    public string ArdeliveryPlanTruckPointArrivalDescription { get; set; }

    [Column("ARDeliveryPlanTruckPointStartedDeliveryTime", TypeName = "datetime")]
    public DateTime? ArdeliveryPlanTruckPointStartedDeliveryTime { get; set; }

    [Column("FK_ICTransferID")]
    public int? FkIctransferId { get; set; }

    [Column("FK_ARSaleReturnID")]
    public int? FkArsaleReturnId { get; set; }

    [InverseProperty("FkArdeliveryPlanTruckPoint")]
    public virtual ICollection<ArdeliveryPlanFile> ArdeliveryPlanFiles { get; set; } = new List<ArdeliveryPlanFile>();

    [InverseProperty("FkArdeliveryPlanTruckPoint")]
    public virtual ICollection<ArdeliveryPlanReportIssue> ArdeliveryPlanReportIssues { get; set; } = new List<ArdeliveryPlanReportIssue>();

    [InverseProperty("FkArdeliveryPlanTruckPoint")]
    public virtual ICollection<ArdeliveryPlanTruckItem> ArdeliveryPlanTruckItems { get; set; } = new List<ArdeliveryPlanTruckItem>();

    [ForeignKey("FkArcustomerId")]
    [InverseProperty("ArdeliveryPlanTruckPoints")]
    public virtual Arcustomer FkArcustomer { get; set; }

    [ForeignKey("FkArdeliveryPlanId")]
    [InverseProperty("ArdeliveryPlanTruckPoints")]
    public virtual ArdeliveryPlan FkArdeliveryPlan { get; set; }

    [ForeignKey("FkArdeliveryPlanTruckId")]
    [InverseProperty("ArdeliveryPlanTruckPoints")]
    public virtual ArdeliveryPlanTruck FkArdeliveryPlanTruck { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArdeliveryPlanTruckPoints")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleReturnId")]
    [InverseProperty("ArdeliveryPlanTruckPoints")]
    public virtual ArsaleReturn FkArsaleReturn { get; set; }

    [ForeignKey("FkGedeliveryDistrictId")]
    [InverseProperty("ArdeliveryPlanTruckPoints")]
    public virtual Gedistrict FkGedeliveryDistrict { get; set; }

    [ForeignKey("FkGedeliveryStateProvinceId")]
    [InverseProperty("ArdeliveryPlanTruckPoints")]
    public virtual GestateProvince FkGedeliveryStateProvince { get; set; }

    [ForeignKey("FkIcproductTruckId")]
    [InverseProperty("ArdeliveryPlanTruckPoints")]
    public virtual Icproduct FkIcproductTruck { get; set; }

    [ForeignKey("FkIctransferId")]
    [InverseProperty("ArdeliveryPlanTruckPoints")]
    public virtual Ictransfer FkIctransfer { get; set; }
}
