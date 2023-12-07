using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public struct ChessTile
    {
        public Vector2 tile;
        public string name;
        public int team;
        public ChessTile(Vector2 tile, string name, int team)
        {
            this.tile = tile;
            this.name = name;
            this.team = team;
        }
}
