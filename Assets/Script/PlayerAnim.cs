using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    public Animator anim;
    private Player player;

    private void Awake()
    {
        player = GetComponent<Player>();
        player.wave += Player_Wave;

    }
    
    private void Player_Wave()
    {
        anim.SetTrigger("Wave");
    }

    void Update()
    {
        anim.SetFloat("Speed", player.speed);
    }
}
