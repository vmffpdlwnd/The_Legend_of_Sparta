# The Legend of Sparta

텍스트 기반의 RPG 게임입니다. 스파르타 마을에서 캐릭터를 생성하고, 아이템을 수집하며, 던전에서 모험을 즐길 수 있습니다.

## 기능 설명

### 필수 구현 사항
1. **게임 시작**
   - 캐릭터 이름 생성
   - 직업 선택 (전사/도적)

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

### 선택 구현 사항
1. **아이템 시스템**
   - 클래스/구조체를 활용한 아이템 정보 관리
   - 배열을 통한 아이템 관리
   - 커스텀 아이템 추가 가능

2. **휴식 기능**
   - 500G를 지불하여 체력 회복

3. **아이템 판매**
   - 구매가의 85%로 판매 가능
   - 장착 중인 아이템 판매 시 자동 해제

4. **장비 시스템 개선**
   - 무기/방어구 각각 한 개만 장착 가능
   - 새로운 장비 장착 시 기존 장비 자동 해제

5. **추가 기능**
   - 레벨업 시스템
   - 던전 입장
   - 게임 저장

## 개발 환경
- Visual Studio 2022
- C# Console Application

## 프로젝트 구조
- `TheLegendOfSparta.cs`: 메인 게임 파일
- `Character.cs`: 캐릭터 클래스
- `Item.cs`: 아이템 클래스
- `Inventory.cs`: 인벤토리 관리
- `Shop.cs`: 상점 시스템
- `GameManager.cs`: 게임 상태 관리

## 실행 화면
```
스파르타 마을에 오신 여러분 환영합니다.
이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.
1. 상태 보기
2. 인벤토리
3. 상점
4. 던전입장
5. 휴식하기
원하시는 행동을 입력해주세요.
>>
```