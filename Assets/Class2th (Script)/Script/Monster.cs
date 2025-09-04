using UnityEngine;

public class Monster : MonoBehaviour
{

    [SerializeField] ability ability2;

    private void Awake()
    {
        // Awake : ��ü�� ������ �� ȣ��Ǹ�, ��ü�� ��Ȱ��ȭ�Ǿ� ���� ������
        // ȣ��ǰ�, �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Awake");
        Debug.Log(ability2.Strength);
    }

    private void OnEnable()
    {
        // OnEnable : ��ü�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnEnable");
    }
    void Start()
    {
        // Start : ��ü�� �����Ǿ��� �� ȣ��Ǹ�, �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ�
      
    }

    private void FixedUpdate()
    {
        // FixedUpdate : Time step�� ������ ���� ���� ������ �������� ȣ��Ǵ� 
        // �̺�Ʈ �Լ�

        Debug.Log("Fixed Update");
       
    }
    void Update()
    {
        // Update : ��ü�� Ȱ��ȭ �Ǵ� ����, �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate : �� �������� ������ �ܰ迡�� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Late Update");
    }

    private void OnDisable()
    {
        // OnDisable : ��ü�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // OnDestory : ��ü�� �����Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnDestory");
    }
}
