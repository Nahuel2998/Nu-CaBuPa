Imports System.Windows.Forms.VisualStyles

Public Class ColorDateTimePicker
    Inherits DateTimePicker

    Public Sub New()
        MyBase.New()
        SetStyle(ControlStyles.UserPaint, True)
        ForeColor = Color.Black
        BackColor = Color.White
    End Sub

    Public Overrides Property ForeColor As Color

    Public Overrides Property BackColor As Color

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = Me.CreateGraphics()

        Dim dropDownRectangle As Rectangle = New Rectangle(ClientRectangle.Width - 17, 0, 17, ClientRectangle.Height)
        Dim bkgBrush As Brush = New SolidBrush(BackColor)
        Dim visualState As ComboBoxState = ComboBoxState.Normal

        g.FillRectangle(bkgBrush, 0, 0, ClientRectangle.Width, ClientRectangle.Height)

        Dim textBrush As Brush = New SolidBrush(ForeColor)
        g.DrawString(Text, Font, textBrush, 0, 2)

        ComboBoxRenderer.DrawDropDownButton(g, dropDownRectangle, visualState)

        g.DrawRectangle(Pens.Gray, 0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1)

        g.Dispose()
        bkgBrush.Dispose()
        textBrush.Dispose()
    End Sub

End Class