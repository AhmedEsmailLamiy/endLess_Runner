
using UnityEngine;
using UnityEngine.SceneManagement;

public class events : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Replay ()
    {
        CollManag.CoinCount = 0;
        SceneManager.LoadScene("SampleScene");
    }
    public void quit()
    {
        Application.Quit();
    }
}
