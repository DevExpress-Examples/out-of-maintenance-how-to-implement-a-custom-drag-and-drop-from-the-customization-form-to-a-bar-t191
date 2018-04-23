Imports System.Drawing
Imports System.Windows.Forms
Imports System

Imports DevExpress.XtraBars.Customization
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraBars
Imports DevExpress.XtraTreeList

Namespace T191208
    Partial Public Class CustomCustomizationControl
        Inherits CustomizationControl
        Implements ISupportCustomizationDrag

        ' Fields...

        Private selectedControl_Renamed As Control
        Protected Property SelectedControl() As Control
            Get
                Return selectedControl_Renamed
            End Get
            Set(ByVal value As Control)
                selectedControl_Renamed = value
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler Me.gridControl1.MouseDown, AddressOf gridControl1_MouseDown
            AddHandler Me.gridControl2.MouseDown, AddressOf gridControl2_MouseDown
            AddHandler Me.treeList1.MouseDown, AddressOf treeList1_MouseDown
        End Sub

        Private Sub CustomCustomizationControl_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub treeList1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            SelectedControl = TryCast(sender, TreeList)
        End Sub

        Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            SelectedControl = TryCast(sender, GridControl)
        End Sub

        Private Sub gridControl2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            SelectedControl = TryCast(sender, GridControl)
        End Sub
        Public Sub AddMouseMoveHandler(ByVal mouseMove As MouseEventHandler) Implements ISupportCustomizationDrag.AddMouseMoveHandler
            AddHandler Me.gridView2.MouseMove, mouseMove
            AddHandler Me.gridView1.MouseMove, mouseMove
            AddHandler Me.treeList1.MouseMove, mouseMove
        End Sub


        Public Sub AddMouseDownHandler(ByVal mouseDown As MouseEventHandler) Implements ISupportCustomizationDrag.AddMouseDownHandler
            AddHandler Me.gridView2.MouseDown, mouseDown
            AddHandler Me.gridView1.MouseDown, mouseDown
            AddHandler Me.treeList1.MouseDown, mouseDown
        End Sub

        Public Sub AddMouseUpHandler(ByVal mouseUp As MouseEventHandler) Implements ISupportCustomizationDrag.AddMouseUpHandler
            AddHandler Me.gridView2.MouseUp, mouseUp
            AddHandler Me.gridView1.MouseUp, mouseUp
            AddHandler Me.treeList1.MouseUp, mouseUp
        End Sub

        Public Function GetDraggingItem(ByVal location As Point) As BarItem Implements ISupportCustomizationDrag.GetDraggingItem
            ' your logic here
            Dim item As BarItem = Nothing
            If TypeOf SelectedControl Is GridControl Then
                Dim grid As GridControl = TryCast(SelectedControl, GridControl)
                If grid IsNot Nothing Then
                    Dim view As GridView = TryCast(grid.MainView, GridView)
                    If view IsNot Nothing Then
                        Dim hitInfo As GridHitInfo = view.CalcHitInfo(location)
                        item = TryCast(view.GetRow(hitInfo.RowHandle), BarItem)
                    End If
                End If
            End If
            If TypeOf SelectedControl Is TreeList Then
                Dim treeList As TreeList = TryCast(SelectedControl, TreeList)
                If treeList IsNot Nothing Then
                    Dim hitInfo As TreeListHitInfo = treeList.CalcHitInfo(location)
                    item = TryCast(treeList1.GetDataRecordByNode(hitInfo.Node), BarItem)
                End If
            End If
            Return item
        End Function

        Public Function GetControlToPerformDragging(ByVal location As Point) As Control Implements ISupportCustomizationDrag.GetControlToPerformDragging
            'your logic here
            Return SelectedControl
        End Function
        Public Sub InitControl(ByVal manager As BarManager) Implements ISupportCustomizationDrag.InitControl
            Me.gridControl1.DataSource = manager.Items
            Me.gridControl2.DataSource = manager.Items
            Me.treeList1.DataSource = manager.Items
        End Sub
    End Class
End Namespace
