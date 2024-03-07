using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemove : MonoBehaviour
{
    public void ToSuggestScene()
    {
        SceneManager.LoadScene("SuggestScene");
    }

    public void ToLotteryScene()
    {
        SceneManager.LoadScene("LotteryScene");
    }

    public void SuggestButton()
    {
        ToSuggestScene();
    }

    public void LotteryButton()
    {
        ToLotteryScene();
    }

}