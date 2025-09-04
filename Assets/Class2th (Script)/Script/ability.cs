using System;
using UnityEngine;

[System.Serializable] // : 데이터를 진열화 시킴(바이트 형태로 변환)
public class ability 
{

    public ability( )
    {
        Debug.Log("능력이 활성화 되었습니다");
    }
    
    
    [SerializeField] int strength = 5; // private 유지하면서 노출 시키게 할수있음
    
    public int Strength { get { return strength; } }
    void Start()
    {

        Debug.Log("Strength : " +  strength);
    }


}
