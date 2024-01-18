using UnityEngine;

public class Seed : MonoBehaviour
{
    public Sprite[] growthStages; // Array of sprites representing different growth stages
    private int currentStage = 0;  // Index of the current growth stage
    private float growthInterval = 7f; // Time interval between growth stages in seconds
    private Player player; // Reference to the Player script

    private void Start()
    {
        player = FindObjectOfType<Player>(); // Find the Player script in the scene
        if (player == null)
        {
            Debug.LogError("Player script not found in the scene.");
        }

        InvokeRepeating("GrowSeed", growthInterval, growthInterval);
    }

    private void Update()
    {
        if (player != null && Vector2.Distance(transform.position, player.transform.position) < 2.0f && Input.GetKey(KeyCode.E) && currentStage >= growthStages.Length -1)
        {
            Destroy(gameObject);

            if (player != null)
            {
                player.AddMoney(1);
            }
            else
            {
                Debug.LogError("Player script reference is null.");
            }
        }
    }

    private void GrowSeed()
    {
        // Check if there are more growth stages
        if (currentStage < growthStages.Length - 1)
        {
            // Increment the current growth stage
            currentStage++;

            // Change the sprite to the next growth stage
            GetComponent<SpriteRenderer>().sprite = growthStages[currentStage];
        }
        else
        {
            
        }
    }
}