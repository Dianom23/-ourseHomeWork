using UnityEngine;

namespace HomeWork4.Exercise3
{
    public class BallClicker : MonoBehaviour
    {
        private Camera _camera;

        private void Awake() => _camera = Camera.main;

        private void Update()
        {
            if(Input.GetMouseButtonDown(0))
                if(Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
                    if (hit.collider.TryGetComponent(out Ball ball))
                    {
                        ball.ClickToBallEvent?.Invoke(ball);
                        ball.gameObject.SetActive(false);
                    }
        }
    }
}
