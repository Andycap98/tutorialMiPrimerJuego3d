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

    void Update()
    {
        MovePlayer();
    }

    public void SetMovementStrategy(IMovementStrategy strategy)
    {
        movementStrategy = strategy;
    }

    private void MovePlayer()
    {
        if (movementStrategy != null)
        {
            movementStrategy.Move(transform, player);
        }
    }
}
