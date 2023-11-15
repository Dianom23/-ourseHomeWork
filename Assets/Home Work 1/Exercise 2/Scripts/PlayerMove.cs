using UnityEngine;

namespace HomeWork1.Exercise2
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private float _speed = 1;

        void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            Vector2 inputMove = new Vector2 (horizontal, vertical).normalized;
            Vector3 directionMove = new Vector3(inputMove.x, 0, inputMove.y);
            directionMove = transform.TransformDirection(directionMove);
            transform.Translate(directionMove * _speed * Time.deltaTime);
        }
    }
}
