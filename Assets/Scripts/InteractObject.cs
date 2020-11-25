using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class InteractObject : MonoBehaviour
{
    public Camera mainCamera;
    public Player_Input player_Input;
    public float maxDistance = 10;
    //public GameObject tempParent;
    public bool isHolding = false;
    //Vector3 objectPos;
    //public Transform objHeld;
    public int movementSpeed;
    //public double heldDistance = -0.1;


    private void Awake()
    {
        player_Input = new Player_Input();
    }

    private void OnEnable()
    {
        player_Input.Enable();
    }

    private void OnDisable()
    {
        player_Input.Disable();
    }


    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = GetComponent<PlayerMovement>().playerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        float rightClick = player_Input.Player.mouseClick.ReadValue<float>();

        if (player_Input.Player.PlaceFence.triggered)
        {
            
            Ray point = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            RaycastHit hit;

            if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, maxDistance) && hit.transform.tag == "wall" )
            {
                Debug.Log("Hit a wall");
                Destroy(hit.transform.gameObject);
                // else if (hit.transform.tag == "Enemy") {
                //     hit.collider.GetComponent<EnemyController>().lightShine = true;
                // }

                // if (hit.transform.tag == "Grab")
                // {
                //     // TODO: THROWING
                //     // if(isHolding) {
                //     //     if(Mouse.current.leftButton.wasPressedThisFrame)
                //     //     {
                //     //         Debug.Log("Throwing");
                //     //         hit.rigidbody.AddForce(tempParent.transform.forward * 600);
                //     //     }

                //     // }
                //     objHeld = hit.transform;
                //     isHolding = !isHolding;

                //     // hit.rigidbody.velocity = Vector3.zero;
                //     // hit.rigidbody.angularVelocity = Vector3.zero;

                // }
            }
        }

        // if (isHolding)
        // {
        //     //set velocities to zero to stop moving objects when picking up
        //     objHeld.GetComponent<Rigidbody>().velocity = Vector3.zero;
        //     objHeld.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        //     //objHeld.collider.enabled = false;
        //     objHeld.GetComponent<Rigidbody>().useGravity = false;
        //     objHeld.transform.SetParent(tempParent.transform);
        //     //objHeld.transform.position = tempParent.transform.position + new Vector3(movementSpeed * Time.deltaTime, movementSpeed * Time.deltaTime, 0+ maxDistance);
        // }
        // else
        // {
        //     objectPos = objHeld.transform.position;
        //     objHeld.transform.SetParent(null);
        //     //objHeld.collider.enabled = true;
        //     objHeld.GetComponent<Rigidbody>().useGravity = true;
        //     objHeld.transform.position = objectPos;
        // }
    }
}

