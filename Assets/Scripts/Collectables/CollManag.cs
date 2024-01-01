using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollManag : MonoBehaviour
{
    // Start is called before the first frame update
    public static int CoinCount;
    public static int ScorCount;
    public GameObject CoinCountOb;
    public GameObject ScorCountOb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CoinCountOb.GetComponent<Text>().text = "" + CoinCount;
        ScorCountOb.GetComponent<Text>().text = "" + ScorCount;
    }
}
