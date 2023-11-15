using UnityEngine;

namespace HomeWork1.Exercise3
{
    public class Example : MonoBehaviour
    {
        [SerializeField] private NpcTrader _npcTrader;
        [SerializeField] private Player _player;

        private void Awake() => _npcTrader.Initialize(new NotTradePattern());

        void Start() => CheckRating(_player.CurrentRating);

        private void CheckRating(Player.Rating rating)
        {
            switch (rating)
            {
                case Player.Rating.Junior:
                    _npcTrader.SetTradePattern(new NotTradePattern());
                    break;
                case Player.Rating.Middle:
                    _npcTrader.SetTradePattern(new FruitTradePattern());
                    break;
                case Player.Rating.Senior:
                    _npcTrader.SetTradePattern(new ArmorTradePattern());
                    break;
            }
        }
    }
}