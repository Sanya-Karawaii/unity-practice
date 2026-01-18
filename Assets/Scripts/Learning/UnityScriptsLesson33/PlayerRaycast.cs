using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    [SerializeField] private float maxDistance = 10f;
    [SerializeField] private float radius = 1f;
    private Vector3 spherePos;
    //[SerializeField] private Material greenMaterial;

    void Start()
    {
        spherePos = new Vector3(transform.position.x, transform.position.y, transform.position.z + maxDistance);
        Ray ray = new Ray(transform.position, Vector3.forward);

        //Debug.DrawRay(transform.position, Vector3.forward * maxDistance, Color.blue, 10000);   } отрисовывает луч через дебаг

        //RaycastHit hit;                                                                        } класс, возвращающий объект, сталкивающийся с лучом;

        //if (Physics.Raycast(ray, /*out hit, */maxDistance))    //Hit - объект, с которым сталкивается луч; out должно стоять перед переменной
        //{
        //    //Debug.Log(hit.transform.position);                                                  }
        //    //hit.transform.position += new Vector3(0, 2, 0);                                     }
        //    //hit.transform.gameObject.GetComponent<Renderer>().material = greenMaterial;         } примеры обращения с объектом hit
        //    Debug.Log("ObjectDetected");                                                          }
        //}
        //else Debug.Log("NoObject");

        if (Physics.SphereCast(ray, radius, maxDistance))
        {
            Debug.Log("ObjectDetected");
        }
        else Debug.Log("NoObject");
    }

    private void OnDrawGizmos()  // метод отрисовывает примитивы
    {
        //Gizmos.color = Color.blue;                        }
        //Gizmos.DrawLine(transform.position, spherePos);   } рисут линию
        //Gizmos.color = Color.red;                         }
        //Gizmos.DrawSphere(spherePos, radius);             } рисует сферу
    }


}
