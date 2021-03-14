public class ModularStateMachine
{
    #region Variables
    public IState CurrentState
    {
        get
        {
            return currentState;
        }
    }
    public IState PreviousState
    {
        get
        {
            return previousState;
        }
    }

    private IState currentState;
    private IState previousState;
    #endregion

    #region Methods
    public void ChangeState(IState newState)
    {
        if(currentState != null)
        {
            previousState = currentState;
            currentState.Exit();
        }
        currentState = newState;
        currentState.Enter();
    }

    public void ExecuteStateUpdate()
    {
        if(currentState != null)
        {
            currentState.Execute();
        }
    }
    #endregion

    public void ReturnToPreviousState()
    {
        if(currentState != null)
        {
            currentState.Exit();
            currentState = previousState;
            currentState.Enter();
        }
    }
}