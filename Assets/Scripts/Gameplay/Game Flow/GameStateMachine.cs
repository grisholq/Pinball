using VContainer.Unity;

public class GameStateMachine : StateMachine, IInitializable
{
    private PlayState _playState;
    
    public GameStateMachine(PlayState playState)
    {
        _playState = playState;
    }
    
    public void Initialize()
    {
        AddState(_playState);
        SwitchState<PlayState>();
    }
}