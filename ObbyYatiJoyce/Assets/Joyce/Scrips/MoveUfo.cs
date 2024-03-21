using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveUfo : MonoBehaviour
{
    [SerializeField] GameObject Pos1;
    [SerializeField] GameObject Pos2;
    [SerializeField] GameObject Pos3;
    [SerializeField] GameObject Pos4;
    [SerializeField] GameObject Pos5;
    [SerializeField] GameObject Pos6;
    [SerializeField] GameObject Pos7;
    [SerializeField] GameObject Pos8;
    [SerializeField] GameObject Pos9;
    [SerializeField] GameObject PosEind;
    [SerializeField] GameObject Ufo;
    [SerializeField] GameObject KapotteUfo;
    [SerializeField] CameraFollow cameraFollow;
    [SerializeField] GameObject Explosion;
    [SerializeField] float speed = 1.0f;

    public float rotationSpeed = 20.0f;

    private List<GameObject> Targets = new List<GameObject>();
    private int CurrentTarget = 0;

    

    void Start()
    {
        Targets.Add(Pos1);
        Targets.Add(Pos2);
        Targets.Add(Pos3);
        Targets.Add(Pos4);
        Targets.Add(PosEind);
        Explosion.SetActive(false);
        

        transform.position = Targets[CurrentTarget].transform.position;
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Targets[CurrentTarget].transform.position) < 0.1f)
        {
            if (CurrentTarget < Targets.Count - 1)
            {
                CurrentTarget++;
            }
            else
            {
                KapotteUfo.transform.position = Ufo.transform.position;
                Explosion.transform.position = KapotteUfo.transform.position;

                Ufo.SetActive(false);
                Explosion.SetActive(true);
                KapotteUfo.SetActive(true);

                cameraFollow.target = KapotteUfo.transform;
                return;
            }
        }


        Vector3 direction = (Targets[CurrentTarget].transform.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
        transform.forward = Vector3.Lerp(transform.forward, direction, 0.02f);
    }
}
