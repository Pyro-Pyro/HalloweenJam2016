using UnityEngine;
using System.Collections;

public class robotMovement : MonoBehaviour {

    enum robotState { Roaming, Targetting, Attacking, InSight };

    private robotState bobState;
    private NavMeshAgent robotNav;
    private Light[] lights;

    // Use this for initialization
    void Start () {
        
        bobState = robotState.Roaming;
        robotNav = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {

        switch (bobState)
        {
            case robotState.Roaming:
            if(this.gameObject.transform.position == robotNav.destination)
                {
                    if(Random.Range(0,10) <= 5)
                    {
                        reTarget(false);
                    }else
                    {
                        reTarget(true);
                        bobState = robotState.Targetting;
                    }
                }

            break;

            case robotState.Targetting:

                if (lightOn())
                {
                    robotNav.destination = new Vector3(-1.75f, 0.5f, 14.0f);
                }else
                {
                    if (this.gameObject.transform.position == robotNav.destination)
                    {
                        if (Random.Range(0, 10) <= 8)
                        {
                            reTarget(false);
                        }
                        else
                        {
                            reTarget(true);
                            bobState = robotState.Targetting;
                        }
                    }
                }

            break;

            case robotState.Attacking:



            break;

            case robotState.InSight:



            break;
        }
	}

    private void reTarget(bool upperFloor)
    {
        float yPos;
        if (upperFloor)
        {
            yPos = 0.5f;
        }
        else
        {
            yPos = -13.0f;
        }

        while (robotNav.pathStatus == NavMeshPathStatus.PathPartial)
        {
            float xPos = Random.Range(-36.0f, 37.0f);
            float zPos = Random.Range(2.0f, 58.0f);

            robotNav.SetDestination(new Vector3(xPos, yPos, zPos));
        }

        return;
    }

    private bool lightOn()
    {
        for(int i = 0; i < lights.Length; i++)
        {
            if (!lights[i].enabled)
            {
                return false;
            }
        }

        return true;
    }
}
