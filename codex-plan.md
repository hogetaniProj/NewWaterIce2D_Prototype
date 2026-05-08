# Codex 作業計画

## 目的

`Assets/CodexTest.cs` の内容を以下にする。

```csharp
//これはテストです（Ver6!）
```

## 確認結果

- `Assets/CodexTest.cs` は存在する。
- 現在の内容はすでに `//これはテストです（Ver6!）` である。
- そのため、現時点では `Assets/CodexTest.cs` の変更は不要。

## 実施方針

1. `Assets/CodexTest.cs` はこの Step 1 では変更しない。
2. 次の作業指示で変更が必要になった場合のみ、対象ファイルを最小差分で編集する。
3. Unity の起動、ビルド、コンパイル確認、`dotnet` 系コマンドは実行しない。
4. 検証は呼び出し元スクリプト側の `C:\Users\hidee\CodexNightlyTools\Test-UnityCSharpCompile.ps1` に任せる。

## 検証予定

- Codex 側では `git status --short` による作業ツリー確認のみ行う。
