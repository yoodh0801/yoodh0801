namespace Framework
{
    public interface IState<TStateMachine>
    {
        TStateMachine StateMachine { get; set; }

        void OnEnter();
        void OnExit();
    }
}
