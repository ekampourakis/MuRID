Imports System.Diagnostics

Public Class Gallery

    Dim cpu As New PerformanceCounter()

    Private Sub Timer_Update_Tick(sender As Object, e As EventArgs) Handles Timer_Update.Tick
        Label_Time.Text = System.DateTime.Now.ToString("HH:mm:ss")
        Label_Date.Text = System.DateTime.Now.ToString("dd/MM/yyyy")
        Label_CPU.Text = CInt(cpu.NextValue) & "%"
        Label_RAM.Text = 100 - CInt(My.Computer.Info.AvailablePhysicalMemory * 100 / My.Computer.Info.TotalPhysicalMemory) & "%"
        Label_Language.Text = InputLanguage.CurrentInputLanguage.LayoutName

    End Sub

    Private Sub Gallery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cpu
            .CategoryName = "Processor"
            .CounterName = "% Processor Time"
            .InstanceName = "_Total"
        End With
    End Sub
End Class