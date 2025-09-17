using System.Collections.Generic;
using UnityEngine;
using System.Collections;
public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    //[SerializeField] GameObject prefab2;
    [SerializeField] int count;
    List<GameObject> units;
    [SerializeField] float time;

    private void Awake()
    {
        //prefab.transform.position = new Vector3(1, 0, 0);
        units = new List<GameObject>();
    }
    void Start()
    {
        //prefab2 = Instantiate(prefab,gameObject.transform);
        //prefab2.transform.position = new Vector3(1,0,0);

        for (int i = 0; i < count; i++)
        {
            units.Add(Instantiate(prefab, gameObject.transform));
            units[i].SetActive(false);
        }

        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        int size = 0;
        int random = Random.Range(0, units.Count);
        while(true)
        {
            yield return new WaitForSeconds(5.0f);
            if (!units[random].activeSelf)
            {
                units[random].SetActive(true);
                size++;
            }
            else
            {
                while (units[random].activeSelf)
                {
                    random = (random + 1) % units.Count;
                    
                }
                units[random].SetActive(true);
                size++;
            }

            if(size == units.Count)
            {
                Debug.Log("전부 활성화 중입니다");
                yield break;
            }
           
        }
 
       

    }
}
