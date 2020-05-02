using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCreater : MonoBehaviour
{
    public GameObject LevelPanel;
    public LevelStore Levels;
    private Vector3 shopPanelTransform;
    public int Score;
    public Text TScore;

    void Start()
    {
        if (PlayerPrefs.HasKey("GlobalScore"))
        {
            Score = PlayerPrefs.GetInt("GlobalScore");
        }
        else
        {
            PlayerPrefs.SetInt("GlobalScore", 0);
        }

        TScore.text = "Scrore: " + Score;
        shopPanelTransform = gameObject.transform.position + new Vector3(0, 500, 0);
        for (int i = 0; i < Levels.Levels.Length; i++)
        {
            GameObject ShopElement = Instantiate(LevelPanel);
            ShopElement.transform.SetParent(gameObject.transform,false);
            ShopElement.transform.position = shopPanelTransform;
            
            ShopElement.transform.GetChild(0).GetComponent<Text>().text = Levels.Levels[i].LevelName;//Level
            ShopElement.transform.GetChild(1).GetComponent<Text>().text = "" + Levels.Levels[i].NeededScore;//Need Score
            
            if (Score > Levels.Levels[i].NeededScore)
            {
                ShopElement.transform.GetChild(2).GetComponent<Text>().text = "Finished";//Status
                ShopElement.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "Finished"; //Button
            }
            
            if (Score == Levels.Levels[i].NeededScore)
            {
                ShopElement.transform.GetChild(2).GetComponent<Text>().text = "Open";//Status
                ShopElement.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "Open"; //Button
            }
            
            if (Score < Levels.Levels[i].NeededScore)
            {
                ShopElement.transform.GetChild(2).GetComponent<Text>().text = "Close";//Status
                ShopElement.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = "Close"; //Button
            }
            shopPanelTransform -= new Vector3(0, 600, 0);
        }
    }
}
