using UnityEngine;

namespace HomeWork1.Exercise3
{
    public class NotTradePattern : ITradeBehavior
    {
        public void Trade() => Debug.Log("Я сейчас не торгуюсь");
    }
}
