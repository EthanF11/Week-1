using UnityEngine;

public class CongratsYouAreBetterThanYandereDev : MonoBehaviour
{
    int number = 199;
    bool isOn = true;
    void Start()
    {
        //if number divided by 2 is equal to 0 remainder
        if (number % 2 == 0)
        {
            Debug.Log("Even");
        }
        else
        {
            Debug.Log("Odd");
        }

        isOn = false;
        isOn = true;
        isOn = !isOn;

        if (isOn != true)
        {

        }
        if (isOn == false)
        {

        }
        if (isOn)
        {

        }
        if (!isOn)
        {

        }
       
    }    
}
