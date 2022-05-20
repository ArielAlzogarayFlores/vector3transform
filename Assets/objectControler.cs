using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectControler : MonoBehaviour
{
    public Vector3 movementVector;
    public Vector3 roteVector;
    public Vector3 scaleVector;
    public float xSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 7)
        {
            transform.position += new Vector3(xSpeed,0,0);
        }
    }
}
