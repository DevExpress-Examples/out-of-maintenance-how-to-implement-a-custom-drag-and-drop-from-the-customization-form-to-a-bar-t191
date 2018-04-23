Imports System

Namespace T191208
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            AddHandler Me.barManager1.CreateCustomizationForm, AddressOf barManager1_CreateCustomizationForm
        End Sub

        Private Sub barManager1_CreateCustomizationForm(ByVal sender As Object, ByVal e As DevExpress.XtraBars.CreateCustomizationFormEventArgs)
            e.CustomizationForm = New MyForm(New CustomCustomizationControl(), Me.LookAndFeel)
        End Sub

    End Class
End Namespace
