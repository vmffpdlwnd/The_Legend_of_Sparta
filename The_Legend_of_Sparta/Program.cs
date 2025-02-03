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

                Console.WriteLine($"당신의 이름은 {playerName} 입니까?");
                Console.WriteLine("1. 저장");
                Console.WriteLine("2. 취소");
                Console.Write(">>");
                string confirmInput = Console.ReadLine();

                if (playerName == "")
                {
                    playerName = "GigaChad";
                }

                if (confirmInput == "1")
                {
                    player = new Character(playerName);
                    isNameConfirmed = true;
                }
                else if (confirmInput == "2")
                {
                    Console.Clear();
                    continue;
                }
                else if (confirmInput == "3")
                {
                    playerName = "GigaChad";
                    player = new Character(playerName);
                    isNameConfirmed = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못된 입력입니다.");
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
                Console.WriteLine("오, 스삣삐");
                Console.WriteLine("내가 너를 위해 새로운 선택창을 추가했어");
                Console.WriteLine("당장 선택해! 스삣삐");
            }
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            if (player.Name == "GigaChad")
            {
                Console.WriteLine("");
                Console.WriteLine("7. Chill guy");
            }

            Console.WriteLine("0. 나가기");
            Console.Write("원하시는 행동을 입력해주세요.\n>>");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Clear();
                    player.DisplayStatus();
                    break;
                case "2":
                    // 인벤토리 
                    Console.Clear();
                    Console.WriteLine("인벤토리는 준비중 입니다.");
                    Console.WriteLine("0. 나가기");
                    Console.Write("원하시는 행동을 입력해주세요.\n>>");
                    Console.ReadLine(); // 사용자 입력 대기
                    break;
                case "3":
                    //상점
                    Console.Clear();
                    Console.WriteLine("상점은 준비중 입니다.");
                    Console.WriteLine("\n0. 나가기");
                    Console.Write("원하시는 행동을 입력해주세요.\n>>");
                    Console.ReadLine(); // 사용자 입력 대기
                    break;
                case "7" when player.Name == "GigaChad":
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
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}