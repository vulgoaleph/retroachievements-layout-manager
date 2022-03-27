﻿namespace Retro_Achievement_Tracker
{
    using Newtonsoft.Json;
    using Retro_Achievement_Tracker.Models;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    [JsonConverter(typeof(UserSummaryConverter))]
    public partial class UserSummary
    {
        public int LastGameID { get; set; }
        public int TotalPoints { get; set; }
        public int TotalTruePoints { get; set; }
        public int Rank { get; set; }
        public int Awards { get; set; }
        public string UserPic { get; set; }
        public List<Achievement> Achievements { get; set; }
        public int GamePointsPossible
        {
            get
            {
                if (Achievements != null)
                {
                    return Achievements.Sum(x => x.Points);
                }
                return 0;
            }
        }
        public int GamePointsEarned
        {
            get
            {
                if (Achievements != null)
                {
                    return Achievements.FindAll(x => x.HardcoreAchieved).Sum(x => x.Points);
                }
                return 0;
            }
        }
        public int AchievmentsPossible
        {
            get
            {
                if (Achievements != null)
                {
                    return Achievements.Count;
                }
                return 0;
            }
        }
        public int AchievementsEarned
        {
            get
            {
                if (Achievements != null)
                {
                    return Achievements.FindAll(x => x.HardcoreAchieved).Count;
                }
                return 0;
            }
        }
        public string RetroRatio
        {
            get
            {
                return ((float)TotalTruePoints / (float)TotalPoints).ToString("0.00") + "%";
            }
        }
    }

    [JsonConverter(typeof(AchievementConverter))]
    public partial class Achievement : IEquatable<Achievement>, IComparable<Achievement>, ICloneable
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string GameTitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public int TrueRatio { get; set; }
        public string BadgeNumber { get; set; }
        public bool HardcoreAchieved { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime? DateEarned { get; set; }

        public int CompareTo(Achievement other)
        {
            if (other.DateEarned.HasValue)
            {
                if (DateEarned.HasValue)
                {
                    if (DateEarned.Value == other.DateEarned.Value)
                    {
                        if ((DisplayOrder == 0 && other.DisplayOrder == 0) || (DisplayOrder == other.DisplayOrder))
                        {
                            return Id.CompareTo(other.Id);
                        }
                        return DisplayOrder.CompareTo(other.DisplayOrder);
                    }
                    return DateEarned.Value < other.DateEarned.Value ? -1 : 1;
                }
                return -1;
            }
            else if (DateEarned.HasValue)
            {
                return 1;
            }
            if ((DisplayOrder == 0 && other.DisplayOrder == 0) || (DisplayOrder == other.DisplayOrder))
            {
                return Id.CompareTo(other.Id);
            }
            return DisplayOrder.CompareTo(other.DisplayOrder);
        }

        public bool Equals(Achievement other)
        {
            return other != null && Id == other.Id;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}