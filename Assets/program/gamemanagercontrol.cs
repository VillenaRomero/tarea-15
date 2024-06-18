using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanagercontrol : MonoBehaviour
{
    public Text textPoints;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        IncreasePoints(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreasePoints(int pointstoAdd) {
        points = points + pointstoAdd;
        textPoints.text = "PUNTOS: " + points;
    }
}
