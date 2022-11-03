using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrewmateNames : MonoBehaviour
{

    private Text textBox;
    public CallTowerManager ctm;

    // Start is called before the first frame update
    void Start()
    {
        textBox = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CrewInfo[] crewInformation = ctm.GetCrewmatesInformation();
        string crewText = "";

        foreach (CrewInfo currCrewmate in crewInformation)
        {
            string currName = currCrewmate.name;
            string currPosition = currCrewmate.worldLocation.ToString();
            crewText = crewText + currName + " " + currPosition + "\n";
        }

        textBox.text = crewText;
    }
}