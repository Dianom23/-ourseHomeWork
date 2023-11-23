using System.Collections;
using UnityEngine;

namespace HomeWork2.Exercise2
{
    public class RestingState : NpcWorkingState
    {
        private RestingStateConfig _config;

        public RestingState(IStateSwitcher stateSwitcher, Npc npc) : base(stateSwitcher, npc) => _config = Npc.Config.RestingStateConfig;

        public override void Enter()
        {
            base.Enter();

            StartRestWaitingRoutine();
        }

        private IEnumerator OnRestWaiting()
        {
            yield return new WaitForSeconds(_config.RestingDuration);
            StateSwitcher.SwitchState<MovingToTargetState>();
        }

        private Coroutine StartRestWaitingRoutine() => Coroutines.StartRoutine(OnRestWaiting());
    }
}
