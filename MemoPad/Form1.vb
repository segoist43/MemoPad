Public Class frmMain
    Public strText As String 'rtxMemo 의 텍스트를 임시로 저장하는 변수를 생성합니다.
    Dim argFilename As String '파일명을 보관하는 변수를 생성합니다.
    Dim strModify As Boolean = False 'rtxMemo 의 텍스트 변경 여부를 확인하는 변수를 생성합니다.
    Dim Fileopen As Boolean = False '파일의 Open 여부를 확인하는 변수를 생성합니다.

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        Dim ans As Integer 'MsgBox의 결과값을 저장할 정수형 변수를 생성합니다.

        If strModify = True Then '메모장에 변경 사항이 있으면
            ans = MsgBox("저장하지 않고 새로 만드시겠습니까?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "새로 만들기")
            If ans = MsgBoxResult.No Then 'No 버튼 선택 시
                Exit Sub
            ElseIf ans = MsgBoxResult.Yes Then 'Yes 버튼 선택 시
                argFilename = "" '파일 이름을 초기화합니다.
                rtxMemo.Text = "" 'rtxMemo 의 텍스트를 초기화 합니다.
                strModify = False '변경 여부를 초기화합니다.
            End If
        Else '메모장에 변경 사항이 없으면
            argFilename = "" '파일명을 초기화합니다.
            rtxMemo.Text = "" 'rtxMemo 의 텍스트를 초기화 합니다.
            strModify = False '변경 여부를 초기화합니다.
        End If
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        Dim readFile As IO.StreamReader

        '열기 대화 상자를 설정합니다.
        OpenDlg.Title = "파일 불러오기"
        OpenDlg.InitialDirectory = ""
        OpenDlg.FileName = argFilename
        OpenDlg.Filter = "텍스트 문서 | *.txt, *.rtf"

        '대화 상자 결과가 OK 일 때
        If OpenDlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            argFilename = OpenDlg.FileName
            readFile = New IO.StreamReader(OpenDlg.FileName, System.Text.Encoding.Default)
            Fileopen = True '파일의 Open 여부를 설정합니다.
            rtxMemo.Text = readFile.ReadToEnd '파일을 읽습니다.
            readFile.Close() '파일의 I/O 를 닫습니다.
            readFile = Nothing '메모리를 해제합니다.
        End If
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        Dim writeFile As IO.StreamWriter

        If Trim(argFilename) = "" Then '신규 파일인 경우 파일명을 확인하고 저장합니다.
            '저장 대화 상자를 설정합니다.
            SaveDlg.Title = "파일 저장하기"
            SaveDlg.InitialDirectory = ""
            SaveDlg.FileName = argFilename
            SaveDlg.Filter = "텍스트 문서 | *.txt, *.rtf"

            '대화 상자 결과가 OK 일 때
            If SaveDlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                argFilename = SaveDlg.FileName
                writeFile = New IO.StreamWriter(SaveDlg.FileName, False, System.Text.Encoding.Default)
                writeFile.Write(rtxMemo.Text) 'rtxMemo 의 텍스트를 저장합니다.
                writeFile.Close() '파일의 I/O 를 닫습니다.
                writeFile = Nothing ' 메모리를 해제합니다.
                strModify = False '변경 여부를 초기화합니다.
            End If
        Else '기존 파일인 경우 무조건 저장합니다.
            writeFile = New IO.StreamWriter(SaveDlg.FileName, False, System.Text.Encoding.Default)
            writeFile.Write(rtxMemo.Text) 'rtxMemo 의 텍스트를 저장합니다.
            writeFile.Close() '파일의 I/O 를 닫습니다.
            writeFile = Nothing ' 메모리를 해제합니다.
            strModify = False '변경 여부를 초기화합니다.
        End If
    End Sub

    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        Dim writeFile As IO.StreamWriter

        '저장 대화 상자를 설정합니다.
        SaveDlg.Title = "다른 이름으로 저장하기"
        SaveDlg.InitialDirectory = ""
        SaveDlg.FileName = argFilename
        SaveDlg.Filter = "텍스트 문서 | *.txt, *.rtf"

        '대화 상자 결과가 OK 일 때
        If SaveDlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            argFilename = SaveDlg.FileName
            writeFile = New IO.StreamWriter(SaveDlg.FileName, False, System.Text.Encoding.Default)
            writeFile.Write(rtxMemo.Text) 'rtxMemo 의 텍스트를 저장합니다.
            writeFile.Close() '파일의 I/O 를 닫습니다.
            writeFile = Nothing ' 메모리를 해제합니다.
            strModify = False '변경 여부를 초기화합니다.
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Dim Ans As Integer '메세지 결과 값을 저장하는 변수를 생성합니다.

        If strModify = True Then '메모장에 변경사항이 있으면
            Ans = MsgBox("저장하지 않고 종료하시겠습니까?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "종료")
            If Ans = MsgBoxResult.Cancel Then
                Exit Sub
            ElseIf Ans = MsgBoxResult.Ok Then
                End
            End If
        Else
            End
        End If
    End Sub

    Private Sub rtxMemo_TextChanged(sender As Object, e As EventArgs) Handles rtxMemo.TextChanged
        'rtxMemo 의 텍스트가 변경되었을 경우
        mnuCut.Enabled = True
        mnuCopy.Enabled = True

        If Fileopen = False Then '파일 Open에 의한 변경이 아닐 경우
            strModify = True
        Else '파일 Open에 의한 변경인 경우
            strModify = False
            Fileopen = False
        End If
    End Sub

    Private Sub mnuFont_Click(sender As Object, e As EventArgs) Handles mnuFont.Click
        FontDlg.ShowDialog() '글꼴 대화 상자를 띄웁니다.
        rtxMemo.Font = FontDlg.Font 'rtxMemo 의 텍스트 글꼴을 대화상자의 설정으로 변경합니다.
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        strText = rtxMemo.SelectedText '선택된 텍스트를 srtText 에 저장합니다.
        rtxMemo.SelectedText = "" '선택된 항목을 지웁니다.
        mnuPaste.Enabled = True 'mnuPaste 항목을 활성화합니다.
        rtxMemo.Focus() '커서를 rtxMemo 로 이동합니다.
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        strText = rtxMemo.SelectedText '선택된 텍스트를 srtText 에 저장합니다.
        mnuPaste.Enabled = True 'mnuPaste 항목을 활성화합니다.
        rtxMemo.Focus() '커서를 rtxMemo 로 이동합니다.
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        rtxMemo.SelectedText = strText 'strText 에 저장되었던 텍스트를 rtxMemo 에 붙여넣습니다.
        mnuPaste.Enabled = True 'mnuPaste 항목을 활성화합니다.
        rtxMemo.Focus() '커서를 rtxMemo 로 이동합니다.
    End Sub

    Private Sub mnuSelectAll_Click(sender As Object, e As EventArgs) Handles mnuSelectAll.Click
        rtxMemo.SelectAll() 'rtxMemo 의 텍스트를 모두 선택합니다.
    End Sub
End Class