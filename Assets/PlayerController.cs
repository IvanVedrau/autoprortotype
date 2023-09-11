using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(vertical);
        //move this object forward 10 cm per frame
        transform.position = transform.position + new Vector3(0, 0, 0.1f) * vertical * speed;
    }
}
