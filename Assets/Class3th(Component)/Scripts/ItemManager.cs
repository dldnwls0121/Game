using UnityEngine;
using UnityEngine.InputSystem;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject[] gameobjects;
    void Start()
    {

        for (int i = 0; i < gameobjects.Length; i++)
        {
            gameobjects[i].SetActive(false);
        }


    }

    void Update()
    {
        int j = 0;
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (j == 0)
            {
                for (int i = 0; i < gameobjects.Length; i++)
                {
                    gameobjects[i].SetActive(false);
                }
                gameobjects[j].SetActive(true);
                j++;
            }
            else if (j == 1)
            {
                for (int i = 0; i < gameobjects.Length; i++)
                {
                    gameobjects[i].SetActive(false);
                }
                gameobjects[j].SetActive(true);
                j++;
            }
            else if(j == 2)
            {
                for (int i = 0; i < gameobjects.Length; i++)
                {
                    gameobjects[i].SetActive(false);
                }
                gameobjects[j].SetActive(true);
                j++;
            }
            else if(j == 3)
            {
                for (int i = 0; i < gameobjects.Length; i++)
                {
                    gameobjects[i].SetActive(false);
                }
                gameobjects[j].SetActive(true);
                j = 0;
            }
            Debug.Log("스페이스");
        }
    }


}
