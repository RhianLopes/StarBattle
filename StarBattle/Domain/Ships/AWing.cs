using StarBattle.Interface;

namespace StarBattle.Domain
{
    public class AWing : Ship, IShipActions
    {
        public AWing()
        {
            Resistence = 500;
            Damage = 150;
            AmountCannons = 5;

        }

        public int GetShipSpeed()
        {
            return Resistence * AmountCannons;
        }
    }
}
