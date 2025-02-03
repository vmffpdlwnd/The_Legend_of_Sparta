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
        public string Name { get; }
        public string Job { get; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int Gold { get; set; }

        public Character(string name)
        {
            Name = name;
            Job = "전사";  // 직업 고정
            Level = 1;
            Attack = 10;
            Defense = 5;
            Health = 100;
            Gold = 1500;
        }
        public void DisplayStatus()
        {
            bool isStatusView = true;
            while (isStatusView)
            {
                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                Console.WriteLine($"Lv. {Level:D2}");
                Console.WriteLine($"{Name} ( {Job} )");
                Console.WriteLine($"공격력 : {Attack}");
                Console.WriteLine($"방어력 : {Defense}");
                Console.WriteLine($"체 력 : {Health}");
                Console.WriteLine($"Gold : {Gold} G");
                Console.WriteLine("0. 나가기");
                Console.Write("원하시는 행동을 입력해주세요.\n>>");

                string input = Console.ReadLine();
                if (input == "0")
                {
                    isStatusView = false;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
    }
}
