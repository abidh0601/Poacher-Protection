using System.Collections.Generic;
using UnityEngine;


public class EnemySpawnOnPlane : MonoBehaviour
{

    public int maxChild;


    [Header("Random Spawn Components")]
    Transform plane;

    GameObject newObject;
    public GameObject spawnPoints;
    public GameObject spawn;

    List<Vector3> VerticeList;

    Vector3 leftTop;
    Vector3 rightTop;
    Vector3 leftBottom;

    Vector3 XAxis;
    Vector3 ZAxis;

    [Header("Home component for Enemies")]
    public List<Transform> homePoints;

    private Transform home;
    public bool nightTime;

    //Start is called before the first frame update
    void Start()
    {
        //Get all home return points for enemies
        home = gameObject.transform.GetChild(0);
        
        foreach(Transform child in home)
        {
            homePoints.Add(child);
        }

        //Setup for RandomSpawnPoints
        plane = spawnPoints.transform.GetChild(0);
        VerticeList = new List<Vector3>(plane.GetComponent<MeshFilter>().sharedMesh.vertices);

        leftTop = plane.transform.TransformPoint(VerticeList[0]);
        rightTop = plane.transform.TransformPoint(VerticeList[10]);
        leftBottom = plane.transform.TransformPoint(VerticeList[110]);

        XAxis = rightTop - leftTop;
        ZAxis = leftBottom - leftTop;

    }


    private void Update()
    {
        if(nightTime)
        {
            while (transform.childCount < maxChild)
            {



                Vector3 RndPointonPlane = leftTop + XAxis * Random.value + ZAxis * Random.value;
                newObject = Instantiate(spawn, RndPointonPlane, Quaternion.identity);
                newObject.transform.parent = gameObject.transform;

            }
        }

        else
        {
            foreach(Transform child in gameObject.transform)
            {
                if(child.name != "Home")
                {
                    Destroy(child.gameObject);
                }
            }
        }
        
    }
}
