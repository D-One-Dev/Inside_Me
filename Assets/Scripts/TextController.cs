using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour
{
    [SerializeField] private Text scoreTxt, healthTxt;
    private int score, health = 3;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt.text = score.ToString();
        healthTxt.text = health.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Death");
        }
    }

    public void IncreaseScore(int value)
    {
        score += value;
        scoreTxt.text = score.ToString();
    }
    public void DecreaseHealth(int value)
    {
        health -= value;
        healthTxt.text = health.ToString();
    }
}
