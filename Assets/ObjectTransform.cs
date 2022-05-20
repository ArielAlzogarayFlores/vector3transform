using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTransform : MonoBehaviour
{
    public GameObject myCube;
    public Vector3 newScale;

    // Start is called before the first frame update
    void Start()
    {
        myCube.transform.localScale = newScale;
        //eulerAngles para la rotación
        //position, para la posición
        //localScale, para la escala
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
