using UnityEngine;
using UnityEngine.InputSystem;

public class ItemManager : MonoBehaviour 
{
    [SerializeField] Item[] gameobjects;



    private int j;
    void Start()
    {

        for (int i = 0; i < gameobjects.Length; i++)
        {
            gameobjects[i].transform.gameObject.SetActive(false);
        }

        j = gameobjects.Length - 1;
        gameobjects[0].transform.gameObject.SetActive(false);
        
    }

    void Update()
    {
  
     
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                Swap();
   
            }


        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            gameobjects[j].Use();
        }

    }

    void Swap()
    {
        gameobjects[j].transform.gameObject.SetActive(false);
        j = (j + 1) % gameobjects.Length;
        gameobjects[j].transform.gameObject.SetActive(true);
       
    }

}
