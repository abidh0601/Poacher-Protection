using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tester : MonoBehaviour
{
    float mousePress;
    bool creating;
    public GameObject start;
    public GameObject end;
    public Camera camera;
    
    private Player_Input player_Input;
    

    private void Awake(){
        player_Input  = new Player_Input();
        
    }
    
    private void onEnable(){
        player_Input.Enable();
    }
    
    private void onDisable(){
        player_Input.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
    }
    
    void getInput(){
        
        mousePress = player_Input.Player.PlaceFence.ReadValue<float>();
        Debug.Log(mousePress);
 
 
    }
    
    void setStart(){
        creating = true;
        start.transform.position = getWorldPoint(); 
    }
    
    void setEnd(){
        creating = false;
    }
    
    void adjust (){
        
        
    }

    Vector3 getWorldPoint(){
        Ray ray = camera.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            return hit.point;
        }
        return Vector3.zero;
    }
    
  //*/
}
