using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangingScript : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    public DataLoggerScript dataLoggerScript;
    public InputHandlerScript inputHandlerScript;
    public void changeColour(GameObject g){
        if(g.name == "bgdownload"){
            dataLoggerScript.wrong = 1;
            dataLoggerScript.WriteCSV();
            return;
        }
        dataLoggerScript.WriteCSV();
        _spriteRenderer = g.GetComponent<SpriteRenderer>();
        _spriteRenderer.color = new Color(0f,1f,0f,1f);
    }
}
