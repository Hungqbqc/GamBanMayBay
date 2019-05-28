using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField]    // cho n hiện lên
	public GameObject enemy, rock;

	private BoxCollider2D box;
    private scoremanager gm;
    public static Spawner instance;
    void Awake()
	{
		box = GetComponent <BoxCollider2D> ();
        MakeInstance();
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () 
	{
		StartCoroutine (SpawnerEnemy());
		StartCoroutine (SpawnerRock());
    }

    // sinh ngẫu nhiên các máy bay địch
    IEnumerator SpawnerEnemy()
	{
        Debug.Log(Enemy.MucDoId);
		yield return new WaitForSeconds (Random.Range(1f, 3f));    // random 1-3s
		float minX = -box.bounds.size.x / 2f;   // lấy bên trái của khu sinh ra máy bay địch
		float maxX = box.bounds.size.x / 2f;    // lấy bên phải của khu sinh ra máy bay địch

        Vector3 temp = transform.position;  // lấy vị trí của máy bay
		temp.x = Random.Range (minX, maxX); // gán vị trí máy bay ngẫu nhiên
        Instantiate(enemy, temp, Quaternion.identity);// sinh ra máy bay

        StartCoroutine (SpawnerEnemy ());
	}

	IEnumerator SpawnerRock()
	{
        yield return new WaitForSeconds (GetDoKhoGame(Enemy.MucDoId));
		float minX = -box.bounds.size.x / 2f;
		float maxX = box.bounds.size.x / 2f;

		Vector3 temp = transform.position;
		temp.x = Random.Range (minX, maxX);
		Instantiate (rock, temp, Quaternion.identity);

		StartCoroutine (SpawnerRock ());
	}

    public float GetDoKhoGame(int MucDoId)
    {
        float tocDo = 1;
        if (MucDoId ==1)
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
}
