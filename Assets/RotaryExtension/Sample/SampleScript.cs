using RotaryInput;
using UnityEngine;
using UnityEngine.UI;

public class SampleScript : MonoBehaviour
{
    public Text TextRotaryDirection;

    private void Awake()
    {
        Debug.Log("Awake");
        Debug.Log(RotaryInputExtension.GetBezelInput().ToString());
    }

    private void Update()
    {
        TextRotaryDirection.text = RotaryInputExtension.GetBezelInput().ToString();
    }
}
