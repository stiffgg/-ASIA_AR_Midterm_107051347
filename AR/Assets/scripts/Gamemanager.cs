using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [Header("樹巨人")]
    public Transform treestone;
    [Header("綠巨人")]
    public Transform greenstone;
    [Header("虛擬搖桿")]
    public FixedJoystick Joystick;
    [Header("旋轉速度"), Range(0.1f, 20f)]
    public float turn = 2f;
    [Header("縮放"), Range(0f, 5f)]
    public float siz = 0.3f;
    [Header("樹巨人動畫元件")]
    public Animator anitreestone;
    [Header("綠巨人動畫元件")]
    public Animator anigreenstone;



    private void Start()
    {
        print("開始事件執行中");

    }
    private void Update()
    {
        print("更新事件");
        print(Joystick.Vertical);
        treestone.Rotate(0, Joystick.Horizontal * 2f, 0);
        greenstone.Rotate(0, Joystick.Horizontal * 2f, 0);
        treestone.localScale += new Vector3(1, 1, 1) * Joystick.Vertical;
        greenstone.localScale += new Vector3(1, 1, 1) * Joystick.Vertical;
        treestone.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(treestone.localScale.x, 0.5f, 3.5f);
        greenstone.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(greenstone.localScale.x, 0.5f, 3.5f);

    }
    public void Attack()
    {
        print("進攻");
        anitreestone.SetTrigger("攻擊觸發");
        anigreenstone.SetTrigger("攻擊觸發");


    }
    public void Death()
    {
        print("死亡");
        anitreestone.SetTrigger("死亡觸發");
        anigreenstone.SetTrigger("死亡觸發");
    }
    public void Provocative()
    {
        print("挑釁");
        anitreestone.SetTrigger("挑釁觸發");
        anigreenstone.SetTrigger("挑釁觸發");
    }
}


