using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExample : MonoBehaviour
{
    public Transform point1;

    void Start()
    {
        //Vector3 vec = new Vector3(1, 2, 3);       : ����� ����� �������� Vector3() ������ � �� ������� �������� xyz �������;
        //Vector2 vec2 = new Vector2(0, 7);         : �� �� ����� ��� Vector2();

        Vector3 vec = new Vector3(1, 1, 0);              //  : ������ ������������� �������������� �������;

        //transform.rotation = Quaternion.Euler(45, 45, 45);          // :  ����� Euler ��������� �������� ������ ������� � ����� ��������� ��� �������� �������, ��� � ������ �������� XYZ;

        //vec.x = 6;
        //vec.y = -2;                               : ���������� �������� ���� ���������;
        //vec.z = 10;

        //vec.Set(90,-34,2);                   //   : ���������� �������� ���� ��������� ����� �������� Set. ������� Set �� ������ �� ��������� Transform;

        //transform.position = vec;            //   : ��������� �������� ��� ������ ��������� � ��������� Position ���������� Transform;
        //tranform.position.Set(5, 5, 5);           : �� ����� ��������, ��� ��� Tranform �� �������� ����������;

        //vec.Set(5, 5, 5);                       
        //transform.position = vec;            //   : ����� ������������ ����� ��������� ��� ��������� �������� ���� ���������: ������� ������� ������������� ������, � ����� ������ ��� ��� ��������� �������� xyz �������;

        //transform.position = point1.position;  // : ��� ������, �� ������� ��������� ������, ����� �������� ���� ��������� �������� ��������� xyz point1;


        //Debug.Log(Vector3.Distance(point1.position, point2.position));  // : �������� Distance ���������� ���������� ����� ���������;
        Debug.Log(Vector3.Angle(Vector3.right, Vector3.up));       // : �������� Angle ��������� �� ���� ����� ����� ���������;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 2, 0);
        transform.LookAt(point1.position);             // : ����� ������� ������ point1;
        //transform.position = Vector3.Lerp(transform.position, point1.position, 0.001f);                       // : ��� ������������� Lerp ��������� ����� ��������� ������ ��� ����������� �� ��������� ��������;
        //transform.position = Vector3.MoveTowards(transform.position, point1.position, Time.deltaTime);    // : ����������� ��������� position ����� ��������� ����� ������������� ������� MoveTowards, � ������� ��������� �������
                                                                                                            // ��������� �������, ���������, ������� ����� ��� ������, � ��, ��������� �� ���� ��� ������� ����� ��������� ������;


    }
}
