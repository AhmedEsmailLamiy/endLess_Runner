using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool go;
    public GameObject gamOve;
    void Start()
    {
        go = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (go)
        {
            Time.timeScale = 0;
            gamOve.SetActive(true);
        }
    }
}
