using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject Border;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log("You Died");
        if (collision.gameObject.name == "Player")
        {
            StartCoroutine(ShowDeathInfo());
            
            StartCoroutine(TeleportAfterDelay(collision.gameObject));
        }
        
    }

    private IEnumerator ShowDeathInfo()
    {
        Border.SetActive(true);
        yield return new WaitForSeconds(3);
        Border.SetActive(false);
    }
    private IEnumerator TeleportAfterDelay(GameObject player)
    {
        yield return new WaitForSeconds(3);

        if (player != null)
        {
            if(PlayerPrefs.HasKey("SavePoint1"))
            {
                player.transform.position = new Vector2(37, 0);
            }
            else
            {
                player.transform.position = new Vector2(-8, -1);
            }
            
        }
    }
}
