using System;
using UnityEngine;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{
    [SerializeField] public Button[] buttonlist;
    [SerializeField] string[] names = { "NewGame", "Option", "Quit" }; // new string[3]{ "NewGame", "Option", "Quit" }; 해주는거 다시 공부
    public void Execute()
    {
        Debug.Log("실행");
    }

    public void Option()
    {
        Debug.Log("옵션");
    }

    public void Quit()
    {
        Debug.Log("나가기");
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
