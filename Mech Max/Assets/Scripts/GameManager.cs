using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject firstWave;
    public GameObject secondWave;
    public GameObject thirdWave;

    public WaveSet setWave;

    // Start is called before the first frame update
    void Start()
    {
        firstWave.SetActive(false);
        secondWave.SetActive(false);
        thirdWave.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (setWave.firstWaveSet)
        {
            firstWave.SetActive(true);
            secondWave.SetActive(false);
            thirdWave.SetActive(false);
        }

        else if (setWave.secondWaveSet)
        {
            firstWave.SetActive(false);
            secondWave.SetActive(true);
            thirdWave.SetActive(false);
        }

        else if (setWave.thirdWaveSet)
        {
            firstWave.SetActive(false);
            secondWave.SetActive(false);
            thirdWave.SetActive(true);
        }
    }
}
