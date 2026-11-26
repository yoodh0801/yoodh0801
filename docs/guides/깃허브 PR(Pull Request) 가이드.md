# GitHub Pull Request(PR) 가이드 문서

```markdown
- **작성자:** 유동한
- **최종 수정일:** 2026-11-26
- **상태:** 초안 (Draft)
- **사전 지식:** Git 브랜치 생성, 커밋(Commit), 원격 저장소 푸시(Push) 기본 사용법
- **대상 독자:** GitHub 협업을 처음 접하는 개발자
- **목표 :** 작업한 브랜치의 변경 사항을 코드 리뷰를 거쳐 안전하게 기준 브랜치(`main`)에 병합하는 방법 습득
```

---

## 1. 사전 준비 (원격 저장소 업로드)
PR 생성 전 로컬 작업 커밋 내역의 원격 저장소(GitHub) 작업 브랜치 업로드 필수

1. **작업 내용 커밋:** GitHub Desktop에서 수정 파일 전체 선택 및 커밋(`Commit`)
2. **원격 저장소 푸시:** 상단 우측 **`Publish branch`** (또는 **`Push origin`**) 버튼 클릭으로 작업 브랜치 GitHub 업로드

---

## 2. Pull Request(PR) 생성하기
원격 저장소의 작업 브랜치(`feature/브랜치명`)를 기준 브랜치(`main`)로 병합 요청(PR)

1. **PR 생성 화면 이동:**
   - **GitHub Desktop:** 상단 메뉴 **`Branch`** → **`Create Pull Request`** 클릭 (단축키: `Ctrl + R` / Mac: `Cmd + R`) 시 웹 브라우저 자동 이동
   - **GitHub 웹:** 저장소 상단 노란색 알림 배너의 **`Compare & pull request`** 버튼 클릭
2. **브랜치 방향 확인:**
   - 상단 브랜치 설정의 `base: main` ← `compare: feature/브랜치명` 방향 일치 여부 확인
3. **PR 내용 작성:**
   - **Title (제목):** 작업 내용을 한눈에 파악할 수 있도록 간결하게 작성 (예: `[Feat] 로그인 기능 구현`)
   - **Description (본문):** 변경 사유, 주요 수정 사항, 테스트 방법 등 작성 (저장소 내 PR 템플릿 존재 시 양식 준수)
4. **리뷰어 지정 및 생성:**
   - 우측 사이드바 **`Reviewers`**에서 코드 검토 팀원 지정 후 하단 초록색 **`Create pull request`** 버튼 클릭

---

## 3. 코드 리뷰 및 수정 반영
PR 생성 후 팀원들과 변경 코드(Files changed) 검토 및 의견 교환

1. **코드 리뷰 확인:** 리뷰어가 특정 코드 라인에 남긴 코멘트 및 수정 요청 확인
2. **수정 사항 추가 반영 (필요 시):**
   - 로컬의 **동일한 작업 브랜치**에서 코드 수정 및 커밋(`Commit`)
   - **`Push origin`** 재실행 시 기존 PR에 수정 내역 자동 반영

---

## 4. PR 승인 및 병합(Merge) 완료
모든 리뷰 완료 및 승인(Approve) 후 웹 상에서 최종 병합 진행

1. **병합 실행:** PR 페이지 하단 초록색 **`Merge pull request`** 버튼 클릭 후 **`Confirm merge`** 선택으로 확정
2. **원격 작업 브랜치 정리:** 병합 완료 후 표시되는 **`Delete branch`** 버튼 클릭으로 사용 완료 원격 작업 브랜치 삭제
3. **로컬 환경 최신화:** GitHub Desktop 복귀 후 `main` 브랜치 이동 및 **`Fetch origin` → `Pull origin`** 실행으로 최신 코드 다운로드

---

## 5. 요약 치트시트 (한눈에 보기)

| 단계 | 실행 환경 | 주요 작업 |
| :--- | :--- | :--- |
| **1. 업로드** | GitHub Desktop | 로컬 작업 커밋 후 `Push origin`으로 원격 반영 |
| **2. PR 생성** | GitHub Desktop → Web | `Create Pull Request` 클릭 후 제목·본문 작성 및 리뷰어 지정 |
| **3. 리뷰/수정** | Local ↔ GitHub Web | 피드백 확인 후 동일 브랜치 수정 및 `Push`로 자동 갱신 |
| **4. 최종 병합** | GitHub Web → Desktop | `Merge pull request` 확정 후 로컬 `main`에서 `Pull origin` |

---

## 6. 주의사항 (Best Practices)
- **PR 단위는 작게 유지:** 수십 개 파일을 한 번에 수정한 거대 PR 지양 및 기능 단위 분할 업로드 권장
- **셀프 리뷰 습관:** PR 생성 직후 **`Files changed`** 탭에서 불필요한 주석, 디버깅 로그, 오타 포함 여부 사전 점검