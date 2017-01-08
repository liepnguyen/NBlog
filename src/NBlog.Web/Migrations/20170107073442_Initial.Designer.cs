using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NBlog.Core.Persistence;

namespace NBlog.Web.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20170107073442_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NBlog.Core.Entities.Blog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("NBlog.Core.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.Property<string>("Name");

                    b.Property<Guid?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NBlog.Core.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.Property<Guid>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("NBlog.Core.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AuthorId");

                    b.Property<Guid>("BlogId");

                    b.Property<Guid>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BlogId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("NBlog.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDateTime");

                    b.Property<DateTime>("ModifiedDateTime");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NBlog.Core.Entities.Category", b =>
                {
                    b.HasOne("NBlog.Core.Entities.Category", "Parent")
                        .WithMany("Childs")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("NBlog.Core.Entities.Comment", b =>
                {
                    b.HasOne("NBlog.Core.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBlog.Core.Entities.Post", b =>
                {
                    b.HasOne("NBlog.Core.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBlog.Core.Entities.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBlog.Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
