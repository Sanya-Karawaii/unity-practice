using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomController : MonoBehaviour
{
    public float TimeToExplosion;
    public float Power;
    public float Radius;

    void Start()
    {
        
    }

    
    void Update()
    {
        TimeToExplosion -= Time.deltaTime;
        if(TimeToExplosion <= 0 )
        {
            Boom();
        }
    }

    void Boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();     /*- FindObjectsOfType - ������� ��� �������, � FindObjectOfType - ������� ������ ������� ������ � ��������. ������� ���� ������� �� ���������� ����������*/
        foreach (Rigidbody B in blocks) 
        {
            if (Vector3.Distance(transform.position, B.transform.position) < Radius)
            {
                Vector3 direction = B.transform.position - transform.position;

                B.AddForce(direction.normalized * Power * (Radius - Vector3.Distance(transform.position, B.transform.position)), ForceMode.Impulse);                  /*- direction.normalized - ���������� ������ � ���������� ������ �������;*/
            }
        }
        TimeToExplosion = 3;
    }
}
