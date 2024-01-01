using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_coins : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource coin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        coin.Play();
        CollManag.CoinCount += 1;
        if(CollManag.ScorCount<=CollManag.CoinCount)
        {
            CollManag.ScorCount = CollManag.CoinCount;
        }
        this.gameObject.SetActive(false);
    }
}
