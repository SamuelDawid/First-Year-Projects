using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class HpDisplay : MonoBehaviour {

    TextMeshProUGUI health;
    Player player;

    private void Start()
    {
        health = GetComponent<TextMeshProUGUI>();
        player = FindObjectOfType<Player>();
    }
    private void Update()
    {
        health.text = ("Hp" + player.ReturnHP().ToString());
    }
}
