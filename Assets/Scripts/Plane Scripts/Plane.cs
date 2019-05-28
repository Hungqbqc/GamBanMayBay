using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour 
{
	public float planeSpeed;
	private Rigidbody2D myBody;
    public Sprite[] mayBayDaChon;
    private scoremanager gm;
    public static int mayBayId = 0;
    //	public AudioClip[] audioClip;

    [SerializeField]
	private GameObject bullet;
	private bool canShoot = true;

	void Awake () 
	{
		myBody = GetComponent<Rigidbody2D> ();
        gm = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<scoremanager>();
        gameObject.GetComponent<SpriteRenderer>().sprite = mayBayDaChon[mayBayId];
    }

    void FixedUpdate () 
	{
		PlaneMovement ();
	}
	void Update()
	{
        // nếu bấm phím Space thì bắn đạn
		if (Input.GetKey (KeyCode.Space))
		{
			if (canShoot) 
			{
				StartCoroutine (Shoot ());
			}
		}
	}
    /// <summary>
    /// hàm máy bay di chuyển
    /// </summary>
	void PlaneMovement()
	{
		float xAxis = Input.GetAxisRaw ("Horizontal") * planeSpeed; // di chuyển theo chiều ngang
		float yAxis = Input.GetAxisRaw ("Vertical") * planeSpeed;// di chuyển theo chiều dọc
        myBody.velocity = new Vector2 (xAxis, yAxis);   // gán tọa độ đã di chuyển
	}

    // hàm bắn viên đạn sau 1 khoảng thời gian
	IEnumerator Shoot()
	{
		canShoot = false;
        Vector3 temp = transform.position;
        temp.y += 0.4f;  // vẽ viên đạn
        Instantiate(bullet, temp, Quaternion.identity); // update vị trí viên đạn
		yield return new WaitForSeconds (1f);
		canShoot = true;
        StartCoroutine(Shoot());
    }

}
