# AGENTS.md

## 検索ルール

- リポジトリ全体に対して `rg --files -g "*.cs" -g "*.unity" -g "*.prefab" -g "*.asset"` のような広すぎるファイル列挙をしないでください。
- CorgiEngine 配下を調査する場合も、まず対象ディレクトリを絞ってください。
- `*.asset` と `*.prefab` の全件列挙は禁止です。必要な場合は `Assets/Scenes`、`Assets/Scripts`、`Assets/CorgiEngine/Common/Scripts` など、対象を限定してください。
- 調査コマンドは最大でも数十行程度の出力になるようにしてください。
- `rg` で検索結果が0件の場合は exit code 1 になるため、調査目的では失敗扱いしないでください。

## 作業ルール

- main ブランチには直接 commit / push しない。
- 作業は現在の feature ブランチ上で行う。
- このプロジェクトは Unity プロジェクトです。バージョンは6000.3.14f1です。
- `Unity.exe` の直接起動、`dotnet test`、`dotnet build`、`dotnet --version`、`Get-Command Unity` は実行しないでください。
- Unity のビルド確認やコンパイル確認を自分で推測して実行しないでください。
- 検証は、呼び出し元スクリプトが実行する `C:\Users\hidee\CodexNightlyTools\Test-UnityCSharpCompile.ps1` に任せてください。
- Codex 自身は、変更対象ファイルの存在確認、内容確認、`git status --short` のみ行ってください。

- 大きすぎる変更は避け、1コミット1目的に分ける。
- 仕様が曖昧な場合は、推測で大規模変更せず、TODO コメントまたはレポートに残す。

## Git ルール

- `git push --force` は禁止。
- `git reset --hard` は禁止。
- `git clean -fdx` は禁止。
- main / develop / release/* への push は禁止。
