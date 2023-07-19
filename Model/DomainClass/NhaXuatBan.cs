using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Hoangpdph31561_CSharp_3_BaiTap_2.DomainClass;

[Table("NhaXuatBan")]
public partial class NhaXuatBan
{
    [Key]
    [Column("idNhaXuatBan")]
    public Guid IdNhaXuatBan { get; set; }

    [Column("tenNhaXuatBan")]
    [StringLength(50)]
    public string? TenNhaXuatBan { get; set; }

    [InverseProperty("IdNhaXuatBanNavigation")]
    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
