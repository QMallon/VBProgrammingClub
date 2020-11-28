Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim number As Integer
        number = 2
        Assert.IsTrue((number Mod 2) = 0)
    End Sub

End Class