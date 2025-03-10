using UnityEngine;
namespace Player
{
    public class PlayerHealth : MonoBehaviour
    {
       [SerializeField] int currentHealth = 100;
       [SerializeField] int maxHealth = 100;
       [SerializeField] int healthPotionHeal = 20;
       [SerializeField] int healthPotion = 5;
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                if (currentHealth == maxHealth)
                {
                    Debug.Log("Your health is already at max!");
                }
                else
                {
                    if (healthPotion == 0)
                    {
                        Debug.Log("You are out of health potions!");
                    }
                    else
                    {
                        currentHealth = currentHealth + healthPotionHeal;
                        healthPotion--;
                        Debug.Log("Health has increased by 20");
                        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                currentHealth -= 15;

                currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

                if (currentHealth == 0)
                {
                 Debug.Log("You are dead");
                }
            }
            
        }
      

    }
}
