using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CollectItem : MonoBehaviour
{
    
    /// <summary>
    /// アイテム取得処理
    /// </summary>
    public void OnCollect(InputValue value)
    {
        // 取得可能なアイテムを探す（例: Raycast）
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, 3f))
        {
            if (hit.collider.CompareTag("Item"))
            {
                Debug.Log($"アイテム取得: {hit.collider.name}");
                Destroy(hit.collider.gameObject); // 実際はインベントリに追加など
            }
        }
    }
}
