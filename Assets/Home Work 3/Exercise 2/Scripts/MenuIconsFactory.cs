using System;
using UnityEngine;

namespace HomeWork3.Exercise2
{
    public class MenuIconsFactory : IconsFactory
    {
        public override Sprite Get(IconType iconType)
        {
            switch (iconType)
            {
                case IconType.Coin:
                    return Resources.Load<Sprite>("Sprites/coin_menu");
                case IconType.Energy:
                    return Resources.Load<Sprite>("Sprites/energy_menu");
                default:
                    throw new ArgumentException(nameof(iconType));
            }
        }
    }
}
