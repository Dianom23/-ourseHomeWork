using UnityEngine;

namespace HomeWork1.Exercise4
{
    public class Gun
    {
        private Camera _camera;

        public Gun(Camera camera) => _camera = camera;

        public Ball OnShoot()
        {
            if (Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
                if(hit.collider.TryGetComponent(out Ball ball))
                    return ball;

            return null;
        }
    }
}
