using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallLighting : MonoBehaviour
{
    UnityEngine.Rendering.Universal.Light2D SpotLight;
    void Start()
    {
        if (GameModeSetter.GameMode == "Flashlight" || GameModeSetter.GameMode == "FlashlightHard"){
            StartCoroutine(LightCoroutine());
        }
        
    }

    IEnumerator LightCoroutine()
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        yield return new WaitForSeconds(1);

        SpotLight = GetComponent<UnityEngine.Rendering.Universal.Light2D>();
        SpotLight.intensity = 1f;

        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
