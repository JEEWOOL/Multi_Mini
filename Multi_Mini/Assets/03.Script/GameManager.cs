using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public Image bomb_CoolTime;
    public GameObject bombCoolTime;
    public Image shield_CoolTime;
    public GameObject shieldCoolTime;
    public Slider hp_Slider;
    public GameObject dBP;

    ///////////////////////////////////////////////

    private void Awake()
    {
        // ���� ��ġ ������ �迭�� ����
        Transform[] points = GameObject.Find("SpawnPointGroup").GetComponentsInChildren<Transform>();
        int idx = Random.Range(1, points.Length);

        // ��Ʈ��ũ�� ĳ���� ����
        PhotonNetwork.Instantiate("Player", points[idx].position, points[idx].rotation, 0);
    }
}
