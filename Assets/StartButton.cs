using System.Collections;
using System.Collections.Generic;


using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button startButton;
    public GameObject ball;
    public ProjectileMotion projectileMotion;

    private void Start()
    {
        startButton.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        projectileMotion.enabled = true;
    }
}

