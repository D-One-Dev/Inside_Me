using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{
    private PlayerInput pi;
    private void Awake()
    {
        pi = new PlayerInput();
        pi.Gameplay.Fire.performed += context => RestartGame();
        pi.Gameplay.Exit.performed += context => Application.Quit();
    }
    private void OnEnable()
    { pi.Enable(); }
    private void OnDisable()
    { pi.Disable(); }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
