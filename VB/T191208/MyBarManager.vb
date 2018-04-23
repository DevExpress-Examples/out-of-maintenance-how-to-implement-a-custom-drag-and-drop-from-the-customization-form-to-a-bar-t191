Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Utils
Imports System.ComponentModel
Imports System.Reflection

Namespace T191208
    Public Class MyBarManager
        Inherits BarManager

        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub New(ByVal components As IContainer)
            MyBase.New(components)
        End Sub
        '
        'This method is hidden from IntelliSense
        'since 'Helper' class is designed for internal use
        'Avoid using it in your app
        '
        <EditorBrowsable(EditorBrowsableState.Never)> _
        Public Function GetHelper() As BarManagerHelpers
            Return Me.Helper
        End Function
        Public Sub SetCustomizeSelectedLink(ByVal link As BarItemLink)
            Me.SelectionInfo.CustomizeSelectedLink = link
        End Sub

        'We do not recommend using Reflection 
        Public Sub SetSelectedItem(ByVal item As BarItem)
            Dim selItemField As FieldInfo = Me.SelectionInfo.GetType().GetField("selectedItem", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
            selItemField.SetValue(Me.SelectionInfo, item)
        End Sub
    End Class
End Namespace
