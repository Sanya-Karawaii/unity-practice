using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("3");
        /*GetComponent<Rigidbody>().AddForce(0, 0, 5, ForceMode.Impulse); */ /*ForceMode.Force - ��������� ��������, ������� ��������� ���������� ���� �� ������ ����� �������.*/
                                                                       /*ForceMode.Acceleration - ��������, ������� ��������� ���������� ����, ��������� ����� �������.*/
                                                                       /*ForceMode.Impulse - ��������, ������� ��������� ��������� ���� �� ������ ����� �������.*/
                                                                       /*ForceMode.VelocityChange - ��������, ������� ��������� ��������� ����, ��������� ����� �������.*/
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, 5, ForceMode.Acceleration);
        GetComponent<Rigidbody>().velocity = Vector3.right; /*����� ����� ������������ Velocity  - �������� ��������� ����, ��� ������, ������� ���������� ����������� � ��������, � ������� �������� ������*/
    }

    //private void OnCollisionEnter(Collision collision) /*������ ��������� ������ Collision ����������� ��������� �������, ������ Collision �������� �� �������, � �������� �������� ������ ���������������*/
    //{
    //    //Debug.Log("Collision detected!");
    //    //Debug.Log(collision.gameObject.name);
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    //Debug.Log("Collision lost!");
    //}

    //private void OnCollisionStay(Collision collision)
    //{

    //}

    //private void OnTriggerEnter(Collider oobject)
    //{
    //    if (oobject.gameObject.name == "���")
    //    {
    //        Debug.Log("Yay!");
    //    }

    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("TriggerLost");
    //}


}
