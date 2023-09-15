using System;

public class Program
{
    public class Entity
    {
        private string name = "unnamed";
        private float movementSpeed = 0;
        private int damage = 0;

        public Entity() { }
        public Entity(string name) : this(name, 0, 0) { }
        public Entity(string name, float movementSpeed, int damage)
        { 
            this.name = name;
            this.movementSpeed = movementSpeed;
            this.damage = damage;
        }

        // Выводит значения полей в консоль.
        public void ShowStats()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Скорость: {movementSpeed}");
            Console.WriteLine($"Урон: {damage} \n");
        }
    }

    public static void Main(string[] args)
    {
        // Создаём 3 объекта с разными параметрами и выводим их значения.
        Entity slime = new Entity("Слизь", 3f, 2);
        Entity spider = new Entity("Паук");
        Entity skeleton = new Entity();

        slime.ShowStats();
        spider.ShowStats();
        skeleton.ShowStats();

        //Entity slime2 = new Entity() { name = "slime" };
    }
}