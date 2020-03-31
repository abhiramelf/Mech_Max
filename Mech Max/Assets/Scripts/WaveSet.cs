using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSet : MonoBehaviour
{
    public bool firstWaveSet;
    public bool secondWaveSet;
    public bool thirdWaveSet;

    // Start is called before the first frame update
    void Start()
    {
        firstWaveSet = false;
        secondWaveSet = false;
        thirdWaveSet = false;
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "First")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                firstWaveSet = true;
                secondWaveSet = false;
                thirdWaveSet = false;
            }
        }

        else if (col.gameObject.tag == "Second")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                firstWaveSet = false;
                secondWaveSet = true;
                thirdWaveSet = false;
            }
        }

        else if (col.gameObject.tag == "Third")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                firstWaveSet = false;
                secondWaveSet = false;
                thirdWaveSet = true;
            }
        }
    }
}
