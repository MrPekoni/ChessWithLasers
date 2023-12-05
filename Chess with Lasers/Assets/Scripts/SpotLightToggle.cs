using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }
    public void ToggleSpotLight()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
