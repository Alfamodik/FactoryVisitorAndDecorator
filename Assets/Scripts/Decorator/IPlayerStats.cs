namespace Decorator
{
    public interface IPlayerStats
    {
        int Strength { get; }

        int Intelligence { get; }

        int Dexterity { get; }

        void AddStrength(int strength);
        
        void AddIntelligence(int intelligence);

        void AddDexterity(int dexterity);
    }
}