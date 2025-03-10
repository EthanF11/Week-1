namespace Player
{
    public class PlayerHealth : MonoBehaviour
    {
       [SerializeField] public int currentHealth = 100;
       [SerializeField] public int maxHealth = 100;
       [SerializeField] public int healthPotionHeal = 20;
       [SerializeField] public int healPotion = 5;
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
