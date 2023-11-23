using UnityEngine;

namespace HomeWork1.Exercise4
{
    public class ToggleColors : MonoBehaviour
    {   
        public BallColors ToggleBallColor { get { return _toggleBallColor; } }
        [SerializeField] private BallColors _toggleBallColor;
    }
}
