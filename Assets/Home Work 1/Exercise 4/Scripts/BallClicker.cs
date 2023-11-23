using UnityEngine;

namespace HomeWork1.Exercise4
{
    public class BallClicker : MonoBehaviour
    {
        private Camera _camera;

        private void Awake() => _camera = Camera.main;

        public BallClicker(Camera camera) => _camera = camera;

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
