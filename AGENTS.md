# AGENTS.md

## 作業ルール

- 作業を開始する前に、必ず現在作ろうとしているものの全体像を把握するために、"C:\Users\hidee\NewWaterIce2D_Proto\water_ice_game_spec_prototype.md"の中身を読み込んでください。
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
