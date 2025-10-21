using UnityEngine;
using TMPro;
using UnityEditor.EditorTools;
public class text : MonoBehaviour
{
    public GameObject texthatmakesfunofyou;
    public GameObject othertext;
    public GameObject previoustext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        texthatmakesfunofyou.SetActive(false);
        othertext.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        previoustext.SetActive(false);
        texthatmakesfunofyou.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        texthatmakesfunofyou.SetActive(false);
        othertext.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
