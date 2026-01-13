using UnityEngine;

public class DataManager : MonoBehaviour
{
    // public으로 그냥 인스턴스를 관리하면 보안상 취약
    private static DataManager instance = null;
    
    public static DataManager Instance
    {
        get
        {
            if(instance == null)
            {
                return null;
            }
            return instance;
        }
    }

    private void Awake()
    {
        // 씬이 전환되어도 파괴되지 않음
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        // 인스턴스가 이미 존재(유일성 보장)
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void Save()
    {
        print("저장 완료!");
    }
}
