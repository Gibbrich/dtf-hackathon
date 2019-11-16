using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/LevelConfiguration")]
public class LevelConfiguration : ScriptableObject
{
    public int RowCount;
    public int ColumnCount;
    public Vector2Int LevelEnter;
    public Vector2Int LevelExit;
    public GameObject EnemyPrefab;
    public GameObject ResourcePrefab;
    public List<Vector2Int> EnemiesPositions;
    public List<Vector2Int> ResourcesPositions;
}
