using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace The_Legend_of_Sparta
{
    public class Chill_guy
    {
        public void DisplayChillguy()
        {
            bool isChillguy = true;
            while (isChillguy)
            {
                Console.Clear();
                Console.WriteLine("오 나의 스삣삐, 마침내 나를 찾아왔군.");
                Console.WriteLine("진정한 강자의 힘을 알려주지, 스삣삐.");
                Console.WriteLine("어떤 공격도 'miss', 어떤 장비든 완벽한 착용.\n");
                Console.WriteLine("스삣삐, 이건 스파르타만이 아는 비밀이다.");
                Console.WriteLine("모든 상점에서 85%의 할인된 가격에 받을 수 있지.");
                Console.WriteLine("함께 정상을 향해 가자, 스삣삐.\n");
                Console.WriteLine("이것이 내가 너를 기다린 이유다, 스삣삐.\n");

                Console.WriteLine("1. 새로운 기능 테스트");
                Console.WriteLine("0. 나가기");
                Console.Write("\n당장 버튼을 \"0\"을 입력해 \n>>");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("스삣삐.. 여긴 기능을 테스트 하는곳이야");
                    Thread.Sleep(5000);

                    Console.Write("아무 버튼이나 눌러라 스삣삐.\n>>");
                    Console.ReadLine(); // 사용자 입력 대기
                    return;
                }
                else if (input == "0")
                {
                    isChillguy = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못 눌렀잖아 스삣삐!!!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
        public void Show_me_the_money(Character player)
        {
            Console.Clear();
            Thread.Sleep(500);

            Console.Write("S");
            Thread.Sleep(500);
            Console.Write("H");
            Thread.Sleep(500);
            Console.Write("O");
            Thread.Sleep(500);
            Console.Write("W");
            Thread.Sleep(1000);

            Console.Write(" ");
            Thread.Sleep(500);
            Console.Write("M");
            Thread.Sleep(500);
            Console.Write("E");
            Thread.Sleep(1000);

            Console.Write(" ");
            Thread.Sleep(500);
            Console.Write("T");
            Thread.Sleep(500);
            Console.Write("H");
            Thread.Sleep(500);
            Console.Write("E");
            Thread.Sleep(1000);

            Console.Write(" ");
            Thread.Sleep(500);
            Console.Write("M");
            Thread.Sleep(500);
            Console.Write("O");
            Thread.Sleep(500);
            Console.Write("N");
            Thread.Sleep(500);
            Console.Write("E");
            Thread.Sleep(500);
            Console.WriteLine("Y");
            Thread.Sleep(1000);

            bool isMoney = true;
            while (isMoney)
            {
                Console.Clear();
                Console.WriteLine("SHOW ME THE MONEY");

                Console.WriteLine("\n스삣삐, 넌 특별해. 내 진정한 동료가 될 자격이 있어.");
                Console.WriteLine("챔피언의 특권을 나누어주지. 500골드를 받아가도록 해.");
                Console.WriteLine("이건 우리들만의 비밀이야, 스삣삐.");
                Console.WriteLine("더 강해져서 돌아오도록. *묵직하게 끄덕임*\n");

                Console.WriteLine("1. 보상을 받는다 ");
                Console.WriteLine("0. 거절한다.\n>>");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("완벽해, 스삣삐.");
                    Console.WriteLine("이제 진정한 챔피언의 길을 걷게 될 거야.");

                    Console.Write("아무 버튼이나 눌러라 스삣삐.\n>>");
                    player.Gold += 500;
                    Console.ReadLine(); // 사용자 입력 대기
                    isMoney = false;
                }
                else if (input == "0")
                {
                    Console.WriteLine("흠... 스삣삐.");
                    Console.WriteLine("진정한 강함을 거부하다니 예상치 못했군.");
                    Console.WriteLine("하지만 네 선택을 존중하지. 그것도 챔피언의 자격이니까.");

                    Console.Write("아무 버튼이나 눌러라 스삣삐.\n>>");
                    Console.ReadLine(); // 사용자 입력 대기
                    isMoney = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("잘못 눌렀잖아 스삣삐!!!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }   

    }
}
