# LeetCode C-Sharp

## 專案目的

- 練習 Leetcode
- 練習 OO, Design Pattern
- 練習 C-sharp

## Instruction

### 必要條件

- 安裝 Visual Studio Code
- 安裝 .NET Core SDK
- 安裝適用於 Visual Studio Code 的 C# 擴充功能

### 執行程式

```terminal
$ dotnet run [problemIndex] [solutionIndex]
```

### 開始新題目

1. 開新資料夾，檔名直接複製題號加題目
2. 建立 Solution-**N**.cs (**N** 為題號)
   1. 從 `/tester/solution/` 裡面挑選一個符合此題 input 數量的 solutionTemplate 整份複製過去（例如 Solution-6 需要兩個輸入就複製 `LCSolutionTwoInput` 的內容
   2. 修改 className（格式為 LCProblem**N**Solution）（可同時修改上下 3 處
   3. 修改 <T1, T2, T3>
   4. 從 LeetCode 執行環境裡面複製整個 function 過來上下都貼（包含 return type, function name, parameters）
   5. 更改 Solve 裡面使用的 function 為剛才複製的 function name 與 parameters，以及修改 return type
3. 建立 Problem-**N**.cs
   1. 類似 2-1 步驟從 `/tester/problem/` 裡面挑選符合輸入參數量的 problemTemplate 整份複製過去如 `LCProblemTwoInput`
   2. 修改 className（格式為 LCProblem**N**）
   3. 修改 tester params type （共 2 處）
   4. 新增 testCase
   5. 設定 solution 為剛才新增的 LCProblem**N**Solution0 （預設為 solution 0，亦可再新增其他 solution）
4. 到 Program.cs 的 `RegisterProblems()` 裡面新增 Problem-N
5. terminal 執行 `$ dotnet run Ｎ`

## Reference

- [C# 與 Visual Studio Code 使用者入門](https://docs.microsoft.com/zh-tw/dotnet/core/tutorials/with-visual-studio-code)
- [Generics (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/index)
