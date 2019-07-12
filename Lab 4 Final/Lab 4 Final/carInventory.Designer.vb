<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ttpCarInventory = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMsg.Location = New System.Drawing.Point(32, 458)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(494, 80)
        Me.lblMsg.TabIndex = 24
        Me.ttpCarInventory.SetToolTip(Me.lblMsg, "Display the final Message")
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(418, 555)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 36)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "E&xit"
        Me.ttpCarInventory.SetToolTip(Me.btnExit, "Click to exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(278, 555)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(108, 36)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "&Reset"
        Me.ttpCarInventory.SetToolTip(Me.btnReset, "Click to reset all the controls")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(138, 555)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(108, 36)
        Me.btnEnter.TabIndex = 25
        Me.btnEnter.Text = "&Enter"
        Me.ttpCarInventory.SetToolTip(Me.btnEnter, "Click to enter car details")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNew.Location = New System.Drawing.Point(77, 156)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(96, 24)
        Me.chkNew.TabIndex = 22
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpCarInventory.SetToolTip(Me.chkNew, "Display whether the car is NEW.")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2016", "2017", "2018", "2019"})
        Me.cmbYear.Location = New System.Drawing.Point(172, 83)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(198, 28)
        Me.cmbYear.TabIndex = 19
        Me.ttpCarInventory.SetToolTip(Me.cmbYear, "Display year in which car was manufactured")
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Hyundai", "Volkswagon", "Honda", "Toyota"})
        Me.cmbMake.Location = New System.Drawing.Point(172, 18)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(198, 28)
        Me.cmbMake.TabIndex = 15
        Me.ttpCarInventory.SetToolTip(Me.cmbMake, "Display the company names of the car")
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(172, 118)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(198, 27)
        Me.txtPrice.TabIndex = 21
        Me.ttpCarInventory.SetToolTip(Me.txtPrice, "Display price of the car")
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(172, 50)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(198, 27)
        Me.txtModel.TabIndex = 17
        Me.ttpCarInventory.SetToolTip(Me.txtModel, "Display the model of a company")
        '
        'lvwCars
        '
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCars.Location = New System.Drawing.Point(25, 186)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(642, 269)
        Me.lvwCars.TabIndex = 23
        Me.ttpCarInventory.SetToolTip(Me.lvwCars, "Display the details of all cars entered")
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 76
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 114
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 112
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(48, 125)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(73, 20)
        Me.lblPrice.TabIndex = 20
        Me.lblPrice.Text = "&Price"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpCarInventory.SetToolTip(Me.lblPrice, "Display Price label")
        '
        'lblYear
        '
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(48, 91)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(68, 20)
        Me.lblYear.TabIndex = 18
        Me.lblYear.Text = "&Year"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpCarInventory.SetToolTip(Me.lblYear, "Display Year label")
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(48, 57)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(79, 20)
        Me.lblModel.TabIndex = 16
        Me.lblModel.Text = "M&odel"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpCarInventory.SetToolTip(Me.lblModel, "Display Model label")
        '
        'lblMake
        '
        Me.lblMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Location = New System.Drawing.Point(44, 26)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(78, 20)
        Me.lblMake.TabIndex = 14
        Me.lblMake.Text = "&Make"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpCarInventory.SetToolTip(Me.lblMake, "Display Make label")
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(710, 619)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.MaximumSize = New System.Drawing.Size(728, 666)
        Me.MinimumSize = New System.Drawing.Size(728, 666)
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ttpCarInventory As ToolTip
    Friend WithEvents lblMsg As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents lvwCars As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblMake As Label
End Class
