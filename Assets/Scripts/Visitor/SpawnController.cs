using UnityEngine;

namespace Assets.Visitor
{
    public class SpawnController : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;
        [SerializeField] private SpawnerData _data;
        
        private SpawnVeigth _spawnVeight;
        private EnemyVeigthVisitor _enemyVisitor;

        private void OnDestroy()
        {
            _spawner.SpawnNotified -= AddVeight;
            _spawner.DeathNotified -= ReduceVeight;
        }

        public void Initialize(Spawner spawner)
        {
            _spawnVeight = new(_data.MaxValue);
            _enemyVisitor = new EnemyVeigthVisitor(_spawnVeight, _data);

            _spawner = spawner;
            _spawner.SpawnNotified += AddVeight;
            _spawner.DeathNotified += ReduceVeight;

            _spawner.StartWork();
        }

        private void AddVeight(Enemy enemy)
        {
            _enemyVisitor.Visit(enemy, Action.Add);

            if (_spawnVeight.IsMaxWeight())
                _spawner.StopWork();

            Debug.Log($"Вес врагов после спавна: {_spawnVeight.CurrentValue}");

        }

        private void ReduceVeight(Enemy enemy)
        {
            _enemyVisitor.Visit(enemy, Action.Reduce);

            if (_spawnVeight.IsNotMaxWeight())
                _spawner.StartWork();
        }

        private class EnemyVeigthVisitor
        {
            private SpawnVeigth _spawnVeight;
            private SpawnerData _data;

            public EnemyVeigthVisitor(SpawnVeigth spawnVeight, SpawnerData data)
            {
                _spawnVeight = spawnVeight;
                _data = data;
            }

            public void Visit(Elf elf, Action action)
            {
                if (action == Action.Add)
                    _spawnVeight.Add(_data.Elf);
                else
                    _spawnVeight.Reduce(_data.Elf);
            }

            public void Visit(Human human, Action action)
            {
                if (action == Action.Add)
                    _spawnVeight.Add(_data.Human);
                else
                    _spawnVeight.Reduce(_data.Human);
            }

            public void Visit(Ork ork, Action action)
            {
                if (action == Action.Add)
                    _spawnVeight.Add(_data.Ork);
                else
                    _spawnVeight.Reduce(_data.Ork);
            }

            public void Visit(Robot robot, Action action)
            {
                if (action == Action.Add)
                    _spawnVeight.Add(_data.Robot);
                else
                    _spawnVeight.Reduce(_data.Robot);
            }

            public void Visit(Enemy enemy, Action action) => Visit((dynamic)enemy, action);
        }
        private enum Action
        {
            Add,
            Reduce
        }
    }
}