using UnityEngine;

namespace HomeWork1.Exercise3
{
    public class Player : MonoBehaviour
    {
        public enum Rating
        {
            Junior,
            Middle,
            Senior
        }
        public Rating CurrentRating;
    }
}