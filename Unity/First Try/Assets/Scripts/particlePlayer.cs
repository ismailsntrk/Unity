
using UnityEngine;

public class particlePlayer : MonoBehaviour
{
    public ParticleSystem particle;
    public Transform player;
    public Material playerMat;
    
 

    

    private void Update()
    {
        transform.position = player.position;
        particle.startColor = playerMat.color;

    }

}
