using UnityEngine;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button[] buttonlist;

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
 
    }




}
