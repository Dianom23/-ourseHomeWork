using UnityEngine;

namespace HomeWork2.Exercise2
{
    [CreateAssetMenu(fileName = "NpcConfig", menuName = "Configs/NpcConfig")]
    public class NpcConfig : ScriptableObject
    {
        [SerializeField] private MovingToHomeStateConfig _moveToHomeStateConfig;
        [SerializeField] private MovingToTargetStateConfig _moveToWorkStateConfig;
        [SerializeField] private RestingStateConfig _restingStateConfig;
        [SerializeField] private WorkingStateConfig _workingStateConfig;

        public MovingToHomeStateConfig MoveToHomeStateConfig => _moveToHomeStateConfig;
        public MovingToTargetStateConfig MoveToWorkStateConfig => _moveToWorkStateConfig;
        public RestingStateConfig RestingStateConfig => _restingStateConfig;
        public WorkingStateConfig WorkingStateConfig => _workingStateConfig;

    }
}
