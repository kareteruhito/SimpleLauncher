# SimpleLauncher

Windows 向けの **超シンプルなアプリランチャー** です。  

📝 **GitHub 上のアプリを入手してビルド・実行する方法については、下記のブログ記事で解説しています：**  
https://maywork.net/computer/github-app-clone-build-install/


使いたい `.exe` ファイルをドラッグ＆ドロップして登録するだけで、  
軽量で高速にアプリケーションを起動できます。

登録内容は自動的に保存され、次回起動時に復元されます。

---

## ✨ 特徴

- **ドラッグ＆ドロップで簡単にアプリ登録**
- **実行ファイルのアイコンを自動取得して表示**
- **キーボード操作に対応**
  - `Delete` …選択したアプリの削除  
  - `Alt + ↑` …上へ移動  
  - `Alt + ↓` …下へ移動  
- **終了時に自動保存・次回起動時に復元**
- **シンプルな MVVM＋ヘルパー構造で拡張が容易**
- **インストール不要 / 超軽量**

---

## 📦 動作環境

- Windows 10 / Windows 11  
- .NET 8  
- WPF アプリケーション（WinExe）

---

## 🚀 使い方

### 起動方法

```powershell
git clone https://github.com/kareteruhito/SimpleLauncher.git
cd SimpleLauncher
dotnet run
