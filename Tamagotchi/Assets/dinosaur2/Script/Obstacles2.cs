using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles2 : MonoBehaviour
{
    float maxTime;
    float timer;
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject obstacle5;
    public GameObject obstacle6;
    public GameObject obstacle7;
    public GameObject obstacle8;
    public GameObject obstacle9;

    int chooseObstacle;
    int Catusnumber;
    int Catusnumber2;
    // Start is called before the first frame update
    void Start()
    {
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= maxTime)
        {
            GenerateObstalcle();
            timer = 0;
        }
    }
    void GenerateObstalcle()
    {
       
        chooseObstacle = Random.Range(1, 7);
        if (chooseObstacle == 1)
        {
            Catusnumber = Random.Range(1, 4);
            if(Catusnumber == 1) { GameObject newObstacle = Instantiate(obstacle1); }
            if(Catusnumber == 2) { GameObject newObstacle = Instantiate(obstacle2); }
            if(Catusnumber == 3) { GameObject newObstacle = Instantiate(obstacle3); }
        }
        if (chooseObstacle == 2)
        {
            Catusnumber = Random.Range(1, 4);
            if(Catusnumber == 1) { GameObject newObstacle = Instantiate(obstacle4); }
            if(Catusnumber == 2) { GameObject newObstacle = Instantiate(obstacle5); }
            if(Catusnumber == 3) { GameObject newObstacle = Instantiate(obstacle6); }
        }
        if (chooseObstacle == 3)
        {
            Catusnumber = Random.Range(1, 4);
            if(Catusnumber == 1) { GameObject newObstacle = Instantiate(obstacle7); }
            if(Catusnumber == 2) { GameObject newObstacle = Instantiate(obstacle8); }
            if(Catusnumber == 3) { GameObject newObstacle = Instantiate(obstacle9); }
        }
        if (chooseObstacle == 4)
        {
            Catusnumber = Random.Range(1, 4);
            if(Catusnumber == 1) { GameObject newObstacle = Instantiate(obstacle1); }
            if(Catusnumber == 2) { GameObject newObstacle = Instantiate(obstacle2); }
            if(Catusnumber == 3) { GameObject newObstacle = Instantiate(obstacle3); }

            Catusnumber2 = Random.Range(1, 4);
            if(Catusnumber2 == 1) { GameObject newObstacle = Instantiate(obstacle4); }
            if(Catusnumber2 == 2) { GameObject newObstacle = Instantiate(obstacle5); }
            if(Catusnumber2 == 3) { GameObject newObstacle = Instantiate(obstacle6); }
        }
        if (chooseObstacle == 5)
        {
            Catusnumber = Random.Range(1, 4);
            if(Catusnumber == 1) { GameObject newObstacle = Instantiate(obstacle1); }
            if(Catusnumber == 2) { GameObject newObstacle = Instantiate(obstacle2); }
            if(Catusnumber == 3) { GameObject newObstacle = Instantiate(obstacle3); }

            Catusnumber2 = Random.Range(1, 4);
            if(Catusnumber2 == 1) { GameObject newObstacle = Instantiate(obstacle7); }
            if(Catusnumber2 == 2) { GameObject newObstacle = Instantiate(obstacle8); }
            if(Catusnumber2 == 3) { GameObject newObstacle = Instantiate(obstacle9); }
        }
        if (chooseObstacle == 6)
        {
            Catusnumber = Random.Range(1, 4);
            if(Catusnumber == 1) { GameObject newObstacle = Instantiate(obstacle7); }
            if(Catusnumber == 2) { GameObject newObstacle = Instantiate(obstacle8); }
            if(Catusnumber == 3) { GameObject newObstacle = Instantiate(obstacle9); }

            Catusnumber2 = Random.Range(1, 4);
            if(Catusnumber2 == 1) { GameObject newObstacle = Instantiate(obstacle4); }
            if(Catusnumber2 == 2) { GameObject newObstacle = Instantiate(obstacle5); }
            if(Catusnumber2 == 3) { GameObject newObstacle = Instantiate(obstacle6); }
        }

       
    }
}
