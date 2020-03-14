using StarBattle.Interface;

namespace StarBattle.Domain
{
    public class XWing : Ship, IShipActions
    {
        public XWing()
        {
            Resistence = 200;
            Damage = 500;
            AmountCannons = 2;
        }

        public int GetShipSpeed()
        {
            return Damage / Resistence;
        }
    }
}
