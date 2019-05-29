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
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DetailBill> DetailBills { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Posision> Posisions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Species> Species { get; set; }
        public virtual DbSet<speciesSize> speciesSizes { get; set; }
        public virtual DbSet<UserAdmin> UserAdmins { get; set; }

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
                .Property(e => e.positionID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.customerID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.paymentMethod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.DetailBills)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Color>()
                .HasMany(e => e.ProductDetails)
                .WithMany(e => e.Colors)
                .Map(m => m.ToTable("ProductColor").MapLeftKey("ColorID").MapRightKey("ProductID"));

            modelBuilder.Entity<Customer>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DetailBill>()
                .Property(e => e.BiLLID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DetailBill>()
                .Property(e => e.ProductID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DetailBill>()
                .Property(e => e.size)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DetailBill>()
                .Property(e => e.color)
                .IsFixedLength();

            modelBuilder.Entity<Image>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.ProductID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Posision>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Posision>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Posision>()
                .HasMany(e => e.Admins)
                .WithOptional(e => e.Posision)
                .HasForeignKey(e => e.positionID);

            modelBuilder.Entity<Product>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.speciesID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.DetailBills)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasOptional(e => e.ProductDetail)
                .WithRequired(e => e.Product);

            modelBuilder.Entity<ProductDetail>()
                .Property(e => e.ProductID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProductDetail>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProductDetail>()
                .HasMany(e => e.Images)
                .WithRequired(e => e.ProductDetail)
                .HasForeignKey(e => e.ProductID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductDetail>()
                .HasMany(e => e.Sizes)
                .WithMany(e => e.ProductDetails)
                .Map(m => m.ToTable("ProductSize").MapLeftKey("ProductID").MapRightKey("SizeID"));

            modelBuilder.Entity<Size>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .Property(e => e.characters)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .Property(e => e.speciesID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Species>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Species>()
                .Property(e => e.categoryID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Species>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Species)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<speciesSize>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<speciesSize>()
                .HasMany(e => e.Sizes)
                .WithOptional(e => e.speciesSize)
                .HasForeignKey(e => e.speciesID);

            modelBuilder.Entity<UserAdmin>()
                .Property(e => e.id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserAdmin>()
                .Property(e => e.AdminID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
