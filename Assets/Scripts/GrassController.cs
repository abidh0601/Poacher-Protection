using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wolf"))
        {
            yield return new WaitForSeconds(2);
            if (other != null)
            {
                float distance = Vector3.Distance(transform.position, other.gameObject.transform.position);
                //Debug.Log(distance);
                if (distance < 2f)
                {
                    //Debug.Log("Eating");
                    other.GetComponent<BunnyStats>().hunger = Random.Range(0, 3);
                    other.GetComponent<BunnyStats>().needToEat = false;
                    Destroy(gameObject);
                }
            }

            //Destroy(gameObject);
        }
    }

        //private void OnTriggerStay(Collider other)
        //{
        //    if (other.CompareTag("Wolf"))
        //    {
        //        other.GetComponent<BunnyStats>().hunger -= 5;

        //        //Destroy(gameObject);
        //    }
        //}


        // Update is called once per frame
        void Update()
    {
        
    }
}
