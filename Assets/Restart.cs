using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public Gamekit2D.InventoryController PlayerInv;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(PlayerInv.HasItem("Key1") && PlayerInv.HasItem("Key2") && PlayerInv.HasItem("Key3"))
            {
                this.RestartLevel();
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            this.RestartLevel();
           
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
