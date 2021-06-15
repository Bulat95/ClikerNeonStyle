using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatMover : MonoBehaviour
{
    public Transform[] blocks;
    public Vector3 axis;
    public float tileSize;
    public float speed;

    private Vector3 _start;
    private int[] _cid;
    private float _pre = 0f;

    void Awake()
    {
        _start = blocks[0].position;
        _cid = new int[blocks.Length];
        for (int i = 0; i < blocks.Length; ++i)
            _cid[i] = i;
    }

    void Update()
    {
        float re = Mathf.Repeat(Time.time * speed, tileSize);
        bool over = (re < _pre);
        _pre = re;
        for (int i = 0; i < blocks.Length; ++i)
        {
            if (over)
            {
                _cid[i] = (_cid[i] + 1) % _cid.Length;
            }
            blocks[i].position = _start + (axis * _cid[i] * tileSize) + (axis * re);
        }
    }
}
