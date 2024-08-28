using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ARContainerLoaderItemDetails")]
public partial class ArcontainerLoaderItemDetail
{
    [Key]
    [Column("ARContainerLoaderItemDetailID")]
    public int ArcontainerLoaderItemDetailId { get; set; }

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

    [Column("FK_ARContainerLoaderID")]
    public int? FkArcontainerLoaderId { get; set; }

    [Column("FK_ARContainerLoaderItemID")]
    public int? FkArcontainerLoaderItemId { get; set; }

    [Column("FK_ICDepartmentID")]
    public int? FkIcdepartmentId { get; set; }

    [Column("FK_ICProductGroupID")]
    public int? FkIcproductGroupId { get; set; }

    [Column("FK_ICProductID")]
    public int? FkIcproductId { get; set; }

    [Column("FK_ICMeasureUnitID")]
    public int? FkIcmeasureUnitId { get; set; }

    [Column("ARContainerLoaderItemDetailProductType")]
    [StringLength(50)]
    public string ArcontainerLoaderItemDetailProductType { get; set; }

    [Column("ARContainerLoaderItemDetailProductName")]
    [StringLength(50)]
    public string ArcontainerLoaderItemDetailProductName { get; set; }

    [Column("ARContainerLoaderItemDetailProductDesc", TypeName = "ntext")]
    public string ArcontainerLoaderItemDetailProductDesc { get; set; }

    [Column("ARContainerLoaderItemDetailProductQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemDetailProductQty { get; set; }

    [Column("ARContainerLoaderItemDetailCanceledQty", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemDetailCanceledQty { get; set; }

    [Column("ARContainerLoaderItemDetailComment")]
    [StringLength(50)]
    public string ArcontainerLoaderItemDetailComment { get; set; }

    [Column("FK_ARSaleForecastID")]
    public int? FkArsaleForecastId { get; set; }

    [Column("FK_ARSaleForecastItemID")]
    public int? FkArsaleForecastItemId { get; set; }

    [Column("FK_ARSaleOrderID")]
    public int? FkArsaleOrderId { get; set; }

    [Column("FK_ARSaleOrderItemID")]
    public int? FkArsaleOrderItemId { get; set; }

    [Column("ARContainerLoaderItemDetailUnitVolume", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemDetailUnitVolume { get; set; }

    [Column("ARContainerLoaderItemDetailLength", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemDetailLength { get; set; }

    [Column("ARContainerLoaderItemDetailWidth", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemDetailWidth { get; set; }

    [Column("ARContainerLoaderItemDetailHeight", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemDetailHeight { get; set; }

    [Column("ARContainerLoaderItemDetailNetWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemDetailNetWeight { get; set; }

    [Column("ARContainerLoaderItemDetailGrossWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemDetailGrossWeight { get; set; }

    [Column("ARContainerLoaderItemDetailTotalGrossWeight", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemDetailTotalGrossWeight { get; set; }

    [Column("ARContainerLoaderItemDetailTotalCMB", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemDetailTotalCmb { get; set; }

    [Column("ARContainerLoaderItemDetailTotalBlock", TypeName = "decimal(18, 5)")]
    public decimal? ArcontainerLoaderItemDetailTotalBlock { get; set; }

    [Column("FK_ICProductForBatchID")]
    public int? FkIcproductForBatchId { get; set; }

    [Column("FK_MMBatchProductProductionNormItemID")]
    public int? FkMmbatchProductProductionNormItemId { get; set; }

    [ForeignKey("FkArcontainerLoaderId")]
    [InverseProperty("ArcontainerLoaderItemDetails")]
    public virtual ArcontainerLoader FkArcontainerLoader { get; set; }

    [ForeignKey("FkArcontainerLoaderItemId")]
    [InverseProperty("ArcontainerLoaderItemDetails")]
    public virtual ArcontainerLoaderItem FkArcontainerLoaderItem { get; set; }

    [ForeignKey("FkArsaleForecastId")]
    [InverseProperty("ArcontainerLoaderItemDetails")]
    public virtual ArsaleForecast FkArsaleForecast { get; set; }

    [ForeignKey("FkArsaleForecastItemId")]
    [InverseProperty("ArcontainerLoaderItemDetails")]
    public virtual ArsaleForecastItem FkArsaleForecastItem { get; set; }

    [ForeignKey("FkArsaleOrderId")]
    [InverseProperty("ArcontainerLoaderItemDetails")]
    public virtual ArsaleOrder FkArsaleOrder { get; set; }

    [ForeignKey("FkArsaleOrderItemId")]
    [InverseProperty("ArcontainerLoaderItemDetails")]
    public virtual ArsaleOrderItem FkArsaleOrderItem { get; set; }

    [ForeignKey("FkIcdepartmentId")]
    [InverseProperty("ArcontainerLoaderItemDetails")]
    public virtual Icdepartment FkIcdepartment { get; set; }

    [ForeignKey("FkIcmeasureUnitId")]
    [InverseProperty("ArcontainerLoaderItemDetails")]
    public virtual IcmeasureUnit FkIcmeasureUnit { get; set; }

    [ForeignKey("FkIcproductId")]
    [InverseProperty("ArcontainerLoaderItemDetailFkIcproducts")]
    public virtual Icproduct FkIcproduct { get; set; }

    [ForeignKey("FkIcproductForBatchId")]
    [InverseProperty("ArcontainerLoaderItemDetailFkIcproductForBatches")]
    public virtual Icproduct FkIcproductForBatch { get; set; }

    [ForeignKey("FkIcproductGroupId")]
    [InverseProperty("ArcontainerLoaderItemDetails")]
    public virtual IcproductGroup FkIcproductGroup { get; set; }

    [ForeignKey("FkMmbatchProductProductionNormItemId")]
    [InverseProperty("ArcontainerLoaderItemDetails")]
    public virtual MmbatchProductProductionNormItem FkMmbatchProductProductionNormItem { get; set; }
}
