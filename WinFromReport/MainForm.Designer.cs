using DevExpress.XtraGrid.Columns;

namespace WinFromReport;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        confirmButton = new DevExpress.XtraEditors.SimpleButton();
        fromDateEdit = new DevExpress.XtraEditors.DateEdit();
        toDateEdit = new DevExpress.XtraEditors.DateEdit();
        reportGrid = new DevExpress.XtraGrid.GridControl();
        reportDtoBindingSource = new BindingSource(components);
        gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
        Nazwa = new GridColumn();
        Data = new GridColumn();
        Godzina = new GridColumn();
        Użytkownik = new GridColumn();
        Lokal = new GridColumn();
        premisesDropDown = new DevExpress.XtraEditors.LookUpEdit();
        premisesDtoBindingSource = new BindingSource(components);
        ((System.ComponentModel.ISupportInitialize)fromDateEdit.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)fromDateEdit.Properties.CalendarTimeProperties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)toDateEdit.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)toDateEdit.Properties.CalendarTimeProperties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)reportGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)reportDtoBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)premisesDropDown.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)premisesDtoBindingSource).BeginInit();
        SuspendLayout();
        // 
        // confirmButton
        // 
        confirmButton.Location = new Point(12, 393);
        confirmButton.Name = "confirmButton";
        confirmButton.Size = new Size(140, 45);
        confirmButton.TabIndex = 0;
        confirmButton.Text = "Zatwierdź";
        confirmButton.Click += ConfirmButtonOnClick;
        // 
        // fromDateEdit
        // 
        fromDateEdit.EditValue = null;
        fromDateEdit.Location = new Point(12, 38);
        fromDateEdit.Name = "fromDateEdit";
        fromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        fromDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        fromDateEdit.Properties.NullText = "Od:";
        fromDateEdit.Size = new Size(196, 20);
        fromDateEdit.TabIndex = 1;
        fromDateEdit.EditValueChanged += FromDateTimeSelectionOnChanged;
        // 
        // toDateEdit
        // 
        toDateEdit.EditValue = null;
        toDateEdit.Location = new Point(12, 64);
        toDateEdit.Name = "toDateEdit";
        toDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        toDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        toDateEdit.Properties.NullText = "Do:";
        toDateEdit.Size = new Size(196, 20);
        toDateEdit.TabIndex = 2;
        toDateEdit.EditValueChanged += ToDateTimeSelectionOnChanged;
        // 
        // reportGrid
        // 
        reportGrid.DataSource = reportDtoBindingSource;
        reportGrid.Dock = DockStyle.Right;
        reportGrid.Location = new Point(212, 0);
        reportGrid.MainView = gridView1;
        reportGrid.Name = "reportGrid";
        reportGrid.Size = new Size(588, 450);
        reportGrid.TabIndex = 3;
        reportGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
        // 
        // reportDtoBindingSource
        // 
        reportDtoBindingSource.DataSource = typeof(ReportInfrastructure.Dtos.ReportDto);
        // 
        // gridView1
        // 
        gridView1.Columns.AddRange(new GridColumn[] { Nazwa, Data, Godzina, Użytkownik, Lokal });
        gridView1.GridControl = reportGrid;
        gridView1.Name = "gridView1";
        gridView1.OptionsView.ShowGroupPanel = false;
        // 
        // Nazwa
        // 
        Nazwa.FieldName = "Name";
        Nazwa.Name = "Nazwa";
        Nazwa.OptionsColumn.AllowEdit = false;
        Nazwa.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
        Nazwa.OptionsFilter.AllowAutoFilter = false;
        Nazwa.OptionsFilter.AllowFilter = false;
        Nazwa.Visible = true;
        Nazwa.VisibleIndex = 0;
        // 
        // Data
        // 
        Data.FieldName = "Date";
        Data.Name = "Data";
        Data.OptionsColumn.AllowEdit = false;
        Data.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
        Data.OptionsFilter.AllowAutoFilter = false;
        Data.OptionsFilter.AllowFilter = false;
        Data.Visible = true;
        Data.VisibleIndex = 1;
        // 
        // Godzina
        // 
        Godzina.FieldName = "Time";
        Godzina.Name = "Godzina";
        Godzina.OptionsColumn.AllowEdit = false;
        Godzina.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
        Godzina.OptionsFilter.AllowAutoFilter = false;
        Godzina.OptionsFilter.AllowFilter = false;
        Godzina.Visible = true;
        Godzina.VisibleIndex = 2;
        // 
        // Użytkownik
        // 
        Użytkownik.FieldName = "User";
        Użytkownik.Name = "Użytkownik";
        Użytkownik.OptionsColumn.AllowEdit = false;
        Użytkownik.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
        Użytkownik.OptionsFilter.AllowAutoFilter = false;
        Użytkownik.OptionsFilter.AllowFilter = false;
        Użytkownik.Visible = true;
        Użytkownik.VisibleIndex = 3;
        // 
        // Lokal
        // 
        Lokal.FieldName = "Permises";
        Lokal.Name = "Lokal";
        Lokal.OptionsColumn.AllowEdit = false;
        Lokal.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
        Lokal.OptionsFilter.AllowAutoFilter = false;
        Lokal.OptionsFilter.AllowFilter = false;
        Lokal.Visible = true;
        Lokal.VisibleIndex = 4;
        // 
        // premisesDropDown
        // 
        premisesDropDown.EditValue = "";
        premisesDropDown.Location = new Point(12, 12);
        premisesDropDown.Name = "premisesDropDown";
        premisesDropDown.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        premisesDropDown.Properties.DataSource = premisesDtoBindingSource;
        premisesDropDown.Properties.DisplayMember = "Name";
        premisesDropDown.Properties.NullText = "Lokal:";
        premisesDropDown.Properties.NullValuePrompt = "Lokal:";
        premisesDropDown.Properties.ShowFooter = false;
        premisesDropDown.Properties.ShowHeader = false;
        premisesDropDown.Properties.ValueMember = "Id";
        premisesDropDown.Size = new Size(196, 20);
        premisesDropDown.TabIndex = 4;
        premisesDropDown.ToolTip = "Lokal";
        // 
        // premisesDtoBindingSource
        // 
        premisesDtoBindingSource.DataSource = typeof(ReportInfrastructure.Dtos.PremisesDto);
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(premisesDropDown);
        Controls.Add(reportGrid);
        Controls.Add(toDateEdit);
        Controls.Add(fromDateEdit);
        Controls.Add(confirmButton);
        Name = "MainForm";
        Text = "Raport";
        Load += MainFormOnLoad;
        ((System.ComponentModel.ISupportInitialize)fromDateEdit.Properties.CalendarTimeProperties).EndInit();
        ((System.ComponentModel.ISupportInitialize)fromDateEdit.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)toDateEdit.Properties.CalendarTimeProperties).EndInit();
        ((System.ComponentModel.ISupportInitialize)toDateEdit.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)reportGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)reportDtoBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)premisesDropDown.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)premisesDtoBindingSource).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DevExpress.XtraEditors.SimpleButton confirmButton;
    private DevExpress.XtraEditors.DateEdit fromDateEdit;
    private DevExpress.XtraEditors.DateEdit toDateEdit;
    private DevExpress.XtraGrid.GridControl reportGrid;
    private BindingSource reportDtoBindingSource;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colDate;
    private DevExpress.XtraGrid.Columns.GridColumn colTime;
    private DevExpress.XtraGrid.Columns.GridColumn colUser;
    private DevExpress.XtraGrid.Columns.GridColumn colPermises;
    private DevExpress.XtraGrid.Columns.GridColumn Nazwa;
    private DevExpress.XtraGrid.Columns.GridColumn Data;
    private DevExpress.XtraGrid.Columns.GridColumn Godzina;
    private DevExpress.XtraGrid.Columns.GridColumn Użytkownik;
    private DevExpress.XtraGrid.Columns.GridColumn Lokal;
    private DevExpress.XtraEditors.LookUpEdit premisesDropDown;
    private BindingSource premisesDtoBindingSource;
}
