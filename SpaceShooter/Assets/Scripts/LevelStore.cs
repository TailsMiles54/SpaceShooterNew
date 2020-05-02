using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "New levels", menuName = "Scriptable Object/New Levels")] // выпадающее меню редактора "Create"
public class LevelStore : ScriptableObject { 

    public GameStoreItems[] Levels;
}

[System.Serializable]
public class GameStoreItems {
    public string LevelName;
    public int NeededScore;
}