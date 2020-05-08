using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlockDescriptionItem", menuName = "Krakout/BlockDescriptions", order = 1)]
public class BlockDescription : ScriptableObject
{
    public int KickCount;
    public Sprite[] Sprites;
    public int Score;
}
public class Block : MonoBehaviour
{
    [SerializeField] private BlockDescription _blockDescription;
    [SerializeField] private int CurrentKickCount = 0;
    public void InitializationBlock(BlockDescription blockDescription)
    {
        _blockDescription = blockDescription;
        CurrentKickCount = 0;
    }

    public int KickBlock()
    {
        if (++CurrentKickCount >= _blockDescription.KickCount)
        {
            // todo animation destroy object
            Destroy(gameObject);
            return _blockDescription.Score;
        }
        // todo animation kick object
        return -1;
    }
}
