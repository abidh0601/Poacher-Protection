using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.InputSystem;
using System;
using Random = UnityEngine.Random;


public class BunnyStats : MonoBehaviour
{
    [Header("Stats")]
    public int hunger;
    public int hungerLimit = 10;
    public int reproduce;
    public int repoLimit = 10;
    public int maxClones;
    bool walking = false;
    public float radius = 10f;

    [Header("Components")]
    public GameObject clone;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;
    public GameObject grass;
    Transform food;

    [Header("Testing")]
    public bool testing = false;
    private Player_Input player_Input;
    [SerializeField] Camera cam;
    float mousePress;

    public bool nightTime;
    bool coroutinesStarted = false;
    public bool needToEat = false;
    public bool isHeld = false;

    public Vector3 RandomNavMeshLocation(float radius)
    {
        Vector3 randomDirection = Vector3.zero;
        NavMeshHit hit;
        Vector3 finalPosition = transform.position;

        randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;

        if (NavMesh.SamplePosition(randomDirection, out hit, radius, 1))
        {
            finalPosition = hit.position;
        }

        return finalPosition;
    }

    IEnumerator Wander()
    {
        //Debug.Log("WAnder Started");
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0, 5));
            if (needToEat)
            {
                goToEat();
                yield return new WaitUntil(new Func<bool>(() => !needToEat));
                ////Debug.Log("Continue Wandering");
            }
            if (!walking)
            {

                Vector3 newDestination = RandomNavMeshLocation(radius);
                agent.SetDestination(newDestination);
                //////Debug.Log("Walking to " + newDestination);
                walking = true;
            }


        }

    }

    IEnumerator increaseHunger()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);

            hunger++;
            if (hunger > 5 && !needToEat)
            {
                needToEat = true;

            }
        }
    }

    IEnumerator increaseReproduce()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);

            reproduce++;

            if (reproduce >= repoLimit && transform.parent.childCount < maxClones)
            {
                reproduction();
            }

        }
    }

    private void goToEat()
    {
        ////Debug.Log("Going to eat");
        food = grass.transform.GetChild(Random.Range(0, (grass.transform.childCount - 1)));
        agent.SetDestination(food.position);
    }

    private void reproduction()
    {
        ////Debug.Log(transform.name + " reproducing");
        float newX = Random.Range(transform.position.x + 5, transform.position.x - 5);
        float newZ = Random.Range(transform.position.z + 5, transform.position.z - 5);
        GameObject a = Instantiate(clone, new Vector3(newX, transform.position.y, newZ), Quaternion.identity);
        a.transform.parent = transform.parent;
        a.transform.name = "Wolf " + (transform.parent.childCount).ToString();
        reproduce = Random.Range(0, 3);
    }

    private void Start()
    {
        //Get Grass parent
        grass = GameObject.Find("GrassSpawner");

        //Let ThirdPersonController control rotation
        agent.updateRotation = false;


        hunger = Random.Range(0, 4);
        reproduce = Random.Range(0, 4);
        maxClones = transform.GetComponentInParent<BunnySpawner>().maxChild;
        GetComponent<Rigidbody>().useGravity = true;
    }

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wolf")
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
        if (collision.gameObject.tag == "Enemy")
        {
            // //Debug.Log("Dying");
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
            //yield return new WaitForSeconds(2);
          
             Destroy(gameObject);
            

        }
        //yield return null; 
    }

    // Update is called once per frame
    void Update()
    {
        if (testing)
        {
            mousePress = player_Input.Screen.click.ReadValue<float>();
            //////Debug.Log(mousePress);
            if (mousePress > 0)
            {
                Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
                RaycastHit point;
                NavMeshHit hit;

                if (Physics.Raycast(ray, out point))
                {
                    //////Debug.Log(point.point);
                    if (NavMesh.SamplePosition(point.point, out hit, 1f, 1))
                    {
                        ////Debug.Log("true");
                        agent.SetDestination(hit.position);
                    }

                }
            }
        }

        //if (isHeld)
        //{
        //    character.Move(Vector3.zero, false, false);
        //    walking = false;

        //}

        if (GetComponentInParent<BunnySpawner>().nightTime && coroutinesStarted)
        {
            //Debug.Log("Nighttime");
            StopAllCoroutines();
            agent.SetDestination(transform.position);
            coroutinesStarted = false;
        }
        if (!GetComponentInParent<BunnySpawner>().nightTime)
        {
            ////Debug.Log("Daytime");
            if (!coroutinesStarted)
            {
                //Debug.Log("Started coroutines");
                StartCoroutine(Wander());
                StartCoroutine(increaseHunger());
                StartCoroutine(increaseReproduce());
                coroutinesStarted = true;
            }

            if (needToEat && food == null)
            {
                food = grass.transform.GetChild(Random.Range(0, (grass.transform.childCount - 1)));
                agent.SetDestination(food.position);
            }
        }

        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
            walking = false;
            //////Debug.Log("Is stopped");

        }


        if (hunger > hungerLimit)
        {
            Destroy(gameObject);
        }






    }



}
