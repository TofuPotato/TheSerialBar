using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject player;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void StartClicked(Object button)
    {
        // Start button clicked, play animations for main camera and player sprite
        mainCamera.GetComponent<Animator>().Play("Down");
        player.GetComponent<Animator>().Play("Player_Walk");
        audioManager.PlaySFX(audioManager.startBell);

    }

    public void clipboardClicked(Object button)
    {
        // clipboard button clicked, play sfx for page turn
        audioManager.PlaySFX(audioManager.pageFlip);

    }
}
