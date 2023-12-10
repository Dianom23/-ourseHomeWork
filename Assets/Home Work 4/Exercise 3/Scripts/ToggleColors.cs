using UnityEngine;

namespace HomeWork4.Exercise3
{
    public class ToggleColors : MonoBehaviour
    {   
        public BallColors ToggleBallColor { get { return _toggleBallColor; } }
        [SerializeField] private BallColors _toggleBallColor;
    }
}
