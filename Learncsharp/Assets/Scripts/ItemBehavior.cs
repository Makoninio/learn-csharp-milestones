using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    // 1
    public GameBehavior gameManager;

    void Start()
    {
        // 2
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }
    void OnCollisionEnter(Collision collision)
    {
        // 2
        if(collision.gameObject.name == "Player")
        {
            // 3
            Destroy(this.transform.parent.gameObject);
            // 4
            Debug.Log("Item collected!");
            // 3
            gameManager.Items += 1;
        }
    }
}
