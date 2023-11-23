using UnityEngine;

namespace HomeWork2.Exercise2
{
    [RequireComponent(typeof(CharacterController))]
    public class Npc : MonoBehaviour
    {
        [SerializeField] private Transform _homeTransform;
        [SerializeField] private Transform _workTransform;
        [SerializeField] private NpcConfig _config;

        private NpcStateMachine _stateMachine;
        private CharacterController _characterController;

        public Vector3 HomePosition => _homeTransform.position;
        public Vector3 TargetPosition => _workTransform.position;
        public NpcConfig Config => _config;
        
        public CharacterController CharacterController => _characterController;

        public void Awake()
        {
            _stateMachine = new NpcStateMachine(this);
            _characterController = GetComponent<CharacterController>();
        }

        private void Update() => _stateMachine.Update();
    }
}