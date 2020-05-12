using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreDisplay;
    private PlayerController player;

    PlatformerModel model = Simulation.GetModel<PlatformerModel>();

    void Start()
    {
        scoreDisplay = GetComponent<Text>();
    }

    void Update()
    {
        player = model.player;
        scoreDisplay.text = player.currentScore.ToString();
    }
}