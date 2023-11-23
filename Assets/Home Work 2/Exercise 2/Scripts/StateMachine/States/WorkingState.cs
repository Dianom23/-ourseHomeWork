using System.Collections;
using UnityEngine;

namespace HomeWork2.Exercise2
{
    public class WorkingState : NpcWorkingState
    {
        private WorkingStateConfig _config;

        public WorkingState(IStateSwitcher stateSwitcher, Npc npc) : base(stateSwitcher, npc) => _config = Npc.Config.WorkingStateConfig;

        public override void Enter()
        {
            base.Enter();
            StartWorkingWaitingRoutine();
        }

        private IEnumerator OnWorkingWaiting()
        {
            yield return new WaitForSeconds(_config.WorkingDuration);
            StateSwitcher.SwitchState<MovingToHomeState>();
        }

        private Coroutine StartWorkingWaitingRoutine() => Coroutines.StartRoutine(OnWorkingWaiting());
    }
}
