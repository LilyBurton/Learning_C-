using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class madLibs : MonoBehaviour
{
    private TextMeshProUGUI TextMeshPro;

    public bool statement = true;
    public string verb = "kill";
    public string noun = "policeman";
    public string adjective = "average";
    public int number = 10;
    public string pluralNoun = "Witnesses";
    public float percent = 101.5F;

    // Start is called before the first frame update
    void Start()
    {
        TextMeshPro = GetComponent<TextMeshProUGUI>();
        TextMeshPro.text = $"This statement is a {statement}. I did not {verb} the {noun}. I am not guilty. I am a {adjective} person. The act was performed by {number} wandering {pluralNoun}. I am {percent}% sure of this.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
