using System;
using UnityEngine;

public class SpritePlacer : MonoBehaviour
{
    private ResourcesFactory _factory;

    public void SetFactory(ResourcesFactory factory) => _factory = factory;

    public void Create(ResoursesType type)
    {
        if (_factory == null)
            throw new NullReferenceException("Нou can't create an object without selecting a factory, use SetFactory!");

        IResources instanseResources = _factory.Get(type);
        Debug.Log($"Создано: {instanseResources}");
    }
}