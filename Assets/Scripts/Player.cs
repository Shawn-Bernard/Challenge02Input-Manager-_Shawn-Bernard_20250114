using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI Text;

    public Image UIColor;

    public Light _light;
    public void Performed()
    {
        //Making my object smaller by subtracting vector(1,1,1) each time
        transform.localScale -= Vector3.one;

        //if my object vector scale is equal to vector(0,0,0)
        if (transform.localScale == Vector3.zero)
        {
            //then transform my object scale equal to my new vector
            transform.localScale = new Vector3(4, 4, 4);
        }
        
    }
    public void Started()
    {
        //Making my text to read active
        Text.text = "active";
        //Changing my image ui to the color green
        UIColor.color = Color.green;
        //Changing my light to the color green
        _light.color = Color.green;

    }
    public void Canceled()
    {
        //Making my text to read deactivated
        Text.text = "deactivated";
        //Changing my image ui to the color red
        UIColor.color = Color.red;
        //Changing my light to the color red
        _light.color = Color.red;
    }
    
    private void OnEnable()
    {
        //Adding my method to my action events
        Actions.PerformedEvent += Performed;
        Actions.StartedEvent += Started;
        Actions.CanceledEvent += Canceled;
    }
    private void OnDisable()
    {
        //Taking my methods out of my action events
        Actions.PerformedEvent -= Performed;
        Actions.StartedEvent -= Started;
        Actions.CanceledEvent -= Canceled;
    }

}
