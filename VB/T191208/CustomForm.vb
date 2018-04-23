Imports System.Drawing
Imports System.Windows.Forms
Imports System
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Utils

Namespace T191208
    Public Class CustomizationFormEx
        Inherits DevExpress.XtraBars.Customization.CustomizationForm

        'Custom control
        Private control As CustomCustomizationControl
        Protected ReadOnly Property ControlForDrag() As ISupportCustomizationDrag
            Get
                Return TryCast(control, ISupportCustomizationDrag)
            End Get
        End Property
        Protected Overridable ReadOnly Property MyManager() As MyBarManager
            Get
                Return (TryCast(Manager, MyBarManager))
            End Get
        End Property

        Private mouseDownPoint_Renamed As Point
        Protected Overridable Property MouseDownPoint() As Point
            Get
                Return mouseDownPoint_Renamed
            End Get
            Set(ByVal value As Point)
                mouseDownPoint_Renamed = value
            End Set
        End Property

        Private mouseDownItem_Renamed As BarItem
        Protected Overridable Property MouseDownItem() As BarItem
            Get
                Return mouseDownItem_Renamed
            End Get
            Set(ByVal value As BarItem)
                mouseDownItem_Renamed = value
            End Set
        End Property


        Private mouseDraggingItem_Renamed As BarItem
        Protected Overridable Property MouseDraggingItem() As BarItem
            Get
                Return mouseDraggingItem_Renamed
            End Get
            Set(ByVal value As BarItem)
                mouseDraggingItem_Renamed = value
            End Set
        End Property
        Public Sub New(ByVal control As DevExpress.XtraBars.Customization.CustomizationControl, ByVal laf As UserLookAndFeel)
            MyBase.New(control, laf)
            Me.control = TryCast(control, T191208.CustomCustomizationControl)
        End Sub
        Private Sub MouseDownEx(ByVal sender As Object, ByVal e As MouseEventArgs)
            If (e.Button And MouseButtons.Left) <> 0 Then
                MouseDownPoint = System.Windows.Forms.Control.MousePosition
                MouseDownItem = Nothing
                MouseDownItem = ControlForDrag.GetDraggingItem(New Point(e.X, e.Y))
            End If
        End Sub
        Private Sub MouseUpEx(ByVal sender As Object, ByVal e As MouseEventArgs)
            Capture = False
            MouseDownItem = Nothing
        End Sub
        Private Sub MouseMoveEx(ByVal sender As Object, ByVal e As MouseEventArgs)
            If (e.Button And MouseButtons.Left) <> 0 Then
                If MouseDownItem IsNot Nothing Then
                    Dim p As Point = System.Windows.Forms.Control.MousePosition
                    p.Offset(-MouseDownPoint.X, -MouseDownPoint.Y)
                    If Math.Abs(p.X) > 4 OrElse Math.Abs(p.Y) > 4 Then
                        MyManager.SetCustomizeSelectedLink(Nothing)
                        MyManager.SetSelectedItem(MouseDownItem)
                        Dim helper As BarManagerHelpers = MyManager.GetHelper()
                        Try
                            MouseDraggingItem = MouseDownItem
                            Me.ControlForDrag.GetControlToPerformDragging(System.Windows.Forms.Control.MousePosition).AllowDrop = True
                            helper.DragManager.UseDefaultCursors = True
                            helper.DragManager.StartDragging(Nothing, e, MouseDownItem, Me.ControlForDrag.GetControlToPerformDragging(System.Windows.Forms.Control.MousePosition))
                        Finally
                            helper.DragManager.UseDefaultCursors = False
                            Me.ControlForDrag.GetControlToPerformDragging(System.Windows.Forms.Control.MousePosition).AllowDrop = False
                            MyManager.SetSelectedItem(Nothing)
                            MouseDraggingItem = Nothing
                        End Try
                    End If
                End If
            End If
        End Sub

        Public Overrides Sub Init(ByVal AManager As BarManager)
            MyBase.Init(AManager)
            If ControlForDrag IsNot Nothing AndAlso MyManager IsNot Nothing Then
                Me.ControlForDrag.InitControl(AManager)
                ControlForDrag.AddMouseDownHandler(AddressOf MouseDownEx)
                ControlForDrag.AddMouseMoveHandler(AddressOf MouseMoveEx)
                ControlForDrag.AddMouseUpHandler(AddressOf MouseUpEx)
            End If
        End Sub
    End Class

    Public Class MyForm
        Inherits CustomizationFormEx

        Public Sub New(ByVal control As DevExpress.XtraBars.Customization.CustomizationControl, ByVal lookAndFeel As UserLookAndFeel)
            MyBase.New(control, lookAndFeel)
        End Sub
    End Class

End Namespace
