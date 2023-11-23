using UnityEngine;

namespace HomeWork2.Exercise2
{
    public class NpcWorkingState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected readonly Npc Npc;

        private const float ThresholdForReachedTheGoal = 0.05f;

        public NpcWorkingState(IStateSwitcher stateSwitcher, Npc npc)
        {
            StateSwitcher = stateSwitcher;
            Npc = npc;
        }

        public virtual void Enter()
        {
            Debug.Log(GetType());
        }

        public virtual void Exit() { }

        public virtual void Update() { }

        protected Vector3 CalculateDirection(Vector3 from, Vector3 to) => (to - from).normalized;

        protected bool IsReachedTheGoal(Vector3 goalPosition)
        {
            Vector2 npcPosition = new Vector2(Npc.transform.position.x, Npc.transform.position.z);
            goalPosition = new Vector2(goalPosition.x, goalPosition.z);

            return true ? (Vector2.Distance(npcPosition, goalPosition) <= ThresholdForReachedTheGoal) : false;
        }
    }

}
