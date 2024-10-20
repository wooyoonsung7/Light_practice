using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightEffect : MonoBehaviour
{
    public Light flashlight;
    public float intensity = 1f;

    void Start()
    {
        // 플래시라이트 기본 세팅
        flashlight.type = LightType.Spot;
        flashlight.range = 10f;
        flashlight.spotAngle = 45f;
        flashlight.intensity = intensity;
        flashlight.enabled = true; // 처음엔 켜진 상태로 시작
    }

    void Update()
    {
        // F키를 눌러서 플래시라이트 켜기/끄기
        if (Input.GetKeyDown(KeyCode.F))
        {
            flashlight.enabled = !flashlight.enabled;
        }
    }
}
