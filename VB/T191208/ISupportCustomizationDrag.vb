Imports DevExpress.XtraBars
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace T191208
    Public Interface ISupportCustomizationDrag
        Sub AddMouseMoveHandler(ByVal mouseMove As MouseEventHandler)
        Sub AddMouseDownHandler(ByVal mouseDown As MouseEventHandler)
        Sub AddMouseUpHandler(ByVal mouseUp As MouseEventHandler)
        Function GetDraggingItem(ByVal location As Point) As BarItem
        Function GetControlToPerformDragging(ByVal location As Point) As Control
        Sub InitControl(ByVal manager As BarManager)
    End Interface
End Namespace
