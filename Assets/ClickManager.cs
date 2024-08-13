using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{
    public GameObject id;
    public GameObject[] idPrefabs;
    public GameObject[] newIDs;
    public int i;
    public int scoreCount;
    public TextMeshProUGUI scoreText;
    public GameObject endScreenWin;
    public GameObject endScreenLose;
    public GameObject fadeScreenOverlay;

    // public GameObject queue;
    // public GameObject[] npcs;
    // public GameObject currentNPC;
    // public Transform target;
    // public Animator[] animators;

    public void CheckChoice(Object button)
    {
        // Get current ID displayed
        id = GameObject.FindWithTag("ID");
        
        if(id != null)
        {
            // npcs = new GameObject[queue.transform.childCount];
            // for(int n = 0; n < npcs.Length; n++)
            // {
            //     npcs[n] = queue.transform.GetChild(n).gameObject;
            //     if(id.name.Contains(npcs[n].name))
            //     {
            //         currentNPC = npcs[n];
            //         Debug.Log(currentNPC.name);
            //     }
            // }

            // Check whether player choice is correct
            if(button.name ==  "YesButton") // Allow entry
            {
                if(id.name.Contains("Wrong"))
                {
                    // Should not allow entry, deduct point
                    Debug.Log("Wrong");
                    scoreCount = int.Parse(scoreText.text);
                    scoreCount -= 1;
                    scoreText.text = scoreCount.ToString();
                }
                else
                {
                    // Allow entry, add point
                    Debug.Log("Correct");
                    scoreCount = int.Parse(scoreText.text);
                    scoreCount += 1;
                    scoreText.text = scoreCount.ToString();
                }
                // for(int a = 0; a < animators.Length; a++)
                // {
                //     animators[a].SetBool("IsWalk", true);
                // }
            }
            else // Deny entry
            {
                if(id.name.Contains("Wrong"))
                {
                    // Deny entry, add point
                    Debug.Log("Correct");
                    scoreCount = int.Parse(scoreText.text);
                    scoreCount += 1;
                    scoreText.text = scoreCount.ToString();
                }
                else
                {
                    // Should allow entry, deduct point
                    Debug.Log("Wrong");
                    scoreCount = int.Parse(scoreText.text);
                    scoreCount -= 1;
                    scoreText.text = scoreCount.ToString();
                }
            }

            // Remove current ID 
            Destroy(id);

            // Spawn next ID in queue
            if(i < idPrefabs.Length)
            {
                newIDs = new GameObject[idPrefabs.Length];
                newIDs[i] = Instantiate(idPrefabs[i]) as GameObject;
                i++;
            }
            else
            {
                Debug.Log("Game End");
                if(scoreCount == 9)
                {
                    EndGame("win");
                }
                else
                {
                    EndGame("lose");
                }
            }
        }
    }

    public void EndGame(string state)
    {
        fadeScreenOverlay.SetActive(true);
        
        if(state == "win")
        {
            endScreenWin.SetActive(true);
        }
        else
        {
            endScreenLose.SetActive(true);
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene("Bar");
    }

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
