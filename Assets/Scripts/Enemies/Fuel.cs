using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A class which controls fuel behaviour
/// </summary>
public class Fuel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Description:
    /// This is meant to be called before destroying the gameobject associated with this script
    /// It can not be replaced with OnDestroy() because of Unity's inability to distiguish between unloading a scene
    /// and destroying the gameobject from the Destroy function
    /// Inputs: 
    /// none
    /// Returns: 
    /// void (no return)
    /// </summary>
    public void DoBeforeDestroy()
    {
        AddToFuelScore();
        IncrementFuelCollected();
    }

    /// <summary>
    /// Description:
    /// Adds to the game manager's variable that holds the fuel amount
    /// Input:
    /// None
    /// Returns:
    /// void (no return)
    /// </summary>
    private void AddToFuelScore()
    {
        if (GameManager.instance != null && !GameManager.instance.gameIsOver)
        {
            GameManager.AddToFuelScore(1);
        }
    }

    /// <summary>
    /// Description:
    /// Increments the game manager's number of fuel collected
    /// Input:
    /// none
    /// Return:
    /// void (no return)
    /// </summary>
    private void IncrementFuelCollected()
    {
        if (GameManager.instance != null && !GameManager.instance.gameIsOver)
        {
            GameManager.instance.IncrementFuelCollected();
        }
    }

    /// <summary>
    /// Description: 
    /// Standard Unity function called whenever a Collider2D enters any attached 2D trigger collider
    /// Inputs:
    /// Collider2D collision
    /// Returns:
    /// void (no return)
    /// </summary>
    /// <param name="collision">The Collider2D that set of the function call</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CollectFuel(collision.gameObject);
    }

    /// <summary>
    /// Description:
    /// This function collects fuel when the player object hits a fuel pellet
    /// Inputs:
    /// GameObject collisionGameObject
    /// Returns:
    /// void (no return)
    /// </summary>
    /// <param name="collisionGameObject">The game object that has been collided with</param>
    private void CollectFuel(GameObject collisionGameObject)
    {
        //Health collidedHealth = collisionGameObject.GetComponent<Health>();
        string playerTag = collisionGameObject.tag;
        if (collisionGameObject != null)
        {
            //collidedHealth.TakeDamage(damageAmount);
            if (playerTag == "Player")
            {
                //collidedHealth.UpdateHealthBar(collidedHealth.currentHealth);
                DoBeforeDestroy();
                Destroy(this.gameObject);
            }
        }
    }
}
