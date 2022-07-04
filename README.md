# CSharp 作业

---

清华大学电子系科协软件部 2022 暑期培训作业

---

## 题目及要求

我们希望编写一个程序，用于统计某个变量被修改与被读取的次数。请在`BasicCSharp/hw1/hw1/Counting.cs`中完成对变量`Variable`被修改与被读取的次数统计。只允许修改`Counting`类中的代码，且满足以下要求

- `Variable` 不能被外部程序赋值为负数。若被赋为负数，则将它代表的值置为0。
- `ReadTimes` 为 `Variable` 被外部程序读取的次数。
- `WriteTimes` 为 `Variable` 被外部程序修改的次数。

## 使用工具

### VS 2022

作业的 C# 程序运行在.NET 6平台上，建议使用Visual Studio 2022进行编写。

使用 Visual Studio 2022直接打开`BasicCSharp/hw1/hw1.sln`进行编写。

### VScode

也可以使用 VScode，使用 VScode 请保证你的计算机上有.NET 6 环境。

使用 VScode 直接修改`BasicCSharp/hw1/hw1/Counting.cs`即可。若要检验结果是否正确，可以使用命令启动`Counting.cs`程序

`dotnet run --project BasicCSharp/hw1/hw1`

或直接用我们写好的测试程序进行测试

`dotnet test BasicCSharp/hw1/hw1.sln`

## 提交方式

提供两种提交方式：

1. GitHub 提交
   - fork 仓库： [TCL606/BasicCSharp (github.com)](https://github.com/TCL606/BasicCSharp)到个人仓库，按要求修改好后，从个人仓库提pr到原本的仓库。
2. 邮箱提交
   - 只允许修改`BasicCSharp/hw1/hw1/Counting.cs`代码，修改好后，将`BasicCSharp`整个文件夹打包成常见压缩格式（如`.rar`、`.zip`等），并命名为：`CSharp_姓名_班级` （如：`CSharp_小明_无19`）发送到邮箱 **tcl606_thu@163.com**。

