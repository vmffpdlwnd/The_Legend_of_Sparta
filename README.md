# The Legend of Sparta

텍스트 기반의 RPG 게임입니다. 스파르타 마을에서 캐릭터를 생성하고, 아이템을 수집하며, 던전에서 모험을 즐길 수 있습니다.

## 기능 설명

1. **게임 시작**
   - 캐릭터 이름 생성

2. **상태 보기**
   - 레벨, 이름, 직업, 공격력, 방어력, 체력, Gold 확인 가능

3. **인벤토리**
   - 보유 아이템 확인
   - 아이템 장착/해제 관리
   - 장착된 아이템 앞에 [E] 표시

4. **상점**
   - 아이템 구매
   - 보유 골드 확인
   - 구매한 아이템은 '구매완료' 표시

## 개발 환경
- Visual Studio 2022

## 프로젝트 구조
- `Program.cs`: 메인 게임 파일
- `Character.cs`: 캐릭터 정보
- `Item.cs`: 아이템 클래스
- `Inventory.cs`: 인벤토리 관리리

## 실행 화면
```
태초마을 마을에 오신 여러분 환영합니다.
이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.
1. 상태 보기
2. 인벤토리
3. 상점
4. 던전입장
5. 휴식하기
원하시는 행동을 입력해주세요.
>>
```

## 개발 예정
- [x] 캐릭터 생성
- [x] 기본 UI 구현
- [x] 인벤토리 시스템
- [ ] 상점 시스템
- [ ] 전투 시스템
- [ ] 데이터 저장/불러오기