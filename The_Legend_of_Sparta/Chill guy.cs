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

                Console.WriteLine("0. 나가기");
                Console.Write("\n당장 버튼을 \"0\"을 입력해 \n>>");

                string input = Console.ReadLine();
                if (input == "0")
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
    }
}
