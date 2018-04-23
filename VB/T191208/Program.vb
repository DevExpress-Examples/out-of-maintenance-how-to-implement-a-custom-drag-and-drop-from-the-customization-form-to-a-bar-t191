Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports System
Imports System.Windows.Forms

Namespace T191208
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Public Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            BonusSkins.Register()
            SkinManager.EnableFormSkins()
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace
