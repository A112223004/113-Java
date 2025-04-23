namespace TestWinForm
{
    partial class frmMainEntrance
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tpgQueue = new System.Windows.Forms.TabControl();
            this.tbgSorting = new System.Windows.Forms.TabPage();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.lblAfter = new System.Windows.Forms.Label();
            this.tbxAfter = new System.Windows.Forms.TextBox();
            this.tbxBefore = new System.Windows.Forms.TextBox();
            this.lblBefore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnString = new System.Windows.Forms.RadioButton();
            this.rbnDouble = new System.Windows.Forms.RadioButton();
            this.rbnInt = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnInsertAfter = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.tbxRemove = new System.Windows.Forms.TextBox();
            this.tbxAddAfter = new System.Windows.Forms.TextBox();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnInsertLast = new System.Windows.Forms.Button();
            this.btnInsertFirst = new System.Windows.Forms.Button();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.cbxCreate = new System.Windows.Forms.ComboBox();
            this.cbxRemove = new System.Windows.Forms.ComboBox();
            this.cbxAdd = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtDoubleLL = new System.Windows.Forms.RadioButton();
            this.rbtSinglyLL = new System.Windows.Forms.RadioButton();
            this.btnCreatLast = new System.Windows.Forms.Button();
            this.btnCreatFirst = new System.Windows.Forms.Button();
            this.tbxAdd = new System.Windows.Forms.TextBox();
            this.tbxLLcontent = new System.Windows.Forms.TextBox();
            this.tbxFindind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnPoly = new System.Windows.Forms.Button();
            this.tbxSearchResult = new System.Windows.Forms.TextBox();
            this.tbxAddResult = new System.Windows.Forms.TextBox();
            this.tbxRemoveResult = new System.Windows.Forms.TextBox();
            this.tbxOriginal = new System.Windows.Forms.TextBox();
            this.Origianl_lbl = new System.Windows.Forms.Label();
            this.tpgLoopRecurslve = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rbtLLstring = new System.Windows.Forms.RadioButton();
            this.rbtLLint = new System.Windows.Forms.RadioButton();
            this.rbtLLdouble = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.tpgQueue.SuspendLayout();
            this.tbgSorting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpgLoopRecurslve.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpgQueue
            // 
            this.tpgQueue.Controls.Add(this.tbgSorting);
            this.tpgQueue.Controls.Add(this.tabPage2);
            this.tpgQueue.Controls.Add(this.tpgLoopRecurslve);
            this.tpgQueue.Controls.Add(this.tabPage3);
            this.tpgQueue.Controls.Add(this.tabPage4);
            this.tpgQueue.Controls.Add(this.tabPage5);
            this.tpgQueue.Controls.Add(this.tabPage6);
            this.tpgQueue.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpgQueue.Location = new System.Drawing.Point(0, 0);
            this.tpgQueue.Margin = new System.Windows.Forms.Padding(4);
            this.tpgQueue.Name = "tpgQueue";
            this.tpgQueue.SelectedIndex = 0;
            this.tpgQueue.Size = new System.Drawing.Size(696, 562);
            this.tpgQueue.TabIndex = 0;
            // 
            // tbgSorting
            // 
            this.tbgSorting.Controls.Add(this.btnSelectionSort);
            this.tbgSorting.Controls.Add(this.btnMergeSort);
            this.tbgSorting.Controls.Add(this.btnInsertionSort);
            this.tbgSorting.Controls.Add(this.lblAfter);
            this.tbgSorting.Controls.Add(this.tbxAfter);
            this.tbgSorting.Controls.Add(this.tbxBefore);
            this.tbgSorting.Controls.Add(this.lblBefore);
            this.tbgSorting.Controls.Add(this.groupBox1);
            this.tbgSorting.Location = new System.Drawing.Point(4, 25);
            this.tbgSorting.Margin = new System.Windows.Forms.Padding(4);
            this.tbgSorting.Name = "tbgSorting";
            this.tbgSorting.Padding = new System.Windows.Forms.Padding(4);
            this.tbgSorting.Size = new System.Drawing.Size(688, 533);
            this.tbgSorting.TabIndex = 0;
            this.tbgSorting.Text = "Sorting";
            this.tbgSorting.UseVisualStyleBackColor = true;
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectionSort.Location = new System.Drawing.Point(232, 212);
            this.btnSelectionSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(129, 42);
            this.btnSelectionSort.TabIndex = 8;
            this.btnSelectionSort.Text = "Selection";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMergeSort.Location = new System.Drawing.Point(439, 212);
            this.btnMergeSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(129, 42);
            this.btnMergeSort.TabIndex = 7;
            this.btnMergeSort.Text = "Merge";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertionSort.Location = new System.Drawing.Point(29, 212);
            this.btnInsertionSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(129, 42);
            this.btnInsertionSort.TabIndex = 6;
            this.btnInsertionSort.Text = "Insertion";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAfter.Location = new System.Drawing.Point(239, 119);
            this.lblAfter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(53, 20);
            this.lblAfter.TabIndex = 5;
            this.lblAfter.Text = "After";
            // 
            // tbxAfter
            // 
            this.tbxAfter.Location = new System.Drawing.Point(305, 114);
            this.tbxAfter.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAfter.Name = "tbxAfter";
            this.tbxAfter.Size = new System.Drawing.Size(309, 25);
            this.tbxAfter.TabIndex = 4;
            // 
            // tbxBefore
            // 
            this.tbxBefore.Location = new System.Drawing.Point(309, 59);
            this.tbxBefore.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBefore.Name = "tbxBefore";
            this.tbxBefore.Size = new System.Drawing.Size(305, 25);
            this.tbxBefore.TabIndex = 3;
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBefore.Location = new System.Drawing.Point(228, 59);
            this.lblBefore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(65, 20);
            this.lblBefore.TabIndex = 2;
            this.lblBefore.Text = "Before";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnString);
            this.groupBox1.Controls.Add(this.rbnDouble);
            this.groupBox1.Controls.Add(this.rbnInt);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(29, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(164, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select DT";
            // 
            // rbnString
            // 
            this.rbnString.AutoSize = true;
            this.rbnString.Checked = true;
            this.rbnString.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbnString.Location = new System.Drawing.Point(23, 79);
            this.rbnString.Margin = new System.Windows.Forms.Padding(4);
            this.rbnString.Name = "rbnString";
            this.rbnString.Size = new System.Drawing.Size(80, 23);
            this.rbnString.TabIndex = 3;
            this.rbnString.TabStop = true;
            this.rbnString.Text = "String";
            this.rbnString.UseVisualStyleBackColor = true;
            // 
            // rbnDouble
            // 
            this.rbnDouble.AutoSize = true;
            this.rbnDouble.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbnDouble.Location = new System.Drawing.Point(23, 52);
            this.rbnDouble.Margin = new System.Windows.Forms.Padding(4);
            this.rbnDouble.Name = "rbnDouble";
            this.rbnDouble.Size = new System.Drawing.Size(89, 23);
            this.rbnDouble.TabIndex = 2;
            this.rbnDouble.Text = "Double";
            this.rbnDouble.UseVisualStyleBackColor = true;
            // 
            // rbnInt
            // 
            this.rbnInt.AutoSize = true;
            this.rbnInt.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbnInt.Location = new System.Drawing.Point(23, 26);
            this.rbnInt.Margin = new System.Windows.Forms.Padding(4);
            this.rbnInt.Name = "rbnInt";
            this.rbnInt.Size = new System.Drawing.Size(88, 23);
            this.rbnInt.TabIndex = 1;
            this.rbnInt.Text = "Integer";
            this.rbnInt.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnInsertAfter);
            this.tabPage2.Controls.Add(this.btnRemoveAt);
            this.tabPage2.Controls.Add(this.tbxRemove);
            this.tabPage2.Controls.Add(this.tbxAddAfter);
            this.tabPage2.Controls.Add(this.btnRemoveLast);
            this.tabPage2.Controls.Add(this.btnInsertLast);
            this.tabPage2.Controls.Add(this.btnInsertFirst);
            this.tabPage2.Controls.Add(this.btnRemoveFirst);
            this.tabPage2.Controls.Add(this.cbxCreate);
            this.tabPage2.Controls.Add(this.cbxRemove);
            this.tabPage2.Controls.Add(this.cbxAdd);
            this.tabPage2.Controls.Add(this.btnFind);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnCreatLast);
            this.tabPage2.Controls.Add(this.btnCreatFirst);
            this.tabPage2.Controls.Add(this.tbxAdd);
            this.tabPage2.Controls.Add(this.tbxLLcontent);
            this.tabPage2.Controls.Add(this.tbxFindind);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnPoly);
            this.tabPage2.Controls.Add(this.tbxSearchResult);
            this.tabPage2.Controls.Add(this.tbxAddResult);
            this.tabPage2.Controls.Add(this.tbxRemoveResult);
            this.tabPage2.Controls.Add(this.tbxOriginal);
            this.tabPage2.Controls.Add(this.Origianl_lbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(688, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LinkedList";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnInsertAfter
            // 
            this.btnInsertAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsertAfter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertAfter.Location = new System.Drawing.Point(345, 146);
            this.btnInsertAfter.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertAfter.Name = "btnInsertAfter";
            this.btnInsertAfter.Size = new System.Drawing.Size(75, 26);
            this.btnInsertAfter.TabIndex = 35;
            this.btnInsertAfter.Text = "After";
            this.btnInsertAfter.UseVisualStyleBackColor = false;
            this.btnInsertAfter.Click += new System.EventHandler(this.btnInsertAfter_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRemoveAt.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveAt.Location = new System.Drawing.Point(509, 146);
            this.btnRemoveAt.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(75, 26);
            this.btnRemoveAt.TabIndex = 34;
            this.btnRemoveAt.Text = "At";
            this.btnRemoveAt.UseVisualStyleBackColor = false;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // tbxRemove
            // 
            this.tbxRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbxRemove.Location = new System.Drawing.Point(590, 145);
            this.tbxRemove.Margin = new System.Windows.Forms.Padding(4);
            this.tbxRemove.Name = "tbxRemove";
            this.tbxRemove.Size = new System.Drawing.Size(75, 25);
            this.tbxRemove.TabIndex = 33;
            this.tbxRemove.Text = "10";
            // 
            // tbxAddAfter
            // 
            this.tbxAddAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxAddAfter.Location = new System.Drawing.Point(428, 145);
            this.tbxAddAfter.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddAfter.Name = "tbxAddAfter";
            this.tbxAddAfter.Size = new System.Drawing.Size(75, 25);
            this.tbxAddAfter.TabIndex = 32;
            this.tbxAddAfter.Text = "10";
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRemoveLast.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveLast.Location = new System.Drawing.Point(592, 115);
            this.btnRemoveLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(77, 26);
            this.btnRemoveLast.TabIndex = 31;
            this.btnRemoveLast.Text = "Last";
            this.btnRemoveLast.UseVisualStyleBackColor = false;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // btnInsertLast
            // 
            this.btnInsertLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsertLast.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertLast.Location = new System.Drawing.Point(428, 115);
            this.btnInsertLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertLast.Name = "btnInsertLast";
            this.btnInsertLast.Size = new System.Drawing.Size(77, 26);
            this.btnInsertLast.TabIndex = 30;
            this.btnInsertLast.Text = "Last";
            this.btnInsertLast.UseVisualStyleBackColor = false;
            this.btnInsertLast.Click += new System.EventHandler(this.btnInsertLast_Click);
            // 
            // btnInsertFirst
            // 
            this.btnInsertFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInsertFirst.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertFirst.Location = new System.Drawing.Point(345, 115);
            this.btnInsertFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertFirst.Name = "btnInsertFirst";
            this.btnInsertFirst.Size = new System.Drawing.Size(75, 26);
            this.btnInsertFirst.TabIndex = 29;
            this.btnInsertFirst.Text = "First";
            this.btnInsertFirst.UseVisualStyleBackColor = false;
            this.btnInsertFirst.Click += new System.EventHandler(this.btnInsertFirst_Click);
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRemoveFirst.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveFirst.Location = new System.Drawing.Point(509, 115);
            this.btnRemoveFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(75, 26);
            this.btnRemoveFirst.TabIndex = 28;
            this.btnRemoveFirst.Text = "First";
            this.btnRemoveFirst.UseVisualStyleBackColor = false;
            this.btnRemoveFirst.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // cbxCreate
            // 
            this.cbxCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxCreate.FormattingEnabled = true;
            this.cbxCreate.Location = new System.Drawing.Point(509, 19);
            this.cbxCreate.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCreate.Name = "cbxCreate";
            this.cbxCreate.Size = new System.Drawing.Size(148, 23);
            this.cbxCreate.TabIndex = 27;
            this.cbxCreate.SelectedIndexChanged += new System.EventHandler(this.cbxCreate_SelectedIndexChanged);
            // 
            // cbxRemove
            // 
            this.cbxRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbxRemove.FormattingEnabled = true;
            this.cbxRemove.Location = new System.Drawing.Point(509, 84);
            this.cbxRemove.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRemove.Name = "cbxRemove";
            this.cbxRemove.Size = new System.Drawing.Size(160, 23);
            this.cbxRemove.TabIndex = 26;
            this.cbxRemove.SelectedIndexChanged += new System.EventHandler(this.cbxRemove_SelectedIndexChanged);
            // 
            // cbxAdd
            // 
            this.cbxAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cbxAdd.FormattingEnabled = true;
            this.cbxAdd.Location = new System.Drawing.Point(432, 84);
            this.cbxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAdd.Name = "cbxAdd";
            this.cbxAdd.Size = new System.Drawing.Size(73, 23);
            this.cbxAdd.TabIndex = 25;
            this.cbxAdd.SelectedIndexChanged += new System.EventHandler(this.cbxAdd_SelectedIndexChanged);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFind.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFind.Location = new System.Drawing.Point(185, 115);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(152, 29);
            this.btnFind.TabIndex = 24;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtDoubleLL);
            this.panel1.Controls.Add(this.rbtSinglyLL);
            this.panel1.Location = new System.Drawing.Point(25, 424);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 59);
            this.panel1.TabIndex = 23;
            // 
            // rbtDoubleLL
            // 
            this.rbtDoubleLL.AutoSize = true;
            this.rbtDoubleLL.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtDoubleLL.Location = new System.Drawing.Point(188, 22);
            this.rbtDoubleLL.Margin = new System.Windows.Forms.Padding(4);
            this.rbtDoubleLL.Name = "rbtDoubleLL";
            this.rbtDoubleLL.Size = new System.Drawing.Size(140, 24);
            this.rbtDoubleLL.TabIndex = 12;
            this.rbtDoubleLL.TabStop = true;
            this.rbtDoubleLL.Text = "Doubly  LL";
            this.rbtDoubleLL.UseVisualStyleBackColor = true;
            // 
            // rbtSinglyLL
            // 
            this.rbtSinglyLL.AutoSize = true;
            this.rbtSinglyLL.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtSinglyLL.Location = new System.Drawing.Point(12, 22);
            this.rbtSinglyLL.Margin = new System.Windows.Forms.Padding(4);
            this.rbtSinglyLL.Name = "rbtSinglyLL";
            this.rbtSinglyLL.Size = new System.Drawing.Size(129, 24);
            this.rbtSinglyLL.TabIndex = 11;
            this.rbtSinglyLL.TabStop = true;
            this.rbtSinglyLL.Text = "Single LL";
            this.rbtSinglyLL.UseVisualStyleBackColor = true;
            // 
            // btnCreatLast
            // 
            this.btnCreatLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreatLast.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreatLast.Location = new System.Drawing.Point(590, 50);
            this.btnCreatLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreatLast.Name = "btnCreatLast";
            this.btnCreatLast.Size = new System.Drawing.Size(77, 26);
            this.btnCreatLast.TabIndex = 10;
            this.btnCreatLast.Text = "Last";
            this.btnCreatLast.UseVisualStyleBackColor = false;
            this.btnCreatLast.Click += new System.EventHandler(this.btnCreatLast_Click);
            // 
            // btnCreatFirst
            // 
            this.btnCreatFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreatFirst.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreatFirst.Location = new System.Drawing.Point(507, 50);
            this.btnCreatFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreatFirst.Name = "btnCreatFirst";
            this.btnCreatFirst.Size = new System.Drawing.Size(75, 26);
            this.btnCreatFirst.TabIndex = 8;
            this.btnCreatFirst.Text = "First";
            this.btnCreatFirst.UseVisualStyleBackColor = false;
            this.btnCreatFirst.Click += new System.EventHandler(this.btnCreatFirst_Clink);
            // 
            // tbxAdd
            // 
            this.tbxAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxAdd.Location = new System.Drawing.Point(345, 82);
            this.tbxAdd.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAdd.Name = "tbxAdd";
            this.tbxAdd.Size = new System.Drawing.Size(75, 25);
            this.tbxAdd.TabIndex = 20;
            // 
            // tbxLLcontent
            // 
            this.tbxLLcontent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbxLLcontent.Font = new System.Drawing.Font("標楷體", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxLLcontent.Location = new System.Drawing.Point(288, 22);
            this.tbxLLcontent.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLLcontent.Name = "tbxLLcontent";
            this.tbxLLcontent.Size = new System.Drawing.Size(213, 22);
            this.tbxLLcontent.TabIndex = 17;
            this.tbxLLcontent.Text = "9, 7, 5, 3, 1, 2, 4 , 6, 8, 0";
            // 
            // tbxFindind
            // 
            this.tbxFindind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxFindind.Location = new System.Drawing.Point(185, 82);
            this.tbxFindind.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFindind.Name = "tbxFindind";
            this.tbxFindind.Size = new System.Drawing.Size(152, 25);
            this.tbxFindind.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(209, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Create";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(37, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(140, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select DT";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton1.Location = new System.Drawing.Point(23, 79);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 23);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "String";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton2.Location = new System.Drawing.Point(23, 52);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 23);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Double";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton3.Location = new System.Drawing.Point(23, 26);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 23);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "Integer";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnPoly
            // 
            this.btnPoly.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPoly.Location = new System.Drawing.Point(443, 435);
            this.btnPoly.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoly.Name = "btnPoly";
            this.btnPoly.Size = new System.Drawing.Size(199, 48);
            this.btnPoly.TabIndex = 9;
            this.btnPoly.Text = "Poly Operation";
            this.btnPoly.UseVisualStyleBackColor = true;
            this.btnPoly.Click += new System.EventHandler(this.btnPoly_Click);
            // 
            // tbxSearchResult
            // 
            this.tbxSearchResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxSearchResult.Location = new System.Drawing.Point(185, 178);
            this.tbxSearchResult.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSearchResult.Multiline = true;
            this.tbxSearchResult.Name = "tbxSearchResult";
            this.tbxSearchResult.Size = new System.Drawing.Size(152, 238);
            this.tbxSearchResult.TabIndex = 4;
            // 
            // tbxAddResult
            // 
            this.tbxAddResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxAddResult.Location = new System.Drawing.Point(345, 178);
            this.tbxAddResult.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddResult.Multiline = true;
            this.tbxAddResult.Name = "tbxAddResult";
            this.tbxAddResult.Size = new System.Drawing.Size(152, 238);
            this.tbxAddResult.TabIndex = 3;
            // 
            // tbxRemoveResult
            // 
            this.tbxRemoveResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbxRemoveResult.Location = new System.Drawing.Point(505, 178);
            this.tbxRemoveResult.Margin = new System.Windows.Forms.Padding(4);
            this.tbxRemoveResult.Multiline = true;
            this.tbxRemoveResult.Name = "tbxRemoveResult";
            this.tbxRemoveResult.Size = new System.Drawing.Size(152, 238);
            this.tbxRemoveResult.TabIndex = 2;
            // 
            // tbxOriginal
            // 
            this.tbxOriginal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbxOriginal.Location = new System.Drawing.Point(25, 178);
            this.tbxOriginal.Margin = new System.Windows.Forms.Padding(4);
            this.tbxOriginal.Multiline = true;
            this.tbxOriginal.Name = "tbxOriginal";
            this.tbxOriginal.Size = new System.Drawing.Size(152, 238);
            this.tbxOriginal.TabIndex = 1;
            // 
            // Origianl_lbl
            // 
            this.Origianl_lbl.AutoSize = true;
            this.Origianl_lbl.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Origianl_lbl.Location = new System.Drawing.Point(53, 152);
            this.Origianl_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Origianl_lbl.Name = "Origianl_lbl";
            this.Origianl_lbl.Size = new System.Drawing.Size(97, 20);
            this.Origianl_lbl.TabIndex = 0;
            this.Origianl_lbl.Text = "Origianl";
            // 
            // tpgLoopRecurslve
            // 
            this.tpgLoopRecurslve.Controls.Add(this.textBox3);
            this.tpgLoopRecurslve.Controls.Add(this.textBox1);
            this.tpgLoopRecurslve.Controls.Add(this.panel3);
            this.tpgLoopRecurslve.Controls.Add(this.panel2);
            this.tpgLoopRecurslve.Location = new System.Drawing.Point(4, 25);
            this.tpgLoopRecurslve.Margin = new System.Windows.Forms.Padding(4);
            this.tpgLoopRecurslve.Name = "tpgLoopRecurslve";
            this.tpgLoopRecurslve.Padding = new System.Windows.Forms.Padding(4);
            this.tpgLoopRecurslve.Size = new System.Drawing.Size(688, 533);
            this.tpgLoopRecurslve.TabIndex = 2;
            this.tpgLoopRecurslve.Text = "LoopRecursive";
            this.tpgLoopRecurslve.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 25);
            this.textBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(621, 25);
            this.textBox1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(340, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 393);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(8, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 393);
            this.panel2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(688, 533);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Stack";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(688, 533);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Queue";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(688, 533);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Tree";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(688, 533);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "B Tree";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton4.Location = new System.Drawing.Point(700, 505);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(74, 24);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "char";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rbtLLstring
            // 
            this.rbtLLstring.AutoSize = true;
            this.rbtLLstring.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtLLstring.Location = new System.Drawing.Point(782, 505);
            this.rbtLLstring.Margin = new System.Windows.Forms.Padding(4);
            this.rbtLLstring.Name = "rbtLLstring";
            this.rbtLLstring.Size = new System.Drawing.Size(96, 24);
            this.rbtLLstring.TabIndex = 2;
            this.rbtLLstring.TabStop = true;
            this.rbtLLstring.Text = "string";
            this.rbtLLstring.UseVisualStyleBackColor = true;
            // 
            // rbtLLint
            // 
            this.rbtLLint.AutoSize = true;
            this.rbtLLint.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtLLint.Location = new System.Drawing.Point(886, 505);
            this.rbtLLint.Margin = new System.Windows.Forms.Padding(4);
            this.rbtLLint.Name = "rbtLLint";
            this.rbtLLint.Size = new System.Drawing.Size(63, 24);
            this.rbtLLint.TabIndex = 3;
            this.rbtLLint.TabStop = true;
            this.rbtLLint.Text = "int";
            this.rbtLLint.UseVisualStyleBackColor = true;
            // 
            // rbtLLdouble
            // 
            this.rbtLLdouble.AutoSize = true;
            this.rbtLLdouble.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtLLdouble.Location = new System.Drawing.Point(957, 505);
            this.rbtLLdouble.Margin = new System.Windows.Forms.Padding(4);
            this.rbtLLdouble.Name = "rbtLLdouble";
            this.rbtLLdouble.Size = new System.Drawing.Size(96, 24);
            this.rbtLLdouble.TabIndex = 4;
            this.rbtLLdouble.TabStop = true;
            this.rbtLLdouble.Text = "double";
            this.rbtLLdouble.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton8.Location = new System.Drawing.Point(717, 45);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(63, 24);
            this.radioButton8.TabIndex = 5;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "ASC";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton9.Location = new System.Drawing.Point(903, 45);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(74, 24);
            this.radioButton9.TabIndex = 6;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "DESC";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // frmMainEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 562);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.rbtLLdouble);
            this.Controls.Add(this.rbtLLint);
            this.Controls.Add(this.rbtLLstring);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.tpgQueue);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainEntrance";
            this.Text = "MainEntrance";
            this.tpgQueue.ResumeLayout(false);
            this.tbgSorting.ResumeLayout(false);
            this.tbgSorting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpgLoopRecurslve.ResumeLayout(false);
            this.tpgLoopRecurslve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpgQueue;
        private System.Windows.Forms.TabPage tbgSorting;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tpgLoopRecurslve;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnDouble;
        private System.Windows.Forms.RadioButton rbnInt;
        private System.Windows.Forms.RadioButton rbnString;
        private System.Windows.Forms.TextBox tbxAfter;
        private System.Windows.Forms.TextBox tbxBefore;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.TextBox tbxSearchResult;
        private System.Windows.Forms.TextBox tbxAddResult;
        private System.Windows.Forms.TextBox tbxRemoveResult;
        private System.Windows.Forms.TextBox tbxOriginal;
        private System.Windows.Forms.Label Origianl_lbl;
        private System.Windows.Forms.Button btnCreatFirst;
        private System.Windows.Forms.Button btnCreatLast;
        private System.Windows.Forms.Button btnPoly;
        private System.Windows.Forms.TextBox tbxLLcontent;
        private System.Windows.Forms.TextBox tbxFindind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxAdd;
        private System.Windows.Forms.RadioButton rbtSinglyLL;
        private System.Windows.Forms.RadioButton rbtDoubleLL;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbxCreate;
        private System.Windows.Forms.ComboBox cbxRemove;
        private System.Windows.Forms.ComboBox cbxAdd;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rbtLLstring;
        private System.Windows.Forms.RadioButton rbtLLint;
        private System.Windows.Forms.RadioButton rbtLLdouble;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxRemove;
        private System.Windows.Forms.TextBox tbxAddAfter;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnInsertLast;
        private System.Windows.Forms.Button btnInsertFirst;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnInsertAfter;
    }
}

