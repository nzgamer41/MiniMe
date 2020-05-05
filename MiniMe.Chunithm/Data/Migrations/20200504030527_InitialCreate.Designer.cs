﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniMe.Chunithm.Data;

namespace MiniMe.Chunithm.Data.Migrations
{
    [DbContext(typeof(ChunithmContext))]
    [Migration("20200504030527_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("ActivityId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kind")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param4")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("TEXT");

                    b.Property<int>("SortNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId", "Kind", "ActivityId")
                        .IsUnique();

                    b.ToTable("UserActivity");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserCharacter", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FriendshipExp")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsNewMark")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsValid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayCount")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("TEXT");

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId", "CharacterId")
                        .IsUnique();

                    b.ToTable("UserCharacter");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserCourse", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClassId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CourseId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAllJustice")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsClear")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFullCombo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSuccess")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastPlayDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Param1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param4")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayCount")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ScoreMax")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScoreRank")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId", "CourseId")
                        .IsUnique();

                    b.ToTable("UserCourse");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserDataEx", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompatibleCmVersion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Ext1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext10")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext11")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext12")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext13")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext14")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext15")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext16")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext17")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext18")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext19")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext20")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext4")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext5")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext6")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext7")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext8")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext9")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ExtLong1")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ExtLong2")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ExtLong3")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ExtLong4")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ExtLong5")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ExtStr1")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtStr2")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtStr3")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtStr4")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExtStr5")
                        .HasColumnType("TEXT");

                    b.Property<int>("MapIconId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Medal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VoiceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("UserDataEx");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserDuelList", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("DuelId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsClear")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastPlayDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Param1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Param4")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Point")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Progress")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId", "DuelId")
                        .IsUnique();

                    b.ToTable("UserDuelList");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserGameOption", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("BgInfo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FieldColor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GuideLine")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GuideSound")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Headphone")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JudgeAttack")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JudgeJustice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JudgePos")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Matching")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OptionSet")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Privacy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SoundEffect")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Speed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SuccessAir")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SuccessExTap")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SuccessFlick")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SuccessSkill")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SuccessSlideHold")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SuccessTap")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SuccessTapTimbre")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("UserGameOption");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserGameOptionEx", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Ext1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext10")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext11")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext12")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext13")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext14")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext15")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext16")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext17")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext18")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext19")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext20")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext4")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext5")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext6")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext7")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext8")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ext9")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("UserGameOptionEx");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsValid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ItemKind")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId", "ItemId", "ItemKind")
                        .IsUnique();

                    b.ToTable("UserItem");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserMap", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AreaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsClear")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsValid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MapId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Routeint")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId", "MapId")
                        .IsUnique();

                    b.ToTable("UserMap");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserMusic", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("FullChain")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAllJustice")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFullCombo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsLock")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSuccess")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxChain")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxComboCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MissCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MusicId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayCount")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResAcceptCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResRequestCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResSuccessCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScoreMax")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScoreRank")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId", "MusicId", "Level")
                        .IsUnique();

                    b.ToTable("UserMusic");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserPlayLog", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FullChainKind")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAllJustice")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsClear")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsContinue")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFreeToPlay")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFullCombo")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMaimai")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsNewRecord")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JudgeAttack")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JudgeCritical")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JudgeGuilty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JudgeJustice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxChain")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxCombo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MusicId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlaceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlaceName")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("PlayDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlayKind")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayedCustom1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayedCustom2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayedCustom3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayedMusicLevel1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayedMusicLevel2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayedMusicLevel3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayedUserId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayedUserId2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayedUserId3")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlayedUserName1")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlayedUserName2")
                        .HasColumnType("TEXT");

                    b.Property<string>("PlayedUserName3")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlayerRating")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RateAir")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RateFlick")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RateHold")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RateSlide")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RateTap")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillEffect")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillLevel")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SortNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Track")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("UserPlayDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("UserPlayLog");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AcceptResCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccessCode")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AimeId")
                        .HasColumnType("TEXT");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("EventWatchedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Exp")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstDataVersion")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstGameId")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("FirstPlayDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstRomVersion")
                        .HasColumnType("TEXT");

                    b.Property<int>("FirstTutorialCancelNum")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FrameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FriendCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HighestRating")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMaimai")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsWebJoin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastAllNetId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastClientId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastDataVersion")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastGameId")
                        .HasColumnType("TEXT");

                    b.Property<int>("LastPlaceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastPlaceName")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("LastPlayDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastRegionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastRegionName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastRomVersion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MasterTutorialCancelNum")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MultiPlayCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MultiWinCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NameplateId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayedTutorialBit")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlayerRating")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Point")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ReincarnationNum")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RequestResCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SuccessResCount")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TotalAdvancedHighScore")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TotalBasicHighScore")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TotalExpertHighScore")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TotalHiScore")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalMapNum")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TotalMasterHighScore")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TotalPoint")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalRepertoireCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrophyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("WebLimitDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserActivity", b =>
                {
                    b.HasOne("MiniMe.Chunithm.Data.Models.UserProfile", "Profile")
                        .WithMany("Activities")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserCharacter", b =>
                {
                    b.HasOne("MiniMe.Chunithm.Data.Models.UserProfile", "Profile")
                        .WithMany("Characters")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserCourse", b =>
                {
                    b.HasOne("MiniMe.Chunithm.Data.Models.UserProfile", "Profile")
                        .WithMany("Courses")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserDataEx", b =>
                {
                    b.HasOne("MiniMe.Chunithm.Data.Models.UserProfile", "Profile")
                        .WithOne("DataEx")
                        .HasForeignKey("MiniMe.Chunithm.Data.Models.UserDataEx", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserDuelList", b =>
                {
                    b.HasOne("MiniMe.Chunithm.Data.Models.UserProfile", "Profile")
                        .WithMany("DuelLists")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserGameOption", b =>
                {
                    b.HasOne("MiniMe.Chunithm.Data.Models.UserProfile", "Profile")
                        .WithOne("GameOption")
                        .HasForeignKey("MiniMe.Chunithm.Data.Models.UserGameOption", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserGameOptionEx", b =>
                {
                    b.HasOne("MiniMe.Chunithm.Data.Models.UserProfile", "Profile")
                        .WithOne("GameOptionEx")
                        .HasForeignKey("MiniMe.Chunithm.Data.Models.UserGameOptionEx", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserItem", b =>
                {
                    b.HasOne("MiniMe.Chunithm.Data.Models.UserProfile", "Profile")
                        .WithMany("Items")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserMap", b =>
                {
                    b.HasOne("MiniMe.Chunithm.Data.Models.UserProfile", "Profile")
                        .WithMany("Maps")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserMusic", b =>
                {
                    b.HasOne("MiniMe.Chunithm.Data.Models.UserProfile", "Profile")
                        .WithMany("Musics")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MiniMe.Chunithm.Data.Models.UserPlayLog", b =>
                {
                    b.HasOne("MiniMe.Chunithm.Data.Models.UserProfile", "Profile")
                        .WithMany("PlayLogs")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
