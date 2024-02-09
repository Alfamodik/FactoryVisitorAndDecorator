using System;
using UnityEngine;

public class Coin : ILocateable, IPickable
{
    public event Action PickedUp;

    private void OnTriggerEnter(Collider other)
    {
        PickedUp.Invoke();
        Destroy(gameObject);
    }

    private void FixedUpdate() => transform.Rotate(0, 2, 0);
}
