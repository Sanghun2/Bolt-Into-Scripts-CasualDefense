# [Bolt Into Scripts]캐주얼 디펜스
볼트로 작성된 캐주얼 디펜스게임을 보고 스크립트로 바꿔서 구현한 버전

https://www.youtube.com/watch?v=IONpYgEfk40&t=771s

![image](https://user-images.githubusercontent.com/50513500/162796730-d277c894-c6d3-4591-9749-b079ca5ae5e1.png)

### 1. 메뉴 만들기
<img src="https://user-images.githubusercontent.com/50513500/162795622-7b348f99-d12b-4cc6-9d0f-87da95990fb8.PNG"  width="950" height="450"/>

##### 구현
* 배경 이미지 배치
* 메인화면 이미지 배치

### 2. 패럴랙스를 곁들인 카메라 이동
![2](https://user-images.githubusercontent.com/50513500/165430796-9e57e26f-eed3-4b9a-900c-63271ebd2cf2.gif)

##### 구현
* 화면이동 기능
* 버튼으로 화면이동 조작

### 3. 적,아군을 구별하는 유닛 만들기

##### 구현
* 적, 아군 유닛 이동
* 적, 아군 유닛의 유닛 감지 구현

##### 배운점 및 고려한 점
1. 처음에는 매니저를 통해 오브젝트를 관리하려고 해서 LinkedList와 동적배열인 List 중 고려를 했었다. 플레이 중 추가, 삭제가 잦을거라고 예상해 LinkedList를 사용하려고 했으나, 각각의 요소에 대해 애니메이션을 관리하는 것이 상당히 번거롭게 여겨졌고, 각각의 오브젝트에 UnitController를 붙여서 사용하는 것이 더 나은 방법이라고 생각해 스크립트를 붙이는 방식으로 작성했다.
2. 1과 같은 선택에 따라 필요요소를 까먹지 않기 위해 requiredComponent에 UnitController도 추가해 주었다.
3. 각각의 스크립트를 매 프레임마다 실행하는 것이 매니저로 한 번에 foreach로 관리하는 것보다 더 느리지는 않을까하는 염려도 있었지만, 그 부분에 대한 내용은 찾아볼 수 없어서 나중에라도 찾아보고 이후 프로젝트에 반영해야겠다고 생각했다.
