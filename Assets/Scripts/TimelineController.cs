using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{

    public PlayableDirector playableDirector;
    private string _currentState;


    public void swing()
    {
        _currentState = "swing";
        Debug.Log(_currentState);
        playableDirector.initialTime = 2;
        playableDirector.Play();
    }

    public void idle() {
        _currentState = "idle";
        Debug.Log(_currentState);
        playableDirector.initialTime = 0;
        playableDirector.Play();

    }

    void Update()
    {
       
        if (_currentState==null) {
            idle(); 
        }

        if (Input.GetKeyDown("w"))
        {
            if(_currentState== "idle") {
                playableDirector.Stop();
                swing();
            }
            else
            {
                playableDirector.Stop();
                swing();
            }
                   
        }

        if ((_currentState=="swing")&&(playableDirector.time > 3)) {
            playableDirector.Stop();
            idle();
        }

        if ((_currentState == "idle") && (playableDirector.time > 1)) {
            playableDirector.Stop();
            idle();
        }

    }
}

