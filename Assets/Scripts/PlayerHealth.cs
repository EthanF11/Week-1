namespace Player
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField]
        int Current_Health = 100;
        int Max_Health = 100;
        int Health_Potions = 5;
        int Health_Potion_Heal = 20;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                if (Current_Health == Max_Health)
                    Debug.Log("Your health is already at max!");
                return;
            }
            else
            {
                (Current_Health =+ Health_Potions);
                Health_Potion = Health_Potion - 1;
                Debug.Log("Health has increased by 20");
            }
        }
    }
}
