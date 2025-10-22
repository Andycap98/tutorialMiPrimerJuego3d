using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    private IMovementStrategy movementStrategy;
    private Player player;

    void Start()
    {
        player = new Player();
        // Estrategia inicial (puedes cambiarla en runtime)
        SetMovementStrategy(new AccelerateMovementStrategy());
    }

 
    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        movementStrategy = strategy;
    }

    public void MovePlayer(float input )
    {
        if (movementStrategy != null)
        {
            movementStrategy.Move(transform, player,input);
        }
    }
}