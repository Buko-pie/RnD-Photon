using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class CharacterMovementHandler : NetworkBehaviour
{
    NetworkCharacterControllerPrototypeCustom networkCharacterControllerPrototypeCustom;

    private void Awake()
    {
        networkCharacterControllerPrototypeCustom = GetComponent<NetworkCharacterControllerPrototypeCustom>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public override void FixedUpdateNetwork()
    {
        //Get input from the network
        if(GetInput(out NetworkInputData networkInputData))
    {
            Vector3 moveDirection = transform.forward * networkInputData.movementInput.y + transform.right * networkInputData.movementInput.x;
            moveDirection.Normalize();

            networkCharacterControllerPrototypeCustom.Move(moveDirection);
        }
    }
}
