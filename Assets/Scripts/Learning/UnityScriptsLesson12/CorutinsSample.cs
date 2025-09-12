using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorutinsSample : MonoBehaviour
{
    private void Start()
    {
        Coroutine coroutine = StartCoroutine(timer());         //����� ������ Coroutine
        StopCoroutine(coroutine);
        //CorutinsSample.StopAllCoroutines();
    }
    private IEnumerator timer()          //����������� ������ Coroutine
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1);         //������� ����������� ���������� �������� ������ ��� �������. WaitForSeconds ���������� ������� �����
            yield return new WaitForSecondsRealtime(1); //WaitForSecondsrealtime ���������� �������� �����
            yield return null; //�������� ����� ����������� ���� ��� �� �����
            Debug.Log(i);        
        }
        //Debug.Log("Ping");
    }
}
