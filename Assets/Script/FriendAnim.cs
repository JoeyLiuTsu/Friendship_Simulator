using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendAnim : MonoBehaviour
{
    public Animator anim;
    private Friend friend;
    void Start()
    {
        friend = GetComponent<Friend>();
        friend.wave += Friend_Wave;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Friend_Wave()
    {
        anim.SetTrigger("Wav");
    }
}
