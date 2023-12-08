using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int stage = 1;
    float score = 0;
    public GameObject player;
    public GameObject ccamera;
    public GameObject stage02;
    public GameObject stage01;
    TextMeshProUGUI scoreText;

    bool isTwoStage = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        stage02 = GameObject.Find("Stage02");
        stage01 = GameObject.Find("Stage01");
        stage02.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        score += Time.deltaTime;
        scoreText.text = "Score : " + Math.Ceiling(score).ToString();
        
        
        
        
        Stage();
        if(stage == 2 && !isTwoStage)
        {
            ccamera.transform.position = new Vector3(ccamera.transform.position.x, -25, ccamera.transform.position.z);
            player.transform.position = player.transform.position + new Vector3(0, -25, 0);
            stage02.SetActive(true);
            stage01.SetActive(false);
            isTwoStage = true;
        }

    }

    void Stage()
    {
        if (score <= 20)
        {
            stage = 1;
        }
        else if (score <= 40)
        {
            stage = 2;
        }
        else
        {
            stage = 2;
        }
    }
}
