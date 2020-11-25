using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class PickupObject : MonoBehaviour {
	public Camera mainCamera;
	bool carrying;
	GameObject carriedObject;
	public float distance;
	public float smooth;
	Pickupable p;

	Player_Input player_Input;
    // Use this for initialization

    private void Awake()
    {
		player_Input = new Player_Input();
    }
    void Start () {

		//player_Input = new Player_Input();
	}

    private void OnEnable()
    {
		player_Input.Enable();
    }

    private void OnDisable()
    {
		player_Input.Disable();
    }

    // Update is called once per frame
    void Update () {
		if(carrying) {
			carry(carriedObject);
			checkDrop();
			//rotateObject();
		} else {
			pickup();
		}
		//if(carriedObject == null)
  //      {
		//	carrying = false;
  //      }
	}
	
	void rotateObject() {
		carriedObject.transform.Rotate(5,10,15);
	}
	
	void carry(GameObject o) {
		if(o != null)
        {
			o.transform.position = Vector3.Lerp(o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
		}
		
	}
	
	void pickup() {
		if(player_Input.Player.mouseClick.triggered) {
			int x = Screen.width / 2;
			int y = Screen.height / 2;

			Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); //ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit) && hit.transform.tag == "Wolf") {
				Debug.Log("Raycast out");
				p = hit.collider.GetComponent<Pickupable>();
				if(p != null) {
					carrying = true;
					carriedObject = p.gameObject;
					p.gameObject.GetComponent<Rigidbody>().useGravity = false;
					//these two resets velocity when picking up moving objects
					p.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
					p.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
					p.gameObject.GetComponent<Pickupable>().held = true;
				}
			}
		}
	}
	
	void checkDrop() {
		if(player_Input.Player.mouseClick.triggered) {
			dropObject();
		}
	}
	
	void dropObject() {
		carrying = false;
		p.gameObject.GetComponent<Rigidbody>().useGravity = true;
		carriedObject = null;
		p.GetComponent<Pickupable>().held = false;
	}
}

