using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalVariables
{
    public static int[] ocurence = {0, 0, 0, 0, 0};
    public static int[] returned = {-1, -1};
    public static int life = 5;
}

public class FirstToGlobal : MonoBehaviour
{
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
        GlobalVariables.life = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
