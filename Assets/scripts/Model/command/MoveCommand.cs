public class MoveCommand : ICommand
{
    private PlayerMovement _playerMovement;
    private float input;
    public MoveCommand(PlayerMovement playerMovement,float input)
    {
        this.input = input;
        _playerMovement = playerMovement;
    }

    public void Execute()
    {
        _playerMovement.SetMovementStrategy(new SmoothMovementStrategy());
        _playerMovement.MovePlayer(input);
      
    }
}
