using UnityEngine;

public class Monster : MonoBehaviour
{

    [SerializeField] ability ability2;

    private void Awake()
    {
        // Awake : 객체가 생성될 때 호출되며, 객체가 비활성화되어 있을 때에도
        // 호출되고, 단 한 번만 호출되는 이벤트 함수
        Debug.Log("Awake");
        Debug.Log(ability2.Strength);
    }

    private void OnEnable()
    {
        // OnEnable : 객체가 활성화되었을 때 호출되는 이벤트 함수
        Debug.Log("OnEnable");
    }
    void Start()
    {
        // Start : 객체가 생성되었을 때 호출되며, 단 한 번만 호출되는 이벤트 함수
      
    }

    private void FixedUpdate()
    {
        // FixedUpdate : Time step에 설정된 값에 따라 일정한 간격으로 호출되는 
        // 이벤트 함수

        Debug.Log("Fixed Update");
       
    }
    void Update()
    {
        // Update : 객체가 활성화 되는 동안, 매 프래임마다 호출되는 이벤트 함수
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate : 한 프레임의 마지막 단계에서 호출되는 이벤트 함수
        Debug.Log("Late Update");
    }

    private void OnDisable()
    {
        // OnDisable : 객체가 비활성화되었을 때 호출되는 이벤트 함수
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // OnDestory : 객체가 삭제되었을 때 호출되는 이벤트 함수
        Debug.Log("OnDestory");
    }
}
