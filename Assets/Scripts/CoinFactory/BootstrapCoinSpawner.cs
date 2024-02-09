using UnityEngine;

public class BootstrapCoinSpawner : MonoBehaviour
{
    [SerializeField] private CoinSpawner _spawner;
    [SerializeField] private Coin _coinPrefab;

    private void Awake()
    {
        _spawner.Initialize(new CoinFactory(_coinPrefab));
        _spawner.StartWork();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            _spawner.StartWork();

        if (Input.GetKeyDown(KeyCode.E))
            _spawner.StopWork();
    }
}
