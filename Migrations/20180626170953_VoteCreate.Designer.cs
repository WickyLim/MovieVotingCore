﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using MovieVotingCore.Models;
using System;

namespace MovieVotingCore.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20180626170953_VoteCreate")]
    partial class VoteCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("MovieVotingCore.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImagePath");

                    b.Property<string>("MovieName");

                    b.Property<int>("Votes");

                    b.HasKey("MovieID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MovieVotingCore.Models.Vote", b =>
                {
                    b.Property<int>("VoteID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IPAddress");

                    b.Property<int>("VotedMovieID");

                    b.HasKey("VoteID");

                    b.ToTable("Vote");
                });
#pragma warning restore 612, 618
        }
    }
}