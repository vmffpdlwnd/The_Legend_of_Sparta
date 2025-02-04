using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace The_Legend_of_Sparta
{
    public class Shop
    {
        private Character player;
        private Inventory inventory;
        private List<Item> shopItems;

        public Shop(Character player, Inventory inventory)
        {
            this.player = player;
            this.inventory = inventory;
            shopItems = new List<Item>
            {
                new Item
                {
                    Name = "수련자 갑옷",
                    Power = 5,
                    Description = "수련에 도움을 주는 갑옷입니다.",
                    Type = ItemType.Armor,
                    Price = 1000,
                    IsPurchased = false
                },
                new Item
                {
                    Name = "무쇠갑옷",
                    Power = 9,
                    Description = "무쇠로 만들어져 튼튼한 갑옷입니다.",
                    Type = ItemType.Armor,
                    Price = 2000,
                    IsPurchased = false
                },
                new Item
                {
                    Name = "스파르타의 갑옷",
                    Power = 15,
                    Description = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.",
                    Type = ItemType.Armor,
                    Price = 3500,
                    IsPurchased = false
                },
                new Item
                {
                    Name = "낡은 검",
                    Power = 2,
                    Description = "쉽게 볼 수 있는 낡은 검 입니다.",
                    Type = ItemType.Sword,
                    Price = 600,
                    IsPurchased = false
                },
                new Item
                {
                    Name = "청동 도끼",
                    Power = 5,
                    Description = "어디선가 사용됐던거 같은 도끼입니다.",
                    Type = ItemType.Axe,
                    Price = 1500,
                    IsPurchased = false
                },
                new Item
                {
                    Name = "스파르타의 창",
                    Power = 7,
                    Description = "스파르타의 전사들이 사용했다는 전설의 창입니다.",
                    Type = ItemType.Spear,
                    Price = 3000,
                    IsPurchased = false
                }
            };
        }
        public void DisplayShop()
        {
            bool isShopOpen = true;
            while (isShopOpen)
            {
                Console.Clear();
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                if (player.Name == "GigaChad")
                {
                    Console.Clear();
                    Console.WriteLine("스삣삐 상점에 찾아왔구나");
                    Console.WriteLine("넌 어떤 물건이든 싸게 살수있어! 유 캔 두 잇");
                }
                Console.WriteLine("\n[보유 골드]");
                Console.WriteLine($"{player.Gold} G");
                Console.WriteLine("\n[아이템 목록]");

                for (int i = 0; i < shopItems.Count; i++)
                {
                    string price;
                    if (shopItems[i].IsPurchased)
                    {
                        price = "구매완료";
                    }
                    else
                    {
                        int actualPrice = player.Name == "GigaChad" ? (int)(shopItems[i].Price * 0.85) : shopItems[i].Price;
                        price = $"{actualPrice} G";
                    }

                    string stat = shopItems[i].Type == ItemType.Armor ? $"방어력 +{shopItems[i].Power}" : $"공격력 +{shopItems[i].Power}";

                    Console.WriteLine($"- {i + 1} {shopItems[i].Name,-8} | {stat,-6} | {shopItems[i].Description,-30} | {price}");
                }

                Console.WriteLine("\n1. 아이템 구매");
                Console.WriteLine("2. 아이템 판매");
                Console.WriteLine("0. 나가기");
                Console.Write("\n원하시는 행동을 입력해주세요.\n>>");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        PurchaseItem();
                        break;
                    case "2":
                        SellItem();
                        break;
                    case "0":
                        isShopOpen = false;
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
        private void PurchaseItem()
        {
            Console.Clear();
            Console.WriteLine("상점 - 아이템 구매");
            Console.WriteLine("\n[보유 골드]");
            Console.WriteLine($"{player.Gold} G");
            if (player.Name == "GigaChad")
            {
                Console.Clear();
                Console.WriteLine("상점 - 아이템 구매");
                Console.WriteLine($"\n{player.Gold} G? 마음껏 골라봐!");
            }
            Console.WriteLine("\n[아이템 목록]");

            for (int i = 0; i < shopItems.Count; i++)
            {
                string price;
                if (shopItems[i].IsPurchased)
                {
                    price = "구매완료";
                }
                else
                {
                    // GigaChad일 경우 85% 가격 적용
                    int actualPrice = player.Name == "GigaChad" ? (int)(shopItems[i].Price * 0.85) : shopItems[i].Price;
                    price = $"{actualPrice} G";
                }

                string stat = shopItems[i].Type == ItemType.Armor ? $"방어력 +{shopItems[i].Power}" : $"공격력 +{shopItems[i].Power}";

                Console.WriteLine($"- {i + 1} {shopItems[i].Name,-8} | {stat,-6} | {shopItems[i].Description,-30} | {price}");
            }

            Console.WriteLine("\n0. 나가기");
            Console.Write("\n구매할 아이템 번호를 입력해주세요.\n>>");

            string input = Console.ReadLine();
            if (input == "0") return;

            if (int.TryParse(input, out int index) && index > 0 && index <= shopItems.Count)
            {
                var item = shopItems[index - 1];
                int actualPrice = player.Name == "GigaChad" ? (int)(item.Price * 0.85) : item.Price;

                if (item.IsPurchased)
                {
                    Console.WriteLine("이미 구매한 아이템입니다.");
                    Thread.Sleep(1000);
                }
                else if (player.Gold >= actualPrice)
                {
                    player.Gold -= actualPrice;
                    item.IsPurchased = true;

                    var newItem = new Item  // 새 아이템 객체 생성
                    {
                        Name = item.Name,
                        Power = item.Power,
                        Description = item.Description,
                        Type = item.Type,
                        Price = item.Price,
                        IsEquipped = false
                    };
                    inventory.AddItem(newItem);

                    if(player.Name == "GigaChad")
                    {
                        Console.WriteLine("이제 진정한 장비를 얻었군.");
                        Console.WriteLine("너의 잠재력을 끌어낼 좋은 선택이야.");
                        Console.WriteLine("계속해서 강해져라. 스삣삐");
                    }
                    else
                    {
                        Console.WriteLine("구매를 완료했습니다.");
                    }

                    
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다.");
                    Thread.Sleep(1000);
                }
            }
            else
            {
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
            }
        }
        private void SellItem()
        {
            Console.Clear();
            Console.WriteLine("상점 - 아이템 판매");
            if (player.Name == "GigaChad")
            {
                Console.Clear();
                Console.WriteLine("현명한 선택이야 스삣삐");
                Console.WriteLine("나약한 장비는 과감하게 버려야 스파르타지/n");
            }
            Console.WriteLine($"\n[보유 골드]\n{player.Gold} G\n");

            var inventoryItems = inventory.GetItems();

            if (inventoryItems.Count <= 1)
            {
                Console.WriteLine("판매할 아이템이 없습니다.");
                if (player.Name == "GigaChad")
                {
                    Console.Clear();
                    Console.WriteLine("스삣삐... 스파르타는 아이템 따윈 팔지 않지");
                    Console.WriteLine("더 강해진 후 돌아오길 기대하지.");
                }
                
                Thread.Sleep(1000);
                return;
            }

            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < inventoryItems.Count; i++)
            {
                
                var item = inventoryItems[i];
                string Price;
                if (item.Name == "나무 막대기")
                {
                    Price = "판매 불가";
                }
                else
                {
                    int actualPrice = (int)(shopItems[i].Price * 0.85);
                    Price = $"{actualPrice} G";
                }

                string stat = item.Type == ItemType.Armor ? $"방어력 + {item.Power}" : $"공격력 + {item.Power}";

                string equippedMark = item.IsEquipped ? "[E] " : "";

                Console.WriteLine($"- {i + 1} {equippedMark}{item.Name,-8} | {stat,-6} | {item.Description,-30} | {Price}");            
            }

            Console.WriteLine("\n0. 나가기");
            Console.Write("판매할 아이템 번호를 입력해 주세요.\n>>");

            string input = Console.ReadLine();
            if (input == "0") return;

            if( int.TryParse(input, out int index) && index > 0 && index <= inventoryItems.Count )
            {
                var item = inventoryItems[index - 1];

               
                if (item.IsBasicItem)
                {
                    Console.WriteLine("해당 아이템은 판매할 수 없습니다.");
                    Thread.Sleep(1000);
                    return;
                }

                if (item.IsEquipped)
                {
                    item.IsEquipped = false;
                    player.UpdateStats();
                }

                int sellPrice = (int)(item.Price * 0.85);

                player.Gold += sellPrice;
                inventory.RemoveItem(index - 1);

                var shopItem = shopItems.Find(x => x.Name == item.Name);
                if (shopItem != null)
                {
                    shopItem.IsPurchased = false;
                }

                if (player.Name == "GigaChad")
                {
                    Console.WriteLine("완벽해, 스삣삐. 약한 장비는 과감히 놓아주는 것.");
                    Console.WriteLine("이제 더 강한 장비를 향해 나아가자고.");
                }
                else
                {
                    Console.WriteLine("판매가 완료했습니다.");
                }
                Thread.Sleep(1000);
            }
            else
            {
                Console.Clear();
                if (player.Name == "GigaChad")
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

}
