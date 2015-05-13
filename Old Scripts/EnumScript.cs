using UnityEngine;
using System.Collections;

enum TileState {Normal, Cracked, Broken, Hole, Grass, Poison, Water, DarkHole, Lava};
enum Owner {Red, Blue, Neutral};
enum EntityState {Floating, Underground, Flying, Normal};
enum HitboxState {Normal, Invincible, Invisible, Reduced};
enum EffectType {Stun, HoT, DoT};