# C# 코드 구성 요소

* C# 코드는 크게 **토큰**(**코드의 최소단위**)과 **구조적 요소**, 그리고 **비실행 및 메타 요소**로 구성됨.

## 1. 토큰 (Tokens)
컴파일러가 코드를 해석할 때 쪼개는 최소 단위임.

* **예약어 (Keywords):** C#에서 특수 용도로 예약된 단어. 변수명으로 사용 불가.
  * 예: `int`, `string`, `if`, `else`, `for`, `class`, `public`, `return`
* **식별자 (Identifiers):** 변수, 메서드, 클래스 등에 붙이는 이름.
  * 예: `userName`, `CalculateTotal`, `Player`
* **리터럴 (Literals):** 코드에 직접 표기하는 고정 값.
  * 예: `100` (정수), `3.14` (실수), `"Hello"` (문자열), `'A'` (문자), `true` (불리언)
* **연산자 (Operators):** 계산, 비교, 할당에 사용하는 기호.
  * 예: `+`, `-`, `*`, `/`, `=`, `==`, `&&`, `??`
* **구두점 및 구분자 (Punctuators):** 문법적 경계를 나누는 기호.
  * 예: `;`, `,`, `.`, `( )`, `[ ]`

## 2. 구조적 요소 (Structural Elements)
토큰이 모여 논리와 흐름을 만드는 단위임.

* **표현식 (Expressions):** 계산되어 하나의 값으로 평가되는 코드 조각.
  * 예: `10 + 20`, `x > 5`, `GetUserName()`
* **문 (Statements):** 실행 가능한 온전한 명령 단위. 주로 `;`로 끝남.
  * 예: `int age = 25;`, `if (age >= 20) { ... }`, `return result;`
* **블록 (Blocks):** `{ }`로 묶인 코드 영역. 실행 범위 및 변수 유효 범위(Scope)를 결정함.

## 3. 비실행 및 메타 요소
실제 로직 외에 설명이나 컴파일 설정을 돕는 요소임.

* **주석 (Comments):** 개발자용 메모. 컴파일러가 무시함.
  * 종류: `//` (한 줄), `/* ... */` (여러 줄), `///` (XML 문서화)
* **전처리기 지시문 (Preprocessor Directives):** 컴파일 전 컴파일러에 지시를 내리는 명령어. `#`으로 시작함.
  * 예: `#region`, `#endregion`, `#if DEBUG`
* **특성 (Attributes):** 클래스, 메서드 등에 추가 메타데이터를 부여할 때 사용. `[ ]`로 감쌈.
  * 예: `[Obsolete]`, `[Serializable]`, `[HttpGet]`

## 코드 예시

```csharp
// [주석] 사용자 정보 클래스
public class User // [예약어: public, class] [식별자: User]
{
    [Obsolete] // [특성]
    public void PrintAge() // [블록 시작]
    {
        int age = 20; // [문] ('20': 리터럴, '=': 연산자, ';': 구분자)
        if (age >= 18) // ('age >= 18': 표현식)
        {
            Console.WriteLine("성인");
        }
    } // [블록 끝]
}
```
