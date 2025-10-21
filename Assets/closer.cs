using System;
using UnityEngine;

public class closer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
