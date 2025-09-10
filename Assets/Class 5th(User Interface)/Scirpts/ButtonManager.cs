using System;
using UnityEngine;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{
    [SerializeField] public Button[] buttonlist;
    [SerializeField] string[] names = { "NewGame", "Option", "Quit" }; // new string[3]{ "NewGame", "Option", "Quit" }; ���ִ°� �ٽ� ����
    public void Execute()
    {
        Debug.Log("����");
    }

    public void Option()
    {
        Debug.Log("�ɼ�");
    }

    public void Quit()
    {
        Debug.Log("������");
    }

 
    void Start()
    {
        Action[] actions = { Execute, Option, Quit };
      
    

        for (int i = 0; i < actions.Length; i++)
        {
            int index = i;
            buttonlist[index].onClick.AddListener(() => actions[index]());
            buttonlist[index].GetComponentInChildren<Text>().text = names[index];
            
        }
    }




}
