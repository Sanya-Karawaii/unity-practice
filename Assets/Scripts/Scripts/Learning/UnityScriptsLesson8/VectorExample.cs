using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExample : MonoBehaviour
{
    public Transform point1;

    void Start()
    {
        //Vector3 vec = new Vector3(1, 2, 3);       : можно также оставить Vector3() пустым и не вводить значени€ xyz заранее;
        //Vector2 vec2 = new Vector2(0, 7);         : то же самое дл€ Vector2();

        Vector3 vec = new Vector3(1, 1, 0);              //  : пример использовани€ предсозданного вектора;

        //transform.rotation = Quaternion.Euler(45, 45, 45);          // :  метод Euler позвол€ет изменить наклон объекта и может принимать как значение вектора, так и другие значени€ XYZ;

        //vec.x = 6;
        //vec.y = -2;                               : присвоение значений ос€м координат;
        //vec.z = 10;

        //vec.Set(90,-34,2);                   //   : присвоение значений ос€м координат одной функцией Set. ‘ункци€ Set не вли€ет на компонент Transform;

        //transform.position = vec;            //   : изменение значений при помощи обращени€ к параметру Position компонента Transform;
        //tranform.position.Set(5, 5, 5);           : не будет работать, так как Tranform не €вл€етс€ переменной;

        //vec.Set(5, 5, 5);                       
        //transform.position = vec;            //   : нужно использовать такой синтактис дл€ изменени€ значений осей координат: сначала создаем промежуточный вектор, а потом задаем его дл€ изменени€ значений xyz объекта;

        //transform.position = point1.position;  // : тот объект, на котором находитс€ скрипт, будет измен€ть свое положение согласно значени€м xyz point1;


        //Debug.Log(Vector3.Distance(point1.position, point2.position));  // : параметр Distance показывает рассто€ние между объектами;
        Debug.Log(Vector3.Angle(Vector3.right, Vector3.up));       // : параметр Angle указывает на угол между двум€ векторами;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 2, 0);
        transform.LookAt(point1.position);             // : можно указать просто point1;
        //transform.position = Vector3.Lerp(transform.position, point1.position, 0.001f);                       // : при использовании Lerp дистанци€ между векторами каждый раз уменьшаетс€ на указанное значение;
        //transform.position = Vector3.MoveTowards(transform.position, point1.position, Time.deltaTime);    // : присваиваем параметру position новое положение через использование функции MoveTowards, в которой указываем текущее
                                                                                                            // положение объекта, положение, которое хотим ему задать, и то, насколько за один тик апдейта будет двигатьс€ объект;


    }
}
