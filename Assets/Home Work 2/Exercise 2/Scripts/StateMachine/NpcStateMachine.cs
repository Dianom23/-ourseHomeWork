using System.Collections.Generic;
using System.Linq;

namespace HomeWork2.Exercise2
{
    public class NpcStateMachine : IStateSwitcher
    {
        private List<IState> _states;
        private IState _currentState;
        private Npc _npc;

        public NpcStateMachine(Npc npc)
        {
            _npc = npc;

            _states = new List<IState>()
            {
                new MovingToTargetState(this, _npc),
                new RestingState(this, _npc),
                new WorkingState(this, _npc),
                new MovingToHomeState(this, _npc),
            };

            _currentState = _states[0];
            _currentState.Enter();
        }

        public void SwitchState<State>() where State : IState
        {
            IState state = _states.FirstOrDefault(state => state is State);

            _currentState.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void Update() => _currentState.Update();
    }
}