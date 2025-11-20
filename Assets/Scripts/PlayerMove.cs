using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    //プレイヤーの入力を受け取るための関数
    private void OnMove(InputValue value)
    {
        //受け取った値をオブジェクトに渡す（オブジェクトの移動）
        Vector2 axis = value.Get<Vector2>();

        //自身のPositionを変数に保持（現在位置の記録）
        Vector2 PlayerVector = this.transform.position;

        //記録した位置に入力された値を加算して新しい位置を計算
        PlayerVector += axis;
        this.transform.position = axis;
    }
}
