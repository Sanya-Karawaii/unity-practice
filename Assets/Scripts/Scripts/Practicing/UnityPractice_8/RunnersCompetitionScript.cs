using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnersCompetitionScript : MonoBehaviour
{
    [SerializeField] public GameObject Runner1;
    [SerializeField] public GameObject Runner2;
    [SerializeField] public GameObject Runner3;
    [SerializeField] public GameObject Runner4;

    [SerializeField] public GameObject Stick;


    private GameObject MainRunner;
    private GameObject LastRunner;
    private GameObject FirstRunner;

    public float Speed;

    public bool ToPoint;
    public bool ToRunner;
    public bool RestartCycle;

    int i1 = 1;
    int i2 = 0;

    float PassDistance;

    private Vector3 NextPosition;
    private Vector3 NextPoint;

    public Vector3[] RunnerPositions = { new Vector3(0.43f, -1.83f, 0.47f), new Vector3(2.89f, 0.11f, 0.47f), new Vector3(-0.81f, 3.05f, 0.47f), new Vector3(-3.15f, 1.15f, 0.47f) };
    public Vector3[] AdditionalPositions = { new Vector3(2.4f, -2.23f, 0.47f), new Vector3(1.13f, 0.98f, 0.47f), new Vector3(-2.53f, 2.37f, 0.47f), new Vector3(-1.48f, -0.97f, 0.47f) };

    void Start()
    {
        NextPosition = RunnerPositions[i1];
        NextPoint = AdditionalPositions[i2];
        MainRunner = Runner1;
        LastRunner = Runner4;
        FirstRunner = Runner1;

        ToPoint = true;
        ToRunner = false;
    }

    void Update()
    {
        PassDistance = Vector3.Distance(MainRunner.transform.position, NextPosition);
        Stick.transform.SetParent(MainRunner.transform);

        if (ToPoint)
        {
            MainRunner.transform.position = Vector3.MoveTowards(MainRunner.transform.position, NextPoint, Speed);

        }
        
        if (ToRunner)
        {
            if (PassDistance < 0.09)
            {
                ToRunner = false;
                ToPoint = true;
            }
            MainRunner.transform.position = Vector3.MoveTowards(MainRunner.transform.position, NextPosition, Speed);

                
        }

        if (PassDistance < 0.09)
        {
            i1++;

            NextPosition = RunnerPositions[i1];

            if (MainRunner == Runner1 && RestartCycle == false)
            {
                MainRunner = Runner2;
            }
            else if (MainRunner == Runner2 && RestartCycle == false)
            {
                MainRunner = Runner3;
            }
            else if(MainRunner == Runner3 && RestartCycle == false)
            {
                MainRunner = Runner4;
            }
            else if (MainRunner == Runner4 && RestartCycle == false)
            {
                MainRunner = Runner1;
            }

            if (i1 == RunnerPositions.Length - 1 )
            {
                i1 = -1;
            }

            if (i1 == 0)
            {
                RestartCycle = true;
            }


            if (RestartCycle)
            {
                Restart();
            }



        }


        if (MainRunner.transform.position == NextPoint)
        {
            i2++;
            NextPoint = AdditionalPositions[i2];
            ToPoint = false;
            ToRunner = true;

            if (i2 == AdditionalPositions.Length - 1)
            {
                i2 = -1;
            }
        }


    }

    public void Restart()
    {
        if ( i2 == 1 )
        {

            if (LastRunner == Runner4)
            {
                FirstRunner = Runner1;
                LastRunner = Runner3;
            }
            else if (LastRunner == Runner3)
            {
                FirstRunner = Runner4;
                LastRunner = Runner2;
            }
            else if (LastRunner == Runner2)
            {
                FirstRunner = Runner3;
                LastRunner = Runner1;
            }
            else if (LastRunner == Runner1)
            {
                FirstRunner = Runner2;
                LastRunner = Runner4;
            }

                MainRunner = FirstRunner;
                RestartCycle = false;
        }
    }
}
