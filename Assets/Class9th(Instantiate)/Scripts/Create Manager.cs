using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] GameObject prefab2;
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

        for(int i = 0; i < count; i++)
        {
            units.Add(Instantiate(prefab, gameObject.transform));
            units[i].SetActive(false);
        }
       

    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >=  5.0f)
        {
            Debug.Log($"{time} 초입니다");
        }
    }
}
