namespace Player
{
    public class PlayerHealth : MonoBehaviour
    {
       [SerializeField] int currentHealth = 100;
       [SerializeField] int maxHealth = 100;
       [SerializeField] int healthPotionHeal = 20;
       [SerializeField] int healPotion = 5;
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
                    currentHealth = currentHealth + healthPotionHeal;
                    healthPotion--;
                    Debug.Log("Health has increased by 20");
                }
            }
        }
    }
}
