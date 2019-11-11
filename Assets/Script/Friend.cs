using System.Collections;
using System;
using UnityEngine;

public class Friend : MonoBehaviour
{
    bool playerInRange;
    public GameObject particleEffect;
   

    public event Action wave;
    private bool waving;
    float waveDuration = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Wave();
    }
    public void Wave()
    {
        if (playerInRange == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                StartCoroutine(Waveing());
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInRange = true;
            Debug.Log("inBound");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInRange = false;
            Debug.Log("Out of reach");
        }
    }
    private IEnumerator Waveing()
    {
        wave?.Invoke();
        waving = true;
        Instantiate(particleEffect, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waveDuration);

        waving = false;
    }

}
