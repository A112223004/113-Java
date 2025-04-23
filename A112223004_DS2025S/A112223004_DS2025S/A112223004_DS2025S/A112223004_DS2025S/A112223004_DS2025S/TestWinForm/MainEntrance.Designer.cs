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
            this.tbxtAfter = new System.Windows.Forms.TextBox();
            this.tbxtBefore = new System.Windows.Forms.TextBox();
            this.lblBefore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtString = new System.Windows.Forms.RadioButton();
            this.rbtDouble = new System.Windows.Forms.RadioButton();
            this.rbtInteger = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlLLDT = new System.Windows.Forms.Panel();
            this.rbtLLStringg = new System.Windows.Forms.RadioButton();
            this.rbtInt = new System.Windows.Forms.RadioButton();
            this.rbtLLdoublee = new System.Windows.Forms.RadioButton();
            this.btnInsertAfter = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.tbxAddAfter = new System.Windows.Forms.TextBox();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnInsertLast = new System.Windows.Forms.Button();
            this.btnInsertFirst = new System.Windows.Forms.Button();
            this.cbxCreate = new System.Windows.Forms.ComboBox();
            this.cbxRemove = new System.Windows.Forms.ComboBox();
            this.cbxAdd = new System.Windows.Forms.ComboBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtDoubleLL = new System.Windows.Forms.RadioButton();
            this.rbtSinglyLL = new System.Windows.Forms.RadioButton();
            this.btnCreatLast = new System.Windows.Forms.Button();
            this.btnCreatFirst = new System.Windows.Forms.Button();
            this.tbxRemove = new System.Windows.Forms.TextBox();
            this.tbxAdd = new System.Windows.Forms.TextBox();
            this.tbxLLcontent = new System.Windows.Forms.TextBox();
            this.tbxFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPoly = new System.Windows.Forms.Button();
            this.tbxFindResult = new System.Windows.Forms.TextBox();
            this.tbxAddResult = new System.Windows.Forms.TextBox();
            this.tbxRemoveResult = new System.Windows.Forms.TextBox();
            this.tbxOriginal = new System.Windows.Forms.TextBox();
            this.Origianl_lbl = new System.Windows.Forms.Label();
            this.tpgLoopRecurslve = new System.Windows.Forms.TabPage();
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
            this.pnlLLDT.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tpgQueue.Name = "tpgQueue";
            this.tpgQueue.SelectedIndex = 0;
            this.tpgQueue.Size = new System.Drawing.Size(522, 450);
            this.tpgQueue.TabIndex = 0;
            // 
            // tbgSorting
            // 
            this.tbgSorting.Controls.Add(this.btnSelectionSort);
            this.tbgSorting.Controls.Add(this.btnMergeSort);
            this.tbgSorting.Controls.Add(this.btnInsertionSort);
            this.tbgSorting.Controls.Add(this.lblAfter);
            this.tbgSorting.Controls.Add(this.tbxtAfter);
            this.tbgSorting.Controls.Add(this.tbxtBefore);
            this.tbgSorting.Controls.Add(this.lblBefore);
            this.tbgSorting.Controls.Add(this.groupBox1);
            this.tbgSorting.Location = new System.Drawing.Point(4, 22);
            this.tbgSorting.Name = "tbgSorting";
            this.tbgSorting.Padding = new System.Windows.Forms.Padding(3);
            this.tbgSorting.Size = new System.Drawing.Size(514, 424);
            this.tbgSorting.TabIndex = 0;
            this.tbgSorting.Text = "Sorting";
            this.tbgSorting.UseVisualStyleBackColor = true;
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectionSort.Location = new System.Drawing.Point(174, 170);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(97, 34);
            this.btnSelectionSort.TabIndex = 8;
            this.btnSelectionSort.Text = "Selection";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMergeSort.Location = new System.Drawing.Point(329, 170);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(97, 34);
            this.btnMergeSort.TabIndex = 7;
            this.btnMergeSort.Text = "Merge";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertionSort.Location = new System.Drawing.Point(22, 170);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(97, 34);
            this.btnInsertionSort.TabIndex = 6;
            this.btnInsertionSort.Text = "Insertion";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAfter.Location = new System.Drawing.Point(179, 95);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(44, 16);
            this.lblAfter.TabIndex = 5;
            this.lblAfter.Text = "After";
            // 
            // tbxtAfter
            // 
            this.tbxtAfter.Location = new System.Drawing.Point(229, 91);
            this.tbxtAfter.Name = "tbxtAfter";
            this.tbxtAfter.Size = new System.Drawing.Size(233, 22);
            this.tbxtAfter.TabIndex = 4;
            // 
            // tbxtBefore
            // 
            this.tbxtBefore.Location = new System.Drawing.Point(232, 47);
            this.tbxtBefore.Name = "tbxtBefore";
            this.tbxtBefore.Size = new System.Drawing.Size(230, 22);
            this.tbxtBefore.TabIndex = 3;
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBefore.Location = new System.Drawing.Point(171, 47);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(55, 16);
            this.lblBefore.TabIndex = 2;
            this.lblBefore.Text = "Before";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtString);
            this.groupBox1.Controls.Add(this.rbtDouble);
            this.groupBox1.Controls.Add(this.rbtInteger);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(22, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select DT";
            // 
            // rbtString
            // 
            this.rbtString.AutoSize = true;
            this.rbtString.Checked = true;
            this.rbtString.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtString.Location = new System.Drawing.Point(17, 63);
            this.rbtString.Name = "rbtString";
            this.rbtString.Size = new System.Drawing.Size(66, 19);
            this.rbtString.TabIndex = 3;
            this.rbtString.TabStop = true;
            this.rbtString.Text = "String";
            this.rbtString.UseVisualStyleBackColor = true;
            // 
            // rbtDouble
            // 
            this.rbtDouble.AutoSize = true;
            this.rbtDouble.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtDouble.Location = new System.Drawing.Point(17, 42);
            this.rbtDouble.Name = "rbtDouble";
            this.rbtDouble.Size = new System.Drawing.Size(72, 19);
            this.rbtDouble.TabIndex = 2;
            this.rbtDouble.Text = "Double";
            this.rbtDouble.UseVisualStyleBackColor = true;
            // 
            // rbtInteger
            // 
            this.rbtInteger.AutoSize = true;
            this.rbtInteger.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtInteger.Location = new System.Drawing.Point(17, 21);
            this.rbtInteger.Name = "rbtInteger";
            this.rbtInteger.Size = new System.Drawing.Size(72, 19);
            this.rbtInteger.TabIndex = 1;
            this.rbtInteger.Text = "Integer";
            this.rbtInteger.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlLLDT);
            this.tabPage2.Controls.Add(this.btnInsertAfter);
            this.tabPage2.Controls.Add(this.btnRemoveAt);
            this.tabPage2.Controls.Add(this.tbxAddAfter);
            this.tabPage2.Controls.Add(this.btnRemoveFirst);
            this.tabPage2.Controls.Add(this.btnRemoveLast);
            this.tabPage2.Controls.Add(this.btnInsertLast);
            this.tabPage2.Controls.Add(this.btnInsertFirst);
            this.tabPage2.Controls.Add(this.cbxCreate);
            this.tabPage2.Controls.Add(this.cbxRemove);
            this.tabPage2.Controls.Add(this.cbxAdd);
            this.tabPage2.Controls.Add(this.btnFind);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnCreatLast);
            this.tabPage2.Controls.Add(this.btnCreatFirst);
            this.tabPage2.Controls.Add(this.tbxRemove);
            this.tabPage2.Controls.Add(this.tbxAdd);
            this.tabPage2.Controls.Add(this.tbxLLcontent);
            this.tabPage2.Controls.Add(this.tbxFind);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnPoly);
            this.tabPage2.Controls.Add(this.tbxFindResult);
            this.tabPage2.Controls.Add(this.tbxAddResult);
            this.tabPage2.Controls.Add(this.tbxRemoveResult);
            this.tabPage2.Controls.Add(this.tbxOriginal);
            this.tabPage2.Controls.Add(this.Origianl_lbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LinkedList";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlLLDT
            // 
            this.pnlLLDT.Controls.Add(this.rbtLLStringg);
            this.pnlLLDT.Controls.Add(this.rbtInt);
            this.pnlLLDT.Controls.Add(this.rbtLLdoublee);
            this.pnlLLDT.Location = new System.Drawing.Point(17, 16);
            this.pnlLLDT.Name = "pnlLLDT";
            this.pnlLLDT.Size = new System.Drawing.Size(113, 100);
            this.pnlLLDT.TabIndex = 36;
            // 
            // rbtLLStringg
            // 
            this.rbtLLStringg.AutoSize = true;
            this.rbtLLStringg.Checked = true;
            this.rbtLLStringg.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtLLStringg.Location = new System.Drawing.Point(24, 63);
            this.rbtLLStringg.Name = "rbtLLStringg";
            this.rbtLLStringg.Size = new System.Drawing.Size(66, 19);
            this.rbtLLStringg.TabIndex = 3;
            this.rbtLLStringg.TabStop = true;
            this.rbtLLStringg.Text = "String";
            this.rbtLLStringg.UseVisualStyleBackColor = true;
            // 
            // rbtInt
            // 
            this.rbtInt.AutoSize = true;
            this.rbtInt.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtInt.Location = new System.Drawing.Point(24, 13);
            this.rbtInt.Name = "rbtInt";
            this.rbtInt.Size = new System.Drawing.Size(72, 19);
            this.rbtInt.TabIndex = 1;
            this.rbtInt.Text = "Integer";
            this.rbtInt.UseVisualStyleBackColor = true;
            // 
            // rbtLLdoublee
            // 
            this.rbtLLdoublee.AutoSize = true;
            this.rbtLLdoublee.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtLLdoublee.Location = new System.Drawing.Point(24, 38);
            this.rbtLLdoublee.Name = "rbtLLdoublee";
            this.rbtLLdoublee.Size = new System.Drawing.Size(72, 19);
            this.rbtLLdoublee.TabIndex = 2;
            this.rbtLLdoublee.Text = "Double";
            this.rbtLLdoublee.UseVisualStyleBackColor = true;
            // 
            // btnInsertAfter
            // 
            this.btnInsertAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsertAfter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertAfter.Location = new System.Drawing.Point(257, 117);
            this.btnInsertAfter.Name = "btnInsertAfter";
            this.btnInsertAfter.Size = new System.Drawing.Size(58, 22);
            this.btnInsertAfter.TabIndex = 35;
            this.btnInsertAfter.Text = "After";
            this.btnInsertAfter.UseVisualStyleBackColor = false;
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveAt.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveAt.Location = new System.Drawing.Point(377, 114);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(54, 22);
            this.btnRemoveAt.TabIndex = 34;
            this.btnRemoveAt.Text = "At";
            this.btnRemoveAt.UseVisualStyleBackColor = false;
            // 
            // tbxAddAfter
            // 
            this.tbxAddAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxAddAfter.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold);
            this.tbxAddAfter.Location = new System.Drawing.Point(321, 114);
            this.tbxAddAfter.Name = "tbxAddAfter";
            this.tbxAddAfter.Size = new System.Drawing.Size(50, 27);
            this.tbxAddAfter.TabIndex = 33;
            this.tbxAddAfter.Text = "10";
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveFirst.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveFirst.Location = new System.Drawing.Point(377, 89);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(54, 22);
            this.btnRemoveFirst.TabIndex = 31;
            this.btnRemoveFirst.Text = "First";
            this.btnRemoveFirst.UseVisualStyleBackColor = false;
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemoveLast.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveLast.Location = new System.Drawing.Point(443, 89);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(51, 24);
            this.btnRemoveLast.TabIndex = 30;
            this.btnRemoveLast.Text = "Last";
            this.btnRemoveLast.UseVisualStyleBackColor = false;
            // 
            // btnInsertLast
            // 
            this.btnInsertLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsertLast.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertLast.Location = new System.Drawing.Point(321, 89);
            this.btnInsertLast.Name = "btnInsertLast";
            this.btnInsertLast.Size = new System.Drawing.Size(50, 22);
            this.btnInsertLast.TabIndex = 29;
            this.btnInsertLast.Text = "Last";
            this.btnInsertLast.UseVisualStyleBackColor = false;
            // 
            // btnInsertFirst
            // 
            this.btnInsertFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsertFirst.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertFirst.Location = new System.Drawing.Point(257, 89);
            this.btnInsertFirst.Name = "btnInsertFirst";
            this.btnInsertFirst.Size = new System.Drawing.Size(58, 22);
            this.btnInsertFirst.TabIndex = 28;
            this.btnInsertFirst.Text = "First";
            this.btnInsertFirst.UseVisualStyleBackColor = false;
            // 
            // cbxCreate
            // 
            this.cbxCreate.BackColor = System.Drawing.SystemColors.Desktop;
            this.cbxCreate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold);
            this.cbxCreate.FormattingEnabled = true;
            this.cbxCreate.Location = new System.Drawing.Point(377, 16);
            this.cbxCreate.Name = "cbxCreate";
            this.cbxCreate.Size = new System.Drawing.Size(117, 24);
            this.cbxCreate.TabIndex = 27;
            // 
            // cbxRemove
            // 
            this.cbxRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbxRemove.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold);
            this.cbxRemove.FormattingEnabled = true;
            this.cbxRemove.Location = new System.Drawing.Point(377, 64);
            this.cbxRemove.Name = "cbxRemove";
            this.cbxRemove.Size = new System.Drawing.Size(117, 24);
            this.cbxRemove.TabIndex = 26;
            // 
            // cbxAdd
            // 
            this.cbxAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbxAdd.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold);
            this.cbxAdd.FormattingEnabled = true;
            this.cbxAdd.Location = new System.Drawing.Point(321, 57);
            this.cbxAdd.Name = "cbxAdd";
            this.cbxAdd.Size = new System.Drawing.Size(50, 24);
            this.cbxAdd.TabIndex = 25;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnFind.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFind.Location = new System.Drawing.Point(139, 90);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 23);
            this.btnFind.TabIndex = 24;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtDoubleLL);
            this.panel1.Controls.Add(this.rbtSinglyLL);
            this.panel1.Location = new System.Drawing.Point(19, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 47);
            this.panel1.TabIndex = 23;
            // 
            // rbtDoubleLL
            // 
            this.rbtDoubleLL.AutoSize = true;
            this.rbtDoubleLL.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtDoubleLL.Location = new System.Drawing.Point(141, 18);
            this.rbtDoubleLL.Name = "rbtDoubleLL";
            this.rbtDoubleLL.Size = new System.Drawing.Size(115, 20);
            this.rbtDoubleLL.TabIndex = 12;
            this.rbtDoubleLL.TabStop = true;
            this.rbtDoubleLL.Text = "Doubly  LL";
            this.rbtDoubleLL.UseVisualStyleBackColor = true;
            // 
            // rbtSinglyLL
            // 
            this.rbtSinglyLL.AutoSize = true;
            this.rbtSinglyLL.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtSinglyLL.Location = new System.Drawing.Point(9, 18);
            this.rbtSinglyLL.Name = "rbtSinglyLL";
            this.rbtSinglyLL.Size = new System.Drawing.Size(106, 20);
            this.rbtSinglyLL.TabIndex = 11;
            this.rbtSinglyLL.TabStop = true;
            this.rbtSinglyLL.Text = "Single LL";
            this.rbtSinglyLL.UseVisualStyleBackColor = true;
            // 
            // btnCreatLast
            // 
            this.btnCreatLast.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCreatLast.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreatLast.Location = new System.Drawing.Point(439, 39);
            this.btnCreatLast.Name = "btnCreatLast";
            this.btnCreatLast.Size = new System.Drawing.Size(55, 24);
            this.btnCreatLast.TabIndex = 10;
            this.btnCreatLast.Text = "Last";
            this.btnCreatLast.UseVisualStyleBackColor = false;
            this.btnCreatLast.Click += new System.EventHandler(this.btnCreatLast_Click);
            // 
            // btnCreatFirst
            // 
            this.btnCreatFirst.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCreatFirst.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreatFirst.Location = new System.Drawing.Point(377, 39);
            this.btnCreatFirst.Name = "btnCreatFirst";
            this.btnCreatFirst.Size = new System.Drawing.Size(56, 24);
            this.btnCreatFirst.TabIndex = 8;
            this.btnCreatFirst.Text = "First";
            this.btnCreatFirst.UseVisualStyleBackColor = false;
            this.btnCreatFirst.Click += new System.EventHandler(this.btnCreatFirst_Clink);
            // 
            // tbxRemove
            // 
            this.tbxRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbxRemove.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold);
            this.tbxRemove.Location = new System.Drawing.Point(443, 114);
            this.tbxRemove.Name = "tbxRemove";
            this.tbxRemove.Size = new System.Drawing.Size(51, 27);
            this.tbxRemove.TabIndex = 22;
            this.tbxRemove.Text = "10";
            // 
            // tbxAdd
            // 
            this.tbxAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxAdd.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold);
            this.tbxAdd.Location = new System.Drawing.Point(259, 57);
            this.tbxAdd.Name = "tbxAdd";
            this.tbxAdd.Size = new System.Drawing.Size(56, 27);
            this.tbxAdd.TabIndex = 20;
            this.tbxAdd.Text = "10";
            // 
            // tbxLLcontent
            // 
            this.tbxLLcontent.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbxLLcontent.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxLLcontent.Location = new System.Drawing.Point(189, 18);
            this.tbxLLcontent.Name = "tbxLLcontent";
            this.tbxLLcontent.Size = new System.Drawing.Size(185, 25);
            this.tbxLLcontent.TabIndex = 17;
            this.tbxLLcontent.Text = "9,7,5,3,1,2,4,6,8,0";
            // 
            // tbxFind
            // 
            this.tbxFind.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxFind.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxFind.Location = new System.Drawing.Point(139, 57);
            this.tbxFind.Name = "tbxFind";
            this.tbxFind.Size = new System.Drawing.Size(112, 27);
            this.tbxFind.TabIndex = 16;
            this.tbxFind.Text = "10";
            this.tbxFind.TextChanged += new System.EventHandler(this.tbxFindind_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(136, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Create";
            // 
            // btnPoly
            // 
            this.btnPoly.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPoly.Location = new System.Drawing.Point(332, 348);
            this.btnPoly.Name = "btnPoly";
            this.btnPoly.Size = new System.Drawing.Size(149, 38);
            this.btnPoly.TabIndex = 9;
            this.btnPoly.Text = "Poly Operation";
            this.btnPoly.UseVisualStyleBackColor = true;
            // 
            // tbxFindResult
            // 
            this.tbxFindResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxFindResult.Location = new System.Drawing.Point(139, 142);
            this.tbxFindResult.Multiline = true;
            this.tbxFindResult.Name = "tbxFindResult";
            this.tbxFindResult.Size = new System.Drawing.Size(115, 191);
            this.tbxFindResult.TabIndex = 4;
            // 
            // tbxAddResult
            // 
            this.tbxAddResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxAddResult.Location = new System.Drawing.Point(259, 142);
            this.tbxAddResult.Multiline = true;
            this.tbxAddResult.Name = "tbxAddResult";
            this.tbxAddResult.Size = new System.Drawing.Size(115, 191);
            this.tbxAddResult.TabIndex = 3;
            // 
            // tbxRemoveResult
            // 
            this.tbxRemoveResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbxRemoveResult.Location = new System.Drawing.Point(379, 142);
            this.tbxRemoveResult.Multiline = true;
            this.tbxRemoveResult.Name = "tbxRemoveResult";
            this.tbxRemoveResult.Size = new System.Drawing.Size(115, 191);
            this.tbxRemoveResult.TabIndex = 2;
            // 
            // tbxOriginal
            // 
            this.tbxOriginal.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbxOriginal.Location = new System.Drawing.Point(19, 142);
            this.tbxOriginal.Multiline = true;
            this.tbxOriginal.Name = "tbxOriginal";
            this.tbxOriginal.Size = new System.Drawing.Size(115, 191);
            this.tbxOriginal.TabIndex = 1;
            // 
            // Origianl_lbl
            // 
            this.Origianl_lbl.AutoSize = true;
            this.Origianl_lbl.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Origianl_lbl.Location = new System.Drawing.Point(40, 122);
            this.Origianl_lbl.Name = "Origianl_lbl";
            this.Origianl_lbl.Size = new System.Drawing.Size(79, 16);
            this.Origianl_lbl.TabIndex = 0;
            this.Origianl_lbl.Text = "Origianl";
            // 
            // tpgLoopRecurslve
            // 
            this.tpgLoopRecurslve.Location = new System.Drawing.Point(4, 22);
            this.tpgLoopRecurslve.Name = "tpgLoopRecurslve";
            this.tpgLoopRecurslve.Padding = new System.Windows.Forms.Padding(3);
            this.tpgLoopRecurslve.Size = new System.Drawing.Size(514, 424);
            this.tpgLoopRecurslve.TabIndex = 2;
            this.tpgLoopRecurslve.Text = "LoopRecursive";
            this.tpgLoopRecurslve.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(514, 424);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Stack";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(514, 424);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Queue";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(514, 424);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Tree";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(514, 424);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "B Tree";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton4.Location = new System.Drawing.Point(525, 404);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 20);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "char";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rbtLLstring
            // 
            this.rbtLLstring.AutoSize = true;
            this.rbtLLstring.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtLLstring.Location = new System.Drawing.Point(648, 404);
            this.rbtLLstring.Name = "rbtLLstring";
            this.rbtLLstring.Size = new System.Drawing.Size(79, 20);
            this.rbtLLstring.TabIndex = 2;
            this.rbtLLstring.TabStop = true;
            this.rbtLLstring.Text = "string";
            this.rbtLLstring.UseVisualStyleBackColor = true;
            // 
            // rbtLLint
            // 
            this.rbtLLint.AutoSize = true;
            this.rbtLLint.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtLLint.Location = new System.Drawing.Point(783, 404);
            this.rbtLLint.Name = "rbtLLint";
            this.rbtLLint.Size = new System.Drawing.Size(52, 20);
            this.rbtLLint.TabIndex = 3;
            this.rbtLLint.TabStop = true;
            this.rbtLLint.Text = "int";
            this.rbtLLint.UseVisualStyleBackColor = true;
            // 
            // rbtLLdouble
            // 
            this.rbtLLdouble.AutoSize = true;
            this.rbtLLdouble.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtLLdouble.Location = new System.Drawing.Point(893, 404);
            this.rbtLLdouble.Name = "rbtLLdouble";
            this.rbtLLdouble.Size = new System.Drawing.Size(79, 20);
            this.rbtLLdouble.TabIndex = 4;
            this.rbtLLdouble.TabStop = true;
            this.rbtLLdouble.Text = "double";
            this.rbtLLdouble.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton8.Location = new System.Drawing.Point(538, 36);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(52, 20);
            this.radioButton8.TabIndex = 5;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "ASC";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton9.Location = new System.Drawing.Point(677, 36);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(61, 20);
            this.radioButton9.TabIndex = 6;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "DESC";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // frmMainEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.rbtLLdouble);
            this.Controls.Add(this.rbtLLint);
            this.Controls.Add(this.rbtLLstring);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.tpgQueue);
            this.Name = "frmMainEntrance";
            this.Text = "MainEntrance";
            this.tpgQueue.ResumeLayout(false);
            this.tbgSorting.ResumeLayout(false);
            this.tbgSorting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlLLDT.ResumeLayout(false);
            this.pnlLLDT.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbtDouble;
        private System.Windows.Forms.RadioButton rbtInteger;
        private System.Windows.Forms.RadioButton rbtString;
        private System.Windows.Forms.TextBox tbxtAfter;
        private System.Windows.Forms.TextBox tbxtBefore;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.TextBox tbxFindResult;
        private System.Windows.Forms.TextBox tbxAddResult;
        private System.Windows.Forms.TextBox tbxRemoveResult;
        private System.Windows.Forms.TextBox tbxOriginal;
        private System.Windows.Forms.Label Origianl_lbl;
        private System.Windows.Forms.Button btnCreatFirst;
        private System.Windows.Forms.Button btnCreatLast;
        private System.Windows.Forms.Button btnPoly;
        private System.Windows.Forms.TextBox tbxLLcontent;
        private System.Windows.Forms.TextBox tbxFind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtLLStringg;
        private System.Windows.Forms.RadioButton rbtLLdoublee;
        private System.Windows.Forms.RadioButton rbtInt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxRemove;
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
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnInsertLast;
        private System.Windows.Forms.Button btnInsertFirst;
        private System.Windows.Forms.TextBox tbxAddAfter;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnInsertAfter;
        private System.Windows.Forms.Panel pnlLLDT;
    }
}

