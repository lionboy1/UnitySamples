using UnityEngine;

public class Collectible : MonoBehaviour
{
    Player player;
    void Start()
    {
        
        player = GameObject.Find("Player").GetComponent<Player>();
        if(player == null)
        {
            Debug.Log("No player component found");
        }
    }

    
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            player.AddCoins();

        }
    }
}
