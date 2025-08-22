using UnityEngine;
using TMPro;

public class Distancia : MonoBehaviour
{
    private TMP_Text distanciaText;
    public GameObject Terra;
    public GameObject Meteor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        distanciaText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(Terra.transform.position, Meteor.transform.position) * 10000 - 7840;
        distanciaText.text = "Distancia: " + distancia.ToString("F0") + "Km";
    }
}
