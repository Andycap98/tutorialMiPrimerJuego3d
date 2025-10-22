public class AcceleratedMoveCommand : ICommand
{
    private PlayerMovement _playerMovement;
     private float input;
    public AcceleratedMoveCommand(PlayerMovement playerMovement, float input)
    {
        _playerMovement = playerMovement;
        this.input = input;
    }

    public void Execute()
    {
       _playerMovement.SetMovementStrategy(new AccelerateMovementStrategy()); 
         _playerMovement.MovePlayer(input);
    }
}
