Public Class frmTicTacToe
    ' Declarations
    Dim _intX1 As Integer = 10
    Dim _intY1 As Integer = 10
    Dim _intX2 As Integer = 110
    Dim _intY2 As Integer = 110
    Dim _intDraws As Integer = 0
    Dim _intPlayer As Integer = 1
    Dim _blnArray() As Boolean = {False, False, False, False, False, False, False, False, False}

    Private Sub frmTicTacToe_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
        DrawBoard()
        _intPlayer = 1
        lblPlayer1X.ForeColor = Color.Blue
    End Sub

    Private Sub DetermineSquare(ByVal intXSquare As Integer, ByVal intYSquare As Integer)
        _intX1 = 10
        _intY1 = 10
        _intX2 = 110
        _intY2 = 110
        _intX1 = _intX1 + intXSquare
        _intY1 = _intY1 + intYSquare
        _intX2 = _intX2 + intXSquare
        _intY2 = _intY2 + intYSquare
    End Sub

    Private Sub frmTicTacToe_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseClick
        Dim intSquare As Integer

        intSquare = MousePos(e)

        If _intPlayer = 1 Then
            If Not lstWin1.Items.Contains(intSquare) Xor lstWin2.Items.Contains(intSquare) Then
                If intSquare <> 0 Then
                    lstWin1.Items.Add(intSquare)
                    DrawX()
                    _intDraws += 1
                    _intPlayer = 2
                    lblPlayer1X.ForeColor = Color.Black
                    lblPlayer2O.ForeColor = Color.Blue
                    FindWinnerOrBoardFull()
                End If
            End If

        Else

            If Not lstWin2.Items.Contains(intSquare) Xor lstWin1.Items.Contains(intSquare) Then
                If intSquare <> 0 Then
                    lstWin2.Items.Add(intSquare)
                    DrawO()
                    _intDraws += 1
                    _intPlayer = 1
                    lblPlayer1X.ForeColor = Color.Blue
                    lblPlayer2O.ForeColor = Color.Black
                    FindWinnerOrBoardFull()
                End If
            End If
        End If
    End Sub

    Private Sub DrawBoard()
        ' Declarations
        Dim MyPen As New Drawing.Pen(Color.Black)
        Dim DrawGraphics As Graphics


        DrawGraphics = Me.CreateGraphics()
        DrawGraphics.DrawRectangle(MyPen, 10, 10, 300, 300)
        DrawGraphics.DrawLine(MyPen, 110, 10, 110, 310)
        DrawGraphics.DrawLine(MyPen, 210, 10, 210, 310)
        DrawGraphics.DrawLine(MyPen, 10, 110, 310, 110)
        DrawGraphics.DrawLine(MyPen, 10, 210, 310, 210)
        DrawGraphics.Dispose()
    End Sub

    Private Sub DrawX()
        ' Declarations
        Dim MyPen As New Drawing.Pen(Color.DarkRed, 3)
        Dim DrawGraphics As Graphics

        DrawGraphics = Me.CreateGraphics()
        DrawGraphics.DrawLine(MyPen, _intX1, _intY1, _intX2, _intY2)
        DrawGraphics.DrawLine(MyPen, _intX2, _intY1, _intX1, _intY2)

    End Sub

    Private Sub DrawO()
        ' Declarations
        Dim MyPen As New Drawing.Pen(Color.DarkViolet, 3)
        Dim DrawGraphics As Graphics

        DrawGraphics = CreateGraphics()
        DrawGraphics.DrawEllipse(MyPen, _intX1, _intY1, 100, 100)
    End Sub

    Private Sub ResetBoard()
        Dim Reset As Graphics
        Reset = Me.CreateGraphics()
        Reset.Clear(Color.Orange)
        lstWin1.Items.Clear()
        lstWin2.Items.Clear()
        DrawBoard()
        _intPlayer = 1
        lblPlayer1X.ForeColor = Color.Blue
        lblPlayer2O.ForeColor = Color.Black
    End Sub

    Private Sub FindWinnerOrBoardFull()
        ' Declarations
        Dim MyPen As New Drawing.Pen(Color.AntiqueWhite, 3)
        Dim DrawGraphics As Graphics
        DrawGraphics = CreateGraphics()

        If lstWin1.Items.Contains(1) And lstWin1.Items.Contains(2) And lstWin1.Items.Contains(3) Then
            DrawGraphics.DrawLine(MyPen, 60, 10, 60, 310)
            MsgBox("Player 1 wins")
        ElseIf lstWin1.Items.Contains(2) And lstWin1.Items.Contains(5) And lstWin1.Items.Contains(8) Then
            DrawGraphics.DrawLine(MyPen, 10, 160, 310, 160)
            MsgBox("Player 1 wins")
        ElseIf lstWin1.Items.Contains(1) And lstWin1.Items.Contains(4) And lstWin1.Items.Contains(7) Then
            DrawGraphics.DrawLine(MyPen, 10, 60, 310, 60)
            MsgBox("Player 1 wins")
        ElseIf lstWin1.Items.Contains(3) And lstWin1.Items.Contains(6) And lstWin1.Items.Contains(9) Then
            DrawGraphics.DrawLine(MyPen, 10, 260, 310, 260)
            MsgBox("Player 1 wins")
        ElseIf lstWin1.Items.Contains(4) And lstWin1.Items.Contains(5) And lstWin1.Items.Contains(6) Then
            DrawGraphics.DrawLine(MyPen, 160, 10, 160, 310)
            MsgBox("Player 1 wins")
        ElseIf lstWin1.Items.Contains(3) And lstWin1.Items.Contains(5) And lstWin1.Items.Contains(7) Then
            DrawGraphics.DrawLine(MyPen, 10, 310, 310, 10)
            MsgBox("Player 1 wins")
        ElseIf lstWin1.Items.Contains(7) And lstWin1.Items.Contains(8) And lstWin1.Items.Contains(9) Then
            DrawGraphics.DrawLine(MyPen, 260, 10, 260, 310)
            MsgBox("Player 1 wins")
        ElseIf lstWin1.Items.Contains(1) And lstWin1.Items.Contains(5) And lstWin1.Items.Contains(9) Then
            DrawGraphics.DrawLine(MyPen, 10, 10, 310, 310)
            MsgBox("Player 1 wins")
        ElseIf lstWin2.Items.Contains(1) And lstWin2.Items.Contains(2) And lstWin2.Items.Contains(3) Then
            DrawGraphics.DrawLine(MyPen, 60, 10, 60, 310)
            MsgBox("Player 2 wins")
        ElseIf lstWin2.Items.Contains(2) And lstWin2.Items.Contains(5) And lstWin2.Items.Contains(8) Then
            DrawGraphics.DrawLine(MyPen, 10, 160, 310, 160)
            MsgBox("Player 2 wins")
        ElseIf lstWin2.Items.Contains(1) And lstWin2.Items.Contains(4) And lstWin2.Items.Contains(7) Then
            DrawGraphics.DrawLine(MyPen, 10, 60, 310, 60)
            MsgBox("Player 2 wins")
        ElseIf lstWin2.Items.Contains(3) And lstWin2.Items.Contains(6) And lstWin2.Items.Contains(9) Then
            DrawGraphics.DrawLine(MyPen, 10, 260, 310, 260)
            MsgBox("Player 2 wins")
        ElseIf lstWin2.Items.Contains(4) And lstWin2.Items.Contains(5) And lstWin2.Items.Contains(6) Then
            DrawGraphics.DrawLine(MyPen, 160, 10, 160, 310)
            MsgBox("Player 2 wins")
        ElseIf lstWin2.Items.Contains(3) And lstWin2.Items.Contains(5) And lstWin2.Items.Contains(7) Then
            DrawGraphics.DrawLine(MyPen, 10, 310, 310, 10)
            MsgBox("Player 2 wins")
        ElseIf lstWin2.Items.Contains(7) And lstWin2.Items.Contains(8) And lstWin2.Items.Contains(9) Then
            DrawGraphics.DrawLine(MyPen, 260, 10, 260, 310)
            MsgBox("Player 2 wins")
        ElseIf lstWin2.Items.Contains(1) And lstWin2.Items.Contains(5) And lstWin2.Items.Contains(9) Then
            DrawGraphics.DrawLine(MyPen, 10, 10, 310, 310)
            MsgBox("Player 2 wins")
        ElseIf _intDraws = 9 Then
            MsgBox("No Winner")
        End If

    End Sub

    Private Function MousePos(e As MouseEventArgs) As Integer
        Dim intSquare As Integer
        If e.X < 110 And e.X > 10 Then
            If e.Y < 110 And e.Y > 10 Then
                DetermineSquare(0, 0)
                intSquare = 1
            ElseIf e.Y < 210 And e.Y > 110 Then
                DetermineSquare(0, 100)
                intSquare = 2
            ElseIf e.Y < 310 And e.Y > 210 Then
                DetermineSquare(0, 200)
                intSquare = 3
            End If
        ElseIf e.X < 210 And e.X > 110 Then
            If e.Y < 110 And e.Y > 10 Then
                DetermineSquare(100, 0)
                intSquare = 4
            ElseIf e.Y < 210 And e.Y > 110 Then
                DetermineSquare(100, 100)
                intSquare = 5
            ElseIf e.Y < 310 And e.Y > 210 Then
                DetermineSquare(100, 200)
                intSquare = 6
            End If
        ElseIf e.X < 310 And e.X > 210 Then
            If e.Y < 110 And e.Y > 10 Then
                DetermineSquare(200, 0)
                intSquare = 7
            ElseIf e.Y < 210 And e.Y > 110 Then
                DetermineSquare(200, 100)
                intSquare = 8
            ElseIf e.Y < 310 And e.Y > 210 Then
                DetermineSquare(200, 200)
                intSquare = 9
            End If
        ElseIf (e.Y > 310 And e.Y < 10) Then
            If (e.X > 310 And e.X < 10) Then
                intSquare = 0
            End If
            intSquare = 0
        End If
        Return intSquare
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetBoard()
        _intDraws = 0
    End Sub
End Class
