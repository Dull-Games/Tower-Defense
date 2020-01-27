using System;

public class Enemy
{
	string name;
	string type;
	int health;
	int speed;

	Path path;
	
	public Enemy(Path path)
	{
		this.path = path;
	}

	void Move()
	{

	}
}
