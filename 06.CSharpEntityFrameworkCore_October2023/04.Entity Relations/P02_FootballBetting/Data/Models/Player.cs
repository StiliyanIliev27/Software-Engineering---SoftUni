﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_FootballBetting.Data.Models
{
    public class Player
    {
        public Player()
        {
            PlayersStatistics = new List<PlayerStatistic>();
        }

        [Key]
        public int PlayerId { get; set; }

        [MaxLength(Const.Constants.PlayerNameMaxLength)]
        [Required]
        public string Name { get; set; } = null!;
        public int SquadNumber { get; set; }
        public int Assists { get; set; }
        public int TownId { get; set; }
        [ForeignKey(nameof(TownId))]
        public virtual Town Town { get; set; } = null!;
        public int PositionId { get; set; }
        [ForeignKey(nameof(PositionId))]
        public virtual Position? Position { get; set; }
        public bool IsInjured { get; set; }
        public int TeamId { get; set; }
        [ForeignKey(nameof(TeamId))]
        public virtual Team? Team { get; set; }
        public virtual ICollection<PlayerStatistic> PlayersStatistics { get; set; }
    }
}