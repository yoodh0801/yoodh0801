# Unity와 Cursor AI 연동 가이드

**유니티(Unity)와 Cursor를 연동하려면 외부 스크립트 에디터를 Cursor로 지정하고, C# 필수 확장 프로그램을 설치한 뒤 Unity MCP를 연결해야 합니다.** 이렇게 설정하면 C# 코드 자동완성과 디버깅은 물론, Cursor의 AI 에이전트가 유니티 씬(Scene)과 오브젝트까지 직접 제어할 수 있습니다.

---

## 1단계: 유니티에서 기본 스크립트 에디터로 Cursor 지정
유니티에서 C# 스크립트 파일을 더블 클릭했을 때 Cursor로 열리고 프로젝트 구조(`.sln`, `.csproj`)가 정상 인식되도록 연결합니다.

1. **Cursor 연동 패키지 설치 (선택 사항)**
   * 유니티 상단 메뉴에서 `Window > Package Manager`를 엽니다.
   * 왼쪽 상단의 `+` 버튼을 눌러 `Add package from git URL...`을 선택합니다.
   * 아래 주소를 입력해 설치하면 유니티 에디터 목록에 Cursor가 깔끔하게 등록됩니다.
     ```text
     https://github.com
     ```

2. **외부 에디터(External Script Editor) 변경**
   * 유니티 상단 메뉴의 `Edit > Preferences`(macOS는 `Unity > Settings`)로 이동합니다.
   * 왼쪽 탭에서 **External Tools**를 클릭한 뒤, `External Script Editor` 항목을 **Cursor**로 변경합니다.

3. **경로가 목록에 안 보일 경우 직접 지정**
   * 드롭다운에서 `Browse...`를 눌러 설치된 Cursor 실행 파일을 직접 선택합니다.
   * **Windows 기본 경로:** `C:\Users\사용자명\AppData\Local\Programs\cursor\Cursor.exe`
   * **macOS 기본 경로:** `응용 프로그램(Applications)` 폴더 내 `Cursor.app`

4. **프로젝트 파일 재생성**
   * 같은 화면 아래쪽에 있는 `Generate .csproj files for:` 항목에서 `Embedded packages`, `Local packages`, `Registry packages` 등을 체크합니다.
   * **Regenerate project files** 버튼을 한 번 눌러 솔루션 파일을 갱신합니다.

---

## 2단계: Cursor 내부에 C# 및 유니티 확장 프로그램 설치
Cursor가 유니티의 C# 문법과 엔진 API를 정확히 이해하고 빨간 줄(오류)을 잡아내려면 전용 확장 프로그램을 설치해야 합니다.

1. **확장(Extensions) 탭 열기**
   * Cursor 화면 왼쪽의 블록 모양 아이콘을 누르거나 단축키 `Ctrl + Shift + X`(macOS는 `Cmd + Shift + X`)를 입력합니다.

2. **필수 확장 프로그램 3종 설치**
   * 검색창에 아래 3가지 확장을 검색해 차례대로 설치(`Install`)합니다.
   * **C#** (Microsoft 제작): 기본 C# 언어 지원 및 문법 강조 기능
   * **C# Dev Kit** (Microsoft 제작): 솔루션 탐색기와 자동완성(IntelliSense) 지원
   * **Unity** (Microsoft 제작): 유니티 전용 디버깅 및 `MonoBehaviour` 함수 자동완성 지원

---

## 3단계: AI 에이전트 제어용 Unity MCP 연결
단순 코드 편집을 넘어 Cursor AI 에이전트가 유니티 에디터 화면의 오브젝트 배치와 콘솔 로그까지 제어하게 만들려면 MCP를 연결합니다.

* **방법 A: Unity 6 공식 MCP 사용 시**
  1. 유니티 에디터 상단 AI 메뉴에서 **AI Assistant 패키지**를 설치합니다.
  2. `Edit > Project Settings > AI > Unity MCP`로 이동합니다.
  3. `Integrations` 항목에서 **Cursor** 옆의 연결(`Configure`) 버튼을 눌러 자동 등록합니다.

* **방법 B: 오픈소스 Unity-MCP 사용 시**
  1. PC에 `Python`과 `uv` 패키지 매니저가 설치되어 있는지 확인합니다.
  2. 유니티 `Package Manager`의 `Add package from git URL...`에 아래 주소를 입력해 설치합니다.
     ```text
     https://github.com
     ```
  3. 유니티 메뉴 `Window > MCP for Unity` 창을 열고 클라이언트를 **Cursor**로 선택한 뒤 `Auto Configure`를 누릅니다.

* **연동 상태 최종 확인**
  * Cursor 설정(`Ctrl + Shift + J` 또는 `Cursor Settings > MCP`)에서 `UnityMCP` 서버 옆에 **초록색 불**이 켜져 있다면 모든 준비가 완료된 것입니다.
