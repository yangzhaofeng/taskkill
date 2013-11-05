Public Class taskkill

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim fs As New Scripting.FileSystemObject
        Shell("C:\WINDOWS\system32\taskkill /f /im student.exe")
        If fs.FileExists("C:\Program Files\AsiaStar\Mars8.1\student.exe") Then
            Try
                Kill("C:\Program Files\AsiaStar\Mars8.1\student.exe")
            Catch
            End Try
            If fs.FileExists("C:\Program Files\AsiaStar\Mars8.1\student.exe") Then MsgBox("移除失败，请重试") Else MsgBox("移除成功")
        Else
            MsgBox("学生机已经移除")
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim fs As New Scripting.FileSystemObject
        Shell("C:\WINDOWS\system32\taskkill /f /im ICCAgent.exe")
        If fs.FileExists("C:\Program Files\ICC\ICCAgent.exe") Then
            Try
                Kill("C:\Program Files\ICC\ICCAgent.exe")
            Catch
            End Try
            If fs.FileExists("C:\Program Files\ICC\ICCAgent.exe") Then MsgBox("移除失败，请重试") Else MsgBox("移除成功")
        Else
            MsgBox("状态监视器已经移除")
        End If
    End Sub

    Private Sub taskkill_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MsgBox("本程序版权归华师大二附中2015届1班杨肇峰所有。本程序仅供学习，使用中造成的任何后果自负。本程序为自由软件，开放源代码并可免费复制、传播，但转载时请声明版权归属。程序说明：学生机的用途为教师对学生的监控及广播。状态监视器的用途为监控存储状态，当学生存储过多信息时自动关机。")
    End Sub
End Class
