using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    
    public float startingTime = 5f;
    float currentTime = 0f;

    public TextMeshProUGUI time;
    void Start()
    {
        currentTime = startingTime;  
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        time.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}

