using UnityEngine;

public class dissapearingact : MonoBehaviour
{
    public GameObject ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ball.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        ball.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
