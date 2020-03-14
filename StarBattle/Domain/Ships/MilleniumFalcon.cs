using StarBattle.Interface;

namespace StarBattle.Domain
{
    public class MilleniumFalcon : Ship, IShipActions
    {
        public MilleniumFalcon()
        {
            Resistence = 500;
            Damage = 200;
            AmountCannons = 10;
        }

        public int GetShipSpeed()
        {
            return Resistence / Damage;
        }
    }
}
