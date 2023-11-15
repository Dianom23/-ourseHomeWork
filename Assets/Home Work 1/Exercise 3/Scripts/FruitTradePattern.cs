using UnityEngine;

namespace HomeWork1.Exercise3
{
    public class FruitTradePattern : ITradeBehavior
    {
        public void Trade() => Debug.Log("Продал фрукт");
    }
}
