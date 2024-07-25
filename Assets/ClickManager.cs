using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameObject id;
    public GameObject[] idPrefabs;
    public GameObject[] newIDs;
    public int i;

    public void CheckChoice(Object button)
    {
        // Add logic to check whether player choice is correct
        id = GameObject.FindWithTag("ID");
        Debug.Log(id.name);
        // Check if name contains "wrong"
        if(id.name.Contains("Wrong"))
        {
            Debug.Log(id.name);
            Debug.Log("Wrong");
        }
        else
        {
            Debug.Log(id.name);
            Debug.Log("Correct");
        }

        
        if(button.name ==  "YesButton")
        {
            Debug.Log("YES");
            // Update score or story point
        }
        else
        {
            Debug.Log("NO");
            // Update score or story point
        }

        // Remove current ID 
        Destroy(id);

        // Spawn next in line ID
        if(i < idPrefabs.Length)
        {
            newIDs = new GameObject[idPrefabs.Length];
            newIDs[i] = Instantiate(idPrefabs[i]) as GameObject;
            i++;
        }
        else
        {
            Debug.Log("Game End");
        }
    }
}
