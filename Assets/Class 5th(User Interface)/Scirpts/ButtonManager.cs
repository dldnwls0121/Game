using UnityEngine;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button[] buttonlist;

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
 
    }




}
