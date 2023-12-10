using System;
using UnityEngine;

namespace HomeWork4.Exercise3
{
    public class Ball : MonoBehaviour
    {
        public Action<Ball> ClickToBallEvent;

        [SerializeField] private BallColors _color;
        public BallColors Color => _color;

        private void Awake()
        {
            if (gameObject.TryGetComponent(out Renderer renderer))
            {
                switch (_color)
                {
                    case BallColors.Red:
                        renderer.material.color = UnityEngine.Color.red;
                        break;
                    case BallColors.White:
                        renderer.material.color = UnityEngine.Color.white;
                        break;
                    case BallColors.Green:
                        renderer.material.color = UnityEngine.Color.green;
                        break;
                }
            }
        }
    }
}
