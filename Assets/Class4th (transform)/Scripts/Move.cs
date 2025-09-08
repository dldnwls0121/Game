using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    private Vector2 moveInput;
    private float z;
    [SerializeField] private float Speed = 10.0f;

    private void Awake()
    {

    }

    private void Update()
    {
        transform.position = transform.position + (Vector3)moveInput * Time.deltaTime * Speed;
    }

    void OnMove(InputValue inputValue)
    {
        moveInput.x = inputValue.Get<Vector2>().x;
        //moveInput.z += inputValue.Get<float>().z;

        //벡터의 크기를 1로 설정
        moveInput.Normalize();
    }


}
