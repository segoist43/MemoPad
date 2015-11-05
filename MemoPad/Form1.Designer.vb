<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuPageSett = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFindNext = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGoto = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTimeDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFormat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWordWrap = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStatBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtxMemo = New System.Windows.Forms.RichTextBox()
        Me.ConMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenDlg = New System.Windows.Forms.OpenFileDialog()
        Me.SaveDlg = New System.Windows.Forms.SaveFileDialog()
        Me.FontDlg = New System.Windows.Forms.FontDialog()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.AutoSize = False
        Me.mnuMain.BackColor = System.Drawing.SystemColors.Control
        Me.mnuMain.GripMargin = New System.Windows.Forms.Padding(0)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuFormat, Me.mnuView, Me.HelpToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Padding = New System.Windows.Forms.Padding(0)
        Me.mnuMain.Size = New System.Drawing.Size(784, 24)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.ToolStripSeparator1, Me.mnuPageSett, Me.mnuPrint, Me.ToolStripSeparator2, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFile.ShowShortcutKeys = False
        Me.mnuFile.Size = New System.Drawing.Size(57, 24)
        Me.mnuFile.Text = "파일(&F)"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNew.Size = New System.Drawing.Size(197, 22)
        Me.mnuNew.Text = "새로 만들기(&N)"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(197, 22)
        Me.mnuOpen.Text = "열기(&O)..."
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuSave.Size = New System.Drawing.Size(197, 22)
        Me.mnuSave.Text = "저장(&S)"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(197, 22)
        Me.mnuSaveAs.Text = "다른 이름으로 저장..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(194, 6)
        '
        'mnuPageSett
        '
        Me.mnuPageSett.Name = "mnuPageSett"
        Me.mnuPageSett.Size = New System.Drawing.Size(197, 22)
        Me.mnuPageSett.Text = "페이지 설정..."
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuPrint.Size = New System.Drawing.Size(197, 22)
        Me.mnuPrint.Text = "인쇄(&P)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(194, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(197, 22)
        Me.mnuExit.Text = "종료"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUndo, Me.ToolStripSeparator3, Me.mnuCut, Me.mnuCopy, Me.mnuPaste, Me.mnuDelete, Me.ToolStripSeparator4, Me.mnuFind, Me.mnuFindNext, Me.mnuReplace, Me.mnuGoto, Me.ToolStripSeparator5, Me.mnuSelectAll, Me.mnuTimeDate})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(57, 24)
        Me.mnuEdit.Text = "편집(&E)"
        '
        'mnuUndo
        '
        Me.mnuUndo.Name = "mnuUndo"
        Me.mnuUndo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.mnuUndo.Size = New System.Drawing.Size(188, 22)
        Me.mnuUndo.Text = "실행 취소"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(185, 6)
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuCut.Size = New System.Drawing.Size(188, 22)
        Me.mnuCut.Text = "잘라내기"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(188, 22)
        Me.mnuCopy.Text = "복사"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(188, 22)
        Me.mnuPaste.Text = "붙여넣기"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.mnuDelete.Size = New System.Drawing.Size(188, 22)
        Me.mnuDelete.Text = "삭제"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(185, 6)
        '
        'mnuFind
        '
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuFind.Size = New System.Drawing.Size(188, 22)
        Me.mnuFind.Text = "찾기..."
        '
        'mnuFindNext
        '
        Me.mnuFindNext.Name = "mnuFindNext"
        Me.mnuFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuFindNext.Size = New System.Drawing.Size(188, 22)
        Me.mnuFindNext.Text = "다음 찾기"
        '
        'mnuReplace
        '
        Me.mnuReplace.Name = "mnuReplace"
        Me.mnuReplace.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.mnuReplace.Size = New System.Drawing.Size(188, 22)
        Me.mnuReplace.Text = "바꾸기..."
        '
        'mnuGoto
        '
        Me.mnuGoto.Name = "mnuGoto"
        Me.mnuGoto.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.mnuGoto.Size = New System.Drawing.Size(188, 22)
        Me.mnuGoto.Text = "줄 찾아가기..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(185, 6)
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Name = "mnuSelectAll"
        Me.mnuSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuSelectAll.Size = New System.Drawing.Size(188, 22)
        Me.mnuSelectAll.Text = "모두 선택"
        '
        'mnuTimeDate
        '
        Me.mnuTimeDate.Name = "mnuTimeDate"
        Me.mnuTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuTimeDate.Size = New System.Drawing.Size(188, 22)
        Me.mnuTimeDate.Text = "시간/날짜"
        '
        'mnuFormat
        '
        Me.mnuFormat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWordWrap, Me.mnuFont})
        Me.mnuFormat.Name = "mnuFormat"
        Me.mnuFormat.Size = New System.Drawing.Size(57, 24)
        Me.mnuFormat.Text = "형식(&F)"
        '
        'mnuWordWrap
        '
        Me.mnuWordWrap.CheckOnClick = True
        Me.mnuWordWrap.Name = "mnuWordWrap"
        Me.mnuWordWrap.Size = New System.Drawing.Size(137, 22)
        Me.mnuWordWrap.Text = "자동 줄바꿈"
        '
        'mnuFont
        '
        Me.mnuFont.Name = "mnuFont"
        Me.mnuFont.Size = New System.Drawing.Size(137, 22)
        Me.mnuFont.Text = "글꼴..."
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStatBar})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(58, 24)
        Me.mnuView.Text = "보기(&V)"
        '
        'mnuStatBar
        '
        Me.mnuStatBar.CheckOnClick = True
        Me.mnuStatBar.Name = "mnuStatBar"
        Me.mnuStatBar.Size = New System.Drawing.Size(140, 22)
        Me.mnuStatBar.Text = "상태 바 보기"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelp, Me.ToolStripSeparator6, Me.mnuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.HelpToolStripMenuItem.Text = "도움말(&H)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(156, 22)
        Me.mnuHelp.Text = "도움말 보기"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(153, 6)
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(156, 22)
        Me.mnuAbout.Text = "MemoPad 정보"
        '
        'rtxMemo
        '
        Me.rtxMemo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxMemo.DetectUrls = False
        Me.rtxMemo.EnableAutoDragDrop = True
        Me.rtxMemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxMemo.Location = New System.Drawing.Point(0, 24)
        Me.rtxMemo.Margin = New System.Windows.Forms.Padding(0)
        Me.rtxMemo.Name = "rtxMemo"
        Me.rtxMemo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.rtxMemo.Size = New System.Drawing.Size(784, 536)
        Me.rtxMemo.TabIndex = 2
        Me.rtxMemo.Text = ""
        '
        'ConMenu
        '
        Me.ConMenu.Name = "ConMenu"
        Me.ConMenu.Size = New System.Drawing.Size(61, 4)
        '
        'OpenDlg
        '
        Me.OpenDlg.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.rtxMemo)
        Me.Controls.Add(Me.mnuMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "MemoPad"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuPageSett As ToolStripMenuItem
    Friend WithEvents mnuPrint As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuUndo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents mnuFind As ToolStripMenuItem
    Friend WithEvents mnuFindNext As ToolStripMenuItem
    Friend WithEvents mnuReplace As ToolStripMenuItem
    Friend WithEvents mnuGoto As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents mnuSelectAll As ToolStripMenuItem
    Friend WithEvents mnuTimeDate As ToolStripMenuItem
    Friend WithEvents mnuFormat As ToolStripMenuItem
    Friend WithEvents mnuWordWrap As ToolStripMenuItem
    Friend WithEvents mnuFont As ToolStripMenuItem
    Friend WithEvents mnuView As ToolStripMenuItem
    Friend WithEvents mnuStatBar As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents rtxMemo As RichTextBox
    Friend WithEvents ConMenu As ContextMenuStrip
    Friend WithEvents OpenDlg As OpenFileDialog
    Friend WithEvents SaveDlg As SaveFileDialog
    Friend WithEvents FontDlg As FontDialog
End Class
