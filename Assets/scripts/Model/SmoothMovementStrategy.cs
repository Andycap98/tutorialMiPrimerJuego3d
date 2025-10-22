using UnityEngine;

public class SmoothMovementStrategy : IMovementStrategy
{
    public void Move(Transform playerTransform, Player player, float direction)
    {
        float moveInX = direction * player.velocity * Time.deltaTime;
        playerTransform.Translate(moveInX, 0, 0);
    }
    }
