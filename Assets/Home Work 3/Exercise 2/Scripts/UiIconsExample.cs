using System;
using UnityEngine;
using UnityEngine.UI;

namespace HomeWork3.Exercise2
{
    public class UiIconsExample : MonoBehaviour
    {
        [SerializeField] private Image _coinIcon;
        [SerializeField] private Image _energyIcon;
        [SerializeField] private PlaceIconType _placeIconType;

        [ContextMenu("UpdateUi")]
        public void UpdateUi()
        {
            IconsFactory iconsFactory;

            switch (_placeIconType)
            {
                case PlaceIconType.Menu:
                    iconsFactory = new MenuIconsFactory();
                    break;
                case PlaceIconType.Shop:
                    iconsFactory = new ShopIconFactory();
                    break;
                default:
                    throw new AggregateException(nameof(PlaceIconType));
            }

            _coinIcon.sprite = iconsFactory.Get(IconType.Coin);
            _energyIcon.sprite = iconsFactory.Get(IconType.Energy);
        }
    }
}
