using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicOnCard : MonoBehaviour
{
    public bool turn = false;
    // public Animator animator;
    public int whoAmI = 0;
    public SpriteRenderer spriteR;
    public Sprite back;
    public Sprite eyeL;
    public Sprite eyeR;
    public Sprite mouseL;
    public Sprite mouseR;
    public Sprite noise;
    //public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        //spriteR.sprite = front;
        //spriteR = obj.GetComponent<SpriteRenderer>();
        turn = false;
        int i = Random.Range(0, 5);
        while (GlobalVariables.ocurence[i] > 1)
            i = Random.Range(0, 5);
        GlobalVariables.ocurence[i]++;
        whoAmI = i;
        print(GlobalVariables.ocurence[i]);        
    }
    void OnMouseUp()
    {
        if (turn == false) {
            if (whoAmI == 0)
                spriteR.sprite = eyeL;
            else if (whoAmI == 1)
                spriteR.sprite = eyeR;
            else if (whoAmI == 2)
                spriteR.sprite = mouseL;
            else if (whoAmI == 3)
                spriteR.sprite = mouseR;
            else
                spriteR.sprite = noise;
    
            if (GlobalVariables.returned[0] == -1)
                GlobalVariables.returned[0] = whoAmI;
            else if (GlobalVariables.returned[1] == -1)
                GlobalVariables.returned[1] = whoAmI;
            // animator.Play("Card_animation");
            turn = true;
        }
        //else {
        //    spriteR.sprite = back;
        //    // animator.Play("Card_animation");
        //}
        // Debug.Log("bonjour");
    }
    // Update is called once per frame
    void Update()
    {

        // if(Input.GetMouseButton(0)) {
        //     turn = !turn;
        // }
        // if (animator.GetCurrentAnimatorStateInfo(0).IsTag("1") == false && turn == true) {
        //     //print("a");
        //     spriteR.sprite = front;
        // }
        // if (animator.GetCurrentAnimatorStateInfo(0).IsTag("1") == false && turn == false) {
        //     //print("b");
        //     //spriteR = gameObject.GetComponent<SpriteRenderer>();
        //     //
        //     spriteR.sprite = back;
        //     //print(back);
        // }
    }
}
