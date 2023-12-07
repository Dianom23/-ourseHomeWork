using System;
using UnityEngine;

namespace HomeWork3.Exercise2
{
    public class ShopIconFactory : IconsFactory
    {
        public override Sprite Get(IconType iconType)
        {
            switch (iconType)
            {
                case IconType.Coin:
                    return Resources.Load<Sprite>("Sprites/coin_shop");
                case IconType.Energy:
                    return Resources.Load<Sprite>("Sprites/energy_shop");
                default:
                    throw new ArgumentException(nameof(iconType));
            }
        }
    }
}
