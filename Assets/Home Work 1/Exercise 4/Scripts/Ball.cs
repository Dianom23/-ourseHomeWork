using UnityEngine;

namespace HomeWork1.Exercise4
{
    public class Ball : MonoBehaviour
    {
        public BallColor Color => _color;
        [SerializeField] private BallColor _color;

        private void Awake()
        {
            if(gameObject.TryGetComponent(out Renderer renderer))
                switch (_color)
                {
                    case BallColor.Red:
                        renderer.material.color = UnityEngine.Color.red;
                        break;
                    case BallColor.White:
                        renderer.material.color = UnityEngine.Color.white;
                        break;
                    case BallColor.Green:
                        renderer.material.color = UnityEngine.Color.green;
                        break;
                }
        }
    }
}
