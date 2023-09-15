![ООП_лаб1-1](https://github.com/Roman784/OOPLab1/assets/79697765/52bfeb9a-28d0-4da4-879f-437f01e904f4)

Цель: получить практические навыки в создании программ,
содержащих определения классов и использующих объекты на языке
программирования C#.

```C#
public class Entity
    {
        private string name = "unnamed";
        private float movementSpeed = 0f;
        private int damage = 0;

        public Entity() { }
        public Entity(string name) : this(name, 0f, 0) { }
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
    }
```
 
![Screenshot_1916](https://github.com/Roman784/OOPLab1/assets/79697765/623b5b90-90ff-401f-ad57-64881809c6e5)

В данной программе я реализовал класс Entity – модель некой сущности с тремя полями: имя, скорость передвижения, урон. В классе также определены 3 конструктора и метод для вывода характеристик сущности в консоль. 

Благодаря перегрузке, в конструктор можно сообщить разный набор параметров, но при передаче только одного имени, автоматически будет вызываться ещё и третий конструктор, который дополнит оставшиеся нетронутые поля.

В методе Main я создаю 3 экземпляра класса Entity и вывожу их значения полей в консоль. 

Для установки начальных значений объекта можно также использовать конструкцию из фигурных скобок. Но в таком случае поле должно быть публичным.
```C#
Entity slime2 = new Entity() { name = "slime" };
```
