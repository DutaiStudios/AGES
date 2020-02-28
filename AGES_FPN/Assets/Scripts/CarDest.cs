using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDest : MonoBehaviour
{


    [SerializeField] GameObject othercar;
    public bool destcar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void carboom()
    {
        destcar = true;
    }
}
