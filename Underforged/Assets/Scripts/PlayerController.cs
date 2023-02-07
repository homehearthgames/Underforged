using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameInput gameInput;
    [SerializeField] float moveSpeed = 7f;

    private bool isWalking;

    private void Update() {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        Vector3 moveDir = new Vector3(inputVector.x, inputVector.y, 0f);
        transform.position += moveDir * moveSpeed * Time.deltaTime;

        isWalking = moveDir != Vector3.zero;

    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
