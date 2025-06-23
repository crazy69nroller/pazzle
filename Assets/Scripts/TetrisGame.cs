using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisGame : MonoBehaviour
{
    // ボードの幅
    public int width = 10;
    // ボードの高さ
    public int height = 20;
    // ボードの状態を保持する配列
    private Transform[,] grid;

    void Start()
    {
        // グリッドを初期化
        grid = new Transform[width, height];
    }

    // ブロックがボード内に収まっているかチェック
    public bool IsValidPosition(Transform tetromino)
    {
        foreach (Transform mino in tetromino)
        {
            Vector2 pos = Round(mino.position);
            if (!InsideBoard(pos))
            {
                return false;
            }
        }
        return true;
    }

    // 位置を丸める
    Vector2 Round(Vector2 pos)
    {
        return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
    }

    // ボード内か判定
    bool InsideBoard(Vector2 pos)
    {
        return ((int)pos.x >= 0 && (int)pos.x < width && (int)pos.y >= 0);
    }
}
