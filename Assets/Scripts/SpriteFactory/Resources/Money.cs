using System;
using UnityEngine;

[Serializable]
public class Money : IResources
{
    [SerializeField] private int _cost;
    [SerializeField] private float _rotationSpeed;

    public int Cost => _cost;
    public float RotationSpeed => _rotationSpeed;
}
