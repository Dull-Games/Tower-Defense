using System;
using System.Collections.Generic;
using Assets.GameObjects.Enemies;

namespace Assets.GameObjects.Structures
{
	public class Tower : Building
	{
		private string name;
		private TowerType type;
		private int damage;
		private int range;
		private int speed;

		public Tower(string name, TowerType type, int damage = 1, int range = 1, int speed = 1)
		{
			this.name = name;
			this.type = type;
			this.damage = damage;
			this.range = range;
			this.speed = speed;
		}

		public void Shoot()
		{
			throw new NotImplementedException();
		}

		public List<Enemy> FindEnemiesInRange()
		{
			throw new NotImplementedException();
		}
	}
}