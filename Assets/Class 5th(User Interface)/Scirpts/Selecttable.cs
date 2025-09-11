using UnityEngine;
using UnityEngine.UI;
public class Selecttable : MonoBehaviour
{
 
    [SerializeField] Text text2; 

    private void Awake()
    {
        text2 = GetComponentInChildren<Text>();
    }
    public void Enterable()
    {
        text2.fontSize = 100; 
       
    }

    public void Exit()
    {
        text2.fontSize = 75; 
    }

    public void Down()
    {
        text2.fontSize = 50; 
    }
}
