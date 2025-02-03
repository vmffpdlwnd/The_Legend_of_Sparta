using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Legend_of_Sparta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("태초마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.Write("원하시는 행동을 입력해주세요.");
            Console.Write("\n>>");

            // 사용자 입력 받기
            string input = Console.ReadLine();
        }
    }
}
