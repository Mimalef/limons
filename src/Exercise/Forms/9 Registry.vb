
'MegaRegistry 0.1.1
'Make your registry cool.
'2012/12/30 - 2012/12/31
'Mim. Alef.

Imports Microsoft.Win32

Public Class Registry

    Dim SubKey As RegistryKey
    Dim Value As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If MsgBox("It is possible to control the interval used to delay the appearance of the cascading menus when you click Start on the Taskbar." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "Start Menu Show Delay") = MsgBoxResult.Yes Then
            Value = InputBox("You can enter any whole number between 0 and 4,000. If you use an entry of 0, there is no menu display delay.", "Insert Value", "0")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("CONTROL PANEL\DESKTOP", True)
            SubKey.SetValue("MenuShowDelay", Value, RegistryValueKind.String)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("This is disable all balloon tips in the notification area for this computer." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "Disable All Balloon Tips") = MsgBoxResult.Yes Then
            Value = InputBox("You can enter 0 to disable and 1 to enable", "Value Insert")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", True)
            SubKey.SetValue("EnableBalloonTips", Value, RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Removes the frequently-used programs list from the Start menu." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "Remove Frequent Programs List") = MsgBoxResult.Yes Then
            Value = InputBox("You can enter 0 to disable and 1 to enable", "Value Insert")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
            SubKey.SetValue("NoStartMenuMFUprogramsList", Value, RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("Removes shortcut menus from the desktop and from Windows Explorer. Shortcut menus appear when you right-click an item." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "Removes Shortcut Menus") = MsgBoxResult.Yes Then
            Value = InputBox("You can enter 0 to disable and 1 to enable", "Value Insert")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
            SubKey.SetValue("NoViewContextMenu", Value, RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MsgBox("Removes the pinned programs list from the Start menu. Also removes the Internet and E-mail checkboxes from the Start menu." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "No Pinned Programs List") = MsgBoxResult.Yes Then
            Value = InputBox(" A value of 1 is enabled, and a value of 0 is disabled.", "Value Insert")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
            SubKey.SetValue("NoStartMenuPinnedList", Value, RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MsgBox("Disables the new simple Start menu and forces the classic Start menu." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "New Simple Start Menu") = MsgBoxResult.Yes Then
            Value = InputBox(" A value of 1 is enabled, and a value of 0 is disabled.", "Value Insert")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
            SubKey.SetValue("NoSimpleStartMenu", Value, RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If MsgBox("Deletes all shortcuts shown in the Recent Documents menu when the user logs off." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "Clear History of Recent Documents") = MsgBoxResult.Yes Then
            Value = InputBox(" A value of 1 is enabled, and a value of 0 is disabled.", "Value Insert")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
            SubKey.SetValue("ClearRecentDocsOnExit", Value, RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If MsgBox("Removes the user name from the Start menu." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "Removes the User Name") = MsgBoxResult.Yes Then
            Value = InputBox(" A value of 1 is enabled, and a value of 0 is disabled.", "Value Insert")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
            SubKey.SetValue("NoUserNameInStartMenu", Value, RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If MsgBox("Prevents users from modifying the Start menu by dragging and dropping items. Other methods of customizing the Start menu are still enabled." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "Disable Drag-and-Drop Menus") = MsgBoxResult.Yes Then
            Value = InputBox(" A value of 1 is enabled, and a value of 0 is disabled.", "Value Insert")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
            SubKey.SetValue("NoChangeStartMenu", Value, RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If MsgBox("Forces the Logoff button to the Start menu and prevents users from removing the Logoff option from the Start menu." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "Force Logoff") = MsgBoxResult.Yes Then
            Value = InputBox(" A value of 1 is enabled, and a value of 0 is disabled.", "Value Insert")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
            SubKey.SetValue("ForceStartMenuLogoff", Value, RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If MsgBox("This problem occurs when a registry key is set to hide or to lock the display settings on the computer." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "Hide the Display Settings") = MsgBoxResult.Yes Then
            Value = InputBox(" A value of 1 is enabled, and a value of 0 is disabled.", "Value Insert")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System", True)
            SubKey.SetValue("NoDispCPL", Value, RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If MsgBox("Removes the Logoff button from the Start menu and prevents users from adding the Logoff button to the Start menu." & vbNewLine & "Are you sure you want to do this?", MsgBoxStyle.YesNo, "Disable Logoff") = MsgBoxResult.Yes Then
            Value = InputBox(" A value of 1 is enabled, and a value of 0 is disabled.", "Value Insert")
            SubKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", True)
            SubKey.SetValue("StartMenuLogoff", Value, RegistryValueKind.DWord)
        End If
    End Sub

    Private Sub Registry_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Visible = True
    End Sub

End Class