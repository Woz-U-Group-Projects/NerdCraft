using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NerdCraft.Models;


#nullable disable

namespace NerdCraft.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<address> addresses { get; set; }
        public virtual DbSet<card> cards { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<discount> discounts { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<ordereditem> ordereditems { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<person> people { get; set; }
        public virtual DbSet<returnment> returnments { get; set; }
        public virtual DbSet<shipment> shipments { get; set; }
        public virtual DbSet<shoppingcart> shoppingcarts { get; set; }
        public virtual DbSet<wishlist> wishlists { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<address>(entity =>
            {
                entity.HasKey(e => new { e.CustomerID, e.Address1, e.Address2, e.City, e.StateProvince, e.Country, e.PostalID })
                    .HasName("PRIMARY");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(85);

                entity.Property(e => e.StateProvince).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.PostalID).HasMaxLength(10);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.addresses)
                    .HasForeignKey(d => d.CustomerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("addresses_ibfk_1");
            });

            modelBuilder.Entity<card>(entity =>
            {
                entity.HasKey(e => new { e.CustomerID, e.CardName, e.CardNum, e.CardComp, e.CardExp, e.CardSec })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CardNum, "CardNum")
                    .IsUnique();

                entity.HasIndex(e => e.CardSec, "CardSec")
                    .IsUnique();

                entity.Property(e => e.CardName).HasMaxLength(20);

                entity.Property(e => e.CardNum).HasMaxLength(16);

                entity.Property(e => e.CardComp).HasMaxLength(20);

                entity.Property(e => e.CardExp).HasColumnType("date");

                entity.Property(e => e.CardSec).HasMaxLength(3);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.cards)
                    .HasForeignKey(d => d.CustomerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cards_ibfk_1");
            });

            modelBuilder.Entity<customer>(entity =>
            {
                entity.ToTable("customer");

                entity.HasIndex(e => e.CustomerID, "CustomerID")
                    .IsUnique();

                entity.Property(e => e.CustomerID).ValueGeneratedOnAdd();

                entity.Property(e => e.Userpass)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Customer)
                    .WithOne(p => p.customer)
                    .HasForeignKey<customer>(d => d.CustomerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customer_ibfk_1");
            });

            modelBuilder.Entity<discount>(entity =>
            {
                entity.ToTable("discount");

                entity.Property(e => e.DiscountCode).HasMaxLength(10);

                entity.Property(e => e.DiscountPercent).HasColumnType("decimal(2,2)");
            });

            modelBuilder.Entity<employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeEmail)
                    .HasName("PRIMARY");

                entity.ToTable("employee");

                entity.HasIndex(e => e.ID, "ID");

                entity.HasIndex(e => e.Supervisor, "Supervisor");

                entity.Property(e => e.EmployeeEmail).HasMaxLength(50);

                entity.Property(e => e.Supervisor).HasMaxLength(50);

                entity.Property(e => e.Userpass)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.IDNavigation)
                    .WithMany(p => p.employees)
                    .HasForeignKey(d => d.ID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employee_ibfk_2");

                entity.HasOne(d => d.SupervisorNavigation)
                    .WithMany(p => p.InverseSupervisorNavigation)
                    .HasForeignKey(d => d.Supervisor)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("employee_ibfk_1");
            });

            modelBuilder.Entity<item>(entity =>
            {
                entity.ToTable("item");

                entity.HasIndex(e => e.ItemID, "ItemID")
                    .IsUnique();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("longblob");

                entity.Property(e => e.ItemDesc).HasMaxLength(200);

                entity.Property(e => e.ItemType)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Price).HasColumnType("decimal(9,2)");

                entity.Property(e => e.Seller)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<order>(entity =>
            {
                entity.HasKey(e => e.OrderNum)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.CustomerID, "CustomerID");

                entity.HasIndex(e => e.OrderNum, "OrderNum")
                    .IsUnique();

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.OrderEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.orders)
                    .HasForeignKey(d => d.CustomerID)
                    .HasConstraintName("orders_ibfk_1");
            });

            modelBuilder.Entity<ordereditem>(entity =>
            {
                entity.HasKey(e => new { e.OrderID, e.ItemID })
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.ItemID, "ItemID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ordereditems)
                    .HasForeignKey(d => d.ItemID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ordereditems_ibfk_2");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ordereditems)
                    .HasForeignKey(d => d.OrderID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ordereditems_ibfk_1");
            });

            modelBuilder.Entity<payment>(entity =>
            {
                entity.HasKey(e => e.OrderID)
                    .HasName("PRIMARY");

                entity.ToTable("payment");

                entity.HasIndex(e => e.CardNum, "CardNum")
                    .IsUnique();

                entity.HasIndex(e => e.CardSec, "CardSec")
                    .IsUnique();

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.CardComp)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CardExp).HasColumnType("date");

                entity.Property(e => e.CardName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CardNum)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.CardSec)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(85);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalID)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StateProvince)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.payment)
                    .HasForeignKey<payment>(d => d.OrderID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("payment_ibfk_1");
            });

            modelBuilder.Entity<person>(entity =>
            {
                entity.ToTable("person");

                entity.HasIndex(e => e.ID, "ID")
                    .IsUnique();

                entity.Property(e => e.DateJoined).HasColumnType("date");

                entity.Property(e => e.DateofBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<returnment>(entity =>
            {
                entity.HasKey(e => new { e.OrderID, e.ItemID })
                    .HasName("PRIMARY");

                entity.ToTable("returnment");

                entity.HasIndex(e => e.ItemID, "ItemID");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<shipment>(entity =>
            {
                entity.HasKey(e => e.OrderID)
                    .HasName("PRIMARY");

                entity.ToTable("shipment");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(85);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalID)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ShipName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StateProvince)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.shipment)
                    .HasForeignKey<shipment>(d => d.OrderID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shipment_ibfk_1");
            });

            modelBuilder.Entity<shoppingcart>(entity =>
            {
                entity.HasKey(e => new { e.CustomerID, e.ItemID })
                    .HasName("PRIMARY");

                entity.ToTable("shoppingcart");

                entity.HasIndex(e => e.ItemID, "ItemID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.shoppingcarts)
                    .HasForeignKey(d => d.CustomerID)
                    .HasConstraintName("shoppingcart_ibfk_1");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.shoppingcarts)
                    .HasForeignKey(d => d.ItemID)
                    .HasConstraintName("shoppingcart_ibfk_2");
            });

            modelBuilder.Entity<wishlist>(entity =>
            {
                entity.HasKey(e => new { e.CustomerID, e.ItemID })
                    .HasName("PRIMARY");

                entity.ToTable("wishlist");

                entity.HasIndex(e => e.ItemID, "ItemID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.wishlists)
                    .HasForeignKey(d => d.CustomerID)
                    .HasConstraintName("wishlist_ibfk_1");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.wishlists)
                    .HasForeignKey(d => d.ItemID)
                    .HasConstraintName("wishlist_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<NerdCraft.Models.seller> seller { get; set; }
        
        
    }
}
