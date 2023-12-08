using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finish : MonoBehaviour
{
    public MeshRenderer kare1, kare2;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(kare1.material.name==kare2.material.name)
        {
            Debug.Log("Tebrikler renkler ayný");
            text.text = "Tebrikler renkler ayný";
        }
    }
}
