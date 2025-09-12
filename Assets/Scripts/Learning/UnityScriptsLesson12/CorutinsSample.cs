using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorutinsSample : MonoBehaviour
{
    private void Start()
    {
        Coroutine coroutine = StartCoroutine(timer());         //вызов метода Coroutine
        StopCoroutine(coroutine);
        //CorutinsSample.StopAllCoroutines();
    }
    private IEnumerator timer()          //обозначение класса Coroutine
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1);         //функция возвращения указанного значения каждые две секунды. WaitForSeconds использует игровое время
            yield return new WaitForSecondsRealtime(1); //WaitForSecondsrealtime использует реальное время
            yield return null; //корутина будет выполняться один раз за фрейм
            Debug.Log(i);        
        }
        //Debug.Log("Ping");
    }
}
