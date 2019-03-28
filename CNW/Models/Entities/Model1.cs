namespace CNW.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Anh> Anhs { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Loaisp> Loaisps { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAD> UserADs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.nameAdmin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.ChucVuId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Anh>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Anh>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<Anh>()
                .Property(e => e.SanPhamID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietHD>()
                .Property(e => e.HoaDonID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHD>()
                .Property(e => e.SanPhamID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChucVu>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.KhachHangID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.HtttId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasOptional(e => e.User)
                .WithRequired(e => e.KhachHang);

            modelBuilder.Entity<Loaisp>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loaisp>()
                .Property(e => e.CategoryID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loaisp>()
                .HasMany(e => e.SanPhams)
                .WithRequired(e => e.Loaisp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.LoaispID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.Anhs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietHDs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserAD>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserAD>()
                .Property(e => e.AdminID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserAD>()
                .Property(e => e.username)
                .IsFixedLength();

            modelBuilder.Entity<UserAD>()
                .Property(e => e.password)
                .IsFixedLength();
        }
    }
}
