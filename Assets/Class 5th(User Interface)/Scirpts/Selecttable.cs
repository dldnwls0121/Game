using UnityEngine;
using UnityEngine.UI;
public class Selecttable : MonoBehaviour
{
 
    private Text text; 

    private void Awake()
    {
        text = GetComponentInChildren<Text>();
    }
    public void Enterable()
    {
        text.fontSize = 100; 
    }

    public void Exit()
    {
        text.fontSize = 75; 
    }

    public void Down()
    {
        text.fontSize = 50; 
    }
}
