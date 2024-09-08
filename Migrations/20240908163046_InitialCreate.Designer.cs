﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TunaPiano.Migrations
{
    [DbContext(typeof(TunaPianoDbContext))]
    [Migration("20240908163046_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TunaPiano.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 44,
                            Bio = "Conor Mullen Oberst (born February 15, 1980) is an American singer-songwriter best known for his work in Bright Eyes. He has also played in several other bands, including Desaparecidos, the Faint (previously named Norman Bailer), Commander Venus, Park Ave., Conor Oberst and the Mystic Valley Band, Monsters of Folk, and Better Oblivion Community Center. Oberst was named the Best Songwriter of 2008 by Rolling Stone magazine.",
                            Name = "Conor Oberst"
                        },
                        new
                        {
                            Id = 2,
                            Age = 78,
                            Bio = "Dolly Rebecca Parton (born January 19, 1946) is an American singer-songwriter, actress, and philanthropist, known primarily for her decades-long career in country music. After achieving success as a songwriter for others, Parton made her album debut in 1967 with Hello, I'm Dolly, which led to success during the remainder of the 1960s (both as a solo artist and with a series of duet albums with Porter Wagoner), before her sales and chart peak arrived during the 1970s and continued into the 1980s. Some of Parton's albums in the 1990s did not sell as well, but she achieved commercial success again in the new millennium and has released albums on various independent labels since 2000, including her own label, Dolly Records.",
                            Name = "Dolly Parton"
                        },
                        new
                        {
                            Id = 3,
                            Age = 69,
                            Bio = "David Robert Jones (8 January 1947 – 10 January 2016), known professionally as David Bowie, was an English singer, songwriter, musician, and actor. He is regarded as one of the most influential musicians of the 20th century. Bowie was acclaimed by critics and musicians, particularly for his innovative work during the 1970s. His career was marked by reinvention and visual presentation, and his music and stagecraft had a significant impact on popular music.",
                            Name = "David Bowie"
                        },
                        new
                        {
                            Id = 4,
                            Age = 43,
                            Bio = "Sharon Katharine Van Etten (born February 26, 1981) is an American singer-songwriter and actress. She has released the albums Because I Was in Love (2009), Epic (2010), Tramp (2012), Are We There (2014), Remind Me Tomorrow (2019) and We've Been Going About This All Wrong (2022).",
                            Name = "Sharon Van Etten"
                        },
                        new
                        {
                            Id = 5,
                            Age = 46,
                            Bio = "Fiona Apple McAfee-Maggart (born September 13, 1977) is an American singer-songwriter. She released five albums from 1996 to 2020, all of which reached the top 20 on the U.S. Billboard 200 chart.[1] Apple has received numerous awards and nominations, including three Grammy Awards, two MTV Video Music Awards, and a Billboard Music Award.",
                            Name = "Fiona Apple"
                        },
                        new
                        {
                            Id = 6,
                            Age = 46,
                            Bio = "Fiona Apple McAfee-Maggart (born September 13, 1977) is an American singer-songwriter. She released five albums from 1996 to 2020, all of which reached the top 20 on the U.S. Billboard 200 chart.[1] Apple has received numerous awards and nominations, including three Grammy Awards, two MTV Video Music Awards, and a Billboard Music Award.",
                            Name = "Fiona Apple"
                        },
                        new
                        {
                            Id = 7,
                            Age = 40,
                            Bio = "Donald McKinley Glover Jr. (born September 25, 1983), also known by his stage name Childish Gambino, is an American actor, rapper, singer, writer, comedian, director and producer. While he studied at New York University and after working in Derrick Comedy, a comedy group, Glover was hired by Tina Fey to write for the NBC sitcom 30 Rock at age 23. He gained fame for portraying college student Troy Barnes on the NBC sitcom Community from 2009 to 2014. From 2016 to 2022, he starred in the FX series Atlanta, which he created and occasionally directed. For his work on Atlanta, he won various accolades including two Primetime Emmy Awards, as well as two Golden Globe Awards.",
                            Name = "Childish Gambino"
                        });
                });

            modelBuilder.Entity("TunaPiano.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Indie Rock"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Pop Rock"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Country"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Rap"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Inde Folk"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Experimental Rock"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Riot Girl"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Metal"
                        },
                        new
                        {
                            Id = 9,
                            Description = "HipHop"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Electronic"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Ambient"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Classical"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Cinematic"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Punk"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Musicals"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Math Rock"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Bluegrass"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Folk Rock"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Psychedelic Rock"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Art Pop"
                        },
                        new
                        {
                            Id = 21,
                            Description = "Rap"
                        });
                });

            modelBuilder.Entity("TunaPiano.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ArtistId")
                        .HasColumnType("integer");

                    b.Property<int>("GenreId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Length")
                        .HasColumnType("numeric");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album = "Jolene",
                            ArtistId = 2,
                            GenreId = 3,
                            Length = 2.42m,
                            Title = "Jolene"
                        },
                        new
                        {
                            Id = 2,
                            Album = "Cassadega",
                            ArtistId = 1,
                            GenreId = 18,
                            Length = 4.16m,
                            Title = "Four Winds"
                        },
                        new
                        {
                            Id = 3,
                            Album = "The Idler Wheel...",
                            ArtistId = 5,
                            GenreId = 20,
                            Length = 4.02m,
                            Title = "Hot Knife"
                        },
                        new
                        {
                            Id = 4,
                            Album = "Blackstar",
                            ArtistId = 5,
                            GenreId = 6,
                            Length = 6.22m,
                            Title = "Lazarus"
                        },
                        new
                        {
                            Id = 5,
                            Album = "The Rise and Fall of Ziggy Stardust...",
                            ArtistId = 5,
                            GenreId = 6,
                            Length = 4.42m,
                            Title = "Five Years"
                        },
                        new
                        {
                            Id = 6,
                            Album = "Salutations",
                            ArtistId = 1,
                            GenreId = 18,
                            Length = 3.35m,
                            Title = "Afterthought"
                        },
                        new
                        {
                            Id = 7,
                            Album = "9 to 5 and Odd Jobs",
                            ArtistId = 2,
                            GenreId = 3,
                            Length = 2.43m,
                            Title = "9 to 5"
                        },
                        new
                        {
                            Id = 8,
                            Album = "Awaken, My Love!",
                            ArtistId = 1,
                            GenreId = 19,
                            Length = 4.41m,
                            Title = "Zombies"
                        });
                });

            modelBuilder.Entity("TunaPiano.Models.Song", b =>
                {
                    b.HasOne("TunaPiano.Models.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TunaPiano.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
