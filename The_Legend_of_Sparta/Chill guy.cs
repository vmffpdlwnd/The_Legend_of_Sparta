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
                Console.WriteLine("오 나의 스삡삐. 드디어 여길 봐줬구나");
                Console.WriteLine("널 위해 난 무슨 말이든 해줄수 있지만,");
                Console.WriteLine("그렇다고 너가 변하는건 아니야. 하지만!");
                Console.WriteLine("스삣삐.. 난 너에게 새로운 정보를 줄 수있어.");

                Console.WriteLine("나 GigaChad는 최강이야!");
                Console.WriteLine("어떤 공격이든 \"miss\" 뜨게하고");
                Console.WriteLine("어떤 장비든 제한없이 착용할 수 있지!");

                Console.WriteLine("스삣삐 이건 비밀인데");
                Console.WriteLine("난 특별히 상점에서 85% 할인을 받을수 있어.");
                Console.WriteLine("상점을 마음껏 이용하자고 스삣삐");

                Console.WriteLine("스삣삐... 난 이 말을 해줄려고 이곳으로 널 불렀어\n");

                Console.WriteLine("0. 나가기");
                Console.Write("당장 버튼을 \"0\"을 입력해 \n>>");

                string input = Console.ReadLine();
                if (input == "0")
                {
                    isChillguy = false;
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
