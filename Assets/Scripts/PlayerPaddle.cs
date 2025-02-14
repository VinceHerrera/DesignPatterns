using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : MonoBehaviour
{
    /*
     * Vince Herrera
     */


    // Vars
    protected Vector3 movDir = Vector3.zero;
    [SerializeField, Range(1,20)]
    protected float moveSpeed = 1f;
    //[SerializeField, Range(10, 29)]
    //protected float maxSpeed = 25f;



    //Methods
    private void Update()
    {
        MovePaddle();
    }
    public void MoveInput(InputAction.CallbackContext aCon)
    {
        Vector2 av2 = aCon.ReadValue<Vector2>();

        movDir.x = av2.x;
        ///MovDir.y = av2.y;

    }

    // Move Player Paddle

    public void MovePaddle()
    {
        transform.Translate(movDir * moveSpeed * Time.deltaTime);
    }


    //Accessors
}

