using StarBattle.Domain.Leaders;
using StarBattle1.Enum;
using System.Collections.Generic;

namespace StarBattle.Domain
{
    public class Faction
    {
        public string FactionName { get; set; }

        public List<Soldier> FactionSoldierList { get; set; }

        public List<Ship> FactionShipList { get; set; }

        public Leader FactionLeader { get; set; }

        public Faction()
        {
            FactionSoldierList = new List<Soldier>();
            FactionShipList = new List<Ship>();
        }

        public void AddSoldierFirstTeamList(int amount, SoldierType soldierType)
        {
            for (int i = 0; i < amount; i++)
            {
                Soldier soldier = null;

                switch (soldierType)
                {
                    case SoldierType.Pilot:
                        soldier = new Pilot();
                        break;
                    case SoldierType.Sniper:
                        soldier = new Sniper();
                        break;
                    case SoldierType.Stormtrooper:
                        soldier = new Stormtrooper();
                        break;
                    default:
                        soldier = new Pilot();
                        break;
                }
                FactionSoldierList.Add(soldier);
            }
        }

        public void AddShipFirstTeamList(int amount, ShipType shipType)
        {
            for (int i = 0; i < amount; i++)
            {
                Ship ship = null;

                switch (shipType)
                {
                    case ShipType.AWing:
                        ship = new AWing();
                        break;
                    case ShipType.MilleniumFalcon:
                        ship = new MilleniumFalcon();
                        break;
                    case ShipType.XWing:
                        ship = new XWing();
                        break;
                    default:
                        ship = new AWing();
                        break;
                }
                FactionShipList.Add(ship);
            }
        }

        public string GetStatusTeam()
        {
            return "------------------------------------------------------------------\n" +
                   "Team Name: " + FactionName + "\n" +
                   "Team Leader: " + FactionLeader.Name + "\n" +
                   "Amount Soldiers: " + FactionSoldierList.Count + "\n" + 
                   "Amount Ships: " + FactionShipList.Count + "\n" +
                   "------------------------------------------------------------------";
        }

    }
}
