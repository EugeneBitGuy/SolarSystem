using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TMPFadeOut : MonoBehaviour
{
    public TextMeshProUGUI tmpComponent;
    public float timeToFade;
    public float time;

    private void Start()
    {
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;

        tmpComponent.alpha = Mathf.Lerp(tmpComponent.alpha, 0, Time.deltaTime);

        if(time > timeToFade)
            Destroy(gameObject);
    }
}
