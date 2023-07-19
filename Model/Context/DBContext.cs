using System;
using System.Collections.Generic;
using Hoangpdph31561_CSharp_3_BaiTap_2.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace Hoangpdph31561_CSharp_3_BaiTap_2.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=PHAMDUCHOANG\\SQLEXPRESS;Initial Catalog=QUANLYSACH_XUONG_LV1;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NhaXuatBan>(entity =>
        {
            entity.HasKey(e => e.IdNhaXuatBan).HasName("pk_NhaXuatBan");

            entity.Property(e => e.IdNhaXuatBan).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.IdSach).HasName("pk_Sach");

            entity.HasOne(d => d.IdNhaXuatBanNavigation).WithMany(p => p.Saches).HasConstraintName("fk_Sach_NhaXuatBan");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
