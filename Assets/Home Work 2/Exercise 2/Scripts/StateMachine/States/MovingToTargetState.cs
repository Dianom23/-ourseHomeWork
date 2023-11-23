using UnityEngine;

namespace HomeWork2.Exercise2
{
    public class MovingToTargetState : NpcWorkingState
    {
        private MovingToTargetStateConfig _config;

        public MovingToTargetState(IStateSwitcher stateSwitcher, Npc npc) : base(stateSwitcher, npc) => _config = Npc.Config.MoveToWorkStateConfig;

        public override void Update()
        {
            base.Update();

            if (IsReachedTheGoal(Npc.TargetPosition))
                StateSwitcher.SwitchState<WorkingState>();

            OnMoveToTarget();
        }

        private void OnMoveToTarget() => Npc.CharacterController.Move(CalculateDirection(Npc.transform.position, Npc.TargetPosition) * _config.Speed * Time.deltaTime);
    }
}
