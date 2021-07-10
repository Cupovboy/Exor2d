using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class BttnManager : MonoBehaviour{
private int turno;
public Button b1;
public Button b2;
public Button b3; 
public Button b4;
public Text txt;
public CHarcterManager cm1;
public CHarcterManager cm2;
private int num;

    // Start is called before the first frame update
    void Start()
    {
        b1.GetComponentInChildren<Text>().text = cm1.Demon.powers[0].name;
        b2.GetComponentInChildren<Text>().text = cm1.Demon.powers[1].name;
        b3.GetComponentInChildren<Text>().text = cm1.Demon.powers[2].name;
        b4.GetComponentInChildren<Text>().text = cm1.Demon.powers[3].name;
        turno = 0;
     
    }

    // Update is called once per frame
    void Update()
    {

        if (cm1.Demon.health <= 0)
        {
            SceneManager.LoadScene(2);
        }

        if (cm2.Demon.health <= 0)
        {
            SceneManager.LoadScene(3);
        }
        if (turno % 2 == 0)
        {
            b1.enabled = true;
            b2.enabled = true;
            b3.enabled = true;
            b4.enabled = true;

        }
        else
        {
            b1.enabled = false;
            b2.enabled = false;
            b3.enabled =false;
            b4.enabled = false;
       
            num = Random.Range(0, 4);

            if (cm2.Demon.powers[num].cost <= cm2.Demon.Sp)
            {
                cm1.Demon.health -= cm2.Demon.powers[num].potency;

                cm2.Demon.Sp -= cm2.Demon.powers[num].cost;
                txt.text = cm2.Demon.Name + " uso " + cm2.Demon.powers[num].name;
                turno += 1;

            }
            else
            {
                cm1.Demon.health -= cm2.Demon.powers[0].potency;

                cm2.Demon.Sp -= cm2.Demon.powers[0].cost;
                txt.text = cm2.Demon.Name + " uso " + cm2.Demon.powers[0].name;
                turno += 1;

            }

        }
    }


    public void onclick(int num)
    {
        if (cm1.Demon.powers[num].cost <= cm1.Demon.Sp)
        {
            if (cm1.Demon.powers[num].type=="dmg")
            {
                cm2.Demon.health -= cm1.Demon.powers[num].potency;
                
            }
            else
            {
                cm1.Demon.health += cm1.Demon.powers[num].potency;
            }

            cm1.Demon.Sp -= cm1.Demon.powers[num].cost;
            txt.text = cm1.Demon.Name + " uso " + cm1.Demon.powers[num].name;
            turno += 1;

        }
        else
        {
            txt.text = " Te falta Sp";

        }
    }
}
