using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CHarcterManager : MonoBehaviour
{

    public Demons Demon;

    public Text NameText;

    public Text HpText;

    public Text SpText;

    // Start is called before the first frame update
    void Start()
    {
        Demon.Awake();
    }

    // Update is called once per frame
    void Update()
    {
        NameText.text = Demon.Name;
        HpText.text = Demon.health.ToString();
        SpText.text = Demon.Sp.ToString();
    }

}