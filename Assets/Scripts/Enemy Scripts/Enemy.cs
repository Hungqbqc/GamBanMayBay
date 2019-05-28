using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed; // tốc độ máy bay địch

    private Rigidbody2D myBody;

    public AudioClip[] audioclip;
    public static int MucDoId = 1;

    [SerializeField]
    private GameObject bullet;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        StartCoroutine(EnemyShoot());
    }
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(0f, -enemySpeed); // cho máy bay di chuyển xuống dưới
    }

    // hàm bắn máy bay ngẫu nhiên của máy bay địch
    IEnumerator EnemyShoot()
    {
        //PlayShound(0); // tiếng đạn kêu
        Vector3 temp = transform.position;
        temp.y -= 0.5f;  // vẽ viên đạn
        Instantiate(bullet, temp, Quaternion.identity); // update vị trí viên đạn

        //yield return new WaitForSeconds(2 * Spawner.instance.GetDoKhoGame(Spawner.instance.diem)); // sau vài dây lại bắn tiếp
        yield return new WaitForSeconds(GetDoKhoGame(MucDoId) * 2); // sau vài dây lại bắn tiếp
        StartCoroutine(EnemyShoot());
    }

    void OnTriggerEnter2D(Collider2D target)
    {

        // nếu máy bay trạm trúng máy bay địch thì game over
        if (target.tag == "Player")
        {
            Destroy(target.gameObject);
            GamePlayController.instance.PlaneDiedShowPanel();
        }
        // nếu bay qua màn hình game thì tự hủy
        if (target.tag == "Border")
        {
            Destroy(gameObject);
        }
    }

    public float GetDoKhoGame(int MucDoId)
    {
        float tocDo = 1;
        if (MucDoId == 1)
        {
            tocDo = Random.Range(2f, 3f);
        }
        else if (MucDoId == 2)
        {
            tocDo = Random.Range(1.5f, 2f);

        }
        else if (MucDoId == 3)
        {
            tocDo = Random.Range(0.5f, 1f);
        }
        return tocDo;
    }

    //void PlayShound(int clip)
    //{
    //    GetComponent<AudioSource>().clip = audioclip[clip];
    //    GetComponent<AudioSource>().Play();
    //}
}
