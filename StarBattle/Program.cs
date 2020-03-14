using StarBattle.Domain;
using StarBattle.Domain.Leaders;
using StarBattle1.Domain;
using StarBattle1.Enum;
using System;

namespace StarBattle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Faction firstFaction = new Faction()
            {
                FactionName = "ZERO > P40",
                FactionLeader = new Chewbacca()
            };

            Faction secondFaction = new Faction()
            {
                FactionName = "RYAN SOLDIER",
                FactionLeader = new DarthVader()
            };

            firstFaction.AddSoldierFirstTeamList(6, SoldierType.Pilot);
            firstFaction.AddShipFirstTeamList(6, ShipType.XWing);

            secondFaction.AddSoldierFirstTeamList(4, SoldierType.Sniper);
            secondFaction.AddShipFirstTeamList(2, ShipType.MilleniumFalcon);


            Battle batalha = new Battle(firstFaction, secondFaction);

            Console.WriteLine(batalha.GetWinner());
        }
    }
}
