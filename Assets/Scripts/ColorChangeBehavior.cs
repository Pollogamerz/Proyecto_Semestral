using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChangeBehavior : MonoBehaviour
{
    System.Random rand;

    public Text infoLabel;

    // Start is called before the first frame update
    void Start()
    {
        rand = new System.Random(2000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonColorChange()
    {
        infoLabel.color = new Color(rand.Next(), rand.Next(), rand.Next());
    }
}
