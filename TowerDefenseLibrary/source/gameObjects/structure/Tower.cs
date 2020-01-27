using System;
using Building;

public class Tower : Building
{
	private string name;
	private string type;
	private int damage;
	private int range;
	private int speed;

	public Tower(string name, string type, int damage = 1, int range = 1, int speed = 1)
	{
		this.name = name;
		this.type = type;
		this.damage = damage;
		this.range = range;
		this.speed = speed;
	}

	public void Shoot()
	{

	}

	List<Enemy> FindEnemiesInRange()
  {

  }
}
