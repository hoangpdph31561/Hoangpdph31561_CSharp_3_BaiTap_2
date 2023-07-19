using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hoangpdph31561_CSharp_3_BaiTap_2.DomainClass;

[Table("SACH")]
public partial class Sach
{
    [Key]
    [Column("idSach")]
    [StringLength(10)]
    [Unicode(false)]
    public string IdSach { get; set; } = null!;

    [Column("tenSach")]
    [StringLength(50)]
    public string? TenSach { get; set; }

    [Column("trangThai")]
    public bool? TrangThai { get; set; }

    [Column("idNhaXuatBan")]
    public Guid? IdNhaXuatBan { get; set; }

    [ForeignKey("IdNhaXuatBan")]
    [InverseProperty("Saches")]
    public virtual NhaXuatBan? IdNhaXuatBanNavigation { get; set; }
}
