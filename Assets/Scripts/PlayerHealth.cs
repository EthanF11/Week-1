using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int Current_Health = 100;
     int Max_Health = 100;
        range[0 - 100];
     int Health_Potions = 5;
        int Health_Potion_Heal = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
            if (Current_Health = Max_Health)
                Debug.Log("Your health is already at max!");
        return;
                 else (Current_Health = Current_Health + Health_Potion_Heal);
                     Health_Potion_Heal = Health_Potion_Heal - 1;
    Debug.Log("Health has increased by 20");
    }
}
