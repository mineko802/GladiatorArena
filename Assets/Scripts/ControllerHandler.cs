using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerHandler : MonoBehaviour
{
    public List<InputDevice> joinDevices = new List<InputDevice>();
    public GameObject PlayerObject = null;

    //1.　ゲーム開始時に接続されているコントローラーを変数joinDevicesに格納
    //3.  作ったオブジェクトをコントローラーと接続する
    void Start()
    {
        //foreach は配列のような複数個変数がある場合に使える
        //配列の先頭から変数の中身を一つずつ取得する
        foreach (var device in InputSystem.devices)
        {
            if (!(device.name == "Keyboard" || device.name == "Mouse"))
            {
                Debug.Log(device.name);

                //変数joinDevicesにデバイス情報を追加
                joinDevices.Add(device);
            }
        }
        JoinPlayer();
    }
    //2.　変数joinDevicesに格納されている数だけプレイヤーオブジェクトを生成する
    void JoinPlayer()
    {
        //変数joinDevicesの数だけプレイヤーオブジェクトを生成
        foreach (var device in joinDevices)
        {
            //PlayerObjectを生成
            PlayerInput.Instantiate(PlayerObject, pairWithDevice: device);
        }
    }
}
