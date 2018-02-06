using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidejas
{
    class Player
    {
        public int health { get; }
        public int x { get; set; }
        public int y { get; set; }
        public int speed { get; set; }

        public Player(int x, int y, int health)
        {
            this.x = x;
            this.y = y;
            this.health = health;
        }

        public void Paejo(int X, int Y)
        {
            x += X;
            y += Y;
        }

        public virtual void Nematom()
        {
            Console.WriteLine("Nematau");
        }
    }

    class Good_Player : Player
    {
        public int armor_class { get; }
        public int mana;

        public Good_Player(int armor_class, int x, int y, int health) : base(x, y, health)
        {
            this.armor_class = armor_class;
        }

        public override void Nematom()
        {
            base.Nematom();
            Console.WriteLine("Dark vision");
        }
    }

    class Enemy : Player
    {
        public int age { get; }

        public Enemy(int x, int y, int health, int armor_class, int age) : base(x, y, health)
        {
            this.age = age;
            base.x = x + 10;
        }

        public override void Nematom()
        {
            base.Nematom();

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Enemy priesas = new Enemy(10, 20, 100, 18, 21);
            Good_Player zaidejas = new Good_Player(20, 20, 20, 120);
            zaidejas.Paejo(12, 10);
            priesas.Paejo(30, 14);
            Console.WriteLine(zaidejas.x + " " + zaidejas.y);
            zaidejas.Nematom();
            priesas.Nematom();
        }
    }
}
