using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public Light _light;
    public void Scale()
    {
        transform.localScale += new Vector3(-1, -1, -1);
    }
    public void Move()
    {
        transform.position += new Vector3(0,1,0);
    }
    public void Light()
    {
        _light.intensity += 10;
        _light.color = Color.yellow;
        if (_light.intensity == 20)
        {
            _light.intensity = 0;
        }
        
    }
    private void OnEnable()
    {
        Actions.JumpEvent += Scale;
        Actions.CanceledEvent += Move;
        Actions.StartedEvent += Light;
    }
    private void OnDisable()
    {
        Actions.JumpEvent -= Scale;
        Actions.CanceledEvent -= Move;
        Actions.StartedEvent -= Light;
    }

}
