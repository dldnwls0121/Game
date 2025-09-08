using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    private Transform trans;
    private Vector3 direction;

    //Time deltatime : 마지막 프레임 이후의 완료되는 시간
    private void Awake()
    {
        trans = gameObject.transform;
    }
    void Start()
    {
      
        Debug.Log("x : " + trans.position.x);
        Debug.Log("y : " + trans.position.y);
        Debug.Log("z : " + trans.position.z);
    }

    void Update()
    {
       // if (Keyboard.current.wKey.wasPressedThisFrame)
       // {
       //     
       //     //trans.position = new Vector3(trans.position.x, trans.position.y, trans.position.z + 1);
       //     trans.position += Vector3.forward;
       //     Debug.Log("z" + trans.position.z);
       // }
       // if (Keyboard.current.sKey.wasPressedThisFrame)
       // {
       //     //trans.position = new Vector3(trans.position.x, trans.position.y, trans.position.z - 1);
       //     trans.position += Vector3.back;
       //     Debug.Log("z" + trans.position.z);
       // }
       // if(Keyboard.current.dKey.wasPressedThisFrame)
       // {
       //     //trans.position = new Vector3(trans.position.x + 1, trans.position.y, trans.position.z);
       //     trans.position += Vector3.right;
       //     Debug.Log("x" + trans.position.x);
       // }
       //if(Keyboard.current.aKey.wasPressedThisFrame)
       // {
       //     //trans.position = new Vector3(trans.position.x - 1, trans.position.y, trans.position.z);
       //     trans.position += Vector3.left;
       //     Debug.Log("x" + trans.position.x);
       //     
       // }
    }
}
