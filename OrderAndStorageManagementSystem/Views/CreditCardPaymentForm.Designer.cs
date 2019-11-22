﻿namespace OrderAndStorageManagementSystem.Views
{
    partial class CreditCardPaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._formLayout = new System.Windows.Forms.TableLayoutPanel();
            this._windowTitle = new System.Windows.Forms.Label();
            this._nameLayout = new System.Windows.Forms.TableLayoutPanel();
            this._nameLabel = new System.Windows.Forms.Label();
            this._nameFieldLayout = new System.Windows.Forms.TableLayoutPanel();
            this._lastNameField = new InputInspectingElements.InputInspectingControls.InputInspectingTextBox();
            this._firstNameField = new InputInspectingElements.InputInspectingControls.InputInspectingTextBox();
            this._nameFieldDash = new System.Windows.Forms.Label();
            this._cardNumberLayout = new System.Windows.Forms.TableLayoutPanel();
            this._cardNumberLabel = new System.Windows.Forms.Label();
            this._cardNumberFieldLayout = new System.Windows.Forms.TableLayoutPanel();
            this._cardNumberFieldFirstDash = new System.Windows.Forms.Label();
            this._cardNumberFieldSecondDash = new System.Windows.Forms.Label();
            this._cardNumberFieldThirdDash = new System.Windows.Forms.Label();
            this._cardNumberFirstField = new InputInspectingElements.InputInspectingControls.InputInspectingTextBox();
            this._cardNumberSecondField = new InputInspectingElements.InputInspectingControls.InputInspectingTextBox();
            this._cardNumberThirdField = new InputInspectingElements.InputInspectingControls.InputInspectingTextBox();
            this._cardNumberFourthField = new InputInspectingElements.InputInspectingControls.InputInspectingTextBox();
            this._cardDateLayout = new System.Windows.Forms.TableLayoutPanel();
            this._cardDateLabel = new System.Windows.Forms.Label();
            this._cardDateFieldLayout = new System.Windows.Forms.TableLayoutPanel();
            this._cardDateMonthField = new InputInspectingElements.InputInspectingControls.InputInspectingDropDownList();
            this._cardDateYearField = new InputInspectingElements.InputInspectingControls.InputInspectingDropDownList();
            this._cardDateFieldSlash = new System.Windows.Forms.Label();
            this._cardSecurityCodeLayout = new System.Windows.Forms.TableLayoutPanel();
            this._cardSecurityCodeLabel = new System.Windows.Forms.Label();
            this._cardSecurityCodeField = new InputInspectingElements.InputInspectingControls.InputInspectingTextBox();
            this._mailLayout = new System.Windows.Forms.TableLayoutPanel();
            this._mailLabel = new System.Windows.Forms.Label();
            this._mailField = new InputInspectingElements.InputInspectingControls.InputInspectingTextBox();
            this._addressLayout = new System.Windows.Forms.TableLayoutPanel();
            this._addressLabel = new System.Windows.Forms.Label();
            this._addressField = new InputInspectingElements.InputInspectingControls.InputInspectingTextBox();
            this._submitButton = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._formLayout.SuspendLayout();
            this._nameLayout.SuspendLayout();
            this._nameFieldLayout.SuspendLayout();
            this._cardNumberLayout.SuspendLayout();
            this._cardNumberFieldLayout.SuspendLayout();
            this._cardDateLayout.SuspendLayout();
            this._cardDateFieldLayout.SuspendLayout();
            this._cardSecurityCodeLayout.SuspendLayout();
            this._mailLayout.SuspendLayout();
            this._addressLayout.SuspendLayout();
            ( ( System.ComponentModel.ISupportInitialize )( this._errorProvider ) ).BeginInit();
            this.SuspendLayout();
            // 
            // _formLayout
            // 
            this._formLayout.ColumnCount = 1;
            this._formLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._formLayout.Controls.Add(this._windowTitle, 0, 0);
            this._formLayout.Controls.Add(this._nameLayout, 0, 1);
            this._formLayout.Controls.Add(this._cardNumberLayout, 0, 2);
            this._formLayout.Controls.Add(this._cardDateLayout, 0, 3);
            this._formLayout.Controls.Add(this._cardSecurityCodeLayout, 0, 4);
            this._formLayout.Controls.Add(this._mailLayout, 0, 5);
            this._formLayout.Controls.Add(this._addressLayout, 0, 6);
            this._formLayout.Controls.Add(this._submitButton, 0, 8);
            this._formLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formLayout.Location = new System.Drawing.Point(0, 0);
            this._formLayout.Name = "_formLayout";
            this._formLayout.Padding = new System.Windows.Forms.Padding(10);
            this._formLayout.RowCount = 9;
            this._formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83432F));
            this._formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83432F));
            this._formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83432F));
            this._formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83432F));
            this._formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83432F));
            this._formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83432F));
            this._formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83432F));
            this._formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83432F));
            this._formLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.325445F));
            this._formLayout.Size = new System.Drawing.Size(478, 644);
            this._formLayout.TabIndex = 0;
            // 
            // _windowTitle
            // 
            this._windowTitle.AutoSize = true;
            this._windowTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this._windowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 136 ) ));
            this._windowTitle.Location = new System.Drawing.Point(13, 10);
            this._windowTitle.Name = "_windowTitle";
            this._windowTitle.Size = new System.Drawing.Size(452, 73);
            this._windowTitle.TabIndex = 0;
            this._windowTitle.Text = "信用卡支付";
            this._windowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _nameLayout
            // 
            this._nameLayout.ColumnCount = 1;
            this._nameLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._nameLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._nameLayout.Controls.Add(this._nameLabel, 0, 0);
            this._nameLayout.Controls.Add(this._nameFieldLayout, 0, 1);
            this._nameLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameLayout.Location = new System.Drawing.Point(13, 86);
            this._nameLayout.Name = "_nameLayout";
            this._nameLayout.RowCount = 2;
            this._nameLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._nameLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._nameLayout.Size = new System.Drawing.Size(452, 67);
            this._nameLayout.TabIndex = 1;
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameLabel.Location = new System.Drawing.Point(3, 0);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(446, 33);
            this._nameLabel.TabIndex = 0;
            this._nameLabel.Text = "持卡人姓名*";
            this._nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _nameFieldLayout
            // 
            this._nameFieldLayout.ColumnCount = 3;
            this._nameFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this._nameFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this._nameFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this._nameFieldLayout.Controls.Add(this._lastNameField, 0, 0);
            this._nameFieldLayout.Controls.Add(this._firstNameField, 2, 0);
            this._nameFieldLayout.Controls.Add(this._nameFieldDash, 1, 0);
            this._nameFieldLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameFieldLayout.Location = new System.Drawing.Point(3, 36);
            this._nameFieldLayout.Name = "_nameFieldLayout";
            this._nameFieldLayout.RowCount = 1;
            this._nameFieldLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._nameFieldLayout.Size = new System.Drawing.Size(446, 28);
            this._nameFieldLayout.TabIndex = 1;
            // 
            // _lastNameField
            // 
            this._lastNameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lastNameField.Location = new System.Drawing.Point(3, 3);
            this._lastNameField.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._lastNameField.Name = "_lastNameField";
            this._lastNameField.Size = new System.Drawing.Size(170, 20);
            this._lastNameField.TabIndex = 0;
            // 
            // _firstNameField
            // 
            this._firstNameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._firstNameField.Location = new System.Drawing.Point(254, 3);
            this._firstNameField.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._firstNameField.Name = "_firstNameField";
            this._firstNameField.Size = new System.Drawing.Size(172, 20);
            this._firstNameField.TabIndex = 1;
            // 
            // _nameFieldDash
            // 
            this._nameFieldDash.AutoSize = true;
            this._nameFieldDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nameFieldDash.Location = new System.Drawing.Point(196, 0);
            this._nameFieldDash.Name = "_nameFieldDash";
            this._nameFieldDash.Size = new System.Drawing.Size(52, 28);
            this._nameFieldDash.TabIndex = 2;
            this._nameFieldDash.Text = "-";
            this._nameFieldDash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cardNumberLayout
            // 
            this._cardNumberLayout.ColumnCount = 1;
            this._cardNumberLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._cardNumberLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._cardNumberLayout.Controls.Add(this._cardNumberLabel, 0, 0);
            this._cardNumberLayout.Controls.Add(this._cardNumberFieldLayout, 0, 1);
            this._cardNumberLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardNumberLayout.Location = new System.Drawing.Point(13, 159);
            this._cardNumberLayout.Name = "_cardNumberLayout";
            this._cardNumberLayout.RowCount = 2;
            this._cardNumberLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._cardNumberLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._cardNumberLayout.Size = new System.Drawing.Size(452, 67);
            this._cardNumberLayout.TabIndex = 2;
            // 
            // _cardNumberLabel
            // 
            this._cardNumberLabel.AutoSize = true;
            this._cardNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardNumberLabel.Location = new System.Drawing.Point(3, 0);
            this._cardNumberLabel.Name = "_cardNumberLabel";
            this._cardNumberLabel.Size = new System.Drawing.Size(446, 33);
            this._cardNumberLabel.TabIndex = 0;
            this._cardNumberLabel.Text = "信用卡卡號*";
            this._cardNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _cardNumberFieldLayout
            // 
            this._cardNumberFieldLayout.ColumnCount = 7;
            this._cardNumberFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.80198F));
            this._cardNumberFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.930695F));
            this._cardNumberFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.80198F));
            this._cardNumberFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.930695F));
            this._cardNumberFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.80198F));
            this._cardNumberFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.930695F));
            this._cardNumberFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.80198F));
            this._cardNumberFieldLayout.Controls.Add(this._cardNumberFieldFirstDash, 1, 0);
            this._cardNumberFieldLayout.Controls.Add(this._cardNumberFieldSecondDash, 3, 0);
            this._cardNumberFieldLayout.Controls.Add(this._cardNumberFieldThirdDash, 5, 0);
            this._cardNumberFieldLayout.Controls.Add(this._cardNumberFirstField, 0, 0);
            this._cardNumberFieldLayout.Controls.Add(this._cardNumberSecondField, 2, 0);
            this._cardNumberFieldLayout.Controls.Add(this._cardNumberThirdField, 4, 0);
            this._cardNumberFieldLayout.Controls.Add(this._cardNumberFourthField, 6, 0);
            this._cardNumberFieldLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardNumberFieldLayout.Location = new System.Drawing.Point(3, 36);
            this._cardNumberFieldLayout.Name = "_cardNumberFieldLayout";
            this._cardNumberFieldLayout.RowCount = 1;
            this._cardNumberFieldLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._cardNumberFieldLayout.Size = new System.Drawing.Size(446, 28);
            this._cardNumberFieldLayout.TabIndex = 1;
            // 
            // _cardNumberFieldFirstDash
            // 
            this._cardNumberFieldFirstDash.AutoSize = true;
            this._cardNumberFieldFirstDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardNumberFieldFirstDash.Location = new System.Drawing.Point(91, 0);
            this._cardNumberFieldFirstDash.Name = "_cardNumberFieldFirstDash";
            this._cardNumberFieldFirstDash.Size = new System.Drawing.Size(24, 28);
            this._cardNumberFieldFirstDash.TabIndex = 0;
            this._cardNumberFieldFirstDash.Text = "-";
            this._cardNumberFieldFirstDash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cardNumberFieldSecondDash
            // 
            this._cardNumberFieldSecondDash.AutoSize = true;
            this._cardNumberFieldSecondDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardNumberFieldSecondDash.Location = new System.Drawing.Point(209, 0);
            this._cardNumberFieldSecondDash.Name = "_cardNumberFieldSecondDash";
            this._cardNumberFieldSecondDash.Size = new System.Drawing.Size(24, 28);
            this._cardNumberFieldSecondDash.TabIndex = 1;
            this._cardNumberFieldSecondDash.Text = "-";
            this._cardNumberFieldSecondDash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cardNumberFieldThirdDash
            // 
            this._cardNumberFieldThirdDash.AutoSize = true;
            this._cardNumberFieldThirdDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardNumberFieldThirdDash.Location = new System.Drawing.Point(327, 0);
            this._cardNumberFieldThirdDash.Name = "_cardNumberFieldThirdDash";
            this._cardNumberFieldThirdDash.Size = new System.Drawing.Size(24, 28);
            this._cardNumberFieldThirdDash.TabIndex = 2;
            this._cardNumberFieldThirdDash.Text = "-";
            this._cardNumberFieldThirdDash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cardNumberFirstField
            // 
            this._cardNumberFirstField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardNumberFirstField.Location = new System.Drawing.Point(3, 3);
            this._cardNumberFirstField.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._cardNumberFirstField.MaxLength = 4;
            this._cardNumberFirstField.Name = "_cardNumberFirstField";
            this._cardNumberFirstField.Size = new System.Drawing.Size(65, 20);
            this._cardNumberFirstField.TabIndex = 3;
            // 
            // _cardNumberSecondField
            // 
            this._cardNumberSecondField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardNumberSecondField.Location = new System.Drawing.Point(121, 3);
            this._cardNumberSecondField.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._cardNumberSecondField.MaxLength = 4;
            this._cardNumberSecondField.Name = "_cardNumberSecondField";
            this._cardNumberSecondField.Size = new System.Drawing.Size(65, 20);
            this._cardNumberSecondField.TabIndex = 4;
            // 
            // _cardNumberThirdField
            // 
            this._cardNumberThirdField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardNumberThirdField.Location = new System.Drawing.Point(239, 3);
            this._cardNumberThirdField.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._cardNumberThirdField.MaxLength = 4;
            this._cardNumberThirdField.Name = "_cardNumberThirdField";
            this._cardNumberThirdField.Size = new System.Drawing.Size(65, 20);
            this._cardNumberThirdField.TabIndex = 5;
            // 
            // _cardNumberFourthField
            // 
            this._cardNumberFourthField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardNumberFourthField.Location = new System.Drawing.Point(357, 3);
            this._cardNumberFourthField.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._cardNumberFourthField.MaxLength = 4;
            this._cardNumberFourthField.Name = "_cardNumberFourthField";
            this._cardNumberFourthField.Size = new System.Drawing.Size(69, 20);
            this._cardNumberFourthField.TabIndex = 6;
            // 
            // _cardDateLayout
            // 
            this._cardDateLayout.ColumnCount = 1;
            this._cardDateLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._cardDateLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._cardDateLayout.Controls.Add(this._cardDateLabel, 0, 0);
            this._cardDateLayout.Controls.Add(this._cardDateFieldLayout, 0, 1);
            this._cardDateLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardDateLayout.Location = new System.Drawing.Point(13, 232);
            this._cardDateLayout.Name = "_cardDateLayout";
            this._cardDateLayout.RowCount = 2;
            this._cardDateLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._cardDateLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._cardDateLayout.Size = new System.Drawing.Size(452, 67);
            this._cardDateLayout.TabIndex = 3;
            // 
            // _cardDateLabel
            // 
            this._cardDateLabel.AutoSize = true;
            this._cardDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardDateLabel.Location = new System.Drawing.Point(3, 0);
            this._cardDateLabel.Name = "_cardDateLabel";
            this._cardDateLabel.Size = new System.Drawing.Size(446, 33);
            this._cardDateLabel.TabIndex = 0;
            this._cardDateLabel.Text = "有效日期*(月/年)";
            this._cardDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _cardDateFieldLayout
            // 
            this._cardDateFieldLayout.ColumnCount = 3;
            this._cardDateFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this._cardDateFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this._cardDateFieldLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this._cardDateFieldLayout.Controls.Add(this._cardDateMonthField, 0, 0);
            this._cardDateFieldLayout.Controls.Add(this._cardDateYearField, 2, 0);
            this._cardDateFieldLayout.Controls.Add(this._cardDateFieldSlash, 1, 0);
            this._cardDateFieldLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardDateFieldLayout.Location = new System.Drawing.Point(3, 36);
            this._cardDateFieldLayout.Name = "_cardDateFieldLayout";
            this._cardDateFieldLayout.RowCount = 1;
            this._cardDateFieldLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._cardDateFieldLayout.Size = new System.Drawing.Size(446, 28);
            this._cardDateFieldLayout.TabIndex = 1;
            // 
            // _cardDateMonthField
            // 
            this._cardDateMonthField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardDateMonthField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cardDateMonthField.FormattingEnabled = true;
            this._cardDateMonthField.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this._cardDateMonthField.Location = new System.Drawing.Point(3, 3);
            this._cardDateMonthField.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._cardDateMonthField.Name = "_cardDateMonthField";
            this._cardDateMonthField.Size = new System.Drawing.Size(170, 21);
            this._cardDateMonthField.TabIndex = 0;
            // 
            // _cardDateYearField
            // 
            this._cardDateYearField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardDateYearField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cardDateYearField.FormattingEnabled = true;
            this._cardDateYearField.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028"});
            this._cardDateYearField.Location = new System.Drawing.Point(254, 3);
            this._cardDateYearField.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._cardDateYearField.Name = "_cardDateYearField";
            this._cardDateYearField.Size = new System.Drawing.Size(172, 21);
            this._cardDateYearField.TabIndex = 1;
            // 
            // _cardDateFieldSlash
            // 
            this._cardDateFieldSlash.AutoSize = true;
            this._cardDateFieldSlash.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardDateFieldSlash.Location = new System.Drawing.Point(196, 0);
            this._cardDateFieldSlash.Name = "_cardDateFieldSlash";
            this._cardDateFieldSlash.Size = new System.Drawing.Size(52, 28);
            this._cardDateFieldSlash.TabIndex = 2;
            this._cardDateFieldSlash.Text = "/";
            this._cardDateFieldSlash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cardSecurityCodeLayout
            // 
            this._cardSecurityCodeLayout.ColumnCount = 1;
            this._cardSecurityCodeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._cardSecurityCodeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._cardSecurityCodeLayout.Controls.Add(this._cardSecurityCodeLabel, 0, 0);
            this._cardSecurityCodeLayout.Controls.Add(this._cardSecurityCodeField, 0, 1);
            this._cardSecurityCodeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardSecurityCodeLayout.Location = new System.Drawing.Point(13, 305);
            this._cardSecurityCodeLayout.Name = "_cardSecurityCodeLayout";
            this._cardSecurityCodeLayout.RowCount = 2;
            this._cardSecurityCodeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._cardSecurityCodeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._cardSecurityCodeLayout.Size = new System.Drawing.Size(452, 67);
            this._cardSecurityCodeLayout.TabIndex = 4;
            // 
            // _cardSecurityCodeLabel
            // 
            this._cardSecurityCodeLabel.AutoSize = true;
            this._cardSecurityCodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardSecurityCodeLabel.Location = new System.Drawing.Point(3, 0);
            this._cardSecurityCodeLabel.Name = "_cardSecurityCodeLabel";
            this._cardSecurityCodeLabel.Size = new System.Drawing.Size(446, 33);
            this._cardSecurityCodeLabel.TabIndex = 0;
            this._cardSecurityCodeLabel.Text = "背面末三碼*";
            this._cardSecurityCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _cardSecurityCodeField
            // 
            this._cardSecurityCodeField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._cardSecurityCodeField.Location = new System.Drawing.Point(3, 36);
            this._cardSecurityCodeField.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._cardSecurityCodeField.MaxLength = 3;
            this._cardSecurityCodeField.Name = "_cardSecurityCodeField";
            this._cardSecurityCodeField.Size = new System.Drawing.Size(429, 20);
            this._cardSecurityCodeField.TabIndex = 1;
            // 
            // _mailLayout
            // 
            this._mailLayout.ColumnCount = 1;
            this._mailLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._mailLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._mailLayout.Controls.Add(this._mailLabel, 0, 0);
            this._mailLayout.Controls.Add(this._mailField, 0, 1);
            this._mailLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mailLayout.Location = new System.Drawing.Point(13, 378);
            this._mailLayout.Name = "_mailLayout";
            this._mailLayout.RowCount = 2;
            this._mailLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._mailLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._mailLayout.Size = new System.Drawing.Size(452, 67);
            this._mailLayout.TabIndex = 5;
            // 
            // _mailLabel
            // 
            this._mailLabel.AutoSize = true;
            this._mailLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mailLabel.Location = new System.Drawing.Point(3, 0);
            this._mailLabel.Name = "_mailLabel";
            this._mailLabel.Size = new System.Drawing.Size(446, 33);
            this._mailLabel.TabIndex = 0;
            this._mailLabel.Text = "Email*";
            this._mailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _mailField
            // 
            this._mailField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mailField.Location = new System.Drawing.Point(3, 36);
            this._mailField.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._mailField.Name = "_mailField";
            this._mailField.Size = new System.Drawing.Size(429, 20);
            this._mailField.TabIndex = 1;
            // 
            // _addressLayout
            // 
            this._addressLayout.ColumnCount = 1;
            this._addressLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._addressLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._addressLayout.Controls.Add(this._addressLabel, 0, 0);
            this._addressLayout.Controls.Add(this._addressField, 0, 1);
            this._addressLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addressLayout.Location = new System.Drawing.Point(13, 451);
            this._addressLayout.Name = "_addressLayout";
            this._addressLayout.RowCount = 2;
            this._addressLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._addressLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._addressLayout.Size = new System.Drawing.Size(452, 67);
            this._addressLayout.TabIndex = 6;
            // 
            // _addressLabel
            // 
            this._addressLabel.AutoSize = true;
            this._addressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addressLabel.Location = new System.Drawing.Point(3, 0);
            this._addressLabel.Name = "_addressLabel";
            this._addressLabel.Size = new System.Drawing.Size(446, 33);
            this._addressLabel.TabIndex = 0;
            this._addressLabel.Text = "帳單地址*";
            this._addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _addressField
            // 
            this._addressField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addressField.Location = new System.Drawing.Point(3, 36);
            this._addressField.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this._addressField.Name = "_addressField";
            this._addressField.Size = new System.Drawing.Size(429, 20);
            this._addressField.TabIndex = 1;
            // 
            // _submitButton
            // 
            this._submitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._submitButton.Location = new System.Drawing.Point(13, 597);
            this._submitButton.Name = "_submitButton";
            this._submitButton.Size = new System.Drawing.Size(452, 34);
            this._submitButton.TabIndex = 7;
            this._submitButton.Text = "確認";
            this._submitButton.UseVisualStyleBackColor = true;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // CreditCardPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 644);
            this.Controls.Add(this._formLayout);
            this.Name = "CreditCardPaymentForm";
            this.Text = "Credit Card Payment";
            this._formLayout.ResumeLayout(false);
            this._formLayout.PerformLayout();
            this._nameLayout.ResumeLayout(false);
            this._nameLayout.PerformLayout();
            this._nameFieldLayout.ResumeLayout(false);
            this._nameFieldLayout.PerformLayout();
            this._cardNumberLayout.ResumeLayout(false);
            this._cardNumberLayout.PerformLayout();
            this._cardNumberFieldLayout.ResumeLayout(false);
            this._cardNumberFieldLayout.PerformLayout();
            this._cardDateLayout.ResumeLayout(false);
            this._cardDateLayout.PerformLayout();
            this._cardDateFieldLayout.ResumeLayout(false);
            this._cardDateFieldLayout.PerformLayout();
            this._cardSecurityCodeLayout.ResumeLayout(false);
            this._cardSecurityCodeLayout.PerformLayout();
            this._mailLayout.ResumeLayout(false);
            this._mailLayout.PerformLayout();
            this._addressLayout.ResumeLayout(false);
            this._addressLayout.PerformLayout();
            ( ( System.ComponentModel.ISupportInitialize )( this._errorProvider ) ).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _formLayout;
        private System.Windows.Forms.Label _windowTitle;
        private System.Windows.Forms.TableLayoutPanel _nameLayout;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.TableLayoutPanel _nameFieldLayout;
        private InputInspectingElements.InputInspectingControls.InputInspectingTextBox _lastNameField;
        private InputInspectingElements.InputInspectingControls.InputInspectingTextBox _firstNameField;
        private System.Windows.Forms.Label _nameFieldDash;
        private System.Windows.Forms.TableLayoutPanel _cardNumberLayout;
        private System.Windows.Forms.Label _cardNumberLabel;
        private System.Windows.Forms.TableLayoutPanel _cardNumberFieldLayout;
        private System.Windows.Forms.Label _cardNumberFieldFirstDash;
        private System.Windows.Forms.Label _cardNumberFieldSecondDash;
        private System.Windows.Forms.Label _cardNumberFieldThirdDash;
        private InputInspectingElements.InputInspectingControls.InputInspectingTextBox _cardNumberFirstField;
        private InputInspectingElements.InputInspectingControls.InputInspectingTextBox _cardNumberSecondField;
        private InputInspectingElements.InputInspectingControls.InputInspectingTextBox _cardNumberThirdField;
        private InputInspectingElements.InputInspectingControls.InputInspectingTextBox _cardNumberFourthField;
        private System.Windows.Forms.TableLayoutPanel _cardDateLayout;
        private System.Windows.Forms.Label _cardDateLabel;
        private System.Windows.Forms.TableLayoutPanel _cardDateFieldLayout;
        private InputInspectingElements.InputInspectingControls.InputInspectingDropDownList _cardDateMonthField;
        private InputInspectingElements.InputInspectingControls.InputInspectingDropDownList _cardDateYearField;
        private System.Windows.Forms.Label _cardDateFieldSlash;
        private System.Windows.Forms.TableLayoutPanel _cardSecurityCodeLayout;
        private System.Windows.Forms.Label _cardSecurityCodeLabel;
        private InputInspectingElements.InputInspectingControls.InputInspectingTextBox _cardSecurityCodeField;
        private System.Windows.Forms.TableLayoutPanel _mailLayout;
        private System.Windows.Forms.Label _mailLabel;
        private InputInspectingElements.InputInspectingControls.InputInspectingTextBox _mailField;
        private System.Windows.Forms.TableLayoutPanel _addressLayout;
        private System.Windows.Forms.Label _addressLabel;
        private InputInspectingElements.InputInspectingControls.InputInspectingTextBox _addressField;
        private System.Windows.Forms.Button _submitButton;
        private System.Windows.Forms.ErrorProvider _errorProvider;
    }
}