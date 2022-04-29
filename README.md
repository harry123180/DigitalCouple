# Unity 草稿碼說明 4.29

## 場景內傳遞變數

* 由global.cs統一管理全域變數，此全域變數可以在同一專案內所有GameObject內同步讀取
* 更新global.cs裡面的變數，只需要在更改的地方以global.變數名=值，即可更新全域變數
* socket Unity 為伺服器端 其接收跟傳出都是以Bytes形式，但進到內部是String形式
* Python為客戶端 目前通訊格式定為 angle1 angle2 angle3 以空格隔開 其中angle是float形式，值在+-180 
* public 變數類型 變數名 可以在unity作為可被設定的公眾變數
* [Range(-180.0f, 180.0f)]
    public float _angle1; 可以作slider 
# 草稿碼備註
+ socketTest資料夾內存放之socket.cs與global.cs、Echo.py為一組
+ 未來如果要進行代碼搬運記得整包搬運
## 未來工作
* 將單軸獨立三個變數傳遞的方式，改寫為以陣列傳遞，提升代碼整體簡潔度。
* 定義可動關節數量，通訊楨意義。
* 可能新增讓socket與本地controller可共同控制角色關節，目前是socket擁有優先更改權

