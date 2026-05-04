#  WAV 音效播放器 (WAV Audio Player)

這是一個使用 C# Windows Forms 開發的簡易 WAV 音效播放器。除了具備基礎的音樂播放與控制功能外，還特別加入了動態的 GIF 視覺化效果，提升整體的操作回饋與使用者體驗。

##  功能特色 (Features)

*   ** 檔案瀏覽 (Browse)**: 透過內建的對話方塊 (OpenFileDialog) 快速過濾並選取本機的 `.wav` 音效檔。
*   ** 基礎播放控制 (Play/Stop)**: 支援一鍵播放與停止當前音效。
*   ** 重複播放 (Loop)**: 提供單曲無限循環播放功能。
*   ** 動態視覺回饋 (Creative Feature)**: 在音效播放或循環播放期間，介面會同步展示動態 GIF 視覺圖形；當音樂停止時則自動隱藏，讓播放器更具生命力與互動感。
*   ** 防呆關閉機制**: 點擊結束按鈕或關閉視窗時，會彈出確認對話方塊，避免使用者誤觸導致程式意外中斷。

##  畫面預覽 (Demo)

沒播放音效時
<img width="478" height="248" alt="image" src="https://github.com/user-attachments/assets/f9ce26d9-0f4f-4aad-96d1-fbacae764421" />
開始播放音效時
<img width="650" height="615" alt="image" src="https://github.com/user-attachments/assets/16066ed2-88e7-404d-bfb6-74a259cc8f31" />


##  如何執行 (Getting Started)

1. 確認電腦已安裝 Visual Studio 及支援 C# Windows Forms 的 .NET 執行環境。
2. 將本專案 Clone 或下載至本地端。
3. 使用 Visual Studio 開啟方案檔。
4. 按下 `F5` 或點選「開始」編譯並執行程式。
