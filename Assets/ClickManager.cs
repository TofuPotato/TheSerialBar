using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameObject id;
    public Sprite idSprite;

    public void CheckChoice(Object button)
    {
        if(button.name ==  "YesButton")
        {
            Debug.Log("YES");
        }
        else
        {
            Debug.Log("NO");
        }

        id = GameObject.FindWithTag("ID");
        Debug.Log(id.name);
        Destroy(id);

        id = new GameObject();
        id.name = "BordieCollinsID";

    }
}
