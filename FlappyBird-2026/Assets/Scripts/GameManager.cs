using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject StartScreen;
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private TextMeshProUGUI scoreText;
    private bool isStarted = false;
    
    [SerializeField] public float score = 0f;
    private float point = 1f;

    private void Awake()
    {
        StartScreen.SetActive(true);
        GameOverScreen.gameObject.SetActive(false);
        Time.timeScale = 0;
        score = 0f;
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

    public void GameOver()
    {
        GameOverScreen.gameObject.SetActive(true);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddPoint()
    {
        score += point;
        scoreText.text = score.ToString();
    }
}
