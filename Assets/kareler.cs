using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kareler : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer ressam;
    public Material sar�,mavi,ye�il,k�rm�z�,turuncu;
    public AudioSource renkSesi;

    void Start()
    {
        ressam = GetComponent<MeshRenderer>();
        RenkVer();
        renkSesi.Play();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Space))
        {
            RenkVer();
            renkSesi.Play();
        }
    }

    void RenkVer()
    {
        int rastgele = Random.Range(1, 6);

        switch (rastgele)
        {
            case 1:
                ressam.material = sar�;
                break;
            case 2:
                ressam.material = mavi;
                break;
            case 3:
                ressam.material = turuncu;
                break;
            case 4:
                ressam.material=k�rm�z�;
                break;
            case 5:
                ressam.material = ye�il;
                break;
        }
    }
}
