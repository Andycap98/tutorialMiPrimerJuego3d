using UnityEngine;

public class SmoothMovementStrategy : IMovementStrategy
{
    public void Move(Transform playerTransform, Player player)
    {
        float move = Input.GetAxis("Horizontal"); // teclas A/D o flechas ← →
        Vector3 movement = new Vector3(move, 0, 0) * player.velocity * Time.deltaTime;
        playerTransform.Translate(movement);
    }
}
