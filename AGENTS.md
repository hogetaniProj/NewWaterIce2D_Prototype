# AGENTS.md

## 作業ルール

- main ブランチには直接 commit / push しない。
- 作業は現在の feature ブランチ上で行う。
- このプロジェクトは Unity プロジェクトです。
- `dotnet`、`dotnet test`、`dotnet build`、`msbuild` は一切実行しないでください。
- Unity Editor の探索も行わないでください。
- ビルドテストには、必ず以下のPowerShellコマンドだけを使ってください。

```powershell
$UnityExe = "C:\Program Files\Unity\Hub\Editor\6000.3.14f1\Editor\Unity.exe"
$RepoPath = "C:\Users\hidee\NewWaterIce2D_Proto"
$LogFile = Join-Path $RepoPath ".codex-run-logs\unity-build.log"

& $UnityExe `
    -batchmode `
    -quit `
    -projectPath $RepoPath `
    -executeMethod CodexBuildValidator.BuildWindows64 `
    -logFile $LogFile
```

- 大きすぎる変更は避け、1コミット1目的に分ける。
- 仕様が曖昧な場合は、推測で大規模変更せず、TODO コメントまたはレポートに残す。

## Git ルール

- `git push --force` は禁止。
- `git reset --hard` は禁止。
- `git clean -fdx` は禁止。
- main / develop / release/* への push は禁止。
