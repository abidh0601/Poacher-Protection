using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DayNight : MonoBehaviour
{

    public float startTime = 10f;
    public float currentTime;
    public int roundNumber;
    public bool nightTime = false;
    public Material night;
    public Material day;
    public Light directionLight;
    public Light playerLight;
    public GameObject playerObject;

    private GameObject Wolfparent;
    private GameObject EnemySpawner;
    public GameObject EnemyPrefab;
    


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        Wolfparent = GameObject.Find("WolfParent");
        EnemySpawner = GameObject.Find("EnemySpawner");
        roundNumber = 1;

    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1f * Time.deltaTime;

        if(currentTime <= 0)
        {
            currentTime = startTime;
            nightTime = !nightTime;
            if (nightTime)
            {
                RenderSettings.skybox = night;
                directionLight.intensity = 0.1f;
                playerLight.enabled = true;
                //playerLight.GetComponent<FlashLight>().nightTime = true;
                Wolfparent.GetComponent<BunnySpawner>().nightTime = true;
                EnemySpawner.GetComponent<EnemySpawnOnPlane>().nightTime = true;

                playerObject.GetComponent<PickupObject>().enabled = false;
                playerObject.GetComponent<InteractObject>().enabled = false;
                playerObject.transform.GetChild(0).GetComponent<CreateWall>().enabled = false;

            }

            else
            {
                RenderSettings.skybox = day;
                directionLight.intensity = 1f;
                playerLight.enabled = false;
                playerLight.GetComponent<FlashLight>().nightTime = false;
                Wolfparent.GetComponent<BunnySpawner>().nightTime = false;
                EnemySpawner.GetComponent<EnemySpawnOnPlane>().nightTime = false;

                playerObject.GetComponent<PickupObject>().enabled = true;
                playerObject.GetComponent<InteractObject>().enabled = true;
                playerObject.transform.GetChild(0).GetComponent<CreateWall>().enabled = true;
                EnemyPrefab.GetComponent<NavMeshAgent>().speed++;

                roundNumber++;
            }
        }
    
        
    }
}
