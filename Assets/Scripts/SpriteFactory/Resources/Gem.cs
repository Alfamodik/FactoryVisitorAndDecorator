using System;
using UnityEngine;

[Serializable]
public class Gem : IResources
{
    [SerializeField] private int _cost;
    [SerializeField] private GemType type;

    public int Cost => _cost;
    public GemType Type => type;
}

public enum GemType
{
    Emirald,
    Saphir
}