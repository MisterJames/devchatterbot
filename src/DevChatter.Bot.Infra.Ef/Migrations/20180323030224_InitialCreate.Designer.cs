﻿// <auto-generated />

using DevChatter.Bot.Infra.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DevChatter.Bot.Infra.Ef.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20180323030224_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DevChatter.Bot.Core.Commands.SimpleCommand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommandText");

                    b.Property<string>("StaticResponse");

                    b.Property<int>("RoleRequired");

                    b.HasKey("Id");

                    b.ToTable("SimpleCommands");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Messaging.IntervalMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DelayInMinutes");

                    b.Property<string>("MessageText");

                    b.HasKey("Id");

                    b.ToTable("IntervalMessages");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Model.ChatUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.Property<int?>("Role");

                    b.Property<int>("Tokens");

                    b.HasKey("Id");

                    b.ToTable("ChatUsers");
                });

            modelBuilder.Entity("DevChatter.Bot.Core.Model.QuoteEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddedBy");

                    b.Property<string>("Author");

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("QuoteId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("QuoteEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
