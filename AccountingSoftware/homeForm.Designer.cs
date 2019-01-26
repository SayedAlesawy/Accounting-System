namespace AccountingSoftware
{
    partial class homeForm
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
            if (disposing && (components != null))
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
            this.lbl_providedFunctionalities = new System.Windows.Forms.Label();
            this.btn_enterBill = new System.Windows.Forms.Button();
            this.btn_cmpLedger = new System.Windows.Forms.Button();
            this.btn_ProductManager = new System.Windows.Forms.Button();
            this.btn_cmpBalanceSheet = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_providedFunctionalities
            // 
            this.lbl_providedFunctionalities.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_providedFunctionalities.AutoEllipsis = true;
            this.lbl_providedFunctionalities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_providedFunctionalities.Location = new System.Drawing.Point(3, 11);
            this.lbl_providedFunctionalities.Name = "lbl_providedFunctionalities";
            this.lbl_providedFunctionalities.Size = new System.Drawing.Size(201, 32);
            this.lbl_providedFunctionalities.TabIndex = 0;
            this.lbl_providedFunctionalities.Text = "Provided Functionalities";
            this.lbl_providedFunctionalities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_enterBill
            // 
            this.btn_enterBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_enterBill.Font = new System.Drawing.Font("HelvLight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enterBill.Location = new System.Drawing.Point(3, 61);
            this.btn_enterBill.Name = "btn_enterBill";
            this.btn_enterBill.Size = new System.Drawing.Size(201, 39);
            this.btn_enterBill.TabIndex = 1;
            this.btn_enterBill.Text = "Billing System";
            this.btn_enterBill.UseVisualStyleBackColor = true;
            this.btn_enterBill.Click += new System.EventHandler(this.btn_enterBill_Click);
            // 
            // btn_cmpLedger
            // 
            this.btn_cmpLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cmpLedger.Font = new System.Drawing.Font("HelvLight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cmpLedger.Location = new System.Drawing.Point(3, 223);
            this.btn_cmpLedger.Name = "btn_cmpLedger";
            this.btn_cmpLedger.Size = new System.Drawing.Size(201, 42);
            this.btn_cmpLedger.TabIndex = 4;
            this.btn_cmpLedger.Text = "Compute Ledger";
            this.btn_cmpLedger.UseVisualStyleBackColor = true;
            this.btn_cmpLedger.Click += new System.EventHandler(this.btn_cmpLedger_Click);
            // 
            // btn_ProductManager
            // 
            this.btn_ProductManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ProductManager.Font = new System.Drawing.Font("HelvLight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductManager.Location = new System.Drawing.Point(3, 115);
            this.btn_ProductManager.Name = "btn_ProductManager";
            this.btn_ProductManager.Size = new System.Drawing.Size(201, 39);
            this.btn_ProductManager.TabIndex = 7;
            this.btn_ProductManager.Text = "Product Manager";
            this.btn_ProductManager.UseVisualStyleBackColor = true;
            this.btn_ProductManager.Click += new System.EventHandler(this.btn_ProductManager_Click);
            // 
            // btn_cmpBalanceSheet
            // 
            this.btn_cmpBalanceSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cmpBalanceSheet.Font = new System.Drawing.Font("HelvLight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cmpBalanceSheet.Location = new System.Drawing.Point(3, 169);
            this.btn_cmpBalanceSheet.Name = "btn_cmpBalanceSheet";
            this.btn_cmpBalanceSheet.Size = new System.Drawing.Size(201, 39);
            this.btn_cmpBalanceSheet.TabIndex = 2;
            this.btn_cmpBalanceSheet.Text = "Compute Balance Sheet";
            this.btn_cmpBalanceSheet.UseVisualStyleBackColor = true;
            this.btn_cmpBalanceSheet.Click += new System.EventHandler(this.btn_cmpBalanceSheet_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_providedFunctionalities, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cmpLedger, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_ProductManager, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_cmpBalanceSheet, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_enterBill, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(76, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 273);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 396);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(372, 382);
            this.Name = "homeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.homeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_providedFunctionalities;
        private System.Windows.Forms.Button btn_enterBill;
        private System.Windows.Forms.Button btn_cmpLedger;
        private System.Windows.Forms.Button btn_ProductManager;
        private System.Windows.Forms.Button btn_cmpBalanceSheet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

