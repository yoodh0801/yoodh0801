namespace Framework
{
    public interface IStateMachine<TState>
    {
        TState CurrentState { get; }
        void ChangeState(TState newState);
    }
}
