using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class CreateWall : MonoBehaviour
{
    float mousePress;
    bool creating;
    public GameObject start;
    public GameObject end;
    public Camera mainCamera;

   
    public GameObject wallPrefab;
    GameObject wall;
    public GameObject fenceParent;
    
    private Player_Input player_Input;

    public bool deleteMode = false; 

    private void Awake(){
        player_Input  = new Player_Input();
        
    }
    
    private void OnEnable(){
        player_Input.Enable();
    }
    
    private void OnDisable(){
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
    
    void getInput() {
        // mousePress = player_Input.Player.PlaceFence.ReadValue<float>();

        if (player_Input.Player.deleteMode.triggered)
        {
            deleteMode = !deleteMode;
            Debug.Log(deleteMode);
            if(deleteMode){
                GameObject[] walls = GameObject.FindGameObjectsWithTag("wall");
                foreach(GameObject wall in walls){
                    wall.layer = LayerMask.NameToLayer("Default");
                }
            }
            else{
                GameObject[] walls = GameObject.FindGameObjectsWithTag("wall");
                foreach(GameObject wall in walls){
                    wall.layer = LayerMask.NameToLayer("Ignore Raycast");
                }
            }
        }

        if (!deleteMode) {
            if(!creating)
            {
                //player_Input.Player.PlaceFence.performed += context =>
                //{
                //    creating = true;
                //    setStart();
                //};

                if(player_Input.Player.PlaceFence.triggered)
                {
                    //if(Vector3.Distance(transform.position, getWorldPoint()) < 15f)
                    //{
                    //    setStart();
                    //}
                    setStart();
                    
                }
            }

            else
            {
                if (player_Input.Player.PlaceFence.triggered)
                {
                   
                        setEnd();
                    
                }
            }
            
            //if (Mouse.current.leftButton.wasPressedThisFrame)
            //{
            //    setStart();
            //}
            //else if (Mouse.current.leftButton.wasReleasedThisFrame)
            //{
            //    setEnd();
            //}
            
                if (creating)
                {
                    adjust();
                }
            
        }
 
    }
    
    void setStart(){
        start.transform.position = getWorldPoint();
        if (Vector3.Distance(transform.position, start.transform.position) < 15f)
        {
            creating = true;
            wall = (GameObject)Instantiate(wallPrefab, start.transform.position, Quaternion.identity);
        }
        
        
    }
    
    void setEnd(){
        creating = false;
        end.transform.position = getWorldPoint();
        wall.transform.parent = fenceParent.transform;
        
    }
    
    void adjust (){
        end.transform.position = getWorldPoint();
        end.transform.position = new Vector3(end.transform.position.x, 0f, end.transform.position.z);
        adjustWall();
    }

    void adjustWall() {
        start.transform.LookAt(end.transform.position);
        end.transform.LookAt(start.transform.position);
        float distance = Vector3.Distance(start.transform.position, end.transform.position);

        if(distance > 10f)
        {
            distance = 10f;
        }

        wall.transform.position = start.transform.position + distance / 2 * start.transform.forward;
        wall.transform.position = new Vector3(wall.transform.position.x, 0f, wall.transform.position.z);
        wall.transform.rotation = start.transform.rotation;
        //wall.transform.rotation = Quaternion.Euler(-start.transform.rotation.x, end.transform.rotation.y, end.transform.rotation.z);
        wall.transform.localScale = new Vector3(wall.transform.localScale.x, wall.transform.localScale.y, distance);
    }

    Vector3 getWorldPoint(){
        //Ray ray = camera.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;
        if(Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit))
        {
            return hit.point;
        }
        return Vector3.zero;
    }
    
  //*/
}

