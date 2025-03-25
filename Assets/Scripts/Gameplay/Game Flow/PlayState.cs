public class PlayState : IState
{
    private readonly Flippers _flippers;
    private readonly IFlippersInput _flippersInput;
    
    public PlayState(Flippers flippers, IFlippersInput flippersInput)
    {
        _flippers = flippers;
        _flippersInput = flippersInput;
    }
    
    public void Enter()
    {
        
    }

    public void Update()
    {
        HandleFlippers();
    }

    public void FixedUpdate()
    {

    }

    public void Exit()
    {

    }

    private void HandleFlippers()
    {
        _flippers.LeftFlipper.Pressed = _flippersInput.LeftFlipperPressed;
        _flippers.RightFlipper.Pressed = _flippersInput.RightFlipperPressed;
    }
    
    public void SetStateMachine(IStateMachine stateMachine)
    {

    }
}