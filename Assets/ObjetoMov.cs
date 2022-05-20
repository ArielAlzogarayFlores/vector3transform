using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoMov : MonoBehaviour
{
    public GameObject myCube;
    public Vector3 movementVector;
    public Vector3 scale;
    public Vector3 rotation;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myCube.transform.position += movementVector;
        myCube.transform.localScale += scale;
        myCube.transform.eulerAngles += rotation;
    }
}
