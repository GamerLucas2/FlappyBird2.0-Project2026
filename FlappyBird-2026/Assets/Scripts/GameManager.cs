using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject StartScreen;
    private bool isStarted = false;

    private void Awake()
    {
        StartScreen.SetActive(true);
        Time.timeScale = 0;
    }

    private void Update()
    {
    
        if (Input.GetButtonDown("Jump") && isStarted == false)
        {
            StartScreen.SetActive(false);
            isStarted = true;
            Time.timeScale = 1f;
        }
    }
}
