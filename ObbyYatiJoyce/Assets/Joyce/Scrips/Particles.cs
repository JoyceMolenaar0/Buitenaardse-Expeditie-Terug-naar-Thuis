using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particlesscript : MonoBehaviour
{
    [SerializeField] GameObject Position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Position.transform.position; 
    }
}
