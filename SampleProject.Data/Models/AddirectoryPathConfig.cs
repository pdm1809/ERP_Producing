using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SampleProject.Data.Models;

[Table("ADDirectoryPathConfigs")]
public partial class AddirectoryPathConfig
{
    [Key]
    [Column("ADDirectoryPathConfigID")]
    public int AddirectoryPathConfigId { get; set; }

    [Column("AAStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string Aastatus { get; set; }

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

    [Column("ADDirectoryPathConfigAddress")]
    [StringLength(512)]
    public string AddirectoryPathConfigAddress { get; set; }

    [Column("ADImageFolderType")]
    [StringLength(50)]
    public string AdimageFolderType { get; set; }

    [Column("ADDirectoryPathConfigUserName")]
    [StringLength(50)]
    public string AddirectoryPathConfigUserName { get; set; }

    [Column("ADDirectoryPathConfigPassword")]
    [StringLength(50)]
    public string AddirectoryPathConfigPassword { get; set; }
}
