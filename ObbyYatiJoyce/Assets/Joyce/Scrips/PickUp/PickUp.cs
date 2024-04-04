using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private BoxCollider targetCollider1;
    [SerializeField] private BoxCollider targetCollider2;
    [SerializeField] private BoxCollider targetCollider3;

    [SerializeField] GameObject UfoDeel1;
    [SerializeField] GameObject UfoDeel2;
    [SerializeField] GameObject UfoDeel3;

    private int Score = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetCollider1 && targetCollider1.bounds.Intersects(GetComponent<Collider>().bounds))
        {
            
            UfoDeel1.SetActive(false);
            Score++;
        }

        if (targetCollider2 && targetCollider2.bounds.Intersects(GetComponent<Collider>().bounds))
        {
            
            UfoDeel2.SetActive(false);
            Score++;
        }

        if (targetCollider3 && targetCollider3.bounds.Intersects(GetComponent<Collider>().bounds))
        {

            UfoDeel3.SetActive(false);
            Score++;
        }
    }
}
