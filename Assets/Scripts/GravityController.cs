using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    // 重力加速度
    const float Gravity = 9.81f;
    
    // 重力の適用具合
    public float gravityScale = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 重力方向のベクトルの初期化
        Vector3 vector = new Vector3();
        
        // Unityエディタと実機で処理を分ける
        // エディタの場合
        if(Application.isEditor)
        {
            // キーの入力を検知し、ベクトルを設定
            vector.x = Input.GetAxis("Horizontal");
            vector.z = Input.GetAxis("Vertical");
        
            // 高さ方向の判定はキーのzとする
            if(Input.GetKey("z"))
            {
                vector.y = 1.0f;
            }
            else
            {
                vector.y = -1.0f;
            }
        }
        // 実機の場合
        else
        {
            // 加速度センサの入力をUnity空間の軸にマッピングする
            vector.x = Input.acceleration.x;
            vector.z = Input.acceleration.y;
            vector.y = Input.acceleration.z;
        }
        // シーンの重力を入力ベクトルの方向に合わせて変化させる
        Physics.gravity = Gravity * vector.normalized * gravityScale;
    }
}
