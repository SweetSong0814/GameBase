using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 싱글턴 패턴
public class Managers : MonoBehaviour
{

    static Managers s_instance;

    static Managers Instance { get { Init(); return s_instance; } }

    public static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);              // Scene이 종료되도 파괴 되지 않게 처리
            s_instance = go.GetComponent<Managers>();
        }
    }

    PoolManagers _pool = new PoolManagers();
    public static PoolManagers Pool { get { return Instance ?._pool; } }


}