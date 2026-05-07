# Codex 作業計画

## 目的
Unity プロジェクトの `Assets` フォルダ直下に `CodexTest.cs` を配置し、ファイル内容を以下の 1 行だけにする。

```csharp
//これはテストです！
```

## 実施予定
1. `Assets` フォルダが存在することを確認する。
2. `Assets/CodexTest.cs` が既に存在するか確認する。
3. 存在しない場合は `Assets/CodexTest.cs` を新規作成する。
4. 存在する場合は、現在の内容を確認してから上書き可否を判断する。
5. `Assets/CodexTest.cs` の内容を `//これはテストです！` のみにする。
6. 作成後、ファイル内容を読み取り確認する。

## 今回の制約
このステップでは `Assets/CodexTest.cs` はまだ作成・変更しない。変更対象はこの `codex-plan.md` のみとする。
