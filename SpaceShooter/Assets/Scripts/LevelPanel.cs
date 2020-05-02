using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelPanel : MonoBehaviour // просто для обработки нажатия на кнопку
{
    [HideInInspector]public Text Status; 
    public void StartLevel()
    {
        if (transform.GetChild(2).GetComponent<Text>().text == "Open" || transform.GetChild(2).GetComponent<Text>().text == "Finished")
        {
            PlayerPrefs.SetInt("NeedScore",Convert.ToInt32(transform.GetChild(1).GetComponent<Text>().text) + 10);
            SceneManager.LoadSceneAsync("Level");
        }
        else
        {
            Debug.Log("Closed");
        }
    }
}
