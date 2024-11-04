using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using TMPro;

public class NextPiece : MonoBehaviour
{
    public Tilemap nextPieceTilemap;
    public Vector3 displayOffset = new Vector3(8.47f, 7.49f, 0.3f);

    public void DisplayNextPiece(TetrominoData nextPieceData)
    {
        // �nceki par�ay� temizleyin
        nextPieceTilemap.ClearAllTiles();

        // Par�ay� 4x4 gridin ortas�na yerle�tirmek i�in float offset kullan�n
        Vector3 centerOffset = new Vector3(-0.48f, -1.75f, 0f); // Par�ay� biraz sa�a ve a�a�� kayd�r�n

        // Yeni par�ay� gride yerle�tirin
        foreach (Vector3Int cell in nextPieceData.cells)
        {
            // H�cre pozisyonunu Vector3'e �evir ve offset uygula
            Vector3 adjustedPosition = cell + centerOffset;

            // Sonucu yuvarlayarak Vector3Int'e �evir ve tile'� yerle�tir
            Vector3Int finalPosition = Vector3Int.RoundToInt(adjustedPosition);
            nextPieceTilemap.SetTile(finalPosition, nextPieceData.tile);
        }
    }
}





