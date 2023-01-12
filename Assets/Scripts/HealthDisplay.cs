using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    Player player;
    [SerializeField] GameObject playerScript;
    public Text valueHealth;
        

    // Start is called before the first frame update
    void Start()
    {
        player = playerScript.GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
    valueHealth.text = player.Health.ToString();
    }
}
