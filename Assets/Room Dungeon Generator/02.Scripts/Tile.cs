using UnityEngine;
using System.Collections;
using ooparts.dungen;

namespace ooparts.dungen
{
	public class Tile : MonoBehaviour
	{
		public IntVector2 Coordinates;

		public void Start()
		{
			if (RoomMapManager.TileSize > 0)
				transform.localScale *= RoomMapManager.TileSize;
		}
	}
}
