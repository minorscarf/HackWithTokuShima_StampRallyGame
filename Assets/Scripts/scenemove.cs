using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToSuggestScene()
    {
        SceneManager.LoadScene("SuggestScene");
    }

    public void ToLotteryScene()
    {
        SceneManager.LoadScene("LotteryScene");
    }

}