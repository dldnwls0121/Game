using System;
using UnityEngine;

[System.Serializable] // : �����͸� ����ȭ ��Ŵ(����Ʈ ���·� ��ȯ)
public class ability 
{

    public ability( )
    {
        Debug.Log("�ɷ��� Ȱ��ȭ �Ǿ����ϴ�");
    }
    
    
    [SerializeField] int strength = 5; // private �����ϸ鼭 ���� ��Ű�� �Ҽ�����
    
    public int Strength { get { return strength; } }
    void Start()
    {

        Debug.Log("Strength : " +  strength);
    }


}
