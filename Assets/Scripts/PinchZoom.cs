using UnityEngine;
using System.Collections;

public class PinchZoom : MonoBehaviour {
    public GameObject stadium;
    private Vector3 position;

    void Start()
    {
       
        //offset = transform.position - player.transform.position;
    }


    void Update()
    {

        transform.position = new Vector3(transform.position.x +5, transform.position.y, transform.position.z);
    }
}
