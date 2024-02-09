using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;


public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private List<PlaceForCoin> _spawnPoints;
    [SerializeField] private float _spawnCooldown;

    private CoinFactory _factory;
    private List<PlaceForCoin> _freePoints;

    private Coroutine _spawn;

    public void Initialize(CoinFactory coinFactory) => _factory = coinFactory;

    public void StartWork()
    {
        StopWork();
        _spawn = StartCoroutine(Spawn());
    }

    public void StopWork()
    {
        if (_spawn != null)
            StopCoroutine(_spawn);
    }

    public IEnumerator Spawn()
    {
        while (true)
        {
            SetAvailability();

            if (AnySpawnPointsIsFree())
                _freePoints[GetRandomPoint()].Set(_factory.Get());
            else
                Debug.Log("Все точки заняты!");

            yield return new WaitForSeconds(_spawnCooldown);
        }
    }

    private int GetRandomPoint() => Random.Range(0, _freePoints.Count - 1);

    private void SetAvailability() => _freePoints = _spawnPoints.Where(el => el.IsFree).ToList();

    private bool AnySpawnPointsIsFree() => _spawnPoints.Any(el => el.IsFree);
}
