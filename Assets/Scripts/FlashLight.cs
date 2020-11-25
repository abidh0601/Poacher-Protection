using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;
public class FlashLight : MonoBehaviour
{
    public bool nightTime;
    public GameObject mainCamera;
    public int distance;


    private void Start()
    {
        distance = 30;
    }

    void Update()
    {

            Ray point = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            RaycastHit hit;

            if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, distance))
            {
                if (hit.transform.tag == "Enemy")
                {
                    hit.collider.GetComponent<EnemyController>().lightShine = true;
                }
            }
        

    }
}
// public class FlashLight : MonoBehaviour
// {
//     public Player_Input player_Input;
//     public float maxDistance = 20;

//     public bool nightTime;

//     private void Awake()
//     {
//         player_Input = new Player_Input();
//     }

//     private void OnEnable()
//     {
//         player_Input.Enable();
//     }

//     private void OnDisable()
//     {
//         player_Input.Disable();
//     }

//     // Start is called before the first frame update
//     void Start()
//     {

//     }

//     // Update is called once per frame
//     void Update()
//     {
//         float rightClick = player_Input.Player.mouseClick.ReadValue<float>();
//         // nightTime??
//         if ( Mouse.current.rightButton.wasPressedThisFrame )
//         {
//             Ray point = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

//             RaycastHit hit;

//             if (Physics.Raycast(point, out hit, maxDistance))
//             {
//                 if (hit.transform.tag == "Enemy")
//                 {
//                     hit.collider.GetComponent<EnemyController>().lightShine = true;
//                 }
//             }
//         }
//     }
// }