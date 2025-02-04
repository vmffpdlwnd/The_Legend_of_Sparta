using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace The_Legend_of_Sparta
{
    internal class Program
    {
        static Character player;
        static Chill_guy Chill_guy;
        static Inventory Inventory;
        static Shop Shop;

        static void Main(string[] args)
        {
            bool isNameConfirmed = false;
            Chill_guy = new Chill_guy();

            while (!isNameConfirmed)
            {
                Console.WriteLine("태초마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이름을 입력해 주세요.");
                Console.Write(">>");
                string playerName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(playerName))  // "", " ", "   " 등 모든 공백 케이스 처리
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                Console.WriteLine($"당신의 이름은 {playerName} 입니까?");
                Console.WriteLine("1. 저장");
                Console.WriteLine("2. 취소");
                Console.Write(">>");
                string confirmInput = Console.ReadLine();

                
                if (confirmInput == "1")
                {
                    player = new Character(playerName);
                    Inventory = new Inventory(player);
                    player.SetInventory(Inventory);
                    Shop = new Shop(player, Inventory);
                    isNameConfirmed = true;
                }
                else if (confirmInput == "2")
                {
                    Console.Clear();
                    continue;
                }
                else if (confirmInput == "3" || confirmInput == "")
                {
                    playerName = "GigaChad";
                    player = new Character(playerName);
                    Inventory = new Inventory(player);
                    player.SetInventory(Inventory);
                    Shop = new Shop(player, Inventory);
                    isNameConfirmed = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                GameLoop();
            }
        }
        static void GameLoop()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                ShowMainMenu();
            }
        }
        static void ShowMainMenu()
        {
            Console.WriteLine("태초마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            if (player.Name == "GigaChad")
            {
                Console.Clear();
                Console.WriteLine("오, 스삣삐. 넌 튜토리얼 필요없지?");
                Console.WriteLine("내가 너를 위해 새로운 선택창을 추가했어");
            }
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            if (player.Name == "GigaChad")
            {
                Console.WriteLine("6. ???");
                Console.WriteLine("7. Chill guy  <= 당장 이걸 선택해! 스삣삐");
            }

            Console.WriteLine("0. 나가기");
            Console.Write("원하시는 행동을 입력해주세요.\n>>");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //상태 보기
                    Console.Clear();
                    player.DisplayStatus();
                    break;
                case "2":
                    // 인벤토리 
                    Console.Clear();
                    Inventory.DisplayInventory();
                    break;
                case "3":
                    //상점
                    Console.Clear();
                    Shop.DisplayShop();
                    break;
                case "4":
                    //던전입장
                    Console.Clear();
                    Console.WriteLine("던전입장은 준비중 입니다.");
                    Console.Write("아무 버튼을 눌러주세요.\n>>");
                    Console.ReadLine(); // 사용자 입력 대기
                    break;
                case "5":
                    //휴식하기
                    Console.Clear();
                    Console.WriteLine("휴식하기는 준비중 입니다.");
                    Console.Write("아무 버튼을 눌러주세요.\n>>");
                    Console.ReadLine(); // 사용자 입력 대기
                    break;
                case "6" when player.Name == "GigaChad":
                    //???
                    Chill_guy.Show_me_the_money();
                    break;
                case "7" when player.Name == "GigaChad":
                    //Chill guy
                    Chill_guy.DisplayChillguy();
                    break;
                case "0":
                    Console.Clear();
                    Console.WriteLine("정말로 종료하시겠습니까?");
                    Console.WriteLine("1. 예");
                    Console.WriteLine("2. 아니오");
                    Console.Write(">>");
                    string exitChoice = Console.ReadLine();

                    if (exitChoice == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("게임을 종료합니다.");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.Clear();  // 메인 메뉴로 돌아가기
                    }
                    break;
                default:
                    if (player.Name == "GigaChad")
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
                    break;
            }
        }
    }
}