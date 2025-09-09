using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public Vector3 moveInput;
    [SerializeField] private float Speed = 10.0f;


    public void OnMove2(Vector3 move)
    {
        moveInput = move;

        moveInput.Normalize();

        transform.position = moveInput * Time.deltaTime * Speed;

    }
}
