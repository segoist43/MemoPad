Public Class frmMain
    Dim argFilename As String '파일명을 보관하는 변수를 생성합니다.
    Dim strModify As Boolean = False 'rtxMemo 의 텍스트 변경 여부를 확인하는 변수를 생성합니다.
    Dim Fileopen As Boolean = False '파일의 Open 여부를 확인하는 변수를 생성합니다.

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        Dim ans As Integer 'MsgBox의 결과값을 저장할 정수형 변수를 생성합니다.

        If strModify = True Then '메모장에 변경 사항이 있으면
            ans = MsgBox("저장하지 않고 새로 만드시겠습니까?", MsgBoxStyle.YesNo, "새로 만들기")
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
End Class