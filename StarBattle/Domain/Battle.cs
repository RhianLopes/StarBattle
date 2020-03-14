using StarBattle.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarBattle1.Domain
{
    public class Battle
    {
        public Faction FirstFaction { get; set; }

        public Faction SecondFaction { get; set; }

        public Battle(Faction firstFaction, Faction secondFaction)
        {
            FirstFaction = firstFaction;
            SecondFaction = secondFaction;
        }

        public string GetStatus() 
        {
            return FirstFaction.GetStatusTeam() + "\n" + SecondFaction.GetStatusTeam();
        }

        private int GetLifeTeam(Faction faction)
        {
            int life = 0;

            foreach(var ship in faction.FactionShipList)
            {
                life += ship.Resistence;
            }

            foreach (var soldier in faction.FactionSoldierList)
            {
                life += soldier.Life;
            }

            return life;
        }

        private int GetPowerTeam(Faction faction)
        {
            int power = 0;

            foreach (var ship in faction.FactionShipList)
            {
                power += ship.Damage * ship.AmountCannons;
            }

            foreach (var soldier in faction.FactionSoldierList)
            {
                power += soldier.Power;
            }

            return power;
        }
        public string GetWinner()
        {
            var firstFactionTotalPower = GetLifeTeam(FirstFaction) * GetPowerTeam(FirstFaction);
            var secondFactionTotalPower = GetLifeTeam(SecondFaction) * GetPowerTeam(SecondFaction);

            if (firstFactionTotalPower >= secondFactionTotalPower)
            {
                return "E O VENCEDOR ÉÉÉÉ!!!!!! " + FirstFaction.FactionName + "!!!!!!!";
            }
            else
            {
                return "E O VENCEDOR ÉÉÉÉ!!!!!! " + SecondFaction.FactionName + "!!!!!!!";
            }
        }
    }
}
