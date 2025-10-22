using UnityEngine;

public class AccelerateMovementStrategy : IMovementStrategy
{
    private float currentSpeed = 0f;

    public void Move(Transform playerTransform, Player player, float direction)
    {
        float movement = direction * (player.velocity + player.acceleration) * Time.deltaTime;

        playerTransform.Translate(movement * Time.deltaTime, 0, 0);
    }
}
