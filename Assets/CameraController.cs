using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get player position and update this camera transofrm position
        transform.position = player.transform.position + new Vector3(0, 6, -10);
    }
}
