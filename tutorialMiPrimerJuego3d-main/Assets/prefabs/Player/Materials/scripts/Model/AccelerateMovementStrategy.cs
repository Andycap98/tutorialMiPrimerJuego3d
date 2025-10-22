using UnityEngine;

public class AccelerateMovementStrategy : IMovementStrategy
{
    private float currentSpeed = 0f;

    public void Move(Transform playerTransform, Player player)
    {
        float input = Input.GetAxis("Horizontal");

        if (input != 0)
        {
            currentSpeed += player.acceleration * Time.deltaTime;
            currentSpeed = Mathf.Clamp(currentSpeed, 0, player.maxSpeed);
        }
        else
        {
            currentSpeed = 0;
        }

        Vector3 movement = new Vector3(input, 0, 0) * currentSpeed * Time.deltaTime;
        playerTransform.Translate(movement);
    }
}
