using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//观察者模式的类！
public class GameEventSystem : IGameSystem {
	public GameEventSystem(PBaseDefenseGame thePBaseDefenseGame) : base(thePBaseDefenseGame) { }
}
