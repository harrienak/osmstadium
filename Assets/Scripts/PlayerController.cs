using UnityEngine;
using System.Collections;
using UnityEditor;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
          //  EditorUtility.DisplayDialog("title", "gelukt", "oke");
            Vector3 movement = new Vector3(1.0f, 0.0f, 0.0f);

            rb.AddForce(movement * speed);
        }
        if (Input.touchCount == 2)
        {
            //  EditorUtility.DisplayDialog("title", "gelukt", "oke");
            Vector3 movement = new Vector3(-1.0f, 0.0f, 0.0f);

            rb.AddForce(movement * speed);
        }
    }

    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}
