using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private List<ICommand> commands;

    void Start()
    {
        playerMovement=gameObject.GetComponent<PlayerMovement>();
        commands=new List<ICommand>();
    }

    // Update is called once per frame
    void Update()
    { commands.Clear();
        float horizontalInput = Input.GetAxis("Horizontal");
        commands.Add(new MoveCommand(playerMovement, horizontalInput));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            commands.Add(new AcceleratedMoveCommand (playerMovement,horizontalInput));
        }
        foreach (ICommand command in commands)
        {
            command.Execute();
        }
    }
}
