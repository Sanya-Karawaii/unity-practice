using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("3");
        /*GetComponent<Rigidbody>().AddForce(0, 0, 5, ForceMode.Impulse); */ /*ForceMode.Force - дефолтное значение, которое примен€ет посто€нную силу на основе массы объекта.*/
                                                                       /*ForceMode.Acceleration - значение, которое примен€ет посто€нную силу, игнориру€ массу объекта.*/
                                                                       /*ForceMode.Impulse - значение, которое примен€ет единичную силу на основе массы объекта.*/
                                                                       /*ForceMode.VelocityChange - значение, которое примен€ет единичную силу, игнориру€ массу объекта.*/
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, 5, ForceMode.Acceleration);
        GetComponent<Rigidbody>().velocity = Vector3.right; /*“акже можно использовать Velocity  - параметр ускорени€ тела, это вектор, который показывает направление и скорость, с которой движетс€ объект*/
    }

    //private void OnCollisionEnter(Collision collision) /*первый экземпл€р класса Collision принадлежит активному объекту, второй Collision отвечает за объекты, с которыми активный объект взаимодействует*/
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
    //    if (oobject.gameObject.name == " уб")
    //    {
    //        Debug.Log("Yay!");
    //    }

    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log("TriggerLost");
    //}


}
