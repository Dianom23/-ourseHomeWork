namespace HomeWork2.Exercise2
{
    public interface IStateSwitcher
    {
        void SwitchState<State>() where State : IState;
    }
}
