Public Class Form1
    Dim stop_time As Integer

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
    Function Reset_Timer(ByRef Label_default As Label, ByRef Label1 As Label, ByRef Label2 As Label, ByRef Label3 As Label, ByRef Label4 As Label, ByRef Label5 As Label, ByRef Label6 As Label, ByRef Label7 As Label, ByRef Label8 As Label, ByRef Label9 As Label, ByRef Label10 As Label, ByRef Label11 As Label, ByRef Label12 As Label, ByRef Label13 As Label)
        If Label_default.BackColor = Label1.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #50")
        ElseIf Label_default.BackColor = Label2.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #100")
        ElseIf Label_default.BackColor = Label3.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #150")
        ElseIf Label_default.BackColor = Label4.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #200")
        ElseIf Label_default.BackColor = Label5.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #250")
        ElseIf Label_default.BackColor = Label6.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #300")
        ElseIf Label_default.BackColor = Label7.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #350")
        ElseIf Label_default.BackColor = Label8.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #400")
        ElseIf Label_default.BackColor = Label9.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #450")
        ElseIf Label_default.BackColor = Label10.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #500")
        ElseIf Label_default.BackColor = Label11.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #550")
        ElseIf Label_default.BackColor = Label12.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #600")
        ElseIf Label_default.BackColor = Label13.BackColor Then
            MsgBox("Thank you for Playing, The Right Answer is  " + right_answer.Text + vbCrLf + "Your Money is #650")
        End If

        Return 1
    End Function

    Function Reset(ByVal fifty As Label, ByVal hundred As Label, ByVal onefifty As Label, ByVal twohundred As Label, ByVal twofifty As Label, ByVal threehundred As Label, ByVal threefifty As Label, ByVal fourhundred As Label, ByVal fourfifty As Label, ByVal fivehundred As Label, ByVal fivefifty As Label, ByVal sixhundred As Label, ByVal sixfifty As Label, ByVal Label_1 As Label, ByVal Label_2 As Label, ByVal Label_3 As Label, ByVal Label_4 As Label, ByVal Pic1 As PictureBox, ByVal Pic2 As PictureBox, ByVal Pic3 As PictureBox, ByVal Pic4 As PictureBox)
        ' For Repalcing LifeLine Pictures
        Pic1.Image = Pic2.Image
        Pic3.Image = Pic4.Image



        fifty.BackColor = Me.BackColor
        hundred.BackColor = Me.BackColor
        one_fifty.BackColor = Me.BackColor
        two_hundred.BackColor = Me.BackColor
        two_fifty.BackColor = Me.BackColor
        three_hundred.BackColor = Me.BackColor
        three_fifty.BackColor = Me.BackColor
        four_hundred.BackColor = Me.BackColor
        four_fifty.BackColor = Me.BackColor
        five_hundred.BackColor = Me.BackColor
        five_fifty.BackColor = Me.BackColor
        six_hundred.BackColor = Me.BackColor
        six_fifty.BackColor = Me.BackColor


        ' For Label Answer 
        Label_1.BackColor = Me.BackColor
        Label_2.BackColor = Me.BackColor
        Label_3.BackColor = Me.BackColor
        Label_4.BackColor = Me.BackColor

        ' For Life Line
        PictureBox5.BackColor = Color.SlateBlue
        PictureBox4.BackColor = Color.SlateBlue
        Return 1

    End Function
    Function Reward(ByVal fifty As Label, ByVal hundred As Label, ByVal onefifty As Label, ByVal twohundred As Label, ByVal twofifty As Label, ByVal threehundred As Label, ByVal threefifty As Label, ByVal fourhundred As Label, ByVal fourfifty As Label, ByVal fivehundred As Label, ByVal fivefifty As Label, ByVal sixhundred As Label, ByVal sixfifty As Label)
        If (fifty.BackColor <> Color.SpringGreen And hundred.BackColor <> Color.SpringGreen And onefifty.BackColor <> Color.SpringGreen And twohundred.BackColor <> Color.SpringGreen And twofifty.BackColor <> Color.SpringGreen And threehundred.BackColor <> Color.SpringGreen And threefifty.BackColor <> Color.SpringGreen And fourhundred.BackColor <> Color.SpringGreen And fourfifty.BackColor <> Color.SpringGreen And fivehundred.BackColor <> Color.SpringGreen And fivefifty.BackColor <> Color.SpringGreen And sixhundred.BackColor <> Color.SpringGreen And sixfifty.BackColor <> Color.SpringGreen) Then
            fifty.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #50")
            answer.Text = ""

        End If

        ' To move the reward upward
        If (fifty.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            fifty.BackColor = Me.BackColor
            hundred.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #100")
            answer.Text = ""
        End If
        If (hundred.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            hundred.BackColor = Me.BackColor
            onefifty.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #150")
            answer.Text = ""
        End If
        If (onefifty.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            onefifty.BackColor = Me.BackColor
            twohundred.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #200")
            answer.Text = ""
        End If
        If (twohundred.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            twohundred.BackColor = Me.BackColor
            twofifty.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #250")
            answer.Text = ""
        End If
        If (twofifty.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            twofifty.BackColor = Me.BackColor
            threehundred.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #300")
            answer.Text = ""
        End If
        If (threehundred.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            threehundred.BackColor = Me.BackColor
            threefifty.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #350")
            answer.Text = ""
        End If
        If (threefifty.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            threefifty.BackColor = Me.BackColor
            fourhundred.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #400")
            answer.Text = ""
        End If
        If (fourhundred.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            fourhundred.BackColor = Me.BackColor
            fourfifty.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #450")
            answer.Text = ""
        End If
        If (fourfifty.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            fourfifty.BackColor = Me.BackColor
            fivehundred.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #500")
            answer.Text = ""
        End If
        If (fivehundred.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            fivehundred.BackColor = Me.BackColor
            fivefifty.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #550")
            answer.Text = ""
        End If
        If (fivefifty.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            fivefifty.BackColor = Me.BackColor
            sixhundred.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #600")
            answer.Text = ""
        End If
        If (sixhundred.BackColor = Color.SpringGreen And right_answer.Text = answer.Text) Then
            sixhundred.BackColor = Me.BackColor
            sixfifty.BackColor = Color.SpringGreen
            MsgBox("Congatulation! You've just won #650")
            answer.Text = ""
        End If
        Return 1
    End Function



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub QuestionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.QuestionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuestionDataSet)

    End Sub


    Private Sub QuestionBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.QuestionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuestionDataSet)

    End Sub


    Private Sub QuestionBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.QuestionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuestionDataSet)

    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuestionDataSet.question' table. You can move, or remove it, as needed.
        Me.QuestionTableAdapter.Fill(Me.QuestionDataSet.question)

        Label6.BackColor = Color.SpringGreen

        My.Computer.Audio.Play(My.Resources.Millionaire, AudioPlayMode.Background)

    End Sub

    Private Sub OneToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OneToolStripButton.Click
        'My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)

        walk_away1.Visible = True
        Label7.Visible = True
        time_limit.Visible = True
        Timer2.Enabled = True

        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor


        right_answer.Text = "D"
        Try
            Me.QuestionTableAdapter.One(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        OneToolStrip.Enabled = False
        NumberLabel1.Visible = True
        QuestionLabel1.Visible = True
        NumberLabel1.Visible = True
        ALabel1.Visible = True
        BLabel1.Visible = True
        CLabel1.Visible = True
        DLabel1.Visible = True


        LinkLabel1.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True

        submit.Visible = True


        cancel.Visible = True
        HintLabel1.Visible = False


    End Sub

    Private Sub OneToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles OneToolStrip.ItemClicked



    End Sub

    Private Sub NumberLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberLabel1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor


        ALabel1.BackColor = Color.SpringGreen
        answer.Text = "A"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click

        If answer.Text = right_answer.Text Then
            Reward(fifty, hundred, one_fifty, two_hundred, two_fifty, three_hundred, three_fifty, four_hundred, four_fifty, five_hundred, five_fifty, six_hundred, six_fifty)
            time_limit.Text = "30"
            Timer2.Enabled = False
        ElseIf (two_hundred.BackColor = Color.SpringGreen Or two_fifty.BackColor = Color.SpringGreen Or three_hundred.BackColor = Color.SpringGreen Or three_fifty.BackColor = Color.SpringGreen) Then
            MsgBox(" You Are Wrong Your Money is" + vbNewLine + "       #200" + vbCrLf + " The Right Answer      " + right_answer.Text)
            ' Rseting Values
            Reset(fifty, hundred, one_fifty, two_hundred, two_fifty, three_hundred, three_fifty, four_hundred, four_fifty, five_hundred, five_fifty, six_hundred, six_fifty, ALabel1, BLabel1, CLabel1, DLabel1, PictureBox4, PictureBox8, PictureBox5, PictureBox9)

            ' To Reset the Screen to new Page
            Panel1.Visible = True
            play.Enabled = False
            stop_time = 1
            Label2.Visible = False
            generate.Text = ""
            Label5.Visible = False

            ' To remove the question When the answer is wrong
            NumberLabel1.Visible = False
            QuestionLabel1.Visible = False
            NumberLabel1.Visible = False
            ALabel1.Visible = False
            BLabel1.Visible = False
            CLabel1.Visible = False
            DLabel1.Visible = False
            LinkLabel1.Visible = False
            LinkLabel2.Visible = False
            LinkLabel3.Visible = False
            LinkLabel4.Visible = False
            HintLabel1.Visible = False

            PictureBox4.Enabled = True
            PictureBox5.Enabled = True


            Label7.Visible = False
            time_limit.Text = "30"
            time_limit.Visible = False
            Timer2.Enabled = False
        ElseIf (four_hundred.BackColor = Color.SpringGreen Or four_fifty.BackColor = Color.SpringGreen Or five_hundred.BackColor = Color.SpringGreen Or five_fifty.BackColor = Color.SpringGreen) Then
            MsgBox(" You Are Wrong Your Money is" + vbNewLine + "       #400" + vbCrLf + " The Right Answer      " + right_answer.Text)
            ' Rseting Values
            Reset(fifty, hundred, one_fifty, two_hundred, two_fifty, three_hundred, three_fifty, four_hundred, four_fifty, five_hundred, five_fifty, six_hundred, six_fifty, ALabel1, BLabel1, CLabel1, DLabel1, PictureBox4, PictureBox8, PictureBox5, PictureBox9)


            ' To Reset the Screen to new Page
            Panel1.Visible = True
            play.Enabled = False
            stop_time = 1
            Label2.Visible = False
            generate.Text = ""
            Label5.Visible = False

            ' To remove the question When the answer is wrong
            NumberLabel1.Visible = False
            QuestionLabel1.Visible = False
            NumberLabel1.Visible = False
            ALabel1.Visible = False
            BLabel1.Visible = False
            CLabel1.Visible = False
            DLabel1.Visible = False
            LinkLabel1.Visible = False
            LinkLabel2.Visible = False
            LinkLabel3.Visible = False
            LinkLabel4.Visible = False
            HintLabel1.Visible = False

            PictureBox4.Enabled = True
            PictureBox5.Enabled = True

            Label7.Visible = False
            time_limit.Text = "30"
            time_limit.Visible = False
            Timer2.Enabled = False
        ElseIf (six_hundred.BackColor = Color.SpringGreen) Then
            MsgBox(" You Are Wrong Your Money is" + vbNewLine + "       #600" + vbCrLf + " The Right Answer      " + right_answer.Text)
            ' Rseting Values
            Reset(fifty, hundred, one_fifty, two_hundred, two_fifty, three_hundred, three_fifty, four_hundred, four_fifty, five_hundred, five_fifty, six_hundred, six_fifty, ALabel1, BLabel1, CLabel1, DLabel1, PictureBox4, PictureBox8, PictureBox5, PictureBox9)


            ' To Reset the Screen to new Page
            Panel1.Visible = True
            play.Enabled = False
            stop_time = 1
            Label2.Visible = False
            generate.Text = ""
            Label5.Visible = False

            ' To remove the question When the answer is wrong
            NumberLabel1.Visible = False
            QuestionLabel1.Visible = False
            NumberLabel1.Visible = False
            ALabel1.Visible = False
            BLabel1.Visible = False
            CLabel1.Visible = False
            DLabel1.Visible = False
            LinkLabel1.Visible = False
            LinkLabel2.Visible = False
            LinkLabel3.Visible = False
            LinkLabel4.Visible = False
            HintLabel1.Visible = False

            PictureBox4.Enabled = True
            PictureBox5.Enabled = True


            Label7.Visible = False
            time_limit.Text = "30"
            time_limit.Visible = False
            Timer2.Enabled = False

        ElseIf (six_fifty.BackColor = Color.SpringGreen) Then
            MsgBox(" You Won Thank You Your Money is" + vbNewLine + "       #650" + vbCrLf + " The Right Answer      " + right_answer.Text)
            ' Rseting Values
            Reset(fifty, hundred, one_fifty, two_hundred, two_fifty, three_hundred, three_fifty, four_hundred, four_fifty, five_hundred, five_fifty, six_hundred, six_fifty, ALabel1, BLabel1, CLabel1, DLabel1, PictureBox4, PictureBox8, PictureBox5, PictureBox9)

            ' To Reset the Screen to new Page
            Panel1.Visible = True
            play.Enabled = False
            stop_time = 1
            Label2.Visible = False
            generate.Text = ""
            Label5.Visible = False

            ' To remove the question When the answer is wrong
            NumberLabel1.Visible = False
            QuestionLabel1.Visible = False
            NumberLabel1.Visible = False
            ALabel1.Visible = False
            BLabel1.Visible = False
            CLabel1.Visible = False
            DLabel1.Visible = False
            LinkLabel1.Visible = False
            LinkLabel2.Visible = False
            LinkLabel3.Visible = False
            LinkLabel4.Visible = False
            HintLabel1.Visible = False

            PictureBox4.Enabled = True
            PictureBox5.Enabled = True

            Label7.Visible = False
            time_limit.Text = "30"
            time_limit.Visible = False
            Timer2.Enabled = False


        ElseIf (fifty.BackColor = Color.SpringGreen Or hundred.BackColor = Color.SpringGreen Or one_fifty.BackColor = Color.SpringGreen) Then
            MsgBox(" Sorry You are Wrong, You have " + vbNewLine + vbCrLf + "       #0" + vbCrLf + " The Right Answer      " + right_answer.Text)
            ' Rseting Values
            Reset(fifty, hundred, one_fifty, two_hundred, two_fifty, three_hundred, three_fifty, four_hundred, four_fifty, five_hundred, five_fifty, six_hundred, six_fifty, ALabel1, BLabel1, CLabel1, DLabel1, PictureBox4, PictureBox8, PictureBox5, PictureBox9)

            ' To Reset the Screen to new Page
            Panel1.Visible = True
            play.Enabled = False
            stop_time = 1
            Label2.Visible = False
            generate.Text = ""
            Label5.Visible = False

            ' To remove the question When the answer is wrong
            NumberLabel1.Visible = False
            QuestionLabel1.Visible = False
            NumberLabel1.Visible = False
            ALabel1.Visible = False
            BLabel1.Visible = False
            CLabel1.Visible = False
            DLabel1.Visible = False
            LinkLabel1.Visible = False
            LinkLabel2.Visible = False
            LinkLabel3.Visible = False
            LinkLabel4.Visible = False
            HintLabel1.Visible = False

            PictureBox4.Enabled = True
            PictureBox5.Enabled = True


            Label7.Visible = False
            time_limit.Text = "30"
            time_limit.Visible = False
            Timer2.Enabled = False

        ElseIf (fifty.BackColor = Me.BackColor And hundred.BackColor = Me.BackColor And one_fifty.BackColor = Me.BackColor And two_hundred.BackColor = Me.BackColor And two_fifty.BackColor = Me.BackColor And three_hundred.BackColor = Me.BackColor And three_fifty.BackColor = Me.BackColor And four_hundred.BackColor = Me.BackColor And four_fifty.BackColor = Me.BackColor And five_hundred.BackColor = Me.BackColor And five_fifty.BackColor = Me.BackColor And six_hundred.BackColor = Me.BackColor And six_fifty.BackColor = Me.BackColor) Then
            MsgBox(" Sorry You are Wrong, You have " + vbNewLine + vbCrLf + "       #0" + vbCrLf + " The Right Answer      " + right_answer.Text)
            ' Rseting Values
            Reset(fifty, hundred, one_fifty, two_hundred, two_fifty, three_hundred, three_fifty, four_hundred, four_fifty, five_hundred, five_fifty, six_hundred, six_fifty, ALabel1, BLabel1, CLabel1, DLabel1, PictureBox4, PictureBox8, PictureBox5, PictureBox9)

            ' To Reset the Screen to new Page
            Panel1.Visible = True
            play.Enabled = False
            stop_time = 1
            Label2.Visible = False
            generate.Text = ""
            Label5.Visible = False

            ' To remove the question When the answer is wrong
            NumberLabel1.Visible = False
            QuestionLabel1.Visible = False
            NumberLabel1.Visible = False
            ALabel1.Visible = False
            BLabel1.Visible = False
            CLabel1.Visible = False
            DLabel1.Visible = False
            LinkLabel1.Visible = False
            LinkLabel2.Visible = False
            LinkLabel3.Visible = False
            LinkLabel4.Visible = False
            HintLabel1.Visible = False

            PictureBox4.Enabled = True
            PictureBox5.Enabled = True

            Label7.Visible = False
            time_limit.Text = "30"
            time_limit.Visible = False
            Timer2.Enabled = False

        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub TwoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TwoToolStripButton.Click
        'My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)
        walk_away1.Visible = True
        Label7.Visible = True
        time_limit.Visible = True
        Timer2.Enabled = True

        HintLabel1.Visible = False
        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor


        right_answer.Text = "B"

        Try
            Me.QuestionTableAdapter.Two(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        TwoToolStrip.Enabled = False

        answer.Text = ""


        OneToolStrip.Enabled = False
        NumberLabel1.Visible = True
        QuestionLabel1.Visible = True
        NumberLabel1.Visible = True
        ALabel1.Visible = True
        BLabel1.Visible = True
        CLabel1.Visible = True
        DLabel1.Visible = True


        LinkLabel1.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True

        submit.Visible = True
        cancel.Visible = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles right_answer.Click

    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor

        BLabel1.BackColor = Color.SpringGreen
        answer.Text = "B"
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        BLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor

        CLabel1.BackColor = Color.SpringGreen
        answer.Text = "C"
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor

        DLabel1.BackColor = Color.SpringGreen
        answer.Text = "D"
    End Sub

    Private Sub ThreeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThreeToolStripButton.Click
        'My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)
        Try
            Me.QuestionTableAdapter.three(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        HintLabel1.Visible = False
        walk_away1.Visible = True
        Label7.Visible = True
        time_limit.Visible = True
        Timer2.Enabled = True


        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor


        right_answer.Text = "C"

        ThreeToolStrip.Enabled = False
        NumberLabel1.Visible = True
        QuestionLabel1.Visible = True
        NumberLabel1.Visible = True
        ALabel1.Visible = True
        BLabel1.Visible = True
        CLabel1.Visible = True
        DLabel1.Visible = True


        LinkLabel1.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True

        submit.Visible = True


        cancel.Visible = True
    End Sub

    Private Sub FourToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FourToolStripButton.Click
        ' My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)
        Try
            Me.QuestionTableAdapter.four(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        walk_away1.Visible = True
        HintLabel1.Visible = False
        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor

        Label7.Visible = True
        time_limit.Visible = True
        Timer2.Enabled = True


        right_answer.Text = "A"

        FourToolStrip.Enabled = False
        NumberLabel1.Visible = True
        QuestionLabel1.Visible = True
        NumberLabel1.Visible = True
        ALabel1.Visible = True
        BLabel1.Visible = True
        CLabel1.Visible = True
        DLabel1.Visible = True


        LinkLabel1.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True

        submit.Visible = True


        cancel.Visible = True

    End Sub

    Private Sub FiveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.QuestionTableAdapter.five(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Five1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Five1ToolStripButton.Click
        ' My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)
        Try
            Me.QuestionTableAdapter.five1(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        HintLabel1.Visible = False
        walk_away1.Visible = True
        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor

        Label7.Visible = True
        time_limit.Visible = True
        Timer2.Enabled = True


        right_answer.Text = "B"

        Five1ToolStrip.Enabled = False
        NumberLabel1.Visible = True
        QuestionLabel1.Visible = True
        NumberLabel1.Visible = True
        ALabel1.Visible = True
        BLabel1.Visible = True
        CLabel1.Visible = True
        DLabel1.Visible = True


        LinkLabel1.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True

        submit.Visible = True


        cancel.Visible = True

    End Sub

    Private Sub SixToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SixToolStripButton.Click
        ' My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)
        Try
            Me.QuestionTableAdapter.six(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        HintLabel1.Visible = False
        walk_away1.Visible = True
        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor

        Label7.Visible = True
        time_limit.Visible = True
        Timer2.Enabled = True


        right_answer.Text = "C"

        SixToolStrip.Enabled = False
        NumberLabel1.Visible = True
        QuestionLabel1.Visible = True
        NumberLabel1.Visible = True
        ALabel1.Visible = True
        BLabel1.Visible = True
        CLabel1.Visible = True
        DLabel1.Visible = True


        LinkLabel1.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True

        submit.Visible = True


        cancel.Visible = True

    End Sub

    Private Sub SevenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SevenToolStripButton.Click
        'My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)
        Try
            Me.QuestionTableAdapter.seven(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        walk_away1.Visible = True
        HintLabel1.Visible = False
        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor

        Label7.Visible = True
        time_limit.Visible = True
        Timer2.Enabled = True


        right_answer.Text = "A"

        SevenToolStrip.Enabled = False
        NumberLabel1.Visible = True
        QuestionLabel1.Visible = True
        NumberLabel1.Visible = True
        ALabel1.Visible = True
        BLabel1.Visible = True
        CLabel1.Visible = True
        DLabel1.Visible = True


        LinkLabel1.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True

        submit.Visible = True


        cancel.Visible = True

    End Sub

    Private Sub SevenToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles SevenToolStrip.ItemClicked

    End Sub

    Private Sub EightToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EightToolStripButton.Click
        ' My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)
        Try
            Me.QuestionTableAdapter.eight(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        walk_away1.Visible = True
        HintLabel1.Visible = False
        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor

        Label7.Visible = True
        time_limit.Visible = True
        Timer2.Enabled = True


        right_answer.Text = "A"

        EightToolStrip.Enabled = False
        NumberLabel1.Visible = True
        QuestionLabel1.Visible = True
        NumberLabel1.Visible = True
        ALabel1.Visible = True
        BLabel1.Visible = True
        CLabel1.Visible = True
        DLabel1.Visible = True


        LinkLabel1.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True

        submit.Visible = True


        cancel.Visible = True

    End Sub

    Private Sub NineToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NineToolStripButton.Click
        ' My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)
        Try
            Me.QuestionTableAdapter.nine(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        walk_away1.Visible = True
        HintLabel1.Visible = False
        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor

        Label7.Visible = True
        time_limit.Visible = True
        Timer2.Enabled = True


        right_answer.Text = "D"

        NineToolStrip.Enabled = False
        NumberLabel1.Visible = True
        QuestionLabel1.Visible = True
        NumberLabel1.Visible = True
        ALabel1.Visible = True
        BLabel1.Visible = True
        CLabel1.Visible = True
        DLabel1.Visible = True


        LinkLabel1.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True

        submit.Visible = True


        cancel.Visible = True

    End Sub

    Private Sub TenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TenToolStripButton.Click
        'My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)
        Try
            Me.QuestionTableAdapter.ten(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        walk_away1.Visible = True
        HintLabel1.Visible = False
        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor

        Label7.Visible = True
        time_limit.Visible = True
        Timer2.Enabled = True


        right_answer.Text = "A"

        TenToolStrip.Enabled = False
        NumberLabel1.Visible = True
        QuestionLabel1.Visible = True
        NumberLabel1.Visible = True
        ALabel1.Visible = True
        BLabel1.Visible = True
        CLabel1.Visible = True
        DLabel1.Visible = True


        LinkLabel1.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True

        submit.Visible = True


        cancel.Visible = True

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        HintLabel1.Visible = True
        PictureBox5.Image = PictureBox7.Image
        PictureBox5.Enabled = False

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PictureBox4.Image = PictureBox6.Image
        PictureBox4.Enabled = False
        If (right_answer.Text = "A") Then
            BLabel1.Visible = False
            DLabel1.Visible = False
            LinkLabel2.Visible = False
            LinkLabel4.Visible = False
        ElseIf (right_answer.Text = "B") Then
            ALabel1.Visible = False
            CLabel1.Visible = False
            LinkLabel1.Visible = False
            LinkLabel3.Visible = False
        ElseIf (right_answer.Text = "C") Then
            BLabel1.Visible = False
            DLabel1.Visible = False
            LinkLabel2.Visible = False
            LinkLabel4.Visible = False
        ElseIf (right_answer.Text = "D") Then
            BLabel1.Visible = False
            CLabel1.Visible = False
            LinkLabel3.Visible = False
            LinkLabel4.Visible = False
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles play.Click
        ' My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)
        Panel1.Visible = False
        Label2.Visible = True
        Label5.Visible = True


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub Button1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        play.Enabled = True

        Timer1.Enabled = True


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        generate.Text = (Int(Rnd() * 21) + 1)
        stop_time = stop_time + 1
        If stop_time = 70 Then
            Timer1.Enabled = False
        End If



    End Sub

    Private Sub generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generate.Click
        stop_time = 1
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        time_limit.Text = (time_limit.Text - 1)

        'To get the reward if Time Elapse

        If (time_limit.Text = "0" And answer.Text <> right_answer.Text) Then
            Timer2.Enabled = False

            Reset_Timer(Label6, fifty, hundred, one_fifty, two_hundred, two_fifty, three_hundred, three_fifty, four_hundred, four_fifty, five_hundred, five_fifty, six_hundred, six_fifty)

            ' Rseting Values
            Reset(fifty, hundred, one_fifty, two_hundred, two_fifty, three_hundred, three_fifty, four_hundred, four_fifty, five_hundred, five_fifty, six_hundred, six_fifty, ALabel1, BLabel1, CLabel1, DLabel1, PictureBox4, PictureBox8, PictureBox5, PictureBox9)

            ' To Reset the Screen to new Page
            Panel1.Visible = True
            play.Enabled = False
            stop_time = 1
            Label2.Visible = False
            generate.Text = ""
            Label5.Visible = False

            ' To remove the question When the answer is wrong
            NumberLabel1.Visible = False
            QuestionLabel1.Visible = False
            NumberLabel1.Visible = False
            ALabel1.Visible = False
            BLabel1.Visible = False
            CLabel1.Visible = False
            DLabel1.Visible = False
            LinkLabel1.Visible = False
            LinkLabel2.Visible = False
            LinkLabel3.Visible = False
            LinkLabel4.Visible = False
            HintLabel1.Visible = False

            PictureBox4.Enabled = True
            PictureBox5.Enabled = True


            Label7.Visible = False
            time_limit.Text = "30"
            time_limit.Visible = False
            Timer2.Enabled = False
            Exit Sub

        End If

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TwoToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles TwoToolStrip.ItemClicked

    End Sub

    Private Sub walk_away1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles walk_away1.Click
        
      
            Reset_Timer(Label6, fifty, hundred, one_fifty, two_hundred, two_fifty, three_hundred, three_fifty, four_hundred, four_fifty, five_hundred, five_fifty, six_hundred, six_fifty)

            ' Rseting Values
            Reset(fifty, hundred, one_fifty, two_hundred, two_fifty, three_hundred, three_fifty, four_hundred, four_fifty, five_hundred, five_fifty, six_hundred, six_fifty, ALabel1, BLabel1, CLabel1, DLabel1, PictureBox4, PictureBox8, PictureBox5, PictureBox9)

            ' To Reset the Screen to new Page
            Panel1.Visible = True
            play.Enabled = False
            stop_time = 1
            Label2.Visible = False
            generate.Text = ""
            Label5.Visible = False

            ' To remove the question When the answer is wrong
            NumberLabel1.Visible = False
            QuestionLabel1.Visible = False
            NumberLabel1.Visible = False
            ALabel1.Visible = False
            BLabel1.Visible = False
            CLabel1.Visible = False
            DLabel1.Visible = False
            LinkLabel1.Visible = False
            LinkLabel2.Visible = False
            LinkLabel3.Visible = False
            LinkLabel4.Visible = False
            HintLabel1.Visible = False

            PictureBox4.Enabled = True
            PictureBox5.Enabled = True


            Label7.Visible = False
            time_limit.Text = "30"
            time_limit.Visible = False
            Timer2.Enabled = False

    End Sub



    

    Private Sub ElevenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElevenToolStripButton.Click
        Try
            Me.QuestionTableAdapter.eleven(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ElevenToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ElevenToolStrip.ItemClicked
        'My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)

        walk_away1.Visible = True
        Label7.Visible = True
        time_limit.Visible = True
        Timer2.Enabled = True

        BLabel1.BackColor = Me.BackColor
        CLabel1.BackColor = Me.BackColor
        DLabel1.BackColor = Me.BackColor
        ALabel1.BackColor = Me.BackColor


        right_answer.Text = "D"
        Try
            Me.QuestionTableAdapter.One(Me.QuestionDataSet.question)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        ElevenToolStrip.Enabled = False
        NumberLabel1.Visible = True
        QuestionLabel1.Visible = True
        NumberLabel1.Visible = True
        ALabel1.Visible = True
        BLabel1.Visible = True
        CLabel1.Visible = True
        DLabel1.Visible = True


        LinkLabel1.Visible = True
        LinkLabel2.Visible = True
        LinkLabel3.Visible = True
        LinkLabel4.Visible = True

        submit.Visible = True


        cancel.Visible = True
        HintLabel1.Visible = False

    End Sub
End Class
