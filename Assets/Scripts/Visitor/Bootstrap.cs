using UnityEngine;

namespace Assets.Visitor
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;
        [SerializeField] private SpawnController _spawnController;
        private Score _score;

        private void Awake()
        {
            _score = new(_spawner);
            _spawnController.Initialize(_spawner);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _spawner.KillRandomEnemy();
        }
    }
}