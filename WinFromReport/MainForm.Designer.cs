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
        Nazwa = new DevExpress.XtraGrid.Columns.GridColumn();
        Data = new DevExpress.XtraGrid.Columns.GridColumn();
        Godzina = new DevExpress.XtraGrid.Columns.GridColumn();
        Użytkownik = new DevExpress.XtraGrid.Columns.GridColumn();
        Lokal = new DevExpress.XtraGrid.Columns.GridColumn();
        ((System.ComponentModel.ISupportInitialize)fromDateEdit.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)fromDateEdit.Properties.CalendarTimeProperties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)toDateEdit.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)toDateEdit.Properties.CalendarTimeProperties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)reportGrid).BeginInit();
        ((System.ComponentModel.ISupportInitialize)reportDtoBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
        SuspendLayout();
        // 
        // confirmButton
        // 
        confirmButton.Location = new Point(12, 393);
        confirmButton.Name = "confirmButton";
        confirmButton.Size = new Size(140, 45);
        confirmButton.TabIndex = 0;
        confirmButton.Text = "Zatwierdź";
        confirmButton.Click += confirmButton_Click;
        // 
        // fromDateEdit
        // 
        fromDateEdit.EditValue = null;
        fromDateEdit.Location = new Point(11, 62);
        fromDateEdit.Name = "fromDateEdit";
        fromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        fromDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        fromDateEdit.Size = new Size(196, 20);
        fromDateEdit.TabIndex = 1;
        // 
        // toDateEdit
        // 
        toDateEdit.EditValue = null;
        toDateEdit.Location = new Point(11, 88);
        toDateEdit.Name = "toDateEdit";
        toDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        toDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        toDateEdit.Size = new Size(195, 20);
        toDateEdit.TabIndex = 2;
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
        gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Nazwa, Data, Godzina, Użytkownik, Lokal });
        gridView1.GridControl = reportGrid;
        gridView1.Name = "gridView1";
        gridView1.OptionsView.ShowGroupPanel = false;
        // 
        // Nazwa
        // 
        Nazwa.FieldName = "Name";
        Nazwa.Name = "Nazwa";
        Nazwa.Visible = true;
        Nazwa.VisibleIndex = 0;
        // 
        // Data
        // 
        Data.FieldName = "Date";
        Data.Name = "Data";
        Data.Visible = true;
        Data.VisibleIndex = 1;
        // 
        // Godzina
        // 
        Godzina.FieldName = "Time";
        Godzina.Name = "Godzina";
        Godzina.Visible = true;
        Godzina.VisibleIndex = 2;
        // 
        // Użytkownik
        // 
        Użytkownik.FieldName = "User";
        Użytkownik.Name = "Użytkownik";
        Użytkownik.Visible = true;
        Użytkownik.VisibleIndex = 3;
        // 
        // Lokal
        // 
        Lokal.FieldName = "Permises";
        Lokal.Name = "Lokal";
        Lokal.Visible = true;
        Lokal.VisibleIndex = 4;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(reportGrid);
        Controls.Add(toDateEdit);
        Controls.Add(fromDateEdit);
        Controls.Add(confirmButton);
        Name = "MainForm";
        Text = "Raport";
        ((System.ComponentModel.ISupportInitialize)fromDateEdit.Properties.CalendarTimeProperties).EndInit();
        ((System.ComponentModel.ISupportInitialize)fromDateEdit.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)toDateEdit.Properties.CalendarTimeProperties).EndInit();
        ((System.ComponentModel.ISupportInitialize)toDateEdit.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)reportGrid).EndInit();
        ((System.ComponentModel.ISupportInitialize)reportDtoBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
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
}
