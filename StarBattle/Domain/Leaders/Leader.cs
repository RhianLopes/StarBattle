namespace StarBattle.Domain.Leaders
{
    public abstract class Leader
    {
        public string Name { get; set; }

        public bool IsBad { get; set; }

        public bool IsSupported { get; set; }
    }
}
