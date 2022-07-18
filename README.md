# ADBtouch44

## 摘要
- 虛擬觸控板在虛擬鍵盤下方的按鈕要叫出來
- 虛擬觸控板有誤差要釐清(ＦＩＮＤ　ＡＮＤ　ＤＥＢＵＧ)

## 已新增的功能

### 指令集頁面

在虛擬鍵盤倒退鍵右方(彈出新畫面)

|按鈕|位置|動作|備註|
|--|--|--|--|
|回到主頁|最上方ROW的右側|如題||
|叫出設定|最上方ROW的左側下一|如題|ㄅ|
|叫出設定的網路分享頁面|最上方ROW的左側下一|如題|ㄆ|
|測試按鈕1|中右|載入SETTING的macro值||
|測試按鈕2|中右|忘了?||
|測試按鈕3|中右|載入表格(解析MACRO設定)||

#### 關閉動作鏈

偵測Droid@Screen標題的畫面並關閉

> 部分可行；有時故障

## 施工中

### 依MACRO設定值

讀MACRO的item的動作

例如ddm就是按壓下下中鍵

> 需要預載入ㄅ或ㄆ等

### 新增/編輯MACRO設定值

REGEX:

名稱:值；名稱:值；名稱:值；名稱:值；

#### 意涵

名稱:顧名思義

#####值:

- udlr:上下左右
- m:中

#### 預計:

- 在畫面中可編輯MACRO
- 用表格或純文字設定

## 愈新增的功能
> 未動工
- 自動獲取解析度
> 網路上有資料顯示可行
- 疊加JAVA畫面與觸控畫面