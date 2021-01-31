using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TableScript : MonoBehaviour
{
    public GameObject[] table;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        GlobalVariables.ocurence[0] = 0;
        GlobalVariables.ocurence[1] = 0;
        GlobalVariables.ocurence[2] = 0;
        GlobalVariables.ocurence[3] = 0;
        GlobalVariables.ocurence[4] = 0;
        GlobalVariables.returned[0] = -1;
        GlobalVariables.returned[1] = -1;
        GlobalVariables.life = 8;
    }

    int emptyItemp()
    {
        int i = 0;
        foreach (GameObject obj in table) {
            if (obj) {
                ++i;
            }
        }
        print(i);
        return i;
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.returned[1] != -1 && GlobalVariables.returned[0] != -1 && GlobalVariables.returned[0] == GlobalVariables.returned[1]) {
            foreach (GameObject obj in table) {
                if (obj)
                    if (obj.GetComponent<ClicOnCard>().whoAmI == GlobalVariables.returned[1])
                        Destroy(obj);
            }
            GlobalVariables.returned[1] = -1;
            GlobalVariables.returned[0] = -1;
        }
        if (GlobalVariables.returned[1] != -1 && GlobalVariables.returned[0] != -1 && GlobalVariables.returned[0] != GlobalVariables.returned[1]) {
            foreach (GameObject obj in table) {
                if (obj) {
                    if (obj.GetComponent<ClicOnCard>().whoAmI == GlobalVariables.returned[1] && obj.GetComponent<ClicOnCard>().turn == true) {
                        obj.GetComponent<ClicOnCard>().turn = false;
                        obj.GetComponent<ClicOnCard>().spriteR.sprite = obj.GetComponent<ClicOnCard>().back;
                    }
                    if (obj.GetComponent<ClicOnCard>().whoAmI == GlobalVariables.returned[0] && obj.GetComponent<ClicOnCard>().turn == true){
                        obj.GetComponent<ClicOnCard>().turn = false;
                        obj.GetComponent<ClicOnCard>().spriteR.sprite = obj.GetComponent<ClicOnCard>().back;
                    }
                }
            }
            GlobalVariables.returned[1] = -1;
            GlobalVariables.returned[0] = -1;
            GlobalVariables.life -= 1;
            slider.GetComponent<Slider>().value--;
            if (GlobalVariables.life == 0)
                SceneManager.LoadScene("Loose", LoadSceneMode.Single);
        }
        if (emptyItemp() == 0)
            SceneManager.LoadScene("Win", LoadSceneMode.Single);
    }
}
