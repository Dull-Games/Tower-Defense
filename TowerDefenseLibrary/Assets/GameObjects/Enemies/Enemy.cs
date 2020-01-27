using System;

namespace Assets.GameObjects.Enemies
{
    public class Enemy
    {
        private string name;
        private EnemyType type;
        private int health;
        private int speed;

        public Enemy(string name, EnemyType type, int health = 1, int speed = 1)
        {
            this.name = name;
            this.type = type;
            this.health = health;
            this.speed = speed;
        }

        public void Move()
        {

        }
    }
}