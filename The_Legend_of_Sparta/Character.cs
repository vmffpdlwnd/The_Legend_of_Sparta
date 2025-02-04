using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace The_Legend_of_Sparta
{
    public class Character
    {
        private Inventory Inventory;

        public string Name { get; }
        public string Job { get; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int PlusAttack { get; set; }
        public int Defense { get; set; }
        public int PlusDefense { get; set; }
        public int Health { get; set; }
        public int Gold { get; set; }
        public int DungeonClearCount { get; set; }

        public Character(string name)
        {
            Name = name;
            Job = "전사";
            Level = 1;
            Attack = 10;
            Defense = 5;
            PlusAttack = 0;
            PlusDefense = 0;
            Health = 100;
            Gold = 1500;
            DungeonClearCount = 0;
        }

        public void SetInventory(Inventory inventory)
        {
            this.Inventory = inventory;
        }

        public void DisplayStatus()
        {
            bool isStatusView = true;

            while (isStatusView)
            {
                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");

                Console.WriteLine($"Lv. {Level:D2}");
                Console.WriteLine($"{Name} ( {Job} )");
                Console.WriteLine($"공격력 : {Attack+PlusAttack} {(PlusAttack > 0 ? $" (+{PlusAttack})" : "")}");
                Console.WriteLine($"방어력 : {Defense+PlusDefense} {(PlusDefense > 0 ? $" (+{PlusDefense})" : "")}");
                Console.WriteLine($"체 력 : {Health}");
                Console.WriteLine($"Gold : {Gold} G\n");

                Console.WriteLine("0. 나가기\n");

                Console.Write("원하시는 행동을 입력해주세요.\n>>");

                string input = Console.ReadLine();
                if (input == "0")
                {
                    isStatusView = false;
                }
                else
                {
                    if (Name == "GigaChad")
                    {
                        Console.Clear();
                        Console.WriteLine("잘못 눌렀잖아 스삣삐!!!");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("잘못된 입력입니다.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
            }
        }
        public void UpdateStats()
        {
            PlusAttack = 0;
            PlusDefense = 0;

            foreach (var item in Inventory.GetEquippedItems())
            {
                if (item.Type == ItemType.Armor || item.Type == ItemType.Cloak)
                {
                    PlusDefense += item.Power;
                }
                else
                {
                    PlusAttack += item.Power;
                }
            }
        }
        public void LevelUP()
        {
            Level += 1;
            if( Level % 2 == 0 )
            {
                Attack += 1;
            }
            Defense += 1;
        }
        public bool CheckLevelUp()
        {
            int requiredClears = Level;
            return DungeonClearCount >= requiredClears;
        }
    }
}
