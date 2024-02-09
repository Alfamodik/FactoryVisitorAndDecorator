namespace Decorator
{
    public class Сharacter
    {
        private IPlayerStats _stat;

        public Сharacter(IPlayerStats stat) => _stat = stat;

        public IPlayerStats Stat => _stat;

        public void ChangeStats(IPlayerStats stat) => _stat = stat;
    }
}