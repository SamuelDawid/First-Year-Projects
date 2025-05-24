using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigJosh : Enemies {

    public float stopDistance;
    public float backDistance;


    public void Update()
    {

        switch (CurrentState)
        {
            case State.MoveTorwords:

                if (Vector2.Distance(transform.position, target.transform.position) < stopDistance && Vector2.Distance(transform.position, target.transform.position) > backDistance)
                {
                    CurrentState = State.Stop;
                    return;
                }
                else if (Vector2.Distance(transform.position, target.transform.position) < backDistance)
                {
                    CurrentState = State.MoveAway;
                    return;
                }

                MovePlayer();

                break;

            case State.Stop:

                if (Vector2.Distance(transform.position, target.transform.position) > stopDistance)
                {
                    CurrentState = State.MoveTorwords;
                }
                else if (Vector2.Distance(transform.position, target.transform.position) < backDistance)
                {
                    CurrentState = State.MoveAway;
                }

                Stop();

                break;

            case State.MoveAway:

                if (Vector2.Distance(transform.position, target.transform.position) > backDistance)
                {
                    CurrentState = State.MoveTorwords;
                }

                RunAway();

                break;
        }
        Death();
        
    }

}

