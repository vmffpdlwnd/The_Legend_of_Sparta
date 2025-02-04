using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace The_Legend_of_Sparta
{
    public class Inventory
    {
        private List<Item> items;
        private Character Char;

        public Inventory(Character Char)
        {
            this.Char = Char;
            items = new List<Item>();

            items.Add(new Item
            {
                Name = "나무 막대기",
                Power = 1,
                Description = "나무가지로 만들어진 막대기 입니다.",
                Type = ItemType.Sword,
                Price = 0,
                IsEquipped = false,
                IsBasicItem = true
            });
        }
        public void AddItem(Item item)
        {
            items.Add(item);  // 이제 내부에서 items 리스트에 접근 가능
        }
        public List<Item> GetEquippedItems()
        {
            return items.Where(item => item.IsEquipped).ToList();
        }
        public void DisplayInventory()
        {
            Console.Clear();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < items.Count; i++)
            {
                string equipped = items[i].IsEquipped ? "[E]" : "";
                string powerText = items[i].Type == ItemType.Armor ? "방어력" : "공격력";
                Console.WriteLine($"- {equipped}{items[i].Name} | {GetStatText(items[i])} | {items[i].Description}");
            }
            Console.WriteLine("\n1. 장착 관리");
            Console.WriteLine("0. 나가기\n");

            Console.Write("원하시는 행동을 입력해주세요.\n>>");

            string input = Console.ReadLine();
            if ( input == "1")
            {

                DisplayEquipMenu();
            }
            else if ( input == "0")
            {
                Console.Clear();
            }
            else
            {
                if (Char.Name == "GigaChad")
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
        public void DisplayEquipMenu()
        {
            bool isEquipMenuOn = true;
            while (isEquipMenuOn)
            {
                Console.Clear();
                Console.WriteLine("인벤토리 - 장착 관리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
                Console.WriteLine("[아이템 목록]");
                for (int i = 0; i < items.Count; i++)
                {
                    string equipped = items[i].IsEquipped ? "[E]" : "";
                    string powerText = items[i].Type == ItemType.Armor ? "방어력" : "공격력";
                    Console.WriteLine($"- {i + 1} {equipped}{items[i].Name} | {GetStatText(items[i])} | {items[i].Description}");
                }
                Console.WriteLine("\n0. 나가기");
                Console.Write("원하시는 행동을 입력해주세요.\n>>");

                string input = Console.ReadLine();

                if (input == "0")
                {
                    isEquipMenuOn = false;
                }
                else if (int.TryParse(input, out int index) && index > 0 && index <= items.Count)
                {
                    EquipItem(index - 1);
                    Char.UpdateStats();
                }
                else
                {
                    Console.Clear();
                    if (Char.Name == "GigaChad")
                    {
                        Console.WriteLine("잘못 눌렀잖아 스삣삐!!!");
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
        private string GetStatText(Item item)
        {
            if (item.Type == ItemType.Armor || item.Type == ItemType.Cloak)
            {
                return $"방어력 +{item.Power}";
            }
            else
            {
                return $"공격력 +{item.Power}";
            }
        }
        private void EquipItem(int index)
        {
            if (index < 0 || index >= items.Count) return;

            Item selectedItem = items[index];

            if (Char.Name == "GigaChad")
            {
                //GigaChad는 모든 아이템 자유롭게 장착 가능
                selectedItem.IsEquipped = !selectedItem.IsEquipped;
            }
            else
            {
                if (selectedItem.Type == ItemType.Wand || selectedItem.Type == ItemType.Cloak)
                {
                    Console.WriteLine("이 아이템은 장착할 수 없습니다.");
                    Thread.Sleep(1000);
                    return;
                }

                if (selectedItem.Type == ItemType.Armor)
                {
                    // 갑옷의 경우 다른 갑옷 해제
                    foreach (var item in items)
                    {
                        if ((item.Type == ItemType.Armor || item.Type == ItemType.Cloak) && item != selectedItem)
                        {
                            item.IsEquipped = false;
                        }
                    }
                    selectedItem.IsEquipped = !selectedItem.IsEquipped;
                }
                else
                {
                    // 무기(창/검)의 경우 다른 무기 해제
                    foreach (var item in items)
                    {
                        if ((item.Type == ItemType.Sword || item.Type == ItemType.Spear || item.Type == ItemType.Axe || item.Type == ItemType.Wand) && item != selectedItem)
                        {
                            item.IsEquipped = false;
                        }
                    }
                    selectedItem.IsEquipped = !selectedItem.IsEquipped;
                }
            }
        }
        public List<Item> GetItems()
        {
            return items;
        }
        public void RemoveItem(int index)
        {
            if(index >= 0 && index < items.Count)
            {
                items.RemoveAt(index);
            }
        }
    }
}

