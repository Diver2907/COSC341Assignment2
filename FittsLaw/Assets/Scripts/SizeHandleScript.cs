using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeHandleScript : MonoBehaviour
{
    public DataLoggerScript DLS;
    // Start is called before the first frame update
    void Start()
    {
        
        float scalar = 1.0f;

        switch(DLS.width){
            case DataLoggerScript.Width.small:
                scalar = 0.5f;
                break;
            case DataLoggerScript.Width.medium:
                scalar = 1.0f;
                break;
            case DataLoggerScript.Width.large:
                scalar = 1.5f;
                break;
            default:
                break;
        }

        foreach(Transform child in transform){
            child.transform.localScale = new Vector3(scalar,scalar,scalar);
        }
    }
}
