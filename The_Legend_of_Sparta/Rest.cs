using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace The_Legend_of_Sparta
{
    public class Rest
    {
        
        public void DisplayRest(Character Player)
        {
            bool isRest = false;
            const int REST_PRISE = 500;
            while (!isRest)
            {
                Console.WriteLine("휴식하기");
                Console.WriteLine($"{REST_PRISE} G 를 내면 체력을 회복할 수 있습니다. (보유 골드 : {Player.Gold} G)");

                Console.WriteLine("1. 휴식하기");
                Console.Write("0. 나가기\n>>");

                string input = Console.ReadLine();
                if (input == "1" && Player.Name == "GigaChad")
                {
                    if(Player.Health == 100)
                    {
                        Console.WriteLine("스삣삐, 이게 무슨 소리야. 체력이 넘치잖아.");
                        Console.WriteLine("약한 마음가짐을 버려. 더 강해질 시간이야.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        isRest = true;
                    }
                    else
                    {
                        if (Player.Gold >= REST_PRISE)
                        {
                            Player.Gold -= REST_PRISE;
                            Player.Health = 100;
                            Console.WriteLine("현명한 판단이야, 스삣삐.");
                            Console.WriteLine("진정한 챔피언은 회복할 때도 완벽하게 하지.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            isRest = true;
                        }
                        else
                        {
                            Console.WriteLine("스삣삐, 챔피언의 휴식에도 대가가 필요해.");
                            Console.WriteLine("더 많은 골드를 가지고 돌아오도록.");
                            Thread.Sleep(1000);
                            Console.Clear();
                            return;
                        }
                    }
                }
                else if (input == "1")
                {
                    if(Player.Gold >= REST_PRISE)
                    {
                        Player.Gold -= REST_PRISE;
                        Player.Health = 100;
                        Console.WriteLine("휴식을 완료했습니다.");
                        Console.Clear();
                        isRest = true;
                    }
                    else
                    {
                        Console.WriteLine("Gold가 부족합니다.");
                        Console.Clear();
                        return;
                    }
                }
                else if (input == "0")
                {
                    Console.Clear();
                    isRest = true;
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
}
