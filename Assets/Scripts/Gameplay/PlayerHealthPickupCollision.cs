using Platformer.Mechanics;
using Platformer.Core;
using UnityEngine;

public class PlayerHealthPickupCollision : Simulation.Event<PlayerHealthPickupCollision>
{
    public HealthPickup pickup;
    public PlayerController player;

    public override void Execute()
    {
        pickup.gameObject.SetActive(false);
        player.health.Increment();
        AudioSource.PlayClipAtPoint(pickup.tokenCollectAudio, pickup.transform.position);
    }
}