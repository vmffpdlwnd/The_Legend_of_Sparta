using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace The_Legend_of_Sparta
{
    public class Dungeon
    {
        readonly int[] recommendedDefense = { 5, 11, 17, 30 };  // 각 난이도별 권장 방어력
        readonly int[] Rewards = { 500, 800, 1000, 3000};  // 각 난이도별 기본 보상
        Random random = new Random();

        public void DisplayDungeon(Character player)
        {
            bool isDungeonOpen = true;
            while (isDungeonOpen)
            {
                Console.Clear();
                Console.WriteLine("던전입장");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");
                Console.WriteLine("[내 상태]");
                Console.WriteLine($"체력 : {player.Health}");
                Console.WriteLine($"공격력 : {player.Attack + player.PlusAttack}");
                Console.WriteLine($"방어력 : {player.Defense+ player.PlusDefense}\n");
                Console.WriteLine("[던전 목록]");
                Console.WriteLine($"1. 쉬운 던전   | 방어력 {recommendedDefense[0]} 이상 권장");
                Console.WriteLine($"2. 일반 던전   | 방어력 {recommendedDefense[1]} 이상 권장");
                Console.WriteLine($"3. 어려운 던전 | 방어력 {recommendedDefense[2]} 이상 권장");
                Console.WriteLine($"4. 매우 어려운 던전 | 방어력 {recommendedDefense[3]} 이상 권장");
                Console.WriteLine("0. 나가기");

                Console.Write("\n원하는 행동을 입력해주세요.\n>>");
                string input = Console.ReadLine();

                if( input == "0")
                {
                    isDungeonOpen = false;
                    continue;
                }

                if (int.TryParse(input, out int index) && index > 0 && index <= 4)
                {
                    if (player.Health <= 1)
                    {
                        Console.WriteLine("체력이 부족하여 던전에 도전할 수 없습니다.");
                        Thread.Sleep(1000);
                        continue;
                    }

                    EnterDungeon(player, index - 1);
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                }
            }
        }
        void EnterDungeon(Character player, int dungeonLevel)
        {
            Console.Clear();
            Console.Write("던전 진행중.");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.WriteLine(".");

            int playerDefense = player.Defense + player.PlusDefense;
            int recommendDef = recommendedDefense[dungeonLevel];

            bool success;
            if (playerDefense< recommendDef)
            {
                success = random.Next(100) >= 40;
            }
            else
            {
                success = true;
            }

            int HealthDecrease = random.Next(20, 35);
            int defDiff = recommendDef - playerDefense;
            int healthDecrease = Math.Max(1, HealthDecrease + defDiff);

            if(success)
            {
                int playerAttack = player.Attack + player.PlusAttack;
                double bonusPercent = random.Next(playerAttack, playerAttack * 2 + 1) / 100.0;
                int reward = (int)(Rewards[dungeonLevel] * (1 + bonusPercent));

                Console.WriteLine("\n던전 클리어!\n");
                Thread.Sleep(1000);
                Console.WriteLine($"체력 {healthDecrease} 감소");
                Console.WriteLine($"보상: {reward} G");

                player.Health -= healthDecrease;
                player.Gold += reward;

                player.DungeonClearCount++;

                if (player.CheckLevelUp())
                {
                    player.LevelUP();
                    player.DungeonClearCount = 0;
                    Console.WriteLine($"\n레벨 업! {player.Level - 1} -> {player.Level}");
                    Console.WriteLine("공격력 +0.5, 방어력 +1 증가!");
                }
            }
            else
            {
                Console.WriteLine("\n던전 실패\n");
                Thread.Sleep(1000);
                Console.WriteLine($"체력 {healthDecrease / 2} 감소");

                player.Health -= healthDecrease / 2;
            }

            Thread.Sleep(2000);
        }
    }
}
