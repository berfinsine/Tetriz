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
        // Önceki parçayý temizleyin
        nextPieceTilemap.ClearAllTiles();

        // Parçayý 4x4 gridin ortasýna yerleþtirmek için float offset kullanýn
        Vector3 centerOffset = new Vector3(-0.48f, -1.75f, 0f); // Parçayý biraz saða ve aþaðý kaydýrýn

        // Yeni parçayý gride yerleþtirin
        foreach (Vector3Int cell in nextPieceData.cells)
        {
            // Hücre pozisyonunu Vector3'e çevir ve offset uygula
            Vector3 adjustedPosition = cell + centerOffset;

            // Sonucu yuvarlayarak Vector3Int'e çevir ve tile'ý yerleþtir
            Vector3Int finalPosition = Vector3Int.RoundToInt(adjustedPosition);
            nextPieceTilemap.SetTile(finalPosition, nextPieceData.tile);
        }
    }
}





