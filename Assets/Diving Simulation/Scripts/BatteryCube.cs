using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryCube : MonoBehaviour
{
    public InformationManager iM;
    private Vector3 originalSize;

    // Start is called before the first frame update
    void Start()
    {
        originalSize = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        float currentBatteryLevel = iM.GetBatteryLevel();
        float currentSize = Mathf.Lerp(0f, originalSize.x, currentBatteryLevel / iM.GetMaxBatteryLevel());

        this.transform.localScale = new Vector3(currentSize, currentSize, currentSize);
    }
}
