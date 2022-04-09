<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministararCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminsitrarPermisoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JornadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeUsiarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeOpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarOpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestinarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.EditarToolStripMenuItem, Me.VerToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.SeguridadToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministararCargosToolStripMenuItem, Me.AdminsitrarPermisoToolStripMenuItem, Me.AdministrarVacacionesToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.VerToolStripMenuItem.Text = "Administrar"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JornadaToolStripMenuItem, Me.AsistenciaToolStripMenuItem, Me.InformeGeneralToolStripMenuItem})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.SeguridadToolStripMenuItem.Text = "ver"
        '
        'SeguridadToolStripMenuItem1
        '
        Me.SeguridadToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeUsiarioToolStripMenuItem, Me.GestionDeRolesToolStripMenuItem, Me.GestionDeOpcionesToolStripMenuItem})
        Me.SeguridadToolStripMenuItem1.Name = "SeguridadToolStripMenuItem1"
        Me.SeguridadToolStripMenuItem1.Size = New System.Drawing.Size(72, 20)
        Me.SeguridadToolStripMenuItem1.Text = "Seguridad"
        '
        'AdministararCargosToolStripMenuItem
        '
        Me.AdministararCargosToolStripMenuItem.Name = "AdministararCargosToolStripMenuItem"
        Me.AdministararCargosToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AdministararCargosToolStripMenuItem.Text = "Administarar cargos"
        '
        'AdminsitrarPermisoToolStripMenuItem
        '
        Me.AdminsitrarPermisoToolStripMenuItem.Name = "AdminsitrarPermisoToolStripMenuItem"
        Me.AdminsitrarPermisoToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AdminsitrarPermisoToolStripMenuItem.Text = "Administrar permiso"
        '
        'AdministrarVacacionesToolStripMenuItem
        '
        Me.AdministrarVacacionesToolStripMenuItem.Name = "AdministrarVacacionesToolStripMenuItem"
        Me.AdministrarVacacionesToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AdministrarVacacionesToolStripMenuItem.Text = "Administrar vacaciones"
        '
        'JornadaToolStripMenuItem
        '
        Me.JornadaToolStripMenuItem.Name = "JornadaToolStripMenuItem"
        Me.JornadaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JornadaToolStripMenuItem.Text = "Jornada"
        '
        'AsistenciaToolStripMenuItem
        '
        Me.AsistenciaToolStripMenuItem.Name = "AsistenciaToolStripMenuItem"
        Me.AsistenciaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AsistenciaToolStripMenuItem.Text = "Asistencia"
        '
        'InformeGeneralToolStripMenuItem
        '
        Me.InformeGeneralToolStripMenuItem.Name = "InformeGeneralToolStripMenuItem"
        Me.InformeGeneralToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InformeGeneralToolStripMenuItem.Text = "Informe general"
        '
        'GestionDeUsiarioToolStripMenuItem
        '
        Me.GestionDeUsiarioToolStripMenuItem.Name = "GestionDeUsiarioToolStripMenuItem"
        Me.GestionDeUsiarioToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GestionDeUsiarioToolStripMenuItem.Text = "Gestion de usiario"
        '
        'GestionDeRolesToolStripMenuItem
        '
        Me.GestionDeRolesToolStripMenuItem.Name = "GestionDeRolesToolStripMenuItem"
        Me.GestionDeRolesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GestionDeRolesToolStripMenuItem.Text = "Gestion de roles "
        '
        'GestionDeOpcionesToolStripMenuItem
        '
        Me.GestionDeOpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.AsignarOpcionesToolStripMenuItem})
        Me.GestionDeOpcionesToolStripMenuItem.Name = "GestionDeOpcionesToolStripMenuItem"
        Me.GestionDeOpcionesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GestionDeOpcionesToolStripMenuItem.Text = "Gestion de opciones"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'AsignarOpcionesToolStripMenuItem
        '
        Me.AsignarOpcionesToolStripMenuItem.Name = "AsignarOpcionesToolStripMenuItem"
        Me.AsignarOpcionesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AsignarOpcionesToolStripMenuItem.Text = "Asignar Opciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GestinarEmpleadoToolStripMenuItem
        '
        Me.GestinarEmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.BorarToolStripMenuItem, Me.EditarToolStripMenuItem1})
        Me.GestinarEmpleadoToolStripMenuItem.Name = "GestinarEmpleadoToolStripMenuItem"
        Me.GestinarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.GestinarEmpleadoToolStripMenuItem.Text = "Gestinar empleado"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'GestionarDepartamentoToolStripMenuItem
        '
        Me.GestionarDepartamentoToolStripMenuItem.Name = "GestionarDepartamentoToolStripMenuItem"
        Me.GestionarDepartamentoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.GestionarDepartamentoToolStripMenuItem.Text = "Gestionar departamento"
        '
        'GestionarCargosToolStripMenuItem
        '
        Me.GestionarCargosToolStripMenuItem.Name = "GestionarCargosToolStripMenuItem"
        Me.GestionarCargosToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.GestionarCargosToolStripMenuItem.Text = "Gestionar cargos"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestinarEmpleadoToolStripMenuItem, Me.GestionarDepartamentoToolStripMenuItem, Me.GestionarCargosToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'BorarToolStripMenuItem
        '
        Me.BorarToolStripMenuItem.Name = "BorarToolStripMenuItem"
        Me.BorarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BorarToolStripMenuItem.Text = "Borar"
        '
        'EditarToolStripMenuItem1
        '
        Me.EditarToolStripMenuItem1.Name = "EditarToolStripMenuItem1"
        Me.EditarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EditarToolStripMenuItem1.Text = "Editar"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministararCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminsitrarPermisoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarVacacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JornadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsistenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionDeUsiarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeRolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeOpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarOpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestinarEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarDepartamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem1 As ToolStripMenuItem
End Class
