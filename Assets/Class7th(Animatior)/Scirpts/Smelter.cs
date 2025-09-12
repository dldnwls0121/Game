using UnityEngine;

public class Smelter : MonoBehaviour
{
    [SerializeField] float progress;
    [SerializeField] int count;
    public void Success()
    {
       //Debug.Log("성공");
    }

    public void Process(float progress)
    {
        this.progress += progress;

        if (this.progress >= 100)
        {
            Debug.Log($"강화 진행도 : {this.progress} 성공했습니다"  );
            this.progress = 0.0f;
        }
        else
        {
            Debug.Log("강화 진행도 : " + this.progress);
        }
    }

    public void Enhance(int count)
    {
        this.count += count;
        Debug.Log("강화 횟수 : " + this.count);
    }

}
