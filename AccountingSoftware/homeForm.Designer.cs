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
            this.btn_cmpBalanceSheet = new System.Windows.Forms.Button();
            this.btn_cmpJournal = new System.Windows.Forms.Button();
            this.btn_cmpLedger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_providedFunctionalities
            // 
            this.lbl_providedFunctionalities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_providedFunctionalities.AutoEllipsis = true;
            this.lbl_providedFunctionalities.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_providedFunctionalities.Location = new System.Drawing.Point(222, 75);
            this.lbl_providedFunctionalities.Name = "lbl_providedFunctionalities";
            this.lbl_providedFunctionalities.Size = new System.Drawing.Size(210, 35);
            this.lbl_providedFunctionalities.TabIndex = 0;
            this.lbl_providedFunctionalities.Text = "Provided Functionalities";
            this.lbl_providedFunctionalities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_enterBill
            // 
            this.btn_enterBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_enterBill.Font = new System.Drawing.Font("HelvLight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enterBill.Location = new System.Drawing.Point(218, 123);
            this.btn_enterBill.Name = "btn_enterBill";
            this.btn_enterBill.Size = new System.Drawing.Size(214, 41);
            this.btn_enterBill.TabIndex = 1;
            this.btn_enterBill.Text = "Billing System";
            this.btn_enterBill.UseVisualStyleBackColor = true;
            this.btn_enterBill.Click += new System.EventHandler(this.btn_enterBill_Click);
            // 
            // btn_cmpBalanceSheet
            // 
            this.btn_cmpBalanceSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cmpBalanceSheet.Font = new System.Drawing.Font("HelvLight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cmpBalanceSheet.Location = new System.Drawing.Point(218, 170);
            this.btn_cmpBalanceSheet.Name = "btn_cmpBalanceSheet";
            this.btn_cmpBalanceSheet.Size = new System.Drawing.Size(214, 41);
            this.btn_cmpBalanceSheet.TabIndex = 2;
            this.btn_cmpBalanceSheet.Text = "Compute Balance Sheet";
            this.btn_cmpBalanceSheet.UseVisualStyleBackColor = true;
            // 
            // btn_cmpJournal
            // 
            this.btn_cmpJournal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cmpJournal.Font = new System.Drawing.Font("HelvLight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cmpJournal.Location = new System.Drawing.Point(218, 217);
            this.btn_cmpJournal.Name = "btn_cmpJournal";
            this.btn_cmpJournal.Size = new System.Drawing.Size(214, 41);
            this.btn_cmpJournal.TabIndex = 3;
            this.btn_cmpJournal.Text = "Compute Journal";
            this.btn_cmpJournal.UseVisualStyleBackColor = true;
            // 
            // btn_cmpLedger
            // 
            this.btn_cmpLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cmpLedger.Font = new System.Drawing.Font("HelvLight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cmpLedger.Location = new System.Drawing.Point(218, 264);
            this.btn_cmpLedger.Name = "btn_cmpLedger";
            this.btn_cmpLedger.Size = new System.Drawing.Size(214, 41);
            this.btn_cmpLedger.TabIndex = 4;
            this.btn_cmpLedger.Text = "Compute Ledger";
            this.btn_cmpLedger.UseVisualStyleBackColor = true;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 343);
            this.Controls.Add(this.btn_cmpLedger);
            this.Controls.Add(this.btn_cmpJournal);
            this.Controls.Add(this.btn_cmpBalanceSheet);
            this.Controls.Add(this.btn_enterBill);
            this.Controls.Add(this.lbl_providedFunctionalities);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "homeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.homeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_providedFunctionalities;
        private System.Windows.Forms.Button btn_enterBill;
        private System.Windows.Forms.Button btn_cmpBalanceSheet;
        private System.Windows.Forms.Button btn_cmpJournal;
        private System.Windows.Forms.Button btn_cmpLedger;
    }
}

