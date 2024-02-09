using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Visitor
{
    public class Spawner : MonoBehaviour, IEnemyDeathNotifier, IEnemySpawnNotifier
    {
        public event Action<Enemy> DeathNotified;
        public event Action<Enemy> SpawnNotified;

        [SerializeField] private float _spawnCooldown;
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private EnemyFactory _enemyFactory;

        private List<Enemy> _spawnedEnemies = new List<Enemy>();

        public void StartWork()
        {
            StopWork();
            StartCoroutine(Spawn());
        }

        public void StopWork() => StopAllCoroutines();

        public void KillRandomEnemy()
        {
            if (_spawnedEnemies.Count == 0)
                return;

            _spawnedEnemies[Random.Range(0, _spawnedEnemies.Count)].Kill();
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                Enemy enemy = _enemyFactory.Get((EnemyType)Random.Range(0, 
                    Enum.GetValues(typeof(EnemyType)).Length));

                enemy.MoveTo(_spawnPoints[Random.Range(0, _spawnPoints.Count)].position);
                enemy.Died += OnEnemyDied;

                _spawnedEnemies.Add(enemy);
                SpawnNotified?.Invoke(enemy);

                yield return new WaitForSeconds(_spawnCooldown);
            }
        }

        private void OnEnemyDied(Enemy enemy)
        {
            enemy.Died -= OnEnemyDied;
            DeathNotified?.Invoke(enemy);
            _spawnedEnemies.Remove(enemy);
        }
    }
}
