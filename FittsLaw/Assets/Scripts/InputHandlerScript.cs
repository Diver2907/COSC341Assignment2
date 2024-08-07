using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputHandlerScript : MonoBehaviour
{
    private Camera _mainCamera;
    public ColorChangingScript colourChangingScript;
    public DataLoggerScript dataLoggerScript;


    // Start is called before the first frame update
    void Start()
    {
        _mainCamera = Camera.main;

    } 
    void Update(){
        dataLoggerScript.time += Time.deltaTime;
    }   
     public void OnClick(InputAction.CallbackContext context){
        if(!context.started){
            return;
        }
        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if(!rayHit.collider){
            return;
        }
        else{
            dataLoggerScript.FinalTime = dataLoggerScript.time;
            dataLoggerScript.time = 0;
            Debug.Log(rayHit.collider.gameObject.name);
            colourChangingScript.changeColour(rayHit.collider.gameObject);
            
        }
        
     }
}
