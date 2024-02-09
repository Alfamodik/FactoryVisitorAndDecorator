using UnityEngine;

public class BootstrapSpriteFactory : MonoBehaviour
{
    [SerializeField] private SpritePlacer _spritePlacer;
    [SerializeField] private MainMenuResources _mainMenuResources;
    [SerializeField] private ShopResources _shopResources;
    private ResoursesType _resoursesType;

    private void Awake()
    {
        _spritePlacer.SetFactory(new MainMenuResourcesFactory(_mainMenuResources));
        Debug.Log("MainMenu factory; Доступны: Gem, Energy");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Create();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _spritePlacer.SetFactory(new MainMenuResourcesFactory(_mainMenuResources));
            Debug.Log("MainMenu factory; Доступны: Gem, Energy");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            _spritePlacer.SetFactory(new ShopResourcesFactory(_shopResources));
            Debug.Log("Shop factory; Доступны: Money, Energy");
        }


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _resoursesType = ResoursesType.Gem;
            Debug.Log("Выбран Gem");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _resoursesType = ResoursesType.Coin;
            Debug.Log("Выбран Money");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _resoursesType = ResoursesType.Energy;
            Debug.Log("Выбран Energy");
        }
    }

    [ContextMenu("Create")]
    public void Create() => _spritePlacer.Create(_resoursesType);
}
