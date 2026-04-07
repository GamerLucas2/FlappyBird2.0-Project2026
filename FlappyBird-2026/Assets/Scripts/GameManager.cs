using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    [Header("Panels")]
    [SerializeField] private GameObject startScreen;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject gamePlayUI;
    
    [Header("Text")]
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Button restartButton;
    
    [SerializeField] private float score = 0f;
    
    private bool isStarted = false;
    private float point = 1f;

    private void Awake()
    {
        Instance = this;
        startScreen.SetActive(true);
        gameOverScreen.gameObject.SetActive(false);
        gamePlayUI.gameObject.SetActive(false);
        
        restartButton.onClick.AddListener(ResetGame);
        Time.timeScale = 0;
        score = 0f;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && isStarted == false)
        {
            startScreen.SetActive(false);
            gamePlayUI.gameObject.SetActive(true);
            isStarted = true;
            Time.timeScale = 1f;
        }
    }

    public void GameOver()
    {
        AudioManager.Instance.PlayDieSound();
        gameOverScreen.SetActive(true);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddPoint()
    {
        score += point;
        scoreText.text = score.ToString();
        AudioManager.Instance.PlayScoreSound();
    }
}
