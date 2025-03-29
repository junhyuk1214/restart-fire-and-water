using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;  // 싱글톤 인스턴스
    public bool isPlayerDead = false;      // 플레이어 생사 여부

    private void Awake()
    {
        // 게임 매니저 인스턴스가 하나만 존재하도록 보장
        if (gameManager == null)
        {
            gameManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 예시: 플레이어가 죽었을 때 호출할 함수
    public void PlayerDied()
    {
        isPlayerDead = true;
        // 추가적으로 게임 종료 처리나 사망 애니메이션 등을 구현할 수 있습니다.
    }

    // 예시: 플레이어가 부활할 때 호출할 함수
    public void PlayerRevived()
    {
        isPlayerDead = false;
        // 추가적으로 부활 처리나 애니메이션 등을 구현할 수 있습니다.
    }
}
