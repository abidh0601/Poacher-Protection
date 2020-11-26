using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class EnemyController : MonoBehaviour
{
    [Header("Components")]
    public Transform target;
    private GameObject targetParent;
    
    public List<Transform> homePoint;
    
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;
    

    private bool followStarted = false;

    [Header("Stats")]
    public float radius = 1f;
    public bool lightShine = false;
    private bool lightShineOffStarted = false;
   
    Transform GetClosestHomePoint(List<Transform> homePoint, Transform fromThis)
    {
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = fromThis.position;
        foreach (Transform potentialTarget in homePoint)
        {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
            }
        }
        return bestTarget;
    }



    private IEnumerator FollowTarget(float radius, Transform target)
    {
        Vector3 previousTargetPosition = new Vector3(float.PositiveInfinity, float.PositiveInfinity);
        while (Vector3.SqrMagnitude(transform.position - target.position) > 0.1f)
        {
            // did target move more than at least a minimum amount since last destination set?
            if (Vector3.SqrMagnitude(previousTargetPosition - target.position) > radius)
            {
                agent.SetDestination(target.position);
                previousTargetPosition = target.position;
            }
            yield return new WaitForSeconds(0.1f);
        }
        yield return null;
    }

    //Sets agent destination to closest home point
    void goHome()
    {
        StopCoroutine(FollowTarget(radius, target));
        followStarted = false;
        Vector3 closestHome = GetClosestHomePoint(homePoint, transform).position;

        agent.SetDestination(closestHome);
    }

    // Start is called before the first frame update
    void Start()
    {
        homePoint = GetComponentInParent<EnemySpawnOnPlane>().homePoints;
       
        targetParent = GameObject.Find("WolfParent");
        //target = targetParent.transform.GetChild(Random.Range(0, targetParent.transform.childCount - 1));

    }

    IEnumerator OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
        if(collision.gameObject.tag == "EdgeWall")
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }


        if (collision.gameObject.name == "Wall(Clone)")
        {
            yield return new WaitForSeconds(5);
            Debug.Log("Enemy has collided with wall");
            Destroy(collision.gameObject);
        }


    }

    private IEnumerator lightShineOff() {
        yield return new WaitForSecondsRealtime(5);
        lightShine = false;
        lightShineOffStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        

            if (lightShine)
            {
                goHome();
                if (!lightShineOffStarted)
                {
                    StartCoroutine(lightShineOff());
                    lightShineOffStarted = true;
                }
                
            }
            else
            {

                if (target == null && targetParent.transform.childCount != 0)
                {
                    StopCoroutine(FollowTarget(radius, target));
                    target = targetParent.transform.GetChild(Random.Range(0, targetParent.transform.childCount - 1));
                    
                    agent.SetDestination(target.position);
                    StartCoroutine(FollowTarget(radius, target));
                }

                if (targetParent.transform.childCount == 0)
                {
                    agent.SetDestination(transform.position);

                }

                if (!followStarted)
                {

                    StartCoroutine(FollowTarget(radius, target));
                    followStarted = true;
                }


            }
        

        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }

    }
}
