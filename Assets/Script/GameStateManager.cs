using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;

    [SerializeField]
    private GameObject GameStartUI;
    [SerializeField]
    private GameObject GameOverUI;

    bool startGame = false;


    void Awake()
    {
        Instance = this;

        Time.timeScale = 0f;
        GameStartUI.SetActive(true);
        GameOverUI.SetActive(false);
    }

    private void Update()
    {
        if (startGame == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                startGame = true;
                Time.timeScale = 1f;
                GameStartUI.SetActive(false);
            }
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        GameOverUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}