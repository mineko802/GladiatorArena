using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float MoveSpeed = 0.1f;
    //プレイヤーの入力を受け取るための関数
    private void OnMove(InputValue value)
    {
        //受け取った値をオブジェクトに渡す（オブジェクトの移動）
        Vector2 axis = value.Get<Vector2>();

        //自身のPositionを変数に保持（現在位置の記録）
        Vector3 PlayerVector = this.transform.position;

        Vector3 updatePlayerPosition = new Vector3(
           PlayerVector.x + axis.x * MoveSpeed,
           PlayerVector.y,
           PlayerVector.z + axis.y * MoveSpeed);

        //記録した位置に入力された値を加算して新しい位置を計算
        this.transform.position = updatePlayerPosition;
    }
}
