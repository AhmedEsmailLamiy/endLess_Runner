using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Sec;
    public int z = 98, SectionNo;
    public bool flag = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flag==false)
        {
            flag = true;
            StartCoroutine(Generatsection());
        }
    }
    IEnumerator Generatsection()
    {
        SectionNo = Random.Range(0, 3);
        Instantiate(Sec[SectionNo], new Vector3(0, 0, z), Quaternion.identity);
        z += 98;
        yield return new WaitForSeconds(2);
        flag = false;
    }
}
