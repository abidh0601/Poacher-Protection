using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnPointOnPlane : MonoBehaviour
{
    bool firstSpawn = true;
    // set your plane here
    Transform plane;
    Vector3 min;
    Vector3 max;
    GameObject newObject;
    public GameObject spawnPoints;
    public GameObject spawn;
    int spawnPlanes;
    List<Vector3> VerticeList;

    Vector3 leftTop;
    Vector3 rightTop;
    Vector3 leftBottom;
    Vector3 rightBottom;

    Vector3 XAxis;
    Vector3 ZAxis;


    void Start()
    {
        //spawnPoints = GameObject.Find("GrassSpawn");
            //spawnPlanes = spawnPoints.transform.childCount;
        
        plane = spawnPoints.transform.GetChild(0);
        VerticeList = new List<Vector3>(plane.GetComponent<MeshFilter>().sharedMesh.vertices);

        leftTop = plane.transform.TransformPoint(VerticeList[0]);
        rightTop = plane.transform.TransformPoint(VerticeList[10]);
        leftBottom = plane.transform.TransformPoint(VerticeList[110]);
        rightBottom = plane.transform.TransformPoint(VerticeList[120]);

        XAxis = rightTop - leftTop;
        ZAxis = leftBottom - leftTop;

        //StartCoroutine(spawnGrass());

        
    }


    IEnumerator spawnGrass()
    {
        while(true)
        {
            if (transform.childCount < 30)
            {
                yield return new WaitForSeconds(10);

                newObject = Instantiate(spawn);
                Vector3 RndPointonPlane = leftTop + XAxis * Random.value + ZAxis * Random.value;
                newObject.transform.position = RndPointonPlane; //+ plane.transform.up * 0.5f;
                newObject.transform.parent = gameObject.transform;

            }
        }
        

    }

    private void Update()
    {

        while (transform.childCount < 30)
        {


            newObject = Instantiate(spawn);
            Vector3 RndPointonPlane = leftTop + XAxis * Random.value + ZAxis * Random.value;
            newObject.transform.position = RndPointonPlane; //+ plane.transform.up * 0.5f; ///(x , y , z) (0 , 1, 0) (0,0.5,0)
            newObject.transform.parent = gameObject.transform;

        }
        firstSpawn = false;
    }

}
