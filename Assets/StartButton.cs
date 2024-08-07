using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject player;

    public void StartClicked(Object button)
    {
        // Start button clicked, play animations for main camera and player sprite
        mainCamera.GetComponent<Animator>().Play("Down");
        player.GetComponent<Animator>().Play("Player_Walk");
    }
}
