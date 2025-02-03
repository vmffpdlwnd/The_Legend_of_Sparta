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
                Name = "무쇠갑옷",
                Power = 5,
                Description = "무쇠로 만들어져 튼튼한 갑옷입니다.",
                Type = ItemType.Armor
            });
            items.Add(new Item
            {
                Name = "스파르타의 창",
                Power = 7,
                Description = "스파르타의 전사들이 사용했다는 전설의 창입니다.",
                Type = ItemType.Spear
            });
            items.Add(new Item
            {
                Name = "낡은 검 ",
                Power = 2,
                Description = "쉽게 볼 수 있는 낡은 검 입니다.",
                Type = ItemType.Sword
            });
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
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기\n");

            Console.Write("원하시는 행동을 입력해주세요.\n>>");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    DisplayEquipMenu();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    break;
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
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }
        private string GetStatText(Item item)
        {
            return item.Type == ItemType.Armor ? $"방어력 +{item.Power}" : $"공격력 +{item.Power}";
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
                if (selectedItem.Type == ItemType.Armor)
                {
                    // 갑옷의 경우 다른 갑옷 해제
                    foreach (var item in items)
                    {
                        if (item.Type == ItemType.Armor && item != selectedItem)
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
                        if ((item.Type == ItemType.Sword || item.Type == ItemType.Spear) && item != selectedItem)
                        {
                            item.IsEquipped = false;
                        }
                    }
                    selectedItem.IsEquipped = !selectedItem.IsEquipped;
                }
            }
        }
        }
    }

