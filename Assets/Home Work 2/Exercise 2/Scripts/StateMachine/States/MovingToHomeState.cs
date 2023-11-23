using UnityEngine;

namespace HomeWork2.Exercise2
{
    public class MovingToHomeState : NpcWorkingState
    {
        private MovingToHomeStateConfig _config;

        public MovingToHomeState(IStateSwitcher stateSwitcher, Npc npc) : base(stateSwitcher, npc) => _config = Npc.Config.MoveToHomeStateConfig;

        public override void Update()
        {
            base.Update();

            if (IsReachedTheGoal(Npc.HomePosition))
                StateSwitcher.SwitchState<RestingState>();

            OnMoveToHome();
        }

        private void OnMoveToHome() => Npc.CharacterController.Move(CalculateDirection(Npc.transform.position, Npc.HomePosition) * _config.Speed * Time.deltaTime);
    }
}
