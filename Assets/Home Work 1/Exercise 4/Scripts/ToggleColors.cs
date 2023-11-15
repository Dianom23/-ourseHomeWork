using UnityEngine;

namespace HomeWork1.Exercise4
{
    public class ToggleColors : MonoBehaviour
    {   
        public BallColor ToggleBallColor { get { return _toggleBallColor; } }
        [SerializeField] private BallColor _toggleBallColor;
    }
}
