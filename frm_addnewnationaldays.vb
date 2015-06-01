Imports System
Imports System.Data
Imports System.Windows.Forms
Imports ADODB
Public Class frm_addnewnationaldays
    Inherits Form
    Dim rs As New ADODB.Recordset
    Dim cn As New ADODB.Connection
    Private Sub frm_addnewnationaldays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        cn.ConnectionString = "Provider=SQLNCLI11;Server=192.168.0.1;Database=AN_SUMATRA;Uid=itdevelopment;Pwd=itdevelopment2015"
        cn.Open()
        rs = cn.Execute("SELECT [Description] FROM [AN_SUMATRA].[dbo].[TM_YearPeriode] ORDER BY [No] ASC")
        If ((rs.EOF = False) And (rs.BOF = False)) = True Then
            While Not rs.EOF
                cbo_yearpriode.Items.Add(rs(0).Value.ToString)
                rs.MoveNext()
            End While
        End If
        DGVdate()
        AutoNumberRowsForGridView()



    End Sub
    'show date in datagrid
    Sub DGVdate()
        Dim col As New GridDateControl()
        Me.DGV.Columns.Add(col)
        DGV.Columns(0).HeaderText = "Date"
        DGV.Columns(0).Width = 200

        With DGV
            .ColumnCount = 2
            .Columns(1).HeaderText = "Event Description"
            .Columns(1).Width = 500
        End With
    End Sub
    'autonumber in datagrid
    Sub AutoNumberRowsForGridView()
        If DGV IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (DGV.Rows.Count - 2))
                DGV.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")
                count += 1
            End While
        End If
    End Sub
    Private Sub DGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        AutoNumberRowsForGridView()
    End Sub

    Private Sub DGV_Click(sender As Object, e As EventArgs) Handles DGV.Click
        DGVdate()
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Try
            Dim xlAPP As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlAPP = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlAPP.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")

            For i = 0 To DGV.RowCount - 2
                For j = 0 To DGV.ColumnCount - 1
                    For k As Integer = 1 To DGV.Columns.Count
                        xlWorkSheet.Cells(1, k) = DGV.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DGV(j, i).Value.ToString()
                    Next
                Next
            Next

            xlAPP.Visible = True
            xlWorkSheet.UsedRange.EntireRow.AutoFit()
            xlWorkSheet.UsedRange.EntireColumn.AutoFit()
            releaseObject(xlAPP)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch es As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub cbo_yearpriode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_yearpriode.SelectedIndexChanged
        rs = cn.Execute("SELECT [Code], [Description], [Periode_From], [Periode_To] FROM [AN_SUMATRA].[dbo].[TM_YearPeriode] WHERE [Description]='" & cbo_yearpriode.Text.ToString & "' ORDER BY [No] ASC")
        If (rs.EOF = False) And (rs.BOF = False) Then
            txt_datefrom.Text = rs(2).Value.ToString
            txt_dateto.Text = rs(3).Value.ToString
        Else
            txt_dateto.Text = ""
            txt_datefrom.Text = ""
        End If

        If cbo_yearpriode.Text = "Year 2014" Then
            txt_yearcode.Text = 2014
        End If
        If cbo_yearpriode.Text = "Year 2015" Then
            txt_yearcode.Text = 2015
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        For i As Integer = 0 To DGV.Rows.Count - 2
            If MessageBox.Show("Apakah Anda yakin akan menyimpan data?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim sqlInsert As String = "INSERT INTO [AN_SUMATRA].[dbo].[TM_NationalDays]([Year_Code],[Year_Description],[Date_Event],[Event_Description],[Create_By],[Create_Time],[Validate_By],[System_Id]) values "
                sqlInsert = sqlInsert & " ('" & txt_yearcode.Text & "','" & cbo_yearpriode.Text.ToString & "','" & DGV.Rows(i).Cells(0).Value & "','" & DGV.Rows(i).Cells(1).Value & "','" & CurrentAccountName & "'," & "GETDATE()" & " " & ",'" & txt_validation.Text & "','" & CurrentAccountId & "')"
                cn.Execute(sqlInsert)

                cn.Close()
                Me.Close()
            End If
        Next
    End Sub
End Class
Public Class GridDateControl
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New CalendarCell())
    End Sub

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)

            ' Ensure that the cell used for the template is a CalendarCell.
            If Not (value Is Nothing) AndAlso _
                Not value.GetType().IsAssignableFrom(GetType(CalendarCell)) _
                Then
                Throw New InvalidCastException("Must be a CalendarCell")
            End If
            MyBase.CellTemplate = value

        End Set
    End Property

End Class

Public Class CalendarCell
    Inherits DataGridViewTextBoxCell

    Public Sub New()
        ' Use the short date format.
        Me.Style.Format = "dd / MMMM / yyyy"
    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, _
        ByVal initialFormattedValue As Object, _
        ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, _
            dataGridViewCellStyle)

        Dim ctl As CalendarEditingControl = _
            CType(DataGridView.EditingControl, CalendarEditingControl)
        If Not Me.Value Is DBNull.Value Then
            If Not Me.Value Is Nothing Then
                ctl.Value = CType(Me.Value, DateTime)
            End If
        End If
    End Sub

    Public Overrides ReadOnly Property EditType() As Type
        Get
            ' Return the type of the editing contol that CalendarCell uses.
            Return GetType(CalendarEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            ' Return the type of the value that CalendarCell contains.
            Return GetType(DateTime)
        End Get
    End Property
End Class

Class CalendarEditingControl
    Inherits DateTimePicker
    Implements IDataGridViewEditingControl

    Private dataGridViewControl As DataGridView
    Private valueIsChanged As Boolean = False
    Private rowIndexNum As Integer

    Public Sub New()
        Me.Format = DateTimePickerFormat.Long
    End Sub

    Public Property EditingControlFormattedValue() As Object _
        Implements IDataGridViewEditingControl.EditingControlFormattedValue

        Get
            Return Me.Value.ToLongDateString()
        End Get

        Set(ByVal value As Object)
            If TypeOf value Is [String] Then
                Me.Value = DateTime.Parse(CStr(value))
            End If
        End Set

    End Property

    Public Function GetEditingControlFormattedValue(ByVal context _
        As DataGridViewDataErrorContexts) As Object _
        Implements IDataGridViewEditingControl.GetEditingControlFormattedValue

        Return Me.Value.ToLongDateString()

    End Function

    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As  _
        DataGridViewCellStyle) _
        Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl

        Me.Font = dataGridViewCellStyle.Font
        Me.CalendarForeColor = dataGridViewCellStyle.ForeColor
        Me.CalendarMonthBackground = dataGridViewCellStyle.BackColor

    End Sub

    Public Property EditingControlRowIndex() As Integer _
        Implements IDataGridViewEditingControl.EditingControlRowIndex

        Get
            Return rowIndexNum
        End Get
        Set(ByVal value As Integer)
            rowIndexNum = value
        End Set

    End Property

    Public Function EditingControlWantsInputKey(ByVal key As Keys, _
        ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
        Implements IDataGridViewEditingControl.EditingControlWantsInputKey

        ' Let the DateTimePicker handle the keys listed.
        Select Case key And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, _
                Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp

                Return True

            Case Else
                Return False
        End Select

    End Function

    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
        Implements IDataGridViewEditingControl.PrepareEditingControlForEdit

        ' No preparation needs to be done.

    End Sub

    Public ReadOnly Property RepositionEditingControlOnValueChange() _
        As Boolean Implements _
        IDataGridViewEditingControl.RepositionEditingControlOnValueChange

        Get
            Return False
        End Get

    End Property

    Public Property EditingControlDataGridView() As DataGridView _
        Implements IDataGridViewEditingControl.EditingControlDataGridView

        Get
            Return dataGridViewControl
        End Get
        Set(ByVal value As DataGridView)
            dataGridViewControl = value
        End Set

    End Property

    Public Property EditingControlValueChanged() As Boolean _
        Implements IDataGridViewEditingControl.EditingControlValueChanged

        Get
            Return valueIsChanged
        End Get
        Set(ByVal value As Boolean)
            valueIsChanged = value
        End Set

    End Property

    Public ReadOnly Property EditingControlCursor() As Cursor _
        Implements IDataGridViewEditingControl.EditingPanelCursor

        Get
            Return MyBase.Cursor
        End Get

    End Property

    Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)

        ' Notify the DataGridView that the contents of the cell have changed.
        valueIsChanged = True

        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
        MyBase.OnValueChanged(eventargs)

    End Sub

End Class