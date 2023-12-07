using UnityEngine;

namespace HomeWork3.Exercise2
{
    public abstract class IconsFactory
    {
        public abstract Sprite Get(IconType iconType);
    }
}
