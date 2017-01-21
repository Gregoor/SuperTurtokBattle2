using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerWaveLength : MonoBehaviour
{
    private int length = 50;                          
    public Slider waveGauge;

    public int player;

    private string dir = "forward";


    void Update()
    {
        if (Input.GetAxis("Shoot player " + player) > 0)
        {
            if (dir.Equals("forward"))
            {
                length += 1;

                if (length == 100) dir = "backward";
            }

            if (dir.Equals("backward"))
            {
                length -= 1;

                if (length == 0) dir = "forward";
            }


            waveGauge.value = (int)length;
        }
        else
        {
            length = 50;
            dir = "forward";
            waveGauge.value = 50;
        }
    }
}